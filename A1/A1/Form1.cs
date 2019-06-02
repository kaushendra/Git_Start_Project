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
    public partial class Form1 : Form
    {
        Form2 f2; // assign a new class within the owner
  
        /// </summary>
        public Form1()
        {
            InitializeComponent();///constructor calling
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)//check if it is created or not
            {
                f2 = new Form2();//create form if not created
                f2.FormClosed += f2_FormClosed;// Add event handler to cleanup after form closes
            }
            f2.Show(this);//show Form2 assigning this (FORM2) as Form owner
            Hide();
        }
        void f2_FormClosed(object sender,FormClosedEventArgs e)
        {
            f2 = null; // if Form2 is closed make sure reference is set to NULL
            Show();

        }

        /*********1st label to execute***********///<summary>

        private void TxtPal1_TextChanged(object sender, EventArgs e)
        {
            string s = txtPal1.Text;
        string revs = "";
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
                {
                revs += s[i].ToString();
                 }
            if (revs == s)
            {
                paldisplay1.Text = "PALINDROME";
            }
            else
            {
                paldisplay1.Text = " NOT PALINDROME";
            }

        }
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private void Txtalpha4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtalpha4.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        public static string RandomNumber()
        {
            Random random = new Random();
            int rand1 = random.Next(10);
            string srand1 = rand1.ToString();
            return srand1;

        }
       /* public static char RandomChar()
        {
            Random random = new Random();
            char randomChar = (char)random.Next('A','Z');
            
            return randomChar;

        }*/
        public static string RemoveSpecialChars(string str)
        {

            string[] chars = new string[] { "Z", "Y", "X", "W", "V", "U", "T", "S", "R", "Q", "P", "O", "N", "M ", "L", "K", "J", "I", "H", "G", "F", "E", "A", "B", "C", "D" };
            
           
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case "A":
                        str = str.Replace(chars[i], "7");
                        break;
                    case "B":
                        str = str.Replace(chars[i], "6");
                        break;
                    case "C":
                        str = str.Replace(chars[i], "5");
                        break;
                    case "D":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "E":
                        str = str.Replace(chars[i], "1");
                        break;
                    case "F":
                        str = str.Replace(chars[i], "2");
                        break;
                    case "H":
                        str = str.Replace(chars[i], "3");
                        break;
                    case "J":
                        str = str.Replace(chars[i], "4");
                        break;
                    case "L":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "O":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "N":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "Q":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "s":
                        str = str.Replace(chars[i], "8");
                        break;
                    case "X":
                        str = str.Replace(chars[i], "8");
                        break;
                        
                }
                /*if (str.Contains(chars[i]))
                {
                    //Here I replaced with emtpy string, 
                    str = str.Replace(chars[i],"7");
                }*/
            }
            return str;

        }
        private void txtalpha4_TextChanged(object sender, EventArgs e)
        {

            string str = txtalpha4.Text;
            string withoutspecialcharacters = RemoveSpecialChars(str);
            alphadisplay4.Text = withoutspecialcharacters;
            // label5.Text = txtdisplay.Text;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtPal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtPal1.Text.Contains('.') == true : true))
                e.Handled = true;
        }
    }
}
