namespace Tyuiu.BukinTK.Sprint6.Task5.V19
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
            PanelTop_BTK = new Panel();
            LabelTitle_BTK = new Label();
            ButtonRun_BTK = new Button();
            ButtonOpenFile_BTK = new Button();
            ButtonHelp_BTK = new Button();
            TextBoxPath_BTK = new TextBox();
            LabelPath_BTK = new Label();
            DataGridViewData_BTK = new DataGridView();
            ColIndex_BTK = new DataGridViewTextBoxColumn();
            ColValue_BTK = new DataGridViewTextBoxColumn();
            //Chart_BTK = new LiveCharts.WinForms.CartesianChart();
            PanelTop_BTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewData_BTK).BeginInit();
            SuspendLayout();
            // 
            // PanelTop_BTK
            // 
            PanelTop_BTK.BackColor = Color.DimGray;
            PanelTop_BTK.Controls.Add(LabelTitle_BTK);
            PanelTop_BTK.Controls.Add(ButtonRun_BTK);
            PanelTop_BTK.Controls.Add(ButtonOpenFile_BTK);
            PanelTop_BTK.Controls.Add(ButtonHelp_BTK);
            PanelTop_BTK.Controls.Add(TextBoxPath_BTK);
            PanelTop_BTK.Controls.Add(LabelPath_BTK);
            PanelTop_BTK.Dock = DockStyle.Top;
            PanelTop_BTK.Location = new Point(0, 0);
            PanelTop_BTK.Name = "PanelTop_BTK";
            PanelTop_BTK.Size = new Size(1200, 100);
            PanelTop_BTK.TabIndex = 0;
            // 
            // LabelTitle_BTK
            // 
            LabelTitle_BTK.AutoSize = true;
            LabelTitle_BTK.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LabelTitle_BTK.Location = new Point(20, 15);
            LabelTitle_BTK.Name = "LabelTitle_BTK";
            LabelTitle_BTK.Size = new Size(668, 19);
            LabelTitle_BTK.TabIndex = 0;
            LabelTitle_BTK.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в таблицу и построить диаграмму.";
            // 
            // ButtonRun_BTK
            // 
            ButtonRun_BTK.BackColor = Color.PaleGreen;
            ButtonRun_BTK.Cursor = Cursors.Hand;
            ButtonRun_BTK.FlatStyle = FlatStyle.Popup;
            ButtonRun_BTK.Location = new Point(720, 20);
            ButtonRun_BTK.Name = "ButtonRun_BTK";
            ButtonRun_BTK.Size = new Size(120, 60);
            ButtonRun_BTK.TabIndex = 4;
            ButtonRun_BTK.Text = "Выполнить";
            ButtonRun_BTK.UseVisualStyleBackColor = false;
            ButtonRun_BTK.Click += ButtonRun_BTK_Click;
            // 
            // ButtonOpenFile_BTK
            // 
            ButtonOpenFile_BTK.BackColor = Color.LightSteelBlue;
            ButtonOpenFile_BTK.Cursor = Cursors.Hand;
            ButtonOpenFile_BTK.FlatStyle = FlatStyle.Popup;
            ButtonOpenFile_BTK.Location = new Point(580, 50);
            ButtonOpenFile_BTK.Name = "ButtonOpenFile_BTK";
            ButtonOpenFile_BTK.Size = new Size(120, 26);
            ButtonOpenFile_BTK.TabIndex = 3;
            ButtonOpenFile_BTK.Text = "Открыть файл";
            ButtonOpenFile_BTK.UseVisualStyleBackColor = false;
            ButtonOpenFile_BTK.Click += ButtonOpenFile_BTK_Click;
            // 
            // ButtonHelp_BTK
            // 
            ButtonHelp_BTK.BackColor = Color.LightBlue;
            ButtonHelp_BTK.Cursor = Cursors.Hand;
            ButtonHelp_BTK.FlatStyle = FlatStyle.Popup;
            ButtonHelp_BTK.Location = new Point(850, 20);
            ButtonHelp_BTK.Name = "ButtonHelp_BTK";
            ButtonHelp_BTK.Size = new Size(120, 60);
            ButtonHelp_BTK.TabIndex = 5;
            ButtonHelp_BTK.Text = "Справка";
            ButtonHelp_BTK.UseVisualStyleBackColor = false;
            ButtonHelp_BTK.Click += ButtonHelp_BTK_Click;
            // 
            // TextBoxPath_BTK
            // 
            TextBoxPath_BTK.BackColor = SystemColors.ControlLightLight;
            TextBoxPath_BTK.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPath_BTK.Location = new Point(110, 52);
            TextBoxPath_BTK.Name = "TextBoxPath_BTK";
            TextBoxPath_BTK.Size = new Size(450, 23);
            TextBoxPath_BTK.TabIndex = 2;
            // 
            // LabelPath_BTK
            // 
            LabelPath_BTK.AutoSize = true;
            LabelPath_BTK.Location = new Point(20, 55);
            LabelPath_BTK.Name = "LabelPath_BTK";
            LabelPath_BTK.Size = new Size(83, 15);
            LabelPath_BTK.TabIndex = 1;
            LabelPath_BTK.Text = "Путь к файлу:";
            // 
            // DataGridViewData_BTK
            // 
            DataGridViewData_BTK.AllowUserToAddRows = false;
            DataGridViewData_BTK.AllowUserToDeleteRows = false;
            DataGridViewData_BTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewData_BTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewData_BTK.Columns.AddRange(new DataGridViewColumn[] { ColIndex_BTK, ColValue_BTK });
            DataGridViewData_BTK.Location = new Point(20, 120);
            DataGridViewData_BTK.Name = "DataGridViewData_BTK";
            DataGridViewData_BTK.ReadOnly = true;
            DataGridViewData_BTK.RowHeadersVisible = false;
            DataGridViewData_BTK.Size = new Size(250, 560);
            DataGridViewData_BTK.TabIndex = 6;
            // 
            // ColIndex_BTK
            // 
            ColIndex_BTK.HeaderText = "Index";
            ColIndex_BTK.Name = "ColIndex_BTK";
            ColIndex_BTK.ReadOnly = true;
            // 
            // ColValue_BTK
            // 
            ColValue_BTK.HeaderText = "Value";
            ColValue_BTK.Name = "ColValue_BTK";
            ColValue_BTK.ReadOnly = true;
            // 
            // Chart_BTK
            // 
            //Chart_BTK.BackColor = Color.DarkSeaGreen;
            //Chart_BTK.Location = new Point(300, 120);
            //Chart_BTK.Name = "Chart_BTK";
            //Chart_BTK.Size = new Size(880, 560);
            //Chart_BTK.TabIndex = 7;
            //Chart_BTK.ChildChanged += Chart_BTK_ChildChanged;
            // 
            // FormMain_BTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1200, 700);
            //Controls.Add(Chart_BTK);
            Controls.Add(DataGridViewData_BTK);
            Controls.Add(PanelTop_BTK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain_BTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Букин Т. К.";
            PanelTop_BTK.ResumeLayout(false);
            PanelTop_BTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewData_BTK).EndInit();
            ResumeLayout(false);

        }
        private System.Windows.Forms.Panel PanelTop_BTK;
        private System.Windows.Forms.Label LabelTitle_BTK;
        private System.Windows.Forms.Button ButtonOpenFile_BTK;
        private System.Windows.Forms.Button ButtonRun_BTK;
        private System.Windows.Forms.Button ButtonHelp_BTK;
        private System.Windows.Forms.TextBox TextBoxPath_BTK;
        private System.Windows.Forms.Label LabelPath_BTK;
        private System.Windows.Forms.DataGridView DataGridViewData_BTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIndex_BTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue_BTK;
        //private LiveCharts.WinForms.CartesianChart Chart_BTK;
    }
}
