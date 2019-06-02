using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void F2button1_Click(object sender, EventArgs e)
        {
            Owner.Show();//show previous form
            Hide();
            /* this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();*/
        }
        public static String change_case(string a)
        {
            string temp = "";
            int l = a.Length;

            for (int i = 0; i < l; i++)
            {
                char ch = a[i];

                // If character is lowercase  
                // change to uppercase 
                switch (ch)
                {
                    case 'a':
                        ch = (char)(65 + (int)(ch - 'a'));

                        break;
                    case 'e':
                        ch = (char)(65 + (int)(ch - 'a'));

                        break;
                    case 'i':
                        ch = (char)(65 + (int)(ch - 'a'));

                        break;
                    case 'o':
                        ch = (char)(65 + (int)(ch - 'a'));

                        break;
                    case 'u':
                        ch = (char)(65 + (int)(ch - 'a'));

                        break;

                }
                temp += ch;


            }

            return temp;

        }
        private void Txtstr1_TextChanged(object sender, EventArgs e)
        {
            String str = txtstr1.Text;
            string casestr = change_case(str);
            char[] char1 = casestr.ToCharArray();
            for (int i = 0; i < char1.Length; i++)
            {
                char1[i] += (char)1;
            }
            string res = new string(char1);
            labelstr1.Text = res;
        }

        /**************************************2nd programm************************************************/


        static bool check(string str1, string str2)
        {
            int i = 0, cnt = 0;
            char[] A1 = str1.ToCharArray();
            char[] A2 = str2.ToCharArray();

            for (i = 0; i < A2.Length; i++)
            {
                if (A1[i] == A2[i])
                    continue;
                else
                    break;
            }
            if (i < A2.Length)
            {

                return false;
            }

            for (i = 0; i < A2.Length; i++)
            {
                if (str2.IndexOf(A2[i]) == str2.LastIndexOf(A2[i]))
                    continue;
                else
                    break;
            }
            if (i < A2.Length)
            {
               
                return false;
            }
            for (i = 0; i < A1.Length; i++)
            {
                for (int j = 0; j < A2.Length; j++)
                {
                    if (A1[i] == A2[j])
                        cnt++;

                }
            }

            if (cnt >= A2.Length)
                return true;
            else
                return false;
        }
        private void Txtword2_TextChanged(object sender, EventArgs e)
        {
            string str1 = txtword1.Text;
            string str2 = txtword2.Text;
            if (str1 != null && str1.Contains(str2))
                labelword.Text = "TRUE";
            else
            {
                if(check(str1, str2))
                    labelword.Text = "TRUE";
                else
                    labelword.Text = "FALSE";

            }
        }

        

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Txtstr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtstr1.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Txtword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtword1.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Txtword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtword2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
    }
}
