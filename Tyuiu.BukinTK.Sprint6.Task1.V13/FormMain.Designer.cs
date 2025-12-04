namespace Tyuiu.BukinTK.Sprint6.Task1.V13
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
            labelFormula = new Label();
            labelStart = new Label();
            textBoxStart = new TextBox();
            labelStop = new Label();
            textBoxStop = new TextBox();
            buttonHelp = new Button();
            buttonCalculate = new Button();
            richTextBoxResult = new RichTextBox();
            groupBoxCondition_BTK = new GroupBox();
            groupBoxInput_BTK = new GroupBox();
            groupBoxOutput_BTK = new GroupBox();
            groupBoxCondition_BTK.SuspendLayout();
            groupBoxInput_BTK.SuspendLayout();
            groupBoxOutput_BTK.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula
            // 
            labelFormula.AutoSize = true;
            labelFormula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula.Location = new Point(7, 19);
            labelFormula.Margin = new Padding(4, 0, 4, 0);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(266, 20);
            labelFormula.TabIndex = 1;
            labelFormula.Text = "F(x) = 3cos(x)/(4x-0,5) + sin(x) - 5x - 2";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(7, 19);
            labelStart.Margin = new Padding(4, 0, 4, 0);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 3;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(7, 36);
            textBoxStart.Margin = new Padding(4, 3, 4, 3);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(129, 23);
            textBoxStart.TabIndex = 4;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(144, 19);
            labelStop.Margin = new Padding(4, 0, 4, 0);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(75, 15);
            labelStop.TabIndex = 5;
            labelStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(144, 36);
            textBoxStop.Margin = new Padding(4, 3, 4, 3);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(131, 23);
            textBoxStop.TabIndex = 6;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp.Location = new Point(302, 365);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(119, 27);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.ActiveCaption;
            buttonCalculate.ForeColor = Color.Black;
            buttonCalculate.Location = new Point(302, 332);
            buttonCalculate.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(119, 27);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.BackColor = SystemColors.ScrollBar;
            richTextBoxResult.Location = new Point(7, 22);
            richTextBoxResult.Margin = new Padding(4, 3, 4, 3);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(274, 350);
            richTextBoxResult.TabIndex = 10;
            richTextBoxResult.Text = "";
            richTextBoxResult.WordWrap = false;
            // 
            // groupBoxCondition_BTK
            // 
            groupBoxCondition_BTK.Controls.Add(labelFormula);
            groupBoxCondition_BTK.Location = new Point(12, 12);
            groupBoxCondition_BTK.Name = "groupBoxCondition_BTK";
            groupBoxCondition_BTK.Size = new Size(409, 307);
            groupBoxCondition_BTK.TabIndex = 11;
            groupBoxCondition_BTK.TabStop = false;
            groupBoxCondition_BTK.Text = "Условие";
            // 
            // groupBoxInput_BTK
            // 
            groupBoxInput_BTK.Controls.Add(labelStart);
            groupBoxInput_BTK.Controls.Add(labelStop);
            groupBoxInput_BTK.Controls.Add(textBoxStart);
            groupBoxInput_BTK.Controls.Add(textBoxStop);
            groupBoxInput_BTK.Location = new Point(12, 325);
            groupBoxInput_BTK.Name = "groupBoxInput_BTK";
            groupBoxInput_BTK.Size = new Size(283, 65);
            groupBoxInput_BTK.TabIndex = 12;
            groupBoxInput_BTK.TabStop = false;
            groupBoxInput_BTK.Text = "Ввод данных ";
            // 
            // groupBoxOutput_BTK
            // 
            groupBoxOutput_BTK.Controls.Add(richTextBoxResult);
            groupBoxOutput_BTK.Location = new Point(427, 12);
            groupBoxOutput_BTK.Name = "groupBoxOutput_BTK";
            groupBoxOutput_BTK.Size = new Size(288, 378);
            groupBoxOutput_BTK.TabIndex = 13;
            groupBoxOutput_BTK.TabStop = false;
            groupBoxOutput_BTK.Text = "Вывод данных ";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 402);
            Controls.Add(groupBoxOutput_BTK);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBoxInput_BTK);
            Controls.Add(groupBoxCondition_BTK);
            Controls.Add(buttonHelp);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Tаск 1 | Вариант 13 | Букин Т. К. ";
            Load += FormMain_Load;
            groupBoxCondition_BTK.ResumeLayout(false);
            groupBoxCondition_BTK.PerformLayout();
            groupBoxInput_BTK.ResumeLayout(false);
            groupBoxInput_BTK.PerformLayout();
            groupBoxOutput_BTK.ResumeLayout(false);
            ResumeLayout(false);

        }
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private GroupBox groupBoxCondition_BTK;
        private GroupBox groupBoxInput_BTK;
        private GroupBox groupBoxOutput_BTK;
    }
}