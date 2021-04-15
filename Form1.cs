using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Bill
{
    public partial class Form1 : Form
    {
        double total=0.00;
        double pizzaPrice = 80.00;
        double dhosaPrice =120.00;
        double friedRicePrice = 220.00;
        double thumsUpPrice = 30.00;

        int pizzaQuantity = 1;
        int dhosaQuantity = 1;
        int friedRiceQuantity = 1;
        int thumsUpQuantity = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label9.Text = pizzaPrice.ToString();
                total +=pizzaPrice;
                label7.Text = total.ToString();
                
                //print Quantity 
                label17.Text = "1";
                
                //show quantity + - Button
                pizzaqp.Visible = true;
                pizzaqm.Visible = true;
            }
            else
            {
                label9.Text = "0.00";
                total -= pizzaPrice;
                label7.Text = total.ToString();
                
                
                //hide quantity + - Button
                pizzaqp.Visible = false;
                pizzaqm.Visible = false;

                //print quantity
                label17.Text = "0";
            }
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label10.Text = dhosaPrice.ToString();
                total += dhosaPrice;
                label7.Text = total.ToString();

                //visible quantity + - Button
                dhosaqp.Visible = true;
                dhosaqm.Visible = true;

                //print quantity
                label18.Text = "1";
            }
            else
            {
                label10.Text = "0.00";
                total -=dhosaPrice;
                label7.Text = total.ToString();

                //hide quantity + - Button
                dhosaqp.Visible = false;
                dhosaqm.Visible = false;

                //print quantity
                label18.Text = "0";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label11.Text = friedRicePrice.ToString();
                total += friedRicePrice;
                label7.Text = total.ToString();

                //visible quantity + - Button
                friedriceqp.Visible = true;
                friedriceqm.Visible = true;

                //print quantity
                label19.Text = "1";
            }
            else
            {
                label11.Text = "0.00";
                total -= friedRicePrice;
                label7.Text = total.ToString();

                //hide quantity + - Button
                friedriceqp.Visible = false;
                friedriceqm.Visible = false;

                //print quantity
                label19.Text = "0";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox4.Checked == true)
            {
                label13.Text = thumsUpPrice.ToString();
                total += thumsUpPrice;
                label7.Text = total.ToString();

                //Visible quantity + - Button

                thumsupqp.Visible = true;
                thumsupqm.Visible = true;

                //print quantity
                label20.Text = "1";
            }
            else
            {
                label13.Text = "0.00";
                total -=thumsUpPrice;
                label7.Text = total.ToString();

                //hide quantity + - Button
                thumsupqp.Visible = false;
                thumsupqm.Visible = false;

                //print quantity
                label20.Text = "0";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pizzaQuantity += 1;
            label17.Text = pizzaQuantity.ToString();
            label9.Text = (pizzaQuantity * pizzaPrice).ToString();

            //print Total

            total +=  pizzaPrice;
            label7.Text = total.ToString();
            if (pizzaQuantity > 1)
                pizzaqm.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dhosaQuantity += 1;
            label18.Text = dhosaQuantity.ToString();
            label10.Text = (dhosaQuantity * dhosaPrice).ToString();

            //print Total

            total += dhosaPrice;
            label7.Text = total.ToString();

            //Enable - quantity button
            if (dhosaQuantity > 1)
                dhosaqm.Enabled = true;
        }

        
        private void friedriceqp_Click(object sender, EventArgs e)
        {
            friedRiceQuantity += 1;
            label19.Text = friedRiceQuantity.ToString();
            label11.Text = (friedRiceQuantity * friedRicePrice).ToString();

            //print total

            total += friedRicePrice;
            label7.Text = total.ToString();

            //Enable - quantity button
            if (friedRiceQuantity > 1)
                friedriceqm.Enabled = true;
        }

        private void thumsupqp_Click(object sender, EventArgs e)
        {
            thumsUpQuantity += 1;
            label20.Text = thumsUpQuantity.ToString();
            label13.Text = (thumsUpQuantity * thumsUpPrice).ToString();

            //print total
            total += thumsUpPrice;
            label7.Text = total.ToString();

            //Enable - quantity button
            if (thumsUpQuantity > 1)
                thumsupqm.Enabled = true;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (pizzaQuantity < 2)
                pizzaqm.Enabled = false;
            else
            {
                pizzaQuantity -= 1;
                label17.Text = pizzaQuantity.ToString();
                label9.Text = (pizzaQuantity * pizzaPrice).ToString();

                //print amount
                total -= pizzaPrice;
                label7.Text = total.ToString();
            }
        }

        private void dhosaqm_Click(object sender, EventArgs e)
        {
            if (dhosaQuantity < 2)
                dhosaqm.Enabled = false;
            else
            {
                dhosaQuantity -= 1;
                label18.Text = dhosaQuantity.ToString();
                label10.Text = (dhosaQuantity * dhosaPrice).ToString();

                //print amount
                total -= dhosaPrice;
                label7.Text = total.ToString();
            }
        }

        private void friedriceqm_Click(object sender, EventArgs e)
        {
            if (friedRiceQuantity < 2)
                friedriceqm.Enabled = false;
            else
            {
                friedRiceQuantity -= 1;
                label19.Text = friedRiceQuantity.ToString();
                label11.Text = (friedRiceQuantity * friedRicePrice).ToString();

                //print amount
                total -= friedRicePrice;
                label7.Text = total.ToString();
            }
        }

        private void thumsupqm_Click(object sender, EventArgs e)
        {
            if (thumsUpQuantity < 2)
                thumsupqm.Enabled = false;
            else
            {
                thumsUpQuantity -= 1;
                label20.Text = thumsUpQuantity.ToString();
                label13.Text = (thumsUpQuantity * thumsUpPrice).ToString();

                //print amount
                total -= thumsUpPrice;
                label7.Text = total.ToString();
            }
        }
    }
}
