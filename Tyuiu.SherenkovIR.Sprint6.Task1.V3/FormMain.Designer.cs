namespace Tyuiu.SherenkovIR.Sprint6.Task1.V3
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
            groupBoxUslovie = new GroupBox();
            buttonResult = new Button();
            buttonSupport = new Button();
            pictureBoxFormula = new PictureBox();
            labelUslovieNext = new Label();
            labelUslovie = new Label();
            groupBoxImport = new GroupBox();
            labelImportData = new Label();
            labelImportDataStop = new Label();
            textBoxDataImportStop = new TextBox();
            textBoxImportData = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxUslovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxImport.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.AutoSize = true;
            groupBoxUslovie.Controls.Add(buttonResult);
            groupBoxUslovie.Controls.Add(buttonSupport);
            groupBoxUslovie.Controls.Add(pictureBoxFormula);
            groupBoxUslovie.Controls.Add(labelUslovieNext);
            groupBoxUslovie.Controls.Add(labelUslovie);
            groupBoxUslovie.Location = new Point(29, 39);
            groupBoxUslovie.Margin = new Padding(3, 4, 3, 4);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Padding = new Padding(3, 4, 3, 4);
            groupBoxUslovie.Size = new Size(446, 455);
            groupBoxUslovie.TabIndex = 0;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие";
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(173, 336);
            buttonResult.Margin = new Padding(3, 4, 3, 4);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(189, 89);
            buttonResult.TabIndex = 4;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            // 
            // buttonSupport
            // 
            buttonSupport.BackColor = SystemColors.HotTrack;
            buttonSupport.FlatStyle = FlatStyle.Flat;
            buttonSupport.Location = new Point(9, 336);
            buttonSupport.Margin = new Padding(3, 4, 3, 4);
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Size = new Size(81, 87);
            buttonSupport.TabIndex = 3;
            buttonSupport.Text = "?";
            buttonSupport.UseVisualStyleBackColor = false;
            buttonSupport.Click += buttonSupport_Click;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Location = new Point(41, 115);
            pictureBoxFormula.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(299, 55);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // labelUslovieNext
            // 
            labelUslovieNext.AutoSize = true;
            labelUslovieNext.Location = new Point(24, 81);
            labelUslovieNext.Name = "labelUslovieNext";
            labelUslovieNext.Size = new Size(209, 20);
            labelUslovieNext.TabIndex = 1;
            labelUslovieNext.Text = "Результат вывести в таблице";
            // 
            // labelUslovie
            // 
            labelUslovie.AutoSize = true;
            labelUslovie.Location = new Point(21, 47);
            labelUslovie.Name = "labelUslovie";
            labelUslovie.Size = new Size(419, 20);
            labelUslovie.TabIndex = 0;
            labelUslovie.Text = "Протабулировать функцию ниже на заданном диапозоне ";
            // 
            // groupBoxImport
            // 
            groupBoxImport.Controls.Add(labelImportData);
            groupBoxImport.Controls.Add(labelImportDataStop);
            groupBoxImport.Controls.Add(textBoxDataImportStop);
            groupBoxImport.Controls.Add(textBoxImportData);
            groupBoxImport.Location = new Point(31, 469);
            groupBoxImport.Margin = new Padding(3, 4, 3, 4);
            groupBoxImport.Name = "groupBoxImport";
            groupBoxImport.Padding = new Padding(3, 4, 3, 4);
            groupBoxImport.Size = new Size(410, 131);
            groupBoxImport.TabIndex = 1;
            groupBoxImport.TabStop = false;
            groupBoxImport.Text = "Ввод данных";
            // 
            // labelImportData
            // 
            labelImportData.AutoSize = true;
            labelImportData.Location = new Point(21, 44);
            labelImportData.Name = "labelImportData";
            labelImportData.Size = new Size(85, 20);
            labelImportData.TabIndex = 1;
            labelImportData.Text = "Старт шага";
            // 
            // labelImportDataStop
            // 
            labelImportDataStop.AutoSize = true;
            labelImportDataStop.Location = new Point(211, 44);
            labelImportDataStop.Name = "labelImportDataStop";
            labelImportDataStop.Size = new Size(91, 20);
            labelImportDataStop.TabIndex = 3;
            labelImportDataStop.Text = "Конец шага";
            // 
            // textBoxDataImportStop
            // 
            textBoxDataImportStop.Location = new Point(194, 72);
            textBoxDataImportStop.Margin = new Padding(3, 4, 3, 4);
            textBoxDataImportStop.Name = "textBoxDataImportStop";
            textBoxDataImportStop.Size = new Size(118, 27);
            textBoxDataImportStop.TabIndex = 2;
            // 
            // textBoxImportData
            // 
            textBoxImportData.Location = new Point(7, 72);
            textBoxImportData.Margin = new Padding(3, 4, 3, 4);
            textBoxImportData.Name = "textBoxImportData";
            textBoxImportData.Size = new Size(121, 27);
            textBoxImportData.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(526, 27);
            groupBoxResult.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult.Size = new Size(389, 575);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(18, 59);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(356, 400);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxImport);
            Controls.Add(groupBoxUslovie);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Шеренков И.Р.";
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxImport.ResumeLayout(false);
            groupBoxImport.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUslovie;
        private Label labelUslovie;
        private PictureBox pictureBoxFormula;
        private Label labelUslovieNext;
        private GroupBox groupBoxImport;
        private Label labelImportDataStop;
        private TextBox textBoxDataImportStop;
        private Label labelImportData;
        private TextBox textBoxImportData;
        private Button buttonResult;
        private Button buttonSupport;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
    }

}



