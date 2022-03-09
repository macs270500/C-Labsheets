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

namespace Lab17Q1
{
    public partial class frmDatabase : Form
    {
        private void UpdateGrid(string sqlStr)
        {
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\MegaCities.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            sda.Dispose();
        }
        public frmDatabase()
        {
            InitializeComponent();

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            UpdateGrid("SELECT * FROM Cities");
        }

        private void btnPopu2005_Click(object sender, EventArgs e)
        {
            UpdateGrid("SELECT * FROM Cities ORDER BY pop2005 ASC");
        }

        private void btnMonetaryUnit_Click(object sender, EventArgs e)
        {
            UpdateGrid("SELECT city , Cities.country, Cities.pop2005, monetaryUnit " +
                "FROM Cities, Countries " +
                "WHERE Cities.Country = Countries.Country " +
                "ORDER BY city ASC");
        }
    }
}
