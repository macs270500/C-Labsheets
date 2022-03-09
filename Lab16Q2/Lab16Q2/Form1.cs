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

namespace Lab16Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int rowIdex = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=|DataDirectory|\\MegaCities.mdf;Integrated Security=True;" +
               "Connect Timeout=30";
            string sqlStr = "SELECT * FROM Cities";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            sda.Fill(dt);
            sda.Dispose();
            UpdateTextBoxes();
        }
       

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowIdex > 0)
            {
                rowIdex--;
                UpdateTextBoxes();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rowIdex < dt.Rows.Count - 1)
            {
                UpdateTextBoxes();
                rowIdex++;
                
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string city = txtSearch.Text;
            bool found = false;
            for (int i = 0; i<= dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i]["city"].Equals(city))
                {
                    rowIdex = i;
                    UpdateTextBoxes();
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show($"City {city} NOT found!!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void UpdateTextBoxes()
        {
            txtCity.Text = dt.Rows[rowIdex]["city"].ToString();
            txtCountry.Text = dt.Rows[rowIdex]["country"].ToString();
            txtpop2005.Text = dt.Rows[rowIdex]["pop2005"].ToString();
            txtpop2015.Text = dt.Rows[rowIdex]["pop2015"].ToString();
        }
    }
}
