namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            panelButton = new Panel();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelIn = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            panelOut = new Panel();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelButton.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelIn.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panelOut.SuspendLayout();
            groupBoxOut.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.папка;
            buttonOpenFile.Location = new Point(3, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 55);
            buttonOpenFile.TabIndex = 0;
            toolTip.SetToolTip(buttonOpenFile, "Открыть Файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = Properties.Resources.файл;
            buttonDone.Location = new Point(84, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 55);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Производит поиск к файлу");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(980, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            toolTip.SetToolTip(buttonHelp, "Сведения");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(buttonOpenFile);
            panelButton.Controls.Add(buttonHelp);
            panelButton.Controls.Add(buttonDone);
            panelButton.Location = new Point(12, 12);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(1058, 63);
            panelButton.TabIndex = 3;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Location = new Point(15, 81);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1055, 98);
            panelTask.TabIndex = 4;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1034, 92);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(1043, 60);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelIn
            // 
            panelIn.Controls.Add(groupBoxIn);
            panelIn.Location = new Point(24, 204);
            panelIn.Name = "panelIn";
            panelIn.Size = new Size(392, 335);
            panelIn.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Location = new Point(11, 14);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(362, 297);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(18, 34);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(314, 257);
            textBoxIn.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Controls.Add(groupBoxOut);
            panelOut.Location = new Point(631, 204);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(436, 335);
            panelOut.TabIndex = 5;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Location = new Point(12, 14);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(414, 297);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(23, 34);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(379, 257);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panelOut);
            Controls.Add(panelIn);
            Controls.Add(panelTask);
            Controls.Add(panelButton);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Шеренков И.Р.";
            panelButton.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelIn.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panelOut.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonHelp;
        private Panel panelButton;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelIn;
        private GroupBox groupBoxIn;
        private TextBox textBoxIn;
        private Panel panelOut;
        private GroupBox groupBoxOut;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
