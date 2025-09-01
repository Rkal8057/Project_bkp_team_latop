// import * as React from 'react';
// import GC from '@grapecity/spread-sheets';
// import "@grapecity/spread-sheets-io";
// import '@grapecity/spread-sheets-charts';
// import '@grapecity/spread-sheets-shapes';
// import "@grapecity/spread-sheets-tablesheet";
// import { SpreadSheets, Worksheet } from '@grapecity/spread-sheets-react';
// import './spreadsheet.css';

// window.GC = GC;
// function deepClone(obj) {
//     return JSON.parse(JSON.stringify(obj));
// }

// console.log("run spreadsheet js file")

// function getElementId(mode, fileType, propName) {
//     return mode + '-' + fileType + '-' + propName;
// }

// function getFileType(file) {
//     if (!file) {
//         return;
//     }

//     var fileName = file.name;
//     var extensionName = fileName.substring(fileName.lastIndexOf(".") + 1);

//     if (extensionName === 'sjs') {
//         return FileType.SJS;
//     } else if (extensionName === 'xlsx' || extensionName === 'xlsm') {
//         return FileType.Excel;
//     } else if (extensionName === 'ssjson' || extensionName === 'json') {
//         return FileType.SSJson;
//     } else if (extensionName === 'csv') {
//         return FileType.Csv;
//     }
// }

// function mapExportFileType(fileType) {
//     if (fileType === FileType.SSJson) {
//         return GC.Spread.Sheets.FileType.ssjson;
//     } else if (fileType === FileType.Csv) {
//         return GC.Spread.Sheets.FileType.csv;
//     }
//     return GC.Spread.Sheets.FileType.excel;
// }

// function _getElementById(id) {
//     return document.getElementById(id);
// }
// var defaultOpenOptions = [
//     { propName: "openMode", type: "select", displayText: "OpenMode", options: [{ name: 'normal', value: 0 }, { name: 'lazy', value: 1 }, { name: 'incremental', value: 2 }], default: 0 },
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "fullRecalc", type: "boolean", default: false },
//     { propName: "dynamicReferences", type: "boolean", default: true },
//     { propName: "calcOnDemand", type: "boolean", default: false },
//     { propName: "includeUnusedStyles", type: "boolean", default: true },
// ];

// var importXlsxOptions = [
//     { propName: "openMode", type: "select", displayText: "OpenMode", options: [{ name: 'normal', value: 0 }, { name: 'lazy', value: 1 }, { name: 'incremental', value: 2 }], default: 0 },
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "frozenColumnsAsRowHeaders", type: "boolean", default: false },
//     { propName: "frozenRowsAsColumnHeaders", type: "boolean", default: false },
//     { propName: "fullRecalc", type: "boolean", default: false },
//     { propName: "dynamicReferences", type: "boolean", default: true },
//     { propName: "calcOnDemand", type: "boolean", default: false },
//     { propName: "includeUnusedStyles", type: "boolean", default: true },
// ];

// var importSSJsonOptions = [
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "frozenColumnsAsRowHeaders", type: "boolean", default: false },
//     { propName: "frozenRowsAsColumnHeaders", type: "boolean", default: false },
//     { propName: "fullRecalc", type: "boolean", default: false },
//     { propName: "incrementalLoading", type: "boolean", default: false }
// ];

// var importCsvOptions = [
//     { propName: "encoding", type: "string", default: "UTF-8" },
//     { propName: "rowDelimiter", type: "string", default: "\r\n" },
//     { propName: "columnDelimiter", type: "string", default: "," }
// ];

// var defaultSaveOptions = [
//     { propName: "includeBindingSource", type: "boolean", default: false },
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "saveAsView", type: "boolean", default: false },
//     { propName: "includeAutoMergedCells", type: "boolean", default: false },
//     { propName: "includeCalcModelCache", type: "boolean", default: false },
//     { propName: "includeUnusedNames", type: "boolean", default: true },
//     { propName: "includeEmptyRegionCells", type: "boolean", default: true },
// ];

