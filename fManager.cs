using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            loaddata();
        }

        private string sql;

 
        private void loaddata()
        {
            sql = "select * from loaisanpham ";
            DataTable dt = DataProvider.GetDataTable(sql);
            dataGridView1.DataSource = DataProvider.GetDataTable(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to load data.");
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
