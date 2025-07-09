using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int endRange = RandomRange.GetEndRange();
            MessageBox.Show($"Загадайте число в диапазоне от 1 до {endRange}");
            MessageBox.Show($"Ваше число меньше {endRange /2 }");
        }
    }
}
