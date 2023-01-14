using System;
using System.Data;

namespace Database
{
    public partial class Form1 : Form
    {

        private Connection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new Connection();
            connection.CreateConnection();
            string sql = "select * from customer";
            DataTable dt = connection.SelectRecord(sql);

            for(int i=0; i< dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                gridView.Rows.Add(dr["name"], dr["phone_number"], dr["address"]);
            }

            //MessageBox.Show(dataTable.Rows[0]["name"].ToString(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Console.WriteLine(dataTable.Rows[0].ToString());

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string phone = txtBoxPhoneNumber.Text;
            string address = txtBoxAddress.Text;

            string sql = "Insert into customer (name, phone_number, address) values ('" + name + "','" + phone + "','" + address + "')";

            connection.InsertUpdateRecord(sql);

            gridView.Rows.Add(name, phone, address);

            MessageBox.Show("Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBoxName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxAddress.Clear();


        }

    }
}