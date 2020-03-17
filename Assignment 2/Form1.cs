using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declare resistor values
            double Resistor1, Resistor2;

            //Read values from textboxes
            try
            {
                Resistor1 = double.Parse(textBox1.Text);
                Resistor2 = double.Parse(textBox2.Text);
            }

            catch
            { 
                //Show message when noting is typed into the textboxes
               MessageBox.Show("Type a number in both resistor boxes!");
               Resistor1 = 0.0;
               Resistor2 = 0.0;
            }

            //Calculate the total resistance
            double Resistance = Resistor1 + Resistor2 ;

            //Display total resistance
            label1.Text = " Total resistance = " + Resistance + " Ohms";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Delare resistor values
            double Resistor3, Resistor4;

            //Read each textbox value
            try
            {
                Resistor3 = double.Parse(textBox3.Text);
                Resistor4 = double.Parse(textBox4.Text);
            }
             catch
            {
                MessageBox.Show("Type a number in both resitor textboxes");
                Resistor3 = 0.0;
                Resistor4 = 0.0;
            }

            //Calculate the total resistance
            double Resistance = 1.0 / (1.0 / Resistor3 + 1.0 / Resistor4);

            //Display the total resistance
            label2.Text = " Total resistance = " + Resistance + " Ohms";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Declare resistor values
            double Resistor5, Resistor6, Resistor7;

            //Read values from textboxes
            try
            {
                Resistor5 = double.Parse(textBox5.Text);
                Resistor6 = double.Parse(textBox6.Text);
                Resistor7 = double.Parse(textBox7.Text);
            }

            catch
            {
                MessageBox.Show("Type a number in all resistor boxes!");
                Resistor5 = 0.0;
                Resistor6 = 0.0;
                Resistor7 = 0.0;
            }

            //Calculate the total resistance
            double Resistance = Resistor5 + Resistor6 + Resistor7 ;

            //Display total resistance
            label3.Text = " Total resistance = " + Resistance + " Ohms";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Delare resistor values
            double Resistor8, Resistor9, Resistor10;

            //Read each textbox value
            try
            {
                Resistor8 = double.Parse(textBox8.Text);
                Resistor9 = double.Parse(textBox9.Text);
                Resistor10 = double.Parse(textBox10.Text);
            }
            catch
            {
                //Show message when nothing its typed into the textboxes
                MessageBox.Show("Type a number in all resistor textboxes!");
                Resistor8 = 0.0;
                Resistor9 = 0.0;
                Resistor10 = 0.0;
            }

            //Calculate the total resistance
            double Resistance = 1.0 / (1.0 / Resistor8 + 1.0 / Resistor9 + 1.0 / Resistor10);

            //Display the total resistance
            label4.Text = " Total resistance = " + Resistance + " Ohms";
        }
    }
    }

