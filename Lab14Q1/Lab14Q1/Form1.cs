using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Vowels = 0, Consonants = 0;
        private void btnFindIt_Click(object sender, EventArgs e)
        {
            string sentence = richtxtString.Text;
            FindVowels(sentence);
            FindConsonants(sentence);
            richTxtConsonants_Vowels.Text = $"There are {Vowels} vowels and {Consonants} consonants";
        }

        private void FindVowels(string sentence)
        {
            foreach (char ch in sentence)
            {
                switch (char.ToLower(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Vowels++;
                        break;
                }
            }
        }

        private void FindConsonants(string sentence)
        {
            int alpha = 0;
            foreach(char ch in sentence)
            {
                if (char.IsLetter(ch))
                {
                    alpha++;
                }
            }
            Consonants = alpha - Vowels;
        }
    }
}
