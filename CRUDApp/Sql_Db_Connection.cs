using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDApp
{
    class Sql_Db_Connection
    {
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter sqlDataAdapter;
        public SqlDataReader dr;
        public Sql_Db_Connection() // constructor to connect with database;
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-EUHC445;
Initial Catalog=tutorial;Integrated Security=True");
            connection.Open();
        }
        public bool insert_query(string query)
        {
            command = new SqlCommand(query, this.connection);

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else return false;
        }
    
        public BindingSource Select_Query(string query)
        {
            sqlDataAdapter = new SqlDataAdapter();
            command = new SqlCommand(query, this.connection);
            sqlDataAdapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            return bindingSource;
        }
    }
}
