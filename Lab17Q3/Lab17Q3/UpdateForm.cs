using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17Q3
{
    public partial class UpdateForm : Form
    {
        string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|" +
            "\\MegaCities.mdf;Integrated Security=True;Connect Timeout=30";
        string sqlStr = "SELECT * FROM Cities";
        DataTable dt = new DataTable();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            sda.Fill(dt);
            DGVDisplay.DataSource = dt;
            sda.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            int changes = sda.Update(dt);

            if (changes > 0) 
            {
                MessageBox.Show($"{changes} records changed");
            }
            else
            {
                MessageBox.Show("No records changed");
            }
        }
    }
}