// var exportXlsxOptions = [
//     { propName: "includeBindingSource", type: "boolean", default: false },
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "saveAsView", type: "boolean", default: false },
//     { propName: "rowHeadersAsFrozenColumns", type: "boolean", default: false },
//     { propName: "columnHeadersAsFrozenRows", type: "boolean", default: false },
//     { propName: "includeAutoMergedCells", type: "boolean", default: false },
//     { propName: "includeCalcModelCache", type: "boolean", default: false },
//     { propName: "includeUnusedNames", type: "boolean", default: true },
//     { propName: "includeEmptyRegionCells", type: "boolean", default: true },
// ];

// var exportSSJsonOptions = [
//     { propName: "includeBindingSource", type: "boolean", default: false },
//     { propName: "includeStyles", type: "boolean", default: true },
//     { propName: "includeFormulas", type: "boolean", default: true },
//     { propName: "saveAsView", type: "boolean", default: false },
//     { propName: "rowHeadersAsFrozenColumns", type: "boolean", default: false },
//     { propName: "columnHeadersAsFrozenRows", type: "boolean", default: false },
//     { propName: "includeAutoMergedCells", type: "boolean", default: false },
// ];

// var exportCsvOptions = [
//     { propName: "encoding", type: "string", default: "UTF-8" },
//     { propName: "rowDelimiter", type: "string", default: "\r\n" },
//     { propName: "columnDelimiter", type: "string", default: "," },
//     { propName: "sheetIndex", type: "number", default: 0 },
//     { propName: "row", type: "number", default: 0 },
//     { propName: "column", type: "number", default: 0 },
//     { propName: "rowCount", type: "number", default: 200 },
//     { propName: "columnCount", type: "number", default: 20 },
// ];

// var FileType = {
//     SJS: 'sjs',
//     Excel: 'xlsx',
//     SSJson: 'ssjson',
//     Csv: 'csv',
// }

// export function AppFunc() {
//     const [spread, setSpread] = React.useState(null);
//     const [selectedFile, setSelectedFile] = React.useState(null);
//     const [openFileType, setOpenFileType] = React.useState('');
//     const [saveFileType, setSaveFileType] = React.useState(FileType.SJS);
//     const [openOptions, setOpenOptions] = React.useState({
//         sjs: {},
//         ssjson: {},
//         xlsx: {},
//         csv: {},
//     });
//     const [saveOptions, setSaveOptions] = React.useState({
//         sjs: {},
//         ssjson: {},
//         xlsx: {},
//         csv: {},
//     });
//     function initSpread(spread) {

//         setSpread(spread);
//         //init Status Bar
//         var statusBar = new GC.Spread.Sheets.StatusBar.StatusBar(document.getElementById('statusBar'));
//         statusBar.bind(spread);
//     }
//     function addTableSheet() {
//         var sheet = spread.addSheetTab(0, "TableSheet1", GC.Spread.Sheets.SheetType.tableSheet);

//         var dataManager = spread.dataManager();
//         var ordersTable = dataManager.addTable("ordersTable", {
//             data: orderDataSource,
//             schema: {
//                 type: "csv",
//                 columns: {
//                     OrderDate: { dataType: "date" },
//                     ShipDate: { dataType: "date" },
//                     Quantity: { dataType: "number" },
//                     Amount: { dataType: "number" }
//                 }
//             }
//         });

//         ordersTable.fetch().then(function () {
//             spread.suspendPaint();

//             var titleStyle = { font: "20pt Helvetica", foreColor: "black" };
//             var subTitleStyle = { font: "bold 12pt Helvetica", foreColor: "black", hAlign: "right" };
//             var subTitleStyle2 = { font: "bold 12pt Helvetica", foreColor: "black" };
//             var contentStyle = { font: "10pt Helvetica", foreColor: "black" };
//             let templateSheet = new GC.Spread.Sheets.Worksheet();
//             templateSheet.options.keepUnknownFormulas = true;
//             templateSheet.setRowCount(4);
//             templateSheet.setColumnCount(7);
//             templateSheet.setValue(0, 0, "Project Plan");
//             templateSheet.setStyle(0, 0, new GC.Spread.Sheets.Style(titleStyle));
//             templateSheet.setValue(1, 0, "Project");
//             templateSheet.setStyle(1, 0, new GC.Spread.Sheets.Style(subTitleStyle));
//             templateSheet.setValue(1, 1, "SpreadJS");
//             templateSheet.setStyle(1, 1, new GC.Spread.Sheets.Style(contentStyle));
//             templateSheet.setValue(1, 3, "Order Date");
//             templateSheet.setStyle(1, 3, new GC.Spread.Sheets.Style(subTitleStyle2));
//             templateSheet.setValue(1, 4, "Ship Date");
//             templateSheet.setStyle(1, 4, new GC.Spread.Sheets.Style(subTitleStyle2));
//             templateSheet.setValue(2, 0, "Owner");
//             templateSheet.setStyle(2, 0, new GC.Spread.Sheets.Style(subTitleStyle));
//             templateSheet.setValue(2, 1, "Beth Bigidea");
//             templateSheet.setStyle(2, 1, new GC.Spread.Sheets.Style(contentStyle));
//             templateSheet.setFormula(2, 3, 'TEXT(MIN(TableSheet1![OrderDate]),"M/d/yyyy")');
//             templateSheet.setStyle(2, 3, new GC.Spread.Sheets.Style(contentStyle));
//             templateSheet.setFormula(2, 4, 'TEXT(MAX(TableSheet1![ShipDate]),"M/d/yyyy")');
//             templateSheet.setStyle(2, 4, new GC.Spread.Sheets.Style(contentStyle));
//             templateSheet.addSpan(0, 1, 1, 3);
//             templateSheet.setRowHeight(0, 60);
//             templateSheet.setStyle(0, -1, new GC.Spread.Sheets.Style("#DDEBF7"));
//             templateSheet.setStyle(2, -1, new GC.Spread.Sheets.Style("#DDEBF7"));
//             let template = templateSheet.toJSON();
//             sheet.applyFreeHeaderArea(template);

//             var myView = ordersTable.addView("myView", [
//                 { value: "OrderID", width: 180 },
//                 { value: "Product", width: 200 },
//                 { value: "Quantity", width: 100 },
//                 { value: "OrderDate", width: 100 },
//                 { value: "ShipDate", width: 100 },
//                 { value: "Amount", width: 100 },
//                 { value: "Office", width: 100 },
//                 { value: "Category", width: 150 },
//                 { value: "=YEAR([@OrderDate])", width: 100 }
//             ]);
//             sheet.setDataView(myView);

//             spread.resumePaint();
//         });
//     }
//     function open() {
//         var file = selectedFile;
//         if (!file) {
//             return;
//         }

//         var fileType = getFileType(file);
//         var options = deepClone(openOptions[fileType]);

//         if (fileType === FileType.SJS) {
//             spread.open(file, function () { }, function () { }, options);
//         } else {
//             spread.import(file, function () { }, function () { }, options);
//         }
//     }
//     function save() {
//         var fileType = saveFileType;
//         var fileName = 'export.' + fileType;
//         var options = deepClone(saveOptions[fileType]);

//         if (fileType === FileType.SJS) {
//             spread.save(function (blob) { saveAs(blob, fileName); }, function () { }, options);
//         } else {
//             options.fileType = mapExportFileType(fileType);
//             spread.export(function (blob) { saveAs(blob, fileName); }, function () { }, options);
//         }
//     }
//     function onSelectedFileChange(e) {
//         let selectedFile = e.target.files[0];
//         let openFileType = getFileType(selectedFile);
//         setSelectedFile(selectedFile);
//         setOpenFileType(openFileType)
//     }
//     function onSaveFileTypeChange(e) {
//         let saveFileType = e.target.value;
//         setSaveFileType(saveFileType);
//     }
//     function onPropChange(mode, fileType, prop, e) {
//         let element = e.target;

//         var value;
//         if (prop.type === 'boolean') {
//             value = element.checked;
//         } else if (prop.type === 'number') {
//             value = +element.value;
//         } else if (prop.type === 'string') {
//             value = element.value;
//         } else if (prop.type === 'select') {
//             value = +element.value;
//         }

//         if (mode === 'open') {
//             openOptions[fileType][prop.propName] = value;
//             setOpenOptions(openOptions);
//         } else if (mode === 'save') {
//             saveOptions[fileType][prop.propName] = value;
//             setSaveOptions(saveOptions);
//         }
//     }
//     function createOptions(options, fileType, mode) {
//         let selectFileType = mode === 'open' ? openFileType : saveFileType;
//         let display = selectFileType === fileType ? '' : 'none';

//         return <div className={fileType} style={{ display }}>
//             {options.map((prop) => createProp(mode, fileType, prop))}
//         </div>;
//     }
//     function createProp(mode, fileType, prop) {
//         let id = getElementId(mode, fileType, prop.propName);

//         if (prop.type === 'select') {
//             return <item className='item'>
//                 <label for={id}>{prop.displayText || prop.propName}</label>
//                 <select id={id} defaultValue={prop.default} onChange={(e) => onPropChange(mode, fileType, prop, e)}>
//                     {prop.options.map((p) => <option value={p.value}>{p.name}</option>)}
//                 </select>
//             </item>
//         } else if (prop.type === 'boolean') {
//             return <item className='item'>
//                 <input id={id} type='checkbox' defaultChecked={prop.default} onChange={(e) => onPropChange(mode, fileType, prop, e)}></input>
//                 <label for={id}>{prop.displayText || prop.propName}</label>
//             </item>
//         } else if (prop.type === 'number') {
//             return <item className='item'>
//                 <label for={id}>{prop.displayText || prop.propName}</label>
//                 <input id={id} type='number' defaultValue={prop.default} onChange={(e) => onPropChange(mode, fileType, prop, e)}></input>
//             </item>
//         } else {
//             return <item className='item'>
//                 <label for={id}>{prop.displayText || prop.propName}</label>
//                 <input id={id} type='text' defaultValue={prop.default} onChange={(e) => onPropChange(mode, fileType, prop, e)}></input>
//             </item>
//         }
//     }
//     return <div class="sample-tutorial">
//         <div class="sample-container">
//             <div class="sample-spreadsheets">
//                 <SpreadSheets workbookInitialized={spread => initSpread(spread)}>
//                     <Worksheet>
//                     </Worksheet>
//                 </SpreadSheets>
//             </div>
//             <div id="statusBar"></div>
//         </div>
//         <div className="options-container">
//             <div className="option-row">
//                 <button class="settingButton" id="addTableSheet" onClick={() => addTableSheet()}>Add TableSheet</button>
//                 <div class="inputContainer">
//                     <input id="selectedFile" type="file" accept=".sjs, .xlsx, .xlsm, .ssjson, .json, .csv" onChange={onSelectedFileChange} />
//                     <button class="settingButton" id="open" onClick={open}>Open</button>

//                     <div class="open-options">
//                         {[
//                             createOptions(defaultOpenOptions, FileType.SJS, 'open'),
//                             createOptions(importXlsxOptions, FileType.Excel, 'open'),
//                             createOptions(importSSJsonOptions, FileType.SSJson, 'open'),
//                             createOptions(importCsvOptions, FileType.Csv, 'open'),
//                         ]}
//                     </div>
//                 </div>
//                 <div class="inputContainer">
//                     <label for="saveFileType">FileType:</label>
//                     <select id="saveFileType" value={saveFileType} onChange={onSaveFileTypeChange}>
//                         <option value="sjs">SJS</option>
//                         <option value="xlsx">Excel</option>
//                         <option value="ssjson">SSJson</option>
//                         <option value="csv">Csv</option>
//                     </select>
//                     <button class="settingButton" id="save" onClick={save}>Save</button>

//                     <div class="save-options">
//                         {[
//                             createOptions(defaultSaveOptions, FileType.SJS, 'save'),
//                             createOptions(exportXlsxOptions, FileType.Excel, 'save'),
//                             createOptions(exportSSJsonOptions, FileType.SSJson, 'save'),
//                             createOptions(exportCsvOptions, FileType.Csv, 'save'),
//                         ]}
//                     </div>
//                 </div>
//             </div>
//         </div>
//     </div>;
// }