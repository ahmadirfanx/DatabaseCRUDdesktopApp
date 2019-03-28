using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewControl1.Hide();
            insertControl1.Show();
            updateControl1.Hide();
            deleteControl1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            insertControl1.Hide();
            viewControl1.Hide();
            updateControl1.Hide();
            deleteControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertControl1.Hide();
            viewControl1.Show();
            updateControl1.Hide();
            deleteControl1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertControl1.Hide();
            viewControl1.Hide();
            updateControl1.Show();
            deleteControl1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertControl1.Hide();
            viewControl1.Hide();
            updateControl1.Hide();
            deleteControl1.Show();
        }
    }
}
