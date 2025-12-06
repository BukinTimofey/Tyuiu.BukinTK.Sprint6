namespace Tyuiu.BukinTK.Sprint6.Task4.V26
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
            groupBoxCondition_BTK = new GroupBox();
            labelFormula_BTK = new Label();
            groupBoxInput_BTK = new GroupBox();
            buttonHelp_BTK = new Button();
            buttonCalculate_BTK = new Button();
            buttonSave_BTK = new Button();
            groupBoxOutput_BTK = new GroupBox();
            textBoxResult_BTK = new TextBox();
            //cartesianChartResult_BTK = new LiveCharts.WinForms.CartesianChart();
            groupBoxCondition_BTK.SuspendLayout();
            groupBoxInput_BTK.SuspendLayout();
            groupBoxOutput_BTK.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_BTK
            // 
            groupBoxCondition_BTK.Controls.Add(labelFormula_BTK);
            groupBoxCondition_BTK.Location = new Point(35, 23);
            groupBoxCondition_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_BTK.Name = "groupBoxCondition_BTK";
            groupBoxCondition_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_BTK.Size = new Size(863, 92);
            groupBoxCondition_BTK.TabIndex = 0;
            groupBoxCondition_BTK.TabStop = false;
            groupBoxCondition_BTK.Text = "Условие";
            // 
            // labelFormula_BTK
            // 
            labelFormula_BTK.AutoSize = true;
            labelFormula_BTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_BTK.Location = new Point(35, 42);
            labelFormula_BTK.Margin = new Padding(4, 0, 4, 0);
            labelFormula_BTK.Name = "labelFormula_BTK";
            labelFormula_BTK.Size = new Size(273, 20);
            labelFormula_BTK.TabIndex = 0;
            labelFormula_BTK.Text = "F(x) = 5 - 3x + 1+sin(x) / 2x - 0.5";
            // 
            // groupBoxInput_BTK
            // 
            groupBoxInput_BTK.Controls.Add(buttonHelp_BTK);
            groupBoxInput_BTK.Controls.Add(buttonCalculate_BTK);
            groupBoxInput_BTK.Controls.Add(buttonSave_BTK);
            groupBoxInput_BTK.Location = new Point(35, 127);
            groupBoxInput_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_BTK.Name = "groupBoxInput_BTK";
            groupBoxInput_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_BTK.Size = new Size(863, 115);
            groupBoxInput_BTK.TabIndex = 1;
            groupBoxInput_BTK.TabStop = false;
            groupBoxInput_BTK.Text = "Ввод данных";
            // 
            // buttonHelp_BTK
            // 
            buttonHelp_BTK.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_BTK.Location = new Point(35, 22);
            buttonHelp_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_BTK.Name = "buttonHelp_BTK";
            buttonHelp_BTK.Size = new Size(265, 78);
            buttonHelp_BTK.TabIndex = 0;
            buttonHelp_BTK.Text = "Справка";
            buttonHelp_BTK.UseVisualStyleBackColor = false;
            buttonHelp_BTK.Click += buttonHelp_BTK_Click;
            // 
            // buttonCalculate_BTK
            // 
            buttonCalculate_BTK.BackColor = SystemColors.Highlight;
            buttonCalculate_BTK.Location = new Point(308, 22);
            buttonCalculate_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_BTK.Name = "buttonCalculate_BTK";
            buttonCalculate_BTK.Size = new Size(256, 78);
            buttonCalculate_BTK.TabIndex = 1;
            buttonCalculate_BTK.Text = "Выполнить";
            buttonCalculate_BTK.UseVisualStyleBackColor = false;
            buttonCalculate_BTK.Click += buttonCalculate_BTK_Click;
            // 
            // buttonSave_BTK
            // 
            buttonSave_BTK.BackColor = SystemColors.Desktop;
            buttonSave_BTK.Location = new Point(572, 22);
            buttonSave_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonSave_BTK.Name = "buttonSave_BTK";
            buttonSave_BTK.Size = new Size(267, 78);
            buttonSave_BTK.TabIndex = 2;
            buttonSave_BTK.Text = "Сохранить";
            buttonSave_BTK.UseVisualStyleBackColor = false;
            buttonSave_BTK.Click += buttonSave_BTK_Click;
            // 
            // groupBoxOutput_BTK
            // 
            groupBoxOutput_BTK.Controls.Add(textBoxResult_BTK);
            //groupBoxOutput_BTK.Controls.Add(cartesianChartResult_BTK);
            groupBoxOutput_BTK.Location = new Point(35, 254);
            groupBoxOutput_BTK.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTK.Name = "groupBoxOutput_BTK";
            groupBoxOutput_BTK.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_BTK.Size = new Size(863, 231);
            groupBoxOutput_BTK.TabIndex = 2;
            groupBoxOutput_BTK.TabStop = false;
            groupBoxOutput_BTK.Text = "Вывод данных";
            // 
            // textBoxResult_BTK
            // 
            textBoxResult_BTK.BackColor = Color.IndianRed;
            textBoxResult_BTK.Location = new Point(35, 35);
            textBoxResult_BTK.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_BTK.Multiline = true;
            textBoxResult_BTK.Name = "textBoxResult_BTK";
            textBoxResult_BTK.ReadOnly = true;
            textBoxResult_BTK.Size = new Size(349, 172);
            textBoxResult_BTK.TabIndex = 0;
            // 
            // cartesianChartResult_BTK
            // 
            //cartesianChartResult_BTK.BackColor = Color.IndianRed;
            //cartesianChartResult_BTK.Location = new Point(457, 35);
            //cartesianChartResult_BTK.Margin = new Padding(4, 3, 4, 3);
            //cartesianChartResult_BTK.Name = "cartesianChartResult_BTK";
            //cartesianChartResult_BTK.Size = new Size(359, 173);
            //cartesianChartResult_BTK.TabIndex = 1;
            //cartesianChartResult_BTK.Text = "cartesianChart_BTK";
            //cartesianChartResult_BTK.ChildChanged += cartesianChartResult_BTK_ChildChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBoxOutput_BTK);
            Controls.Add(groupBoxInput_BTK);
            Controls.Add(groupBoxCondition_BTK);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Task 4 | Вариант 26 | Букин Т. К.";
            groupBoxCondition_BTK.ResumeLayout(false);
            groupBoxCondition_BTK.PerformLayout();
            groupBoxInput_BTK.ResumeLayout(false);
            groupBoxOutput_BTK.ResumeLayout(false);
            groupBoxOutput_BTK.PerformLayout();
            ResumeLayout(false);

        }

        //private void cartesianChartResult_BTK_ChildChanged(object sender, ChildChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private System.Windows.Forms.GroupBox groupBoxCondition_BTK;
        private System.Windows.Forms.Label labelFormula_BTK;
        private System.Windows.Forms.GroupBox groupBoxInput_BTK;
        private System.Windows.Forms.Button buttonHelp_BTK;
        private System.Windows.Forms.Button buttonCalculate_BTK;
        private System.Windows.Forms.Button buttonSave_BTK;
        private System.Windows.Forms.GroupBox groupBoxOutput_BTK;
        private System.Windows.Forms.TextBox textBoxResult_BTK;
        //private LiveCharts.WinForms.CartesianChart cartesianChartResult_BTK;
    }
}
