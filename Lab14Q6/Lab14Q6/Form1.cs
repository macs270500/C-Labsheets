using System;
using System.Windows.Forms;

namespace Lab14Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

//            lstIndexes.Items.Insert(0, 001);
  //          lstIndexes.Items.Insert(1, 002);
    //        arrStud[index] = myStud;
        }
        struct Student
        {
            /*public int[] ID;
            public string[] Name;
            public double[] mod1;
            public double[] mod2;
            public double[] mod3;
            public double[] mod4;*/
            public int ID;
            public String Name;
            public double mod1;
            public double mod2;
            public double mod3;
            public double mod4;

            public Student(int ID, string Name, double mod1, double mod2, double mod3, double mod4)
            {
                this.ID = ID;
                this.Name = Name;
                this.mod1 = mod1;
                this.mod2 = mod2;
                this.mod3 = mod3;
                this.mod4 = mod4;
            }
        }
        Student myStud = new Student();
        Student[] arrStud = new Student[10];

        int index = 0;
        private int selectedIndex;

       /* private Student initialize()
        {
            Student myStud = new Student(int ID, String Name, String mod1, String mod2, String mod3, String mod5);

            myStud.ID = new int[5];
           myStud.Name = new string[5];
           myStud.mod1 = new double[5];
           myStud.mod2 = new double[5];
           myStud.mod3 = new double[5];
           myStud.mod4 = new double[5];
               return myStud;
        }*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
           // Student myStud =initialize();
            if (index < 5)
            {
                //   myStud.ID = int.Parse(txtID.Text);
                //  myStud.Name = txtName.Text;
                //  myStud.mod1[index] = double.Parse(txtMod1.Text);
                // myStud.mod2[index] = double.Parse(txtMod2.Text);
                //myStud.mod1[index] = double.Parse(txtMod3.Text);
                //myStud.mod1[index] = double.Parse(txtMod4.Text);
                int ID = int.Parse(txtID.Text);
                String Name = txtName.Text;
                  double mod1 =double.Parse(txtMod1.Text);
                double mod2 = double.Parse(txtMod2.Text);
               double mod3 = double.Parse(txtMod3.Text);
               double mod4 = double.Parse(txtMod4.Text);

                Student myStud = new Student(ID, Name, mod1, mod2, mod3, mod4);

                lstIndexes.Items.Insert(index,txtID.Text);
                arrStud[index] = myStud;
                index++;
            }
        }

        private void lstIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lstIndexes);
            Console.WriteLine(arrStud);
            if (lstIndexes.SelectedIndex >= 0)
            {
                int selectedIndex = lstIndexes.SelectedIndex;
                Console.WriteLine(arrStud[selectedIndex]);
                txtID.Text = arrStud[selectedIndex].ID.ToString();
                txtName.Text = arrStud[selectedIndex].Name.ToString();

               //txtID.Text = myStud.ID[lstIndexes.SelectedIndex].ToString();
               //txtName.Text = myStud.Name[lstIndexes.SelectedIndex];
                //txtMod1.Text = myStud.mod1[lstIndexes.SelectedIndex].ToString();
                //txtMod2.Text = myStud.mod2[lstIndexes.SelectedIndex].ToString();
               //txtMod3.Text = myStud.mod3[lstIndexes.SelectedIndex].ToString();
                //txtMod4.Text = myStud.mod4[lstIndexes.SelectedIndex].ToString();
            }
        }
    }
}
