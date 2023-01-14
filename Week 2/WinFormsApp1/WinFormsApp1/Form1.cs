using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)

            //validation for multiple data
        {
            string name = txtBoxName.Text.Trim();
            foreach(Person p in persons)

            {
                if(p.GetName()==name)
                {
                    MessageBox.Show("Please enter another name","Cannot Enter", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Stop) ;
                    return;

                }
            }
            string age = txtBoxAge.Text;
            string address = txtBoxAddress.Text;

            bool isreading = chkBoxReading.Checked;
            bool isSports = chkBoxSports.Checked;

            string province = cmboBoxProvince.Text;

            persons.Add(new Person(name, age, address, isreading, isSports));    

            string detail = "We have " +persons.Count +" no. of persons";
            lblDetails.Text = detail;
            // person count is shown

            // add in gridview
            gridView.Rows.Clear();
            foreach(Person p in persons)
            {
                gridView.Rows.Add(p.GetName(), p.GetAddress(), p.GetAge());

                    

            }
           

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = int.Parse( txtIndexNo.Text)-1;
            Person p = persons[index];
            string detail = "Your name is " + p.GetName() + ", your age is " + p.GetAge() + " and your address is " + p.GetAddress();
            lblDetails.Text = detail;

        }
    }
}