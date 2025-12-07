using Tyuiu.BukinTK.Sprint6.Task7.V9.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        private int[,]? _inputMatrix;
        private int[,]? _outputMatrix;

        private readonly DataService _dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_BTK_Click(object sender, EventArgs e)
        {
            if (openFileDialog_BTK.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog_BTK.FileName;
            TextBoxPath_BTK.Text = path;

            try
            {
                _inputMatrix = _dataService.GetMatrix(path);

                FillDataGrid(DataGridViewInput_BTK, _inputMatrix);
                DataGridViewOutput_BTK.Rows.Clear();
                DataGridViewOutput_BTK.Columns.Clear();
                _outputMatrix = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Формат файла не подходит: " + ex.Message);
            }
        }

        private void ButtonRun_BTK_Click(object sender, EventArgs e)
        {
            if (_inputMatrix == null)
            {
                MessageBox.Show("Файл ещё не был загружен.");
                return;
            }

            _outputMatrix = _dataService.ProcessMatrix(_inputMatrix);

            FillDataGrid(DataGridViewOutput_BTK, _outputMatrix);
        }

        private void ButtonSave_BTK_Click(object sender, EventArgs e)
        {
            if (_outputMatrix == null)
            {
                MessageBox.Show("Расчеты ещё не были произведены.");
                return;
            }

            if (saveFileDialog_BTK.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                _dataService.SaveToFile(saveFileDialog_BTK.FileName, _outputMatrix);
                MessageBox.Show("Файл сохранен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void ButtonAbout_BTK_Click(object sender, EventArgs e)
        {
            using (FormAbout about = new FormAbout())
            {
                about.ShowDialog();
            }
        }

        private void FillDataGrid(DataGridView dgv, int[,] matrix)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int c = 0; c < cols; c++)
            {
                dgv.Columns.Add("col" + c, "C" + c);
                dgv.Columns[c].Width = 40;
            }

            dgv.Rows.Add(rows);

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    dgv[c, r].Value = matrix[r, c];
        }
    }
}