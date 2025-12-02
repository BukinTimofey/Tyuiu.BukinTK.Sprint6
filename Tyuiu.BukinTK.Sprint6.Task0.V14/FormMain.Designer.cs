using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.BukinTK.Sprint6.Task0.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFormula_BTK = new Label();
            labelX_BTK = new Label();
            textBoxInput_BTK = new TextBox();
            labelResult_BTK = new Label();
            textBoxResult_BTK = new TextBox();
            buttonCalculatePush_BTK = new Button();
            groupBoxCondition_BTK = new GroupBox();
            groupBoxInput_BTK = new GroupBox();
            groupBoxOutput_BTK = new GroupBox();
            groupBoxCondition_BTK.SuspendLayout();
            groupBoxInput_BTK.SuspendLayout();
            groupBoxOutput_BTK.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula_BTK
            // 
            labelFormula_BTK.AutoSize = true;
            labelFormula_BTK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_BTK.Location = new Point(7, 19);
            labelFormula_BTK.Margin = new Padding(4, 0, 4, 0);
            labelFormula_BTK.Name = "labelFormula_BTK";
            labelFormula_BTK.Size = new Size(147, 20);
            labelFormula_BTK.TabIndex = 1;
            labelFormula_BTK.Text = "y(x) = (1-x)^2 / (-3x)";
            labelFormula_BTK.Click += labelFormula_Click;
            // 
            // labelX_BTK
            // 
            labelX_BTK.AutoSize = true;
            labelX_BTK.Location = new Point(7, 24);
            labelX_BTK.Margin = new Padding(4, 0, 4, 0);
            labelX_BTK.Name = "labelX_BTK";
            labelX_BTK.Size = new Size(89, 15);
            labelX_BTK.TabIndex = 3;
            labelX_BTK.Text = "Переменная X:";
            // 
            // textBoxInput_BTK
            // 
            textBoxInput_BTK.Location = new Point(7, 42);
            textBoxInput_BTK.Margin = new Padding(4, 3, 4, 3);
            textBoxInput_BTK.Name = "textBoxInput_BTK";
            textBoxInput_BTK.Size = new Size(186, 23);
            textBoxInput_BTK.TabIndex = 4;
            // 
            // labelResult_BTK
            // 
            labelResult_BTK.AutoSize = true;
            labelResult_BTK.Location = new Point(7, 24);
            labelResult_BTK.Margin = new Padding(4, 0, 4, 0);
            labelResult_BTK.Name = "labelResult_BTK";
            labelResult_BTK.Size = new Size(63, 15);
            labelResult_BTK.TabIndex = 6;
            labelResult_BTK.Text = "Результат:";
            // 
            // textBoxResult_BTK
            // 
            textBoxResult_BTK.Location = new Point(7, 42);
            textBoxResult_BTK.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_BTK.Name = "textBoxResult_BTK";
            textBoxResult_BTK.ReadOnly = true;
            textBoxResult_BTK.Size = new Size(186, 23);
            textBoxResult_BTK.TabIndex = 7;
            // 
            // buttonCalculatePush_BTK
            // 
            buttonCalculatePush_BTK.Location = new Point(244, 262);
            buttonCalculatePush_BTK.Margin = new Padding(4, 3, 4, 3);
            buttonCalculatePush_BTK.Name = "buttonCalculatePush_BTK";
            buttonCalculatePush_BTK.Size = new Size(117, 27);
            buttonCalculatePush_BTK.TabIndex = 8;
            buttonCalculatePush_BTK.Text = "Выполнить";
            buttonCalculatePush_BTK.UseVisualStyleBackColor = true;
            buttonCalculatePush_BTK.Click += buttonCalculate_Click;
            // 
            // groupBoxCondition_BTK
            // 
            groupBoxCondition_BTK.Controls.Add(labelFormula_BTK);
            groupBoxCondition_BTK.Location = new Point(12, 12);
            groupBoxCondition_BTK.Name = "groupBoxCondition_BTK";
            groupBoxCondition_BTK.Size = new Size(581, 191);
            groupBoxCondition_BTK.TabIndex = 9;
            groupBoxCondition_BTK.TabStop = false;
            groupBoxCondition_BTK.Text = "Условие";
            // 
            // groupBoxInput_BTK
            // 
            groupBoxInput_BTK.Controls.Add(labelX_BTK);
            groupBoxInput_BTK.Controls.Add(textBoxInput_BTK);
            groupBoxInput_BTK.Location = new Point(12, 220);
            groupBoxInput_BTK.Name = "groupBoxInput_BTK";
            groupBoxInput_BTK.Size = new Size(200, 100);
            groupBoxInput_BTK.TabIndex = 9;
            groupBoxInput_BTK.TabStop = false;
            groupBoxInput_BTK.Text = "Ввод данных";
            // 
            // groupBoxOutput_BTK
            // 
            groupBoxOutput_BTK.Controls.Add(textBoxResult_BTK);
            groupBoxOutput_BTK.Controls.Add(labelResult_BTK);
            groupBoxOutput_BTK.Location = new Point(393, 220);
            groupBoxOutput_BTK.Name = "groupBoxOutput_BTK";
            groupBoxOutput_BTK.RightToLeft = RightToLeft.No;
            groupBoxOutput_BTK.Size = new Size(200, 100);
            groupBoxOutput_BTK.TabIndex = 10;
            groupBoxOutput_BTK.TabStop = false;
            groupBoxOutput_BTK.Text = "Вывод данных";
            // 
            // FormMain_BTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 335);
            Controls.Add(groupBoxOutput_BTK);
            Controls.Add(buttonCalculatePush_BTK);
            Controls.Add(groupBoxInput_BTK);
            Controls.Add(groupBoxCondition_BTK);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain_BTK";
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Букин Т. К. ";
            groupBoxCondition_BTK.ResumeLayout(false);
            groupBoxCondition_BTK.PerformLayout();
            groupBoxInput_BTK.ResumeLayout(false);
            groupBoxInput_BTK.PerformLayout();
            groupBoxOutput_BTK.ResumeLayout(false);
            groupBoxOutput_BTK.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFormula_BTK;
        private System.Windows.Forms.Label labelX_BTK;
        private System.Windows.Forms.TextBox textBoxInput_BTK;
        private System.Windows.Forms.Label labelResult_BTK;
        private System.Windows.Forms.TextBox textBoxResult_BTK;
        private System.Windows.Forms.Button buttonCalculatePush_BTK;
        private GroupBox groupBoxCondition_BTK;
        private GroupBox groupBoxInput_BTK;
        private GroupBox groupBoxOutput_BTK;
    }
}

