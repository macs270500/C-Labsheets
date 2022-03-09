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

namespace Lab16Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|" +
                "\\MegaCities.mdf;Integrated Security=True;Connect Timeout=30";
            string sqlStr = "SELECT * FROM Countries";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);            
            sda.Fill(dt);
            sda.Dispose();
            lstCountry.DataSource = dt;
            lstCountry.DisplayMember = "Country";
        }

        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMonetary.Text = dt.Rows[lstCountry.SelectedIndex]["monetaryUnit"].ToString();
        }
    }
}
