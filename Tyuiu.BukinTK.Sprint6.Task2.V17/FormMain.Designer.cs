namespace Tyuiu.BukinTK.Sprint6.Task2.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            //System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            //System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            //System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            //Нейронка сказала что этот пакет к чертям устарел, так что увы
            groupBoxCondition_BTK = new GroupBox();
            labelFormula_BTK = new Label();
            groupBoxInput_BTK = new GroupBox();
            labelStart_BTK = new Label();
            textBoxStart_BTK = new TextBox();
            labelStop_BTK = new Label();
            textBoxStop_BTK = new TextBox();
            buttonHelp_BTK = new Button();
            buttonCalculate_BTK = new Button();
            groupBoxOutput_BTK = new GroupBox();
            dataGridViewResult_BTK = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            //chart_BTK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_BTK.SuspendLayout();
            groupBoxInput_BTK.SuspendLayout();
            groupBoxOutput_BTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTK).BeginInit();
            //((System.ComponentModel.ISupportInitialize)chart_BTK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_BTK
            // 
            groupBoxCondition_BTK.Controls.Add(labelFormula_BTK);
            groupBoxCondition_BTK.Location = new Point(35, 23);
            groupBoxCondition_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_BTK.Name = "groupBoxCondition_BTK";
            groupBoxCondition_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_BTK.Size = new Size(409, 92);
            groupBoxCondition_BTK.TabIndex = 0;
            groupBoxCondition_BTK.TabStop = false;
            groupBoxCondition_BTK.Text = "Условие";
            // 
            // labelFormula_BTK
            // 
            labelFormula_BTK.AutoSize = true;
            labelFormula_BTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_BTK.Location = new Point(35, 35);
            labelFormula_BTK.Margin = new Padding(4, 0, 4, 0);
            labelFormula_BTK.Name = "labelFormula_BTK";
            labelFormula_BTK.Size = new Size(236, 20);
            labelFormula_BTK.TabIndex = 0;
            labelFormula_BTK.Text = "F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)";
            // 
            // groupBoxInput_BTK
            // 
            groupBoxInput_BTK.Controls.Add(labelStart_BTK);
            groupBoxInput_BTK.Controls.Add(textBoxStart_BTK);
            groupBoxInput_BTK.Controls.Add(labelStop_BTK);
            groupBoxInput_BTK.Controls.Add(textBoxStop_BTK);
            groupBoxInput_BTK.Controls.Add(buttonHelp_BTK);
            groupBoxInput_BTK.Controls.Add(buttonCalculate_BTK);
            groupBoxInput_BTK.Location = new Point(35, 127);
            groupBoxInput_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_BTK.Name = "groupBoxInput_BTK";
            groupBoxInput_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_BTK.Size = new Size(409, 115);
            groupBoxInput_BTK.TabIndex = 1;
            groupBoxInput_BTK.TabStop = false;
            groupBoxInput_BTK.Text = "Ввод данных";
            // 
            // labelStart_BTK
            // 
            labelStart_BTK.AutoSize = true;
            labelStart_BTK.Location = new Point(35, 35);
            labelStart_BTK.Margin = new Padding(4, 0, 4, 0);
            labelStart_BTK.Name = "labelStart_BTK";
            labelStart_BTK.Size = new Size(72, 15);
            labelStart_BTK.TabIndex = 0;
            labelStart_BTK.Text = "Старт шага:";
            // 
            // textBoxStart_BTK
            // 
            textBoxStart_BTK.Location = new Point(117, 31);
            textBoxStart_BTK.Margin = new Padding(4, 3, 4, 3);
            textBoxStart_BTK.Name = "textBoxStart_BTK";
            textBoxStart_BTK.Size = new Size(116, 23);
            textBoxStart_BTK.TabIndex = 1;
            // 
            // labelStop_BTK
            // 
            labelStop_BTK.AutoSize = true;
            labelStop_BTK.Location = new Point(35, 69);
            labelStop_BTK.Margin = new Padding(4, 0, 4, 0);
            labelStop_BTK.Name = "labelStop_BTK";
            labelStop_BTK.Size = new Size(75, 15);
            labelStop_BTK.TabIndex = 2;
            labelStop_BTK.Text = "Конец шага:";
            // 
            // textBoxStop_BTK
            // 
            textBoxStop_BTK.Location = new Point(117, 66);
            textBoxStop_BTK.Margin = new Padding(4, 3, 4, 3);
            textBoxStop_BTK.Name = "textBoxStop_BTK";
            textBoxStop_BTK.Size = new Size(116, 23);
            textBoxStop_BTK.TabIndex = 3;
            // 
            // buttonHelp_BTK
            // 
            buttonHelp_BTK.Location = new Point(257, 31);
            buttonHelp_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_BTK.Name = "buttonHelp_BTK";
            buttonHelp_BTK.Size = new Size(93, 27);
            buttonHelp_BTK.TabIndex = 4;
            buttonHelp_BTK.Text = "Справка";
            buttonHelp_BTK.UseVisualStyleBackColor = true;
            buttonHelp_BTK.Click += buttonHelp_BTK_Click;
            // 
            // buttonCalculate_BTK
            // 
            buttonCalculate_BTK.Location = new Point(257, 66);
            buttonCalculate_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_BTK.Name = "buttonCalculate_BTK";
            buttonCalculate_BTK.Size = new Size(93, 27);
            buttonCalculate_BTK.TabIndex = 5;
            buttonCalculate_BTK.Text = "Выполнить";
            buttonCalculate_BTK.UseVisualStyleBackColor = true;
            buttonCalculate_BTK.Click += buttonCalculate_BTK_Click;
            // 
            // groupBoxOutput_BTK
            // 
            groupBoxOutput_BTK.Controls.Add(dataGridViewResult_BTK);
            groupBoxOutput_BTK.Location = new Point(465, 23);
            groupBoxOutput_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTK.Name = "groupBoxOutput_BTK";
            groupBoxOutput_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTK.Size = new Size(437, 219);
            groupBoxOutput_BTK.TabIndex = 2;
            groupBoxOutput_BTK.TabStop = false;
            groupBoxOutput_BTK.Text = "Вывод данных";
            // 
            // dataGridViewResult_BTK
            // 
            dataGridViewResult_BTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BTK.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewResult_BTK.Location = new Point(143, 35);
            dataGridViewResult_BTK.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_BTK.Name = "dataGridViewResult_BTK";
            dataGridViewResult_BTK.Size = new Size(172, 173);
            dataGridViewResult_BTK.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "X";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "F(X)";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 80;
            // 
            // chart_BTK
            // 
            //chart_BTK.AccessibleName = "";
            //chartArea1.Name = "ChartArea1";
            //chart_BTK.ChartAreas.Add(chartArea1);
            //chart_BTK.ImeMode = ImeMode.Off;
            //legend1.Name = "Legend1";
            //chart_BTK.Legends.Add(legend1);
            //chart_BTK.Location = new Point(35, 260);
            //chart_BTK.Name = "chart_BTK";
            //chart_BTK.RightToLeft = RightToLeft.No;
            //series1.ChartArea = "ChartArea1";
            //series1.Legend = "Legend1";
            //series1.Name = "Series1";
            //chart_BTK.Series.Add(series1);
            //chart_BTK.Size = new Size(867, 164);
            //chart_BTK.TabIndex = 2;
            //chart_BTK.Text = "chart";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 421);
            //Controls.Add(chart_BTK);
            Controls.Add(groupBoxOutput_BTK);
            Controls.Add(groupBoxInput_BTK);
            Controls.Add(groupBoxCondition_BTK);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Букин Т. К.";
            groupBoxCondition_BTK.ResumeLayout(false);
            groupBoxCondition_BTK.PerformLayout();
            groupBoxInput_BTK.ResumeLayout(false);
            groupBoxInput_BTK.PerformLayout();
            groupBoxOutput_BTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTK).EndInit();
            //((System.ComponentModel.ISupportInitialize)chart_BTK).EndInit();
            ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBoxCondition_BTK;
        private System.Windows.Forms.Label labelFormula_BTK;
        private System.Windows.Forms.GroupBox groupBoxInput_BTK;
        private System.Windows.Forms.Label labelStart_BTK;
        private System.Windows.Forms.TextBox textBoxStart_BTK;
        private System.Windows.Forms.Label labelStop_BTK;
        private System.Windows.Forms.TextBox textBoxStop_BTK;
        private System.Windows.Forms.Button buttonHelp_BTK;
        private System.Windows.Forms.Button buttonCalculate_BTK;
        private System.Windows.Forms.GroupBox groupBoxOutput_BTK;
        private System.Windows.Forms.DataGridView dataGridViewResult_BTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart_BTK;
    }
}

