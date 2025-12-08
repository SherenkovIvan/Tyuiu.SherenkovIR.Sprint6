namespace Tyuiu.SherenkovIR.Sprint6.Task7.V19
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
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonFileLoad = new Button();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            panelLeft = new Panel();
            groupBoxInput = new GroupBox();
            dataGridViewIn = new DataGridView();
            splitterPanel = new Splitter();
            panelRight = new Panel();
            groupBoxOutPut = new GroupBox();
            dataGridViewOut = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            groupBoxTask.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelRight.SuspendLayout();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Location = new Point(6, 100);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1055, 111);
            panelTask.TabIndex = 5;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 103);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1034, 102);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(1043, 73);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // buttonFileLoad
            // 
            buttonFileLoad.Image = (Image)resources.GetObject("buttonFileLoad.Image");
            buttonFileLoad.Location = new Point(12, 12);
            buttonFileLoad.Name = "buttonFileLoad";
            buttonFileLoad.Size = new Size(75, 55);
            buttonFileLoad.TabIndex = 6;
            toolTipButton.SetToolTip(buttonFileLoad, "Открыть файл\r\n");
            buttonFileLoad.UseVisualStyleBackColor = true;
            buttonFileLoad.Click += buttonFileLoad_Click;
            buttonFileLoad.MouseEnter += buttonFileLoad_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(102, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 55);
            buttonDone.TabIndex = 7;
            toolTipButton.SetToolTip(buttonDone, "Выполнить?");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(192, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 55);
            buttonSave.TabIndex = 8;
            toolTipButton.SetToolTip(buttonSave, "Сохранить?");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseEnter += buttonSave_MouseEnter;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(995, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 9;
            toolTipButton.SetToolTip(buttonHelp, "Справка");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonHelp_MouseEnter;
            // 
            // panelLeft
            // 
            panelLeft.Anchor = AnchorStyles.Left;
            panelLeft.Controls.Add(groupBoxInput);
            panelLeft.Location = new Point(17, 217);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(499, 336);
            panelLeft.TabIndex = 10;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Location = new Point(3, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(518, 365);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(6, 26);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(468, 298);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitterPanel
            // 
            splitterPanel.Location = new Point(0, 0);
            splitterPanel.MinimumSize = new Size(4, 300);
            splitterPanel.Name = "splitterPanel";
            splitterPanel.Size = new Size(4, 653);
            splitterPanel.TabIndex = 3;
            splitterPanel.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxOutPut);
            panelRight.Location = new Point(588, 220);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(482, 324);
            panelRight.TabIndex = 4;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(dataGridViewOut);
            groupBoxOutPut.Location = new Point(3, 3);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(470, 318);
            groupBoxOutPut.TabIndex = 0;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 26);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(458, 286);
            dataGridViewOut.TabIndex = 0;
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(panelRight);
            Controls.Add(splitterPanel);
            Controls.Add(panelLeft);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(buttonFileLoad);
            Controls.Add(panelTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Шеренков И.Р.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonFileLoad;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private Panel panelLeft;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewIn;
        private Splitter splitterPanel;
        private Panel panelRight;
        private GroupBox groupBoxOutPut;
        private DataGridView dataGridViewOut;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
