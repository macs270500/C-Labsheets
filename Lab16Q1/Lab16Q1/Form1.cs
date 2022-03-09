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

namespace Lab16Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\MegaCities.mdf;Integrated Security=True;" +
                "Connect Timeout=30";
            string sqlStr = "SELECT * FROM Cities";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            sda.Fill(dt);
            sda.Dispose();
        }
    }
}
