using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;


namespace RTA.Common.Database
{
    public class MySqlDB
    {
        public MySqlDB()
        {
            MySqlCon = new MySqlConnection();
        }
        public MySqlConnection MySqlCon { get; set; }
        public MySqlDataReader MySqlReader { get; set; }
        private MySqlCommand MySqlCmd { get; set; }
        public void ConnOpen(string ConnStr)
        {
            try
            {
                MySqlCon.ConnectionString = ConnStr;
                MySqlCon.Open();
            }
            catch (Exception E)
            {
                throw new Exception(E.Message);
            }
        }
        public void ConnClose()
        {
            MySqlCon.Close();
            MySqlCon.Dispose();
        }

        public void ExecuteSql(string sql)
        {
            try
            {
                MySqlCmd = MySqlCon.CreateCommand();
                MySqlCmd.CommandTimeout = 900;
                MySqlCmd.CommandText = sql;
                MySqlReader = MySqlCmd.ExecuteReader();
            }
            catch (Exception E)
            {
                throw new Exception(E.Message);
            }
        }

    }

}