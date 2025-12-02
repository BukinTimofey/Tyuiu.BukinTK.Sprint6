using Tyuiu.BukinTK.Sprint6.Task0.V14.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = int.Parse(textBoxInput_BTK.Text);
                double result = ds.Calculate(x);
                textBoxResult_BTK.Text = result.ToString("F3");
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
