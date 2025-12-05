using Tyuiu.BukinTK.Sprint6.Task3.V29.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
                {-2, -13, -15, -9, -17},
                {13, -20, -15, 27, 18},
                {-12, -1, -20, 13, 0},
                {15, 32, 18, -12, -18},
                {16, 5, 3, -5, -8}
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewResult_BTK.RowCount = 5;
            dataGridViewResult_BTK.ColumnCount = 5;
            dataGridViewResult_BTK.ColumnHeadersVisible = false;
            dataGridViewResult_BTK.RowHeadersVisible = false;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_BTK.Columns[i].Width = 50;
                dataGridViewResult_BTK.Rows[i].Height = 30;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_BTK.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonHelp_BTK_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_BTK.BackColor = Color.LightBlue;
        }

        private void buttonHelp_BTK_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_BTK.BackColor = SystemColors.Control;
        }

        private void buttonCalculate_BTK_MouseEnter(object sender, EventArgs e)
        {
            buttonCalculate_BTK.BackColor = Color.LightGreen;
        }

        private void buttonCalculate_BTK_MouseLeave(object sender, EventArgs e)
        {
            buttonCalculate_BTK.BackColor = SystemColors.Control;
        }

        private void buttonHelp_BTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил Букин Тимофей Константинович ИСПБ-25-1", "Уээээ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalculate_BTK_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] resultMatrix = ds.Calculate(matrix);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_BTK.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                textBoxResult_BTK.Text = "Расчет выполнен!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибочка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
