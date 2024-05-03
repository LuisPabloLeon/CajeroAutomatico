using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cuenta.Clear();
            PIN.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Cuenta.TextLength < 5)
            {
                Cuenta.Text += "1";
                if (PIN.TextLength < 4) 
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4) 
                {
                    PIN.Text += "1";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "2";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "2";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "3";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "3";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "4";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "4";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "5";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "6";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "6";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "7";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "7";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "8";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "8";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "9";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "9";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text += "0";
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "";
                }
            }
            else
            {
                if (PIN.TextLength < 4)
                {
                    PIN.Text += "0";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Cuenta.Text == "12345")
            {
                if (PIN.Text == "1234")
                {
                    MessageBox.Show("Datos correctos");
                }
                else
                {
                    MessageBox.Show("PIN incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrenctos");
            }
        }
    }
}
