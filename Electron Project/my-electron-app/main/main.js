const { ipcRenderer } = require('electron');

// Function to handle navigation events
function navigateTo(route) {
  ipcRenderer.send('navigate', route);
}

