namespace A1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.paldisplay1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alphadisplay4 = new System.Windows.Forms.Label();
            this.txtPal1 = new System.Windows.Forms.TextBox();
            this.txtalpha4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALINDROME";
            // 
            // paldisplay1
            // 
            this.paldisplay1.AutoSize = true;
            this.paldisplay1.Location = new System.Drawing.Point(107, 245);
            this.paldisplay1.Name = "paldisplay1";
            this.paldisplay1.Size = new System.Drawing.Size(0, 17);
            this.paldisplay1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(541, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alpha To Numric No.";
            // 
            // alphadisplay4
            // 
            this.alphadisplay4.AutoSize = true;
            this.alphadisplay4.Location = new System.Drawing.Point(541, 236);
            this.alphadisplay4.Name = "alphadisplay4";
            this.alphadisplay4.Size = new System.Drawing.Size(0, 17);
            this.alphadisplay4.TabIndex = 7;
            // 
            // txtPal1
            // 
            this.txtPal1.Location = new System.Drawing.Point(105, 147);
            this.txtPal1.Name = "txtPal1";
            this.txtPal1.Size = new System.Drawing.Size(100, 22);
            this.txtPal1.TabIndex = 8;
            this.txtPal1.TextChanged += new System.EventHandler(this.TxtPal1_TextChanged);
            this.txtPal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPal1_KeyPress);
            // 
            // txtalpha4
            // 
            this.txtalpha4.Location = new System.Drawing.Point(544, 142);
            this.txtalpha4.Name = "txtalpha4";
            this.txtalpha4.Size = new System.Drawing.Size(100, 22);
            this.txtalpha4.TabIndex = 11;
            this.txtalpha4.TextChanged += new System.EventHandler(this.txtalpha4_TextChanged);
            this.txtalpha4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtalpha4_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "INPUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "RESULT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "INPUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "RESULT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "1st Program Window";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtalpha4);
            this.Controls.Add(this.txtPal1);
            this.Controls.Add(this.alphadisplay4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paldisplay1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paldisplay1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label alphadisplay4;
        private System.Windows.Forms.TextBox txtPal1;
        private System.Windows.Forms.TextBox txtalpha4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

