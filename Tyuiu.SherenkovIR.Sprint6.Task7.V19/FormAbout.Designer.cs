namespace Tyuiu.SherenkovIR.Sprint6.Task7.V19
{
    partial class FormAbout
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
            labelinfo = new Label();
            buttonClose = new Button();
            pictureBoxAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelinfo
            // 
            labelinfo.Location = new Point(528, 50);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(233, 200);
            labelinfo.TabIndex = 0;
            labelinfo.Text = "Разработчик: Шеренков И.Р.\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\n";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(584, 221);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Ok";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.кот;
            pictureBoxAvatar.Location = new Point(31, 35);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(469, 368);
            pictureBoxAvatar.TabIndex = 2;
            pictureBoxAvatar.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(buttonClose);
            Controls.Add(labelinfo);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelinfo;
        private Button buttonClose;
        private PictureBox pictureBoxAvatar;
    }
}