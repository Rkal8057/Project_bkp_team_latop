import * as GC from '@grapecity/spread-sheets';
import { SpreadSheets, Worksheet } from '@grapecity/spread-sheets-react';
import '@grapecity/spread-sheets/styles/gc.spread.sheets.excel2013white.css';



function Excel() {
    let hostStyle = {
      width: '100%',
      height: '500px',
      border: '1px solid darkgray'
    }
  
    let initSpread = function (spread) {
      let sheet = spread.getActiveSheet();
      sheet.getCell(0, 0).vAlign(GC.Spread.Sheets.VerticalAlign.center).value('Hello SpreadJS!');
    }
  
    return (
      <div className="App">
        <SpreadSheets workbookInitialized={spread => initSpread(spread)}  hostStyle={hostStyle}>
          <Worksheet></Worksheet>
        </SpreadSheets>
      </div>
    );
  }
  
  export default Excel;