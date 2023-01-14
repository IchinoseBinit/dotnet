using System;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{

    internal class Connection
    {
        public OleDbConnection connection;

        public void CreateConnection()
        {
            string path = "Provider=Microsoft.ACE.OLEDB.12.0;DataSource=C:\\Users\\binit\\OneDrive\\Desktop\\dotnet\\Week 2\\Database\\Database\\test.accdb";
            conn = new OleDbConnection(path);
            conn.Open();
        }

        public void InsertUpdateRecord(String sql)
        {
            command = new OleDbCommand(sql, conn);
            command.ExecuteNonQuery();
            Console.WriteLine(sql);
        }
    }
}
