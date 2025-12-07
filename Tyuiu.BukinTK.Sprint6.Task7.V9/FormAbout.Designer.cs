namespace Tyuiu.BukinTK.Sprint6.Task7.V9
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox_BTK;
        private System.Windows.Forms.Label labelName_BTK;
        private System.Windows.Forms.Label labelGroup_BTK;
        private System.Windows.Forms.Button ButtonOK_BTK;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_BTK = new PictureBox();
            labelName_BTK = new Label();
            labelGroup_BTK = new Label();
            ButtonOK_BTK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BTK).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_BTK
            // 
            pictureBox_BTK.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_BTK.Image = (Image)resources.GetObject("pictureBox_BTK.Image");
            pictureBox_BTK.Location = new Point(10, 10);
            pictureBox_BTK.Name = "pictureBox_BTK";
            pictureBox_BTK.Size = new Size(140, 160);
            pictureBox_BTK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_BTK.TabIndex = 0;
            pictureBox_BTK.TabStop = false;
            pictureBox_BTK.Click += pictureBox_BTK_Click;
            // 
            // labelName_BTK
            // 
            labelName_BTK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName_BTK.AutoSize = true;
            labelName_BTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName_BTK.Location = new Point(156, 9);
            labelName_BTK.Name = "labelName_BTK";
            labelName_BTK.Size = new Size(203, 21);
            labelName_BTK.TabIndex = 1;
            labelName_BTK.Text = "Разработчик: Букин Т. К.";
            // 
            // labelGroup_BTK
            // 
            labelGroup_BTK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup_BTK.AutoSize = true;
            labelGroup_BTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGroup_BTK.Location = new Point(156, 45);
            labelGroup_BTK.Name = "labelGroup_BTK";
            labelGroup_BTK.Size = new Size(276, 75);
            labelGroup_BTK.TabIndex = 2;
            labelGroup_BTK.Text = "Группа: ИСПб-25-1\r\nПрограмма разработана в рамках изучения С#\r\n@ТИУ 2025. @ВШЦТ 2025\r\nВнутренний ник: Tyuiu.BukinTK.Sprint6.Task7\r\n\r\n";
            // 
            // ButtonOK_BTK
            // 
            ButtonOK_BTK.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonOK_BTK.AutoSize = true;
            ButtonOK_BTK.BackColor = Color.WhiteSmoke;
            ButtonOK_BTK.Cursor = Cursors.Hand;
            ButtonOK_BTK.FlatStyle = FlatStyle.Flat;
            ButtonOK_BTK.Location = new Point(156, 132);
            ButtonOK_BTK.Name = "ButtonOK_BTK";
            ButtonOK_BTK.Size = new Size(332, 30);
            ButtonOK_BTK.TabIndex = 3;
            ButtonOK_BTK.Text = "ОК";
            ButtonOK_BTK.UseVisualStyleBackColor = false;
            ButtonOK_BTK.Click += ButtonOK_BTK_Click;
            // 
            // FormAbout
            // 
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(500, 174);
            Controls.Add(pictureBox_BTK);
            Controls.Add(labelName_BTK);
            Controls.Add(labelGroup_BTK);
            Controls.Add(ButtonOK_BTK);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_BTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}