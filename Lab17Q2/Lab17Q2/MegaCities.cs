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

namespace Lab17Q2
{
    public partial class MegaCities : Form
    {
        string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|\\MegaCities.mdf;Integrated Security=True;Connect Timeout=30";
        string sqlStr = "SELECT * FROM Cities";        
        DataTable dt = new DataTable();
        int inc = 0;
        public MegaCities()
        {
            InitializeComponent();
        }

        private void MegaCities_Load(object sender, EventArgs e)
        {
            //Loads the database in a datatable & displays the first record.
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr,connStr);
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();
        }
        private void NavigateRecords()
        {
            //Display the contents of the database.
            txtCity.Text = dt.Rows[inc]["city"].ToString();
            txtCountry.Text = dt.Rows[inc]["country"].ToString();
            txtPop2005.Text = dt.Rows[inc]["pop2005"].ToString();
            txtPop2015.Text = dt.Rows[inc]["pop2015"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateRecords();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            inc = dt.Rows.Count - 1;
            NavigateRecords();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc < dt.Rows.Count-1)
            {
                inc++;
                NavigateRecords();
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
        }
        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            sda.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();

            newRow["city"] = txtCity.Text;
            newRow["country"] = txtCountry.Text;
            newRow["pop2005"] = txtPop2005.Text;
            newRow["pop2015"] = txtPop2015.Text;

            dt.Rows.Add(newRow);
            Save(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(inc);
            //or dt.Rows[inc].Delete();
            Save();
            btnClear_Click(sender,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.Rows[inc]["city"] = txtCity.Text;
            dt.Rows[inc]["country"] = txtCountry.Text;
            dt.Rows[inc]["pop2005"] = txtPop2005.Text;
            dt.Rows[inc]["pop2015"] = txtPop2015.Text;
            Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCity.Clear();
            txtCountry.Clear();
            txtPop2005.Clear();
            txtPop2015.Clear();
        }
    }
}
