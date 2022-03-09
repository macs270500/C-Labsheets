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

namespace Lab16Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnShowData_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\MegaCities.mdf;" +
                "Integrated Security=True;Connect Timeout=30";
            string sqlStr = "SELECT * FROM Cities";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Dispose();

            double percentIncrease;
            string fmtStr = "{0,-15}{1,-10}{2,7:N1}{3,7:N1}{4,7:P0}";
            lstData.Items.Add(String.Format(fmtStr, "CITY", "COUNTRY", "2005",
            "2015", "INCR."));
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                double pop2015 = double.Parse(dt.Rows[i]["pop2015"].ToString());
                double pop2005 = double.Parse(dt.Rows[i]["pop2005"].ToString()); percentIncrease = (pop2015 - pop2005) / pop2005;
                lstData.Items.Add(String.Format(fmtStr, dt.Rows[i][0],
                dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], percentIncrease));

            }
        }
    }
}

