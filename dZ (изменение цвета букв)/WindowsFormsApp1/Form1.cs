using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random R;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122))
            {
                e.Handled = true;
                
            }
            else
            {
                if (e.KeyChar == 65 || e.KeyChar == 97)
                {
                    richTextBox1.BackColor = Color.Aqua;
                }
                else if (e.KeyChar == 66 || e.KeyChar == 98)
                {
                    richTextBox1.BackColor = Color.Blue;
                }
                else if (e.KeyChar == 67 || e.KeyChar == 99)
                {
                    richTextBox1.BackColor = Color.Coral;
                }
                else if (e.KeyChar == 68 || e.KeyChar == 100)
                {
                    richTextBox1.BackColor = Color.DarkGoldenrod;
                }
                else if (e.KeyChar == 70 || e.KeyChar == 102)
                {
                    richTextBox1.BackColor = Color.Firebrick;
                }
                else if (e.KeyChar == 71 || e.KeyChar == 103)
                {
                    richTextBox1.BackColor = Color.Gray;
                }
                else if (e.KeyChar == 72 || e.KeyChar == 104)
                {
                    richTextBox1.BackColor = Color.HotPink;
                }
                else if (e.KeyChar == 73 || e.KeyChar == 105)
                {
                    richTextBox1.BackColor = Color.IndianRed;
                }
                else if (e.KeyChar == 75 || e.KeyChar == 107)
                {
                    richTextBox1.BackColor = Color.Khaki;
                }
                else if (e.KeyChar == 76 || e.KeyChar == 108)
                {
                    richTextBox1.BackColor = Color.LemonChiffon;
                }
                else if (e.KeyChar == 77 || e.KeyChar == 109)
                {
                    richTextBox1.BackColor = Color.Maroon;
                }
                else if (e.KeyChar == 78 || e.KeyChar == 110)
                {
                    richTextBox1.BackColor = Color.NavajoWhite;
                }
                else if (e.KeyChar == 79 || e.KeyChar == 111)
                {
                    richTextBox1.BackColor = Color.Orange;
                }
                else if (e.KeyChar == 80 || e.KeyChar == 112)
                {
                    richTextBox1.BackColor = Color.PaleTurquoise;
                }
                else if (e.KeyChar == 81 || e.KeyChar == 113)
                {
                    DialogResult rezult = MessageBox.Show("К сожалению нет цвета на данную букву.\n" +
                        "Хотите заменить цвет на черный?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezult == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                    
                }
                else if (e.KeyChar == 82 || e.KeyChar == 114)
                {
                    richTextBox1.BackColor = Color.Red;
                }
                else if (e.KeyChar == 83 || e.KeyChar == 115)
                {
                    richTextBox1.BackColor = Color.Salmon;
                }
                else if (e.KeyChar == 84 || e.KeyChar == 116)
                {
                    richTextBox1.BackColor = Color.Tan;
                }
                else if (e.KeyChar == 86 || e.KeyChar == 118)
                {
                    richTextBox1.BackColor = Color.Violet;
                }
                else if (e.KeyChar == 87 || e.KeyChar == 119)
                {
                    richTextBox1.BackColor = Color.White;
                }
                else if (e.KeyChar == 89 || e.KeyChar == 121)
                {
                    richTextBox1.BackColor = Color.Yellow;
                }

            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (timer1.Enabled == false)
                        timer1.Enabled = true;
                    else
                        timer1.Enabled = false;
                }
                else if (e.KeyData == Keys.PageUp)
                {
                    timer1.Interval -= 10;
                }
                else if (e.KeyData == Keys.PageDown)
                    timer1.Interval += 10;
            }
            catch
            {

            }
        }


                private void Form1_Load(object sender, EventArgs e)
                {
                    R = new Random();
                }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(R.Next(0, 256), R.Next(0, 256), R.Next(0, 256));
            this.BackColor = Color.FromArgb(R.Next(0, 256), R.Next(0, 256), R.Next(0, 256));
        }
         
    }
}


