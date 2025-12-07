namespace Tyuiu.BukinTK.Sprint6.Task7.V9
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_BTK;

        private System.Windows.Forms.SplitContainer splitContainer_BTK;
        private System.Windows.Forms.DataGridView DataGridViewInput_BTK;
        private System.Windows.Forms.DataGridView DataGridViewOutput_BTK;
        private System.Windows.Forms.Label labelTask_BTK;

        private System.Windows.Forms.OpenFileDialog openFileDialog_BTK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_BTK;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripSeparator_BTK = new ToolStripSeparator();
            splitContainer_BTK = new SplitContainer();
            DataGridViewInput_BTK = new DataGridView();
            DataGridViewOutput_BTK = new DataGridView();
            labelTask_BTK = new Label();
            openFileDialog_BTK = new OpenFileDialog();
            saveFileDialog_BTK = new SaveFileDialog();
            buttonRun_ToolStripButton_BTK = new ToolStripButton();
            buttonSave_ToolStripButton_BTK = new ToolStripButton();
            buttonAbout_ToolStripButton_BTK = new ToolStripButton();
            buttonOpen_ToolStripButton_BTK = new ToolStripButton();
            toolStrip_BTK = new ToolStrip();
            TextBoxPath_BTK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTK).BeginInit();
            splitContainer_BTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInput_BTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutput_BTK).BeginInit();
            toolStrip_BTK.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator_BTK
            // 
            toolStripSeparator_BTK.Name = "toolStripSeparator_BTK";
            toolStripSeparator_BTK.Size = new Size(6, 6);
            // 
            // splitContainer_BTK
            // 
            splitContainer_BTK.Location = new Point(5, 2000);
            splitContainer_BTK.Name = "splitContainer_BTK";
            // 
            // splitContainer_BTK.Panel1
            // 
            splitContainer_BTK.Panel1.AccessibleRole = AccessibleRole.None;
            splitContainer_BTK.Panel1.AutoScroll = true;
            splitContainer_BTK.Size = new Size(960, 500);
            splitContainer_BTK.SplitterDistance = 320;
            splitContainer_BTK.TabIndex = 0;
            // 
            // DataGridViewInput_BTK
            // 
            DataGridViewInput_BTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewInput_BTK.BackgroundColor = Color.LightSlateGray;
            DataGridViewInput_BTK.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewInput_BTK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewInput_BTK.Location = new Point(12, 176);
            DataGridViewInput_BTK.Name = "DataGridViewInput_BTK";
            DataGridViewInput_BTK.Size = new Size(343, 423);
            DataGridViewInput_BTK.TabIndex = 0;
            // 
            // DataGridViewOutput_BTK
            // 
            DataGridViewOutput_BTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewOutput_BTK.BackgroundColor = Color.LightSlateGray;
            DataGridViewOutput_BTK.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewOutput_BTK.Location = new Point(361, 176);
            DataGridViewOutput_BTK.Name = "DataGridViewOutput_BTK";
            DataGridViewOutput_BTK.Size = new Size(352, 423);
            DataGridViewOutput_BTK.TabIndex = 0;
            // 
            // labelTask_BTK
            // 
            labelTask_BTK.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTask_BTK.ForeColor = Color.DarkSlateGray;
            labelTask_BTK.Location = new Point(0, 77);
            labelTask_BTK.Name = "labelTask_BTK";
            labelTask_BTK.Size = new Size(725, 96);
            labelTask_BTK.TabIndex = 2;
            labelTask_BTK.Text = resources.GetString("labelTask_BTK.Text");
            // 
            // buttonRun_ToolStripButton_BTK
            // 
            buttonRun_ToolStripButton_BTK.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonRun_ToolStripButton_BTK.Image = (Image)resources.GetObject("buttonRun_ToolStripButton_BTK.Image");
            buttonRun_ToolStripButton_BTK.Name = "buttonRun_ToolStripButton_BTK";
            buttonRun_ToolStripButton_BTK.Size = new Size(76, 76);
            buttonRun_ToolStripButton_BTK.Text = "Выполнить";
            buttonRun_ToolStripButton_BTK.Click += ButtonRun_BTK_Click;
            // 
            // buttonSave_ToolStripButton_BTK
            // 
            buttonSave_ToolStripButton_BTK.BackgroundImageLayout = ImageLayout.None;
            buttonSave_ToolStripButton_BTK.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonSave_ToolStripButton_BTK.Image = (Image)resources.GetObject("buttonSave_ToolStripButton_BTK.Image");
            buttonSave_ToolStripButton_BTK.Name = "buttonSave_ToolStripButton_BTK";
            buttonSave_ToolStripButton_BTK.Size = new Size(76, 76);
            buttonSave_ToolStripButton_BTK.Text = "Сохранить";
            buttonSave_ToolStripButton_BTK.Click += ButtonSave_BTK_Click;
            // 
            // buttonAbout_ToolStripButton_BTK
            // 
            buttonAbout_ToolStripButton_BTK.Alignment = ToolStripItemAlignment.Right;
            buttonAbout_ToolStripButton_BTK.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonAbout_ToolStripButton_BTK.Image = (Image)resources.GetObject("buttonAbout_ToolStripButton_BTK.Image");
            buttonAbout_ToolStripButton_BTK.Name = "buttonAbout_ToolStripButton_BTK";
            buttonAbout_ToolStripButton_BTK.Size = new Size(76, 76);
            buttonAbout_ToolStripButton_BTK.Text = "?";
            buttonAbout_ToolStripButton_BTK.Click += ButtonAbout_BTK_Click;
            // 
            // buttonOpen_ToolStripButton_BTK
            // 
            buttonOpen_ToolStripButton_BTK.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonOpen_ToolStripButton_BTK.Image = (Image)resources.GetObject("buttonOpen_ToolStripButton_BTK.Image");
            buttonOpen_ToolStripButton_BTK.Name = "buttonOpen_ToolStripButton_BTK";
            buttonOpen_ToolStripButton_BTK.Size = new Size(76, 76);
            buttonOpen_ToolStripButton_BTK.Text = "Открыть";
            buttonOpen_ToolStripButton_BTK.Click += ButtonOpenFile_BTK_Click;
            // 
            // toolStrip_BTK
            // 
            toolStrip_BTK.BackColor = Color.LightSlateGray;
            toolStrip_BTK.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_BTK.ImageScalingSize = new Size(72, 72);
            toolStrip_BTK.Items.AddRange(new ToolStripItem[] { buttonRun_ToolStripButton_BTK, buttonSave_ToolStripButton_BTK, buttonAbout_ToolStripButton_BTK, buttonOpen_ToolStripButton_BTK });
            toolStrip_BTK.Location = new Point(0, 0);
            toolStrip_BTK.Name = "toolStrip_BTK";
            toolStrip_BTK.RenderMode = ToolStripRenderMode.System;
            toolStrip_BTK.RightToLeft = RightToLeft.No;
            toolStrip_BTK.Size = new Size(725, 79);
            toolStrip_BTK.TabIndex = 3;
            // 
            // TextBoxPath_BTK
            // 
            TextBoxPath_BTK.BackColor = SystemColors.ActiveBorder;
            TextBoxPath_BTK.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPath_BTK.Location = new Point(10, 605);
            TextBoxPath_BTK.Name = "TextBoxPath_BTK";
            TextBoxPath_BTK.ReadOnly = true;
            TextBoxPath_BTK.Size = new Size(703, 23);
            TextBoxPath_BTK.TabIndex = 1;
            // 
            // FormMain
            // 
            BackColor = Color.GhostWhite;
            ClientSize = new Size(725, 640);
            Controls.Add(DataGridViewOutput_BTK);
            Controls.Add(DataGridViewInput_BTK);
            Controls.Add(splitContainer_BTK);
            Controls.Add(TextBoxPath_BTK);
            Controls.Add(labelTask_BTK);
            Controls.Add(toolStrip_BTK);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 9 | Букин Т. К.";
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTK).EndInit();
            splitContainer_BTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewInput_BTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutput_BTK).EndInit();
            toolStrip_BTK.ResumeLayout(false);
            toolStrip_BTK.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripButton buttonRun_ToolStripButton_BTK;
        private ToolStripButton buttonSave_ToolStripButton_BTK;
        private ToolStripButton buttonAbout_ToolStripButton_BTK;
        private ToolStripButton buttonOpen_ToolStripButton_BTK;
        private ToolStrip toolStrip_BTK;
        private TextBox TextBoxPath_BTK;
    }
}