using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coding_competiton
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter writer = new StreamWriter(Path.Combine(docPath,"image.txt"));
            Random rnd = new Random();
            int red=-1, green=-1, blue=-1;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    do
                    {
                        red = rnd.Next(255);
                    }
                    while (red <= 0);
                    do
                    {
                        green = rnd.Next(255);
                    } 
                    while (green <= 0);
                    do
                    {
                        blue = rnd.Next(255);
                    } 
                    while (blue <= 0);
                    writer.Write($"{red},{green},{blue}-");
                }
                writer.WriteLine();
            }

            int[,,] array = new int[100,100,100];

            
        }
    }
}
