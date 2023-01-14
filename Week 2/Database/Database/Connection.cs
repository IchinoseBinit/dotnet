using System;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace Database
{    
    
    internal class Connection
    {
        public MySqlConnection conn;
        public MySqlCommand command;

        public void CreateConnection()
        {
            //string path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\binit\OneDrive\Desktop\dotnet\Week 2\Database\Database\test.accdb";
            string path = "SERVER='localhost'; UID='root'; DATABASE='bca'; PASSWORD=''";
            conn = new MySqlConnection(path);
            conn.Open();
        }

        public void InsertUpdateRecord(String sql)
        {

            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Console.WriteLine(sql);
        }

        public DataTable SelectRecord(String sql)
        {
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
            
        }
    }
}
