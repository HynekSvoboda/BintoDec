using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolPrevody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        string DectoBin(int cislo)
        {
            string vysledek = string.Empty;
            try
            {
                while (cislo > 0)
                {
                    int zbytek = cislo % 2;
                    vysledek = zbytek + vysledek;
                    cislo /= 2;
                }
                if (vysledek == string.Empty) vysledek = "0";
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return vysledek;
        }

        int BintoDec(string cislo)
        {
            int vysledek = 0;
            try
            {
                while (cislo.Length > 0)
                {
                    if (cislo[0] == '1')
                    {
                        checked { vysledek += (int)Math.Pow(2, cislo.Length - 1); }
                    }
                    cislo = cislo.Substring(1);
                }
            }catch (Exception e) { MessageBox.Show(e.Message); }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DectoBin(Convert.ToInt32(numericUpDown1.Value));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = BintoDec(textBox1.Text).ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || e.KeyChar > '1') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
