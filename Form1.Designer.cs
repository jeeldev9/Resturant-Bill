
namespace Resturant_Bill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pizzaqp = new System.Windows.Forms.Button();
            this.dhosaqp = new System.Windows.Forms.Button();
            this.friedriceqp = new System.Windows.Forms.Button();
            this.thumsupqp = new System.Windows.Forms.Button();
            this.pizzaqm = new System.Windows.Forms.Button();
            this.dhosaqm = new System.Windows.Forms.Button();
            this.friedriceqm = new System.Windows.Forms.Button();
            this.thumsupqm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :- ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Type :-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash Payment",
            "Google Pay",
            "Paytm"});
            this.comboBox1.Location = new System.Drawing.Point(251, 506);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select Mode..";
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price :- 80";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Pizza";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(93, 199);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 24);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Dhosa";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(93, 257);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 24);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Fried Rice";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price :- 120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price :- 220";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(667, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total :-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(753, 502);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Size = new System.Drawing.Size(69, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "0.00";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(760, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "0.00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "0.00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "0.00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(92, 310);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 24);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Thums Up";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Price :- 30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Food";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Price of Food";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(522, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(570, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "0";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(570, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "0";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(570, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "0";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(570, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "0";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // pizzaqp
            // 
            this.pizzaqp.Location = new System.Drawing.Point(494, 134);
            this.pizzaqp.Name = "pizzaqp";
            this.pizzaqp.Size = new System.Drawing.Size(26, 29);
            this.pizzaqp.TabIndex = 27;
            this.pizzaqp.Text = "+";
            this.pizzaqp.UseVisualStyleBackColor = true;
            this.pizzaqp.Visible = false;
            this.pizzaqp.Click += new System.EventHandler(this.button1_Click);
            // 
            // dhosaqp
            // 
            this.dhosaqp.Location = new System.Drawing.Point(494, 200);
            this.dhosaqp.Name = "dhosaqp";
            this.dhosaqp.Size = new System.Drawing.Size(26, 29);
            this.dhosaqp.TabIndex = 28;
            this.dhosaqp.Text = "+";
            this.dhosaqp.UseVisualStyleBackColor = true;
            this.dhosaqp.Visible = false;
            this.dhosaqp.Click += new System.EventHandler(this.button2_Click);
            // 
            // friedriceqp
            // 
            this.friedriceqp.Location = new System.Drawing.Point(494, 258);
            this.friedriceqp.Name = "friedriceqp";
            this.friedriceqp.Size = new System.Drawing.Size(26, 29);
            this.friedriceqp.TabIndex = 29;
            this.friedriceqp.Text = "+";
            this.friedriceqp.UseVisualStyleBackColor = true;
            this.friedriceqp.Visible = false;
            this.friedriceqp.Click += new System.EventHandler(this.friedriceqp_Click);
            // 
            // thumsupqp
            // 
            this.thumsupqp.Location = new System.Drawing.Point(494, 311);
            this.thumsupqp.Name = "thumsupqp";
            this.thumsupqp.Size = new System.Drawing.Size(26, 30);
            this.thumsupqp.TabIndex = 30;
            this.thumsupqp.Text = "+";
            this.thumsupqp.UseVisualStyleBackColor = true;
            this.thumsupqp.Visible = false;
            this.thumsupqp.Click += new System.EventHandler(this.thumsupqp_Click);
            // 
            // pizzaqm
            // 
            this.pizzaqm.Location = new System.Drawing.Point(638, 134);
            this.pizzaqm.Name = "pizzaqm";
            this.pizzaqm.Size = new System.Drawing.Size(26, 29);
            this.pizzaqm.TabIndex = 31;
            this.pizzaqm.Text = "-";
            this.pizzaqm.UseVisualStyleBackColor = true;
            this.pizzaqm.Visible = false;
            this.pizzaqm.Click += new System.EventHandler(this.button5_Click);
            // 
            // dhosaqm
            // 
            this.dhosaqm.Location = new System.Drawing.Point(638, 200);
            this.dhosaqm.Name = "dhosaqm";
            this.dhosaqm.Size = new System.Drawing.Size(26, 29);
            this.dhosaqm.TabIndex = 32;
            this.dhosaqm.Text = "-";
            this.dhosaqm.UseVisualStyleBackColor = true;
            this.dhosaqm.Visible = false;
            this.dhosaqm.Click += new System.EventHandler(this.dhosaqm_Click);
            // 
            // friedriceqm
            // 
            this.friedriceqm.Location = new System.Drawing.Point(638, 258);
            this.friedriceqm.Name = "friedriceqm";
            this.friedriceqm.Size = new System.Drawing.Size(26, 29);
            this.friedriceqm.TabIndex = 33;
            this.friedriceqm.Text = "-";
            this.friedriceqm.UseVisualStyleBackColor = true;
            this.friedriceqm.Visible = false;
            this.friedriceqm.Click += new System.EventHandler(this.friedriceqm_Click);
            // 
            // thumsupqm
            // 
            this.thumsupqm.Location = new System.Drawing.Point(638, 311);
            this.thumsupqm.Name = "thumsupqm";
            this.thumsupqm.Size = new System.Drawing.Size(26, 29);
            this.thumsupqm.TabIndex = 34;
            this.thumsupqm.Text = "-";
            this.thumsupqm.UseVisualStyleBackColor = true;
            this.thumsupqm.Visible = false;
            this.thumsupqm.Click += new System.EventHandler(this.thumsupqm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 558);
            this.Controls.Add(this.thumsupqm);
            this.Controls.Add(this.friedriceqm);
            this.Controls.Add(this.dhosaqm);
            this.Controls.Add(this.pizzaqm);
            this.Controls.Add(this.thumsupqp);
            this.Controls.Add(this.friedriceqp);
            this.Controls.Add(this.dhosaqp);
            this.Controls.Add(this.pizzaqp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Restaurant Bill Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button pizzaqp;
        private System.Windows.Forms.Button dhosaqp;
        private System.Windows.Forms.Button friedriceqp;
        private System.Windows.Forms.Button thumsupqp;
        private System.Windows.Forms.Button pizzaqm;
        private System.Windows.Forms.Button dhosaqm;
        private System.Windows.Forms.Button friedriceqm;
        private System.Windows.Forms.Button thumsupqm;
    }
}

