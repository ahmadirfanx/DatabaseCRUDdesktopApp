using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CRUDApp
{
    public partial class UpdateControl : UserControl
    {
        public UpdateControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            string query = "SELECT * FROM crud_table Where ID=" + id;
            Sql_Db_Connection sql_Db = new Sql_Db_Connection();
            sql_Db.command = new SqlCommand(query, sql_Db.connection);
            try {
                sql_Db.dr = sql_Db.command.ExecuteReader();
                if (sql_Db.dr.Read())
                {
                    textBox2.Text = (sql_Db.dr["Fname"].ToString());
                    textBox3.Text = (sql_Db.dr["Lname"].ToString());
                    textBox4.Text = (sql_Db.dr["GPA"].ToString());
                    textBox5.Text = (sql_Db.dr["Contact"].ToString());
                    MessageBox.Show("User found");
                }
                else MessageBox.Show("User not Found");
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Fname, Lname, contact;
            double gpa;
            Fname = textBox2.Text;
            Lname = textBox3.Text;
            contact = textBox5.Text;
            gpa = Convert.ToDouble(textBox4.Text);
            try
            {
                Sql_Db_Connection connection = new Sql_Db_Connection(); // my db class
                string query = "UPDATE crud_table SET Fname='" + Fname + "' , Lname = '" + Lname + "' , GPA = '" + gpa + "' , Contact ='" + contact + "' WHERE ID = '" + textBox1.Text + "' ";
                MessageBox.Show(query);
                if (connection.insert_query(query))
                {
                    MessageBox.Show("Data Updated Successfully");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
