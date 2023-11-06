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
            while(cislo>0)
            {
                int zbytek = cislo % 2;
                vysledek += zbytek;
                cislo /= 2;
            }
            return vysledek;
        }

        int BintoDec(string cislo)
        {
            int vysledek = 0;
            int delka = 1;
            while(delka<cislo.Length)
            {
                int pocet = cislo[cislo.Length-delka-delka-1] * Convert.ToInt32(Math.Pow(2, delka));
                vysledek += pocet;
                delka++;
            }
            return vysledek;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = DectoBin(Convert.ToInt32(numericUpDown1.Value));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            string cis = Convert.ToString(numericUpDown1.Value);
            label4.Text = BintoDec(cis).ToString();
        }
    }
}
