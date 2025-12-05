using Tyuiu.BukinTK.Sprint6.Task2.V17.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_BTK_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = int.Parse(textBoxStart_BTK.Text);
                int stopValue = int.Parse(textBoxStop_BTK.Text);

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewResult_BTK.Rows.Clear();

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    dataGridViewResult_BTK.Rows.Add(x, values[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void buttonHelp_BTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИСПБ-25-1 беббе");
        }
    }
}
