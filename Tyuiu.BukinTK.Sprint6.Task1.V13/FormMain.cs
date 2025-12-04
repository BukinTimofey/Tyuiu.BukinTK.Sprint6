using System.Windows.Forms.VisualStyles;
using Tyuiu.BukinTK.Sprint6.Task1.V13.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task1.V13
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
                int startValue = int.Parse(textBoxStart.Text);
                int stopValue = int.Parse(textBoxStop.Text);

                double[] values = ds.GetMassFunction(startValue, stopValue);

                string result = "+------------------------+-----------------------+\n";
                result += "|     X      |    f(x)    |\n";
                result += "+------------------------+-----------------------+\n";

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    result += $"| {x,3} | {values[i],6:F2} |\n";
                }

                result += "+------------------------+-----------------------+";

                richTextBoxResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формула F(x) = 3cos(x)/(4x-0,5) + sin(x) - 5x - 2 на отрезке [-5, 5] с шагом 1.");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
