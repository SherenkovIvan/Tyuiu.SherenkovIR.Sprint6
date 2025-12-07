namespace Tyuiu.SherenkovIR.Sprint6.Task3.V6
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
            groupBoxHeading = new GroupBox();
            groupBoxResult = new GroupBox();
            labelHeading = new Label();
            dataGridViewResult = new DataGridView();
            buttonResult = new Button();
            buttonHelp = new Button();
            dataGridViewMatrix = new DataGridView();
            groupBoxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(groupBoxResult);
            groupBoxHeading.Controls.Add(labelHeading);
            groupBoxHeading.Location = new Point(14, 37);
            groupBoxHeading.Margin = new Padding(3, 4, 3, 4);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Padding = new Padding(3, 4, 3, 4);
            groupBoxHeading.Size = new Size(514, 533);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Location = new Point(503, 19);
            groupBoxResult.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult.Size = new Size(405, 507);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.BorderStyle = BorderStyle.FixedSingle;
            labelHeading.Font = new Font("Segoe UI", 10F);
            labelHeading.Location = new Point(7, 25);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(404, 163);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Дана матрица 5 на 5 \r\n -2 -10  -8  11   1\r\n -15  -9  -4 -15  18\r\n -15  12   7   6   9\r\n -14 -10  10  18  -5\r\n  -1   7 -19 -19  -4\r\nЗаменить четные значения в третьей строке на 0";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(568, 37);
            dataGridViewResult.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(333, 407);
            dataGridViewResult.TabIndex = 1;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(745, 523);
            buttonResult.Margin = new Padding(3, 4, 3, 4);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(155, 61);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(568, 523);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(155, 61);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(21, 272);
            dataGridViewMatrix.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(355, 323);
            dataGridViewMatrix.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(buttonHelp);
            Controls.Add(buttonResult);
            Controls.Add(dataGridViewResult);
            Controls.Add(groupBoxHeading);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Шеренков И.Р.";
            Load += Form1_Load;
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHeading;
        private Label labelHeading;
        private DataGridView dataGridViewResult;
        private GroupBox groupBoxResult;
        private Button buttonResult;
        private Button buttonHelp;
        private DataGridView dataGridViewMatrix;
    }
}
