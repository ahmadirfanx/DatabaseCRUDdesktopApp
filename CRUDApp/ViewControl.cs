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
    public partial class ViewControl : UserControl
    {
        public ViewControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql_Db_Connection sql_Db = new Sql_Db_Connection();
            string query = "SELECT * FROM crud_table";
            BindingSource bindingSource = sql_Db.Select_Query(query);
            dataGridView1.DataSource = bindingSource;
        }
    }
}
