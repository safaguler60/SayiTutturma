using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6Bir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int say1 = r.Next(1, 3);
            int say2 = r.Next(1, 3);
            int say3 = r.Next(1, 3);
            label1.Text = say1.ToString();
            label2.Text = say2.ToString();
            label3.Text = say3.ToString();
            if (say1 == say2 & say2 == say3) MessageBox.Show("BİNGO");
        }
    }
}
