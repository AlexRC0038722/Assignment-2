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
            double Resistor1, Resistor2;

            //Read each textbox value
            try
            {
                Resistor1 = double.Parse(textBox3.Text);
                Resistor2 = double.Parse(textBox4.Text);
            }
             catch
            {
                MessageBox.Show("Type a number in both resitor textboxes");
                Resistor1 = 0.0;
                Resistor2 = 0.0;
            }

            //Calculate the total resistance
            double resistance = 1 / 1 / Resistor1 + 1 / Resistor2; 

            //Display the total resistance
            label2
        }
    }
}
