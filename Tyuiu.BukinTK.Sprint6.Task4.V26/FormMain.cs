using Tyuiu.BukinTK.Sprint6.Task4.V26.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task4.V26
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
                int startValue = -5;
                int stopValue = 5;

                double[] values = ds.GetMassFunction(startValue, stopValue);

                string table = "";


                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    table += $"| {x,3} | {values[i],6:F2}";
                }



                textBoxResult_BTK.Text = table;

                //var series = new LineSeries
                //{
                //    Values = new ChartValues<double>(),
                //    PointGeometrySize = 0,
                //    StrokeThickness = 2,
                //};

                //for (int i = 0; i < values.Length; i++)
                //{
                //    int x = startValue + i;
                //    series.Values.Add(values[i]);
                //}

                //cartesianChartResult_BTK.Series.Clear();
                //cartesianChartResult_BTK.Series.Add(series);
                //cartesianChartResult_BTK.AxisX.Clear();
                //cartesianChartResult_BTK.AxisY.Clear();
                //cartesianChartResult_BTK.AxisX.Add(new Axis { Title = "X", MinValue = -6, MaxValue = 6 });
                //cartesianChartResult_BTK.AxisY.Add(new Axis { Title = "f(x)", MinValue = -100, MaxValue = 100 });
                //cartesianChartResult_BTK.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void buttonSave_BTK_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] values = ds.GetMassFunction(startValue, stopValue);

            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask4V26.txt";
            string filePath = Path.Combine(tempPath, fileName);

            string content = "";

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                content += $"{x};{values[i]:F2}\n";
            }

            File.WriteAllText(filePath, content);

            MessageBox.Show($"Файл создан по пути: {filePath}");
        }

        private void buttonHelp_BTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проект сделан Букином Тимофеем Константиновичом, группа ИСПБ-25-1");
        }
    }
}