const mongoose = require('mongoose');

module.exports = function connectToDatabase() {
  // Define your connection string
  // const connectionString = 'mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.10.1myElectronApp';


  const connectionString = "mongodb://127.0.0.1:27017/"
  // Check if the connection is already established
  if (mongoose.connection.readyState !== 1) {
    mongoose.connect(connectionString, {
      useNewUrlParser: true,
      useUnifiedTopology: true,
    });

    // Listen for connection events
    mongoose.connection.on('connected', () => {
      console.log('Connected to MongoDB successfully!');
    });

    mongoose.connection.on('error', (error) => {
      console.error('Failed to connect to MongoDB:', error);
    });
  }

  // Return the Mongoose connection object
  return mongoose.connection;
}

