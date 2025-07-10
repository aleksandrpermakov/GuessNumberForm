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
            List<int> listValues = new List<int>();
            listValues = GuessValue.ListValues(endRange);
            int half = GuessValue.GetHalf(listValues);
            int centerList = GuessValue.GetHalf(listValues);

            while (listValues.Count > 3)
            {
                DialogResult result = MessageBox.Show($"Ваше число меньше {centerList}? ", "Нажмешь ОТМЕНА значит угадал", 
                                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listValues = GuessValue.LeftListValues(listValues,half);
                    half = half / 2;
                    centerList = GuessValue.GetHalf(listValues);
                }
                if (result == DialogResult.No)
                {
                    listValues = GuessValue.RightListValues(listValues, half);
                    half = half / 2;
                    centerList = GuessValue.GetHalf(listValues);
                }
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"Ура ваше число - {centerList}");
                    Application.Exit();
                }

            }
            DialogResult result_ = MessageBox.Show($"Ваше число меньше {listValues[1]}? ", "Нажмешь ОТМЕНА значит угадал",
                                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result_ == DialogResult.Yes)
            {
                MessageBox.Show($"Ура ваше число - {listValues[0]}");
                Application.Exit();
            }
            if (result_ == DialogResult.No)
            {
                MessageBox.Show($"Ура ваше число - {listValues[2]}");
                Application.Exit();
            }
            if (result_ == DialogResult.Cancel)
            {
                MessageBox.Show($"Ура ваше число - {listValues[1]}");
                Application.Exit();
            }
        }
    }
}
