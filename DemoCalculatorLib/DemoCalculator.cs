using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            CurrentOperation = operation.clearOperation;
        }

        String buffer;
        operation CurrentOperation;



        enum operation
        {
            substraction,
            addiction,
            multiplication,
            division,
            clearOperation
        }


        private void button15_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("hdfh");
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = buffer;
                    
                }
                else
                {
                             
                    if (CurrentOperation == operation.addiction)
                    {
                      
                        double tmpBuffer = double.Parse(textBox1.Text);
                        textBox1.Text = (double.Parse(buffer) + tmpBuffer).ToString();
                        CurrentOperation = operation.clearOperation;
                    }
                    if (CurrentOperation == operation.substraction)
                    {
                        double tmpBuffer = double.Parse(textBox1.Text);
                        textBox1.Text = (double.Parse(buffer) - tmpBuffer).ToString();
                        CurrentOperation = operation.clearOperation;
                    }
                    if (CurrentOperation == operation.multiplication)
                    {
                        double tmpBuffer = double.Parse(textBox1.Text);
                        textBox1.Text = (double.Parse(buffer) * tmpBuffer).ToString();
                        CurrentOperation = operation.clearOperation;
                    }
                    if (CurrentOperation == operation.division)
                    {
                        double tmpBuffer = double.Parse(textBox1.Text);
                        textBox1.Text = (double.Parse(buffer) / tmpBuffer).ToString();
                        CurrentOperation = operation.clearOperation;
                    }
                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("Try input incorrect data");
            }

        } // result button

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((int.Parse(textBox1.Text)) * (-1)).ToString();
        }
        // TODO: "." or ","
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (CurrentOperation == operation.clearOperation)
            {
                CurrentOperation = operation.addiction;
                buffer = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
               
            }
            else
            {
                CurrentOperation = operation.addiction;
            }
        } // addition button

        
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox1.Focus();
        }  // button 1 

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CurrentOperation == operation.clearOperation)
            {
                CurrentOperation = operation.division;
                buffer = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                CurrentOperation = operation.division;
            }
        }
        // TODO: double click (add variable "count" with if statement?)
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            buffer = "";   // preferable double ckick 
            CurrentOperation = operation.clearOperation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Focus();
        } // button 2

        
        private void button14_Click(object sender, EventArgs e)
        {
            if (CurrentOperation == operation.clearOperation)
            {
                CurrentOperation = operation.substraction;
                buffer = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                CurrentOperation = operation.substraction;                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CurrentOperation == operation.clearOperation)
            {
                CurrentOperation = operation.multiplication;
                buffer = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                CurrentOperation = operation.multiplication;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Focus();
        }
        // TODO: now: properties - read only - true
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
