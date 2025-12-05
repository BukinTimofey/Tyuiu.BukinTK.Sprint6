namespace Tyuiu.BukinTK.Sprint6.Task3.V29
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
            textBoxTask_BTK = new TextBox();
            groupBoxInput_BTK = new GroupBox();
            buttonHelp_BTK = new Button();
            buttonCalculate_BTK = new Button();
            groupBoxOutput_BTK = new GroupBox();
            textBoxResult_BTK = new TextBox();
            dataGridViewResult_BTK = new DataGridView();
            groupBoxCondition_BTK.SuspendLayout();
            groupBoxInput_BTK.SuspendLayout();
            groupBoxOutput_BTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_BTK
            // 
            groupBoxCondition_BTK.BackColor = SystemColors.ActiveCaption;
            groupBoxCondition_BTK.Controls.Add(textBoxTask_BTK);
            groupBoxCondition_BTK.Location = new Point(12, 12);
            groupBoxCondition_BTK.Name = "groupBoxCondition_BTK";
            groupBoxCondition_BTK.Size = new Size(510, 102);
            groupBoxCondition_BTK.TabIndex = 0;
            groupBoxCondition_BTK.TabStop = false;
            groupBoxCondition_BTK.Text = "Условие";
            // 
            // textBoxTask_BTK
            // 
            textBoxTask_BTK.BackColor = SystemColors.ActiveCaption;
            textBoxTask_BTK.BorderStyle = BorderStyle.None;
            textBoxTask_BTK.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BTK.Location = new Point(6, 22);
            textBoxTask_BTK.Multiline = true;
            textBoxTask_BTK.Name = "textBoxTask_BTK";
            textBoxTask_BTK.ReadOnly = true;
            textBoxTask_BTK.Size = new Size(498, 52);
            textBoxTask_BTK.TabIndex = 0;
            textBoxTask_BTK.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // groupBoxInput_BTK
            // 
            groupBoxInput_BTK.BackColor = SystemColors.ActiveCaption;
            groupBoxInput_BTK.Controls.Add(buttonHelp_BTK);
            groupBoxInput_BTK.Controls.Add(buttonCalculate_BTK);
            groupBoxInput_BTK.Location = new Point(12, 98);
            groupBoxInput_BTK.Name = "groupBoxInput_BTK";
            groupBoxInput_BTK.Size = new Size(510, 92);
            groupBoxInput_BTK.TabIndex = 1;
            groupBoxInput_BTK.TabStop = false;
            groupBoxInput_BTK.Text = "-..-";
            // 
            // buttonHelp_BTK
            // 
            buttonHelp_BTK.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_BTK.Location = new Point(6, 16);
            buttonHelp_BTK.Name = "buttonHelp_BTK";
            buttonHelp_BTK.Size = new Size(249, 64);
            buttonHelp_BTK.TabIndex = 1;
            buttonHelp_BTK.Text = "Справка";
            buttonHelp_BTK.UseVisualStyleBackColor = false;
            buttonHelp_BTK.Click += buttonHelp_BTK_Click;
            buttonHelp_BTK.MouseEnter += buttonHelp_BTK_MouseEnter;
            buttonHelp_BTK.MouseLeave += buttonHelp_BTK_MouseLeave;
            // 
            // buttonCalculate_BTK
            // 
            buttonCalculate_BTK.BackColor = SystemColors.Control;
            buttonCalculate_BTK.Location = new Point(261, 16);
            buttonCalculate_BTK.Name = "buttonCalculate_BTK";
            buttonCalculate_BTK.Size = new Size(243, 64);
            buttonCalculate_BTK.TabIndex = 0;
            buttonCalculate_BTK.Text = "Выполнить";
            buttonCalculate_BTK.UseVisualStyleBackColor = false;
            buttonCalculate_BTK.Click += buttonCalculate_BTK_Click;
            buttonCalculate_BTK.MouseEnter += buttonCalculate_BTK_MouseEnter;
            buttonCalculate_BTK.MouseLeave += buttonCalculate_BTK_MouseLeave;
            // 
            // groupBoxOutput_BTK
            // 
            groupBoxOutput_BTK.BackColor = SystemColors.ActiveCaption;
            groupBoxOutput_BTK.Controls.Add(textBoxResult_BTK);
            groupBoxOutput_BTK.Controls.Add(dataGridViewResult_BTK);
            groupBoxOutput_BTK.Location = new Point(12, 184);
            groupBoxOutput_BTK.Name = "groupBoxOutput_BTK";
            groupBoxOutput_BTK.Size = new Size(510, 250);
            groupBoxOutput_BTK.TabIndex = 2;
            groupBoxOutput_BTK.TabStop = false;
            groupBoxOutput_BTK.Text = "Вывод данных";
            // 
            // textBoxResult_BTK
            // 
            textBoxResult_BTK.BackColor = SystemColors.ActiveCaption;
            textBoxResult_BTK.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_BTK.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_BTK.Location = new Point(6, 221);
            textBoxResult_BTK.Name = "textBoxResult_BTK";
            textBoxResult_BTK.ReadOnly = true;
            textBoxResult_BTK.Size = new Size(498, 23);
            textBoxResult_BTK.TabIndex = 1;
            textBoxResult_BTK.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewResult_BTK
            // 
            dataGridViewResult_BTK.AllowUserToAddRows = false;
            dataGridViewResult_BTK.AllowUserToDeleteRows = false;
            dataGridViewResult_BTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult_BTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BTK.ColumnHeadersVisible = false;
            dataGridViewResult_BTK.Location = new Point(6, 22);
            dataGridViewResult_BTK.Name = "dataGridViewResult_BTK";
            dataGridViewResult_BTK.ReadOnly = true;
            dataGridViewResult_BTK.RowHeadersVisible = false;
            dataGridViewResult_BTK.Size = new Size(498, 180);
            dataGridViewResult_BTK.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(534, 446);
            Controls.Add(groupBoxOutput_BTK);
            Controls.Add(groupBoxInput_BTK);
            Controls.Add(groupBoxCondition_BTK);
            MaximizeBox = false;
            MaximumSize = new Size(550, 485);
            MinimumSize = new Size(550, 485);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Букин Т. К.";
            Load += FormMain_Load;
            groupBoxCondition_BTK.ResumeLayout(false);
            groupBoxCondition_BTK.PerformLayout();
            groupBoxInput_BTK.ResumeLayout(false);
            groupBoxOutput_BTK.ResumeLayout(false);
            groupBoxOutput_BTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BTK).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBoxCondition_BTK;
        private TextBox textBoxTask_BTK;
        private GroupBox groupBoxInput_BTK;
        private Button buttonHelp_BTK;
        private Button buttonCalculate_BTK;
        private GroupBox groupBoxOutput_BTK;
        private DataGridView dataGridViewResult_BTK;
        private TextBox textBoxResult_BTK;
    }
}