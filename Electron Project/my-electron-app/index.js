const electron = require("electron");
const {ipcMain, dialog,globalShortcut} = require('electron');
const BrowserWindow = electron.BrowserWindow;
const app = electron.app;
const path = require("path");
const xlsx = require('xlsx');
const url = require("url");
const connectToDatabase  = require('./config/v1/mongoose.config')

let win ;

function createWindow(){

    win = new BrowserWindow({  
        title:"User Drive",
        width: 800,
        height: 600,
        // alwaysOnTop:true,
        webPreferences: {
            nodeIntegration: true,
            enableRemoteModule: true,
            contextIsolation: false,
            // preload: path.join(__dirname, 'renderer', 'js', 'preload.js')
        }
    });

    win.loadURL(url.format({
        pathname: path.join(__dirname, './renderer/login.html'),
        protocol: "file",
        slashes: true
    }))
    win.webContents.openDevTools();

    ipcMain.on('navigate', (event, route) => {
        win.loadURL(
          url.format({
            pathname: path.join(__dirname, 'renderer', `${route}.html`),
            protocol: 'file:',
            slashes: true,
          })
        );
    });
      
    // win.webContents.openDevTools();
    win.on('closed',()=>{
        win =null;
    })
}
app.on('ready', ()=>{
    console.log("============= window start ==============")
    // MenuTemplate()  // Show menu list 
    // file.headerMenu()
    connectToDatabase()

    globalShortcut.register("ctrl+o", ()=> {
        const options = {
            title: 'Open Excel File',
            filters: [
            { name: 'Excel Files', extensions: ['xlsx', 'xls'] }
            ],
            properties: ['openFile']
        };
      
        dialog.showOpenDialog(options).then((result) => {
            if (!result.canceled) {
            const filePath = result.filePaths[0];
            console.log(filePath)
            
            const workbook = xlsx.readFile(filePath);
            const worksheet = workbook.Sheets[workbook.SheetNames[0]];
            const jsonData = xlsx.utils.sheet_to_json(worksheet, { header: 1 });

            console.log(jsonData)
          
            win.loadURL(`data:text/html;charset=utf-8,${encodeURIComponent(jsonData)}`);
            }
        });
    });
    createWindow()
});



// app.on("browser-window-focus",()=>{
//     console.log("you are on app")
// })
// app.on("browser-window-blur",()=>{
//     console.log("you are on app")
// })

app.on('window-all-closed', ()=>{
    console.log("============= window closed ==============")
    if(process.platform !== 'darwin'){
        app.quit()
    }
})

app.on('activate', ()=>{
    if(win===null){
        createWindow()
    }
})
