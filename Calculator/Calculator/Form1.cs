using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double operand1, operand2, Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 + operand2;
            txtResult.Text=Result.ToString();

        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 - operand2;
            txtResult.Text = Result.ToString();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 * operand2;
            txtResult.Text = Result.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtOperand2.Text) != 0)
            {
                operand1 = Convert.ToDouble(txtOperand1.Text);
                operand2 = Convert.ToDouble(txtOperand2.Text);
                Result = operand1 / operand2;
                txtResult.Text = Result.ToString();
            }
            else { }
        }

        private void TxtOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar)==false && (e.KeyChar=='.'?txtOperand1.Text.Contains('.')== true:true))
            e.Handled = true;
        }

        private void TxtOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;

        }

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
                        str = str.Replace(chars[i], "4");
                        break;
                    case "C":
                        str = str.Replace(chars[i], "5");
                        break;
                    case "D":
                        str = str.Replace(chars[i], "6");
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
        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

            string str = txtdisplay.Text;
            string withoutspecialcharacters = RemoveSpecialChars(str);
            label5.Text = withoutspecialcharacters;
           // label5.Text = txtdisplay.Text;
        }
        
        //Resets the placeholder text for password textbox
        

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
          /*  this.Hide();
            Form1 form2 = new Form1();
            form2.Show();*/
            // label5.Text = txtdisplay.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
