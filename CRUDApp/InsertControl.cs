using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class InsertControl : UserControl
    {
        public InsertControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id, Fname, Lname, contact;
            double gpa;
            Id = textBox5.Text;
            Fname = textBox4.Text;
            Lname = textBox3.Text;
            contact = textBox1.Text;
            gpa = Convert.ToDouble(textBox2.Text);
            Sql_Db_Connection connection = new Sql_Db_Connection(); // my db class

            string query = "INSERT INTO Crud_Table VALUES('" + Id + "','" + Fname + "','" + Lname + "','" + gpa + "','" +
contact + "') ";
            if (connection.insert_query(query))
            {
                MessageBox.Show("Data Inserted Successfully");
            }
        }

    }
}
