using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreac_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0, x = 0;
            int[] sayi = { 8, 10, 12, 16, 17, 18, 20, 24, 25, 27 };
            foreach(int s in sayi)
            {
                //4 e tam bölünen sayılar
                if(s % 4 == 0)
                {
                    x++;
                    toplam = toplam + s;
                    listBox1.Items.Add(s);
                }
                label1.Text = toplam.ToString();
                label2.Text = x.ToString();
            }
        }
    }
}
