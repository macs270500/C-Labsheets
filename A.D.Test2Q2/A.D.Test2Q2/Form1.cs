using System;
using System.Windows.Forms;

namespace A.D.Test2Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            int num = int.Parse(txtN.Text);
            int[] arrMarks = new int[lstMarks.Items.Count];
            for(int a = 0; a < lstMarks.Items.Count; a++)
            {
                arrMarks[a] = int.Parse(lstMarks.Items[a].ToString());
            }
           
            for (int p = 0; p <= arrMarks.Length - 2; p++)
            {
                for (int i = 0; i <= arrMarks.Length - 2; i++)
                {
                    if (arrMarks[i] < arrMarks[i + 1])
                    {
                         int temp = arrMarks[i + 1];
                        arrMarks[i + 1] = arrMarks[i];
                        arrMarks[i] = temp;
                    }
                }                
            }
            for(int k = 0; k < num; k++)
            {
               lstList.Items.Add(arrMarks[k]);
            }
        }
    }
}
