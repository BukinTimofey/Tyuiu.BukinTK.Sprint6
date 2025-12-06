using Tyuiu.BukinTK.Sprint6.Task5.V19.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string filePath = "";
        public FormMain()
        {
            InitializeComponent();
        }
        private void ButtonOpenFile_BTK_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files|*.txt";
                ofd.InitialDirectory = @"C:\DataSprint5\";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    TextBoxPath_BTK.Text = filePath;
                    ButtonRun_BTK.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ужас: {ex.Message}", "Кээээ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRun_BTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не существует!", "Исправьте",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] allData = ds.LoadFromDataFile(filePath);

                DataGridViewData_BTK.Rows.Clear();
                for (int i = 0; i < allData.Length; i++)
                {
                    DataGridViewData_BTK.Rows.Add(i + 1, Math.Round(allData[i], 3));
                }

                double[] part = new double[6];
                for (int i = 1; i <= 6; i++)
                {
                    if (i < allData.Length)
                    {
                        part[i - 1] = Math.Round(allData[i], 3);
                    }
                }

                Chart_BTK.Series.Clear();

                //SeriesCollection series = new SeriesCollection();
                //ChartValues<double> values = new ChartValues<double>(part);
                //ColumnSeries columnSeries = new ColumnSeries
                //{
                //    Title = "Çíà÷åíèÿ",
                //    Values = values,
                //    Fill = System.Windows.Media.Brushes.LightBlue
                //};

                //series.Add(columnSeries);
                //Chart_BTK.Series = series;


                //Chart_BTK.AxisX.Clear();
                //Chart_BTK.AxisX.Add(new Axis
                //{
                //    Title = "X",
                //    Labels = new[] { "2", "3", "4", "5", "6", "7" }
                //});

                //Chart_BTK.AxisY.Clear();
                //Chart_BTK.AxisY.Add(new Axis
                //{
                //    Title = "Y",
                //    LabelFormatter = value => value.ToString("F2")
                //});

                //Chart_BTK.LegendLocation = LegendLocation.Top;


                TextBoxPath_BTK.Text = $"Бабаба: {allData.Length}. Беее x=2..7";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"И что это: {ex.Message}", "Крута",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHelp_BTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнено Букиным Тимофеем Константиновичом, ИСПБ-25-1");
        }
        private void ButtonOpenFile_BTK_MouseEnter(object sender, EventArgs e)
        {
            ButtonOpenFile_BTK.BackColor = Color.SteelBlue;
            ButtonOpenFile_BTK.ForeColor = Color.White;
        }

        private void ButtonOpenFile_BTK_MouseLeave(object sender, EventArgs e)
        {
            ButtonOpenFile_BTK.BackColor = Color.LightSteelBlue;
            ButtonOpenFile_BTK.ForeColor = Color.Black;
        }

        private void ButtonRun_BTK_MouseEnter(object sender, EventArgs e)
        {
            ButtonRun_BTK.BackColor = Color.LimeGreen;
            ButtonRun_BTK.ForeColor = Color.White;
        }

        private void ButtonRun_BTK_MouseLeave(object sender, EventArgs e)
        {
            ButtonRun_BTK.BackColor = Color.PaleGreen;
            ButtonRun_BTK.ForeColor = Color.Black;
        }

        private void ButtonHelp_BTK_MouseEnter(object sender, EventArgs e)
        {
            ButtonHelp_BTK.BackColor = Color.RoyalBlue;
            ButtonHelp_BTK.ForeColor = Color.White;
        }

        private void ButtonHelp_BTK_MouseLeave(object sender, EventArgs e)
        {
            ButtonHelp_BTK.BackColor = Color.LightBlue;
            ButtonHelp_BTK.ForeColor = Color.Black;
        }
        //private void Chart_BTK_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        //{

        //}
    }
}