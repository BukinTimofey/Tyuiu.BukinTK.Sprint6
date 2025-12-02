using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BukinTK.Sprint6.Task0.V14;

namespace Tyuiu.BukinTK.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //DataService ds = new DataService();

            try
            {
                //int x = int.Parse(textBoxInput_BTK.Text);
                //double result = ds.Calculate(x);
                //textBoxResult_BTK.Text = result.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }
        private void labelFormula_Click(object sender, EventArgs e)
        {

        }
    }
}
