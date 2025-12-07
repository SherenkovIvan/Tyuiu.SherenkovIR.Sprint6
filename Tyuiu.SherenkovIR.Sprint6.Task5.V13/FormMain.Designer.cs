namespace Tyuiu.SherenkovIR.Sprint6.Task5.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            buttonFileOpened = new Button();
            buttonHelp = new Button();
            panelUp = new Panel();
            textBoxTask = new TextBox();
            groupBoxTask = new GroupBox();
            panelRezult = new Panel();
            splitterRezult = new Splitter();
            dataGridViewRezult = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnResult = new DataGridViewTextBoxColumn();
            groupBoxRezult = new GroupBox();
            panelLegend = new Panel();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelRezult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).BeginInit();
            panelLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(592, 20);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 80);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFileOpened
            // 
            buttonFileOpened.Location = new Point(717, 20);
            buttonFileOpened.Name = "buttonFileOpened";
            buttonFileOpened.Size = new Size(100, 80);
            buttonFileOpened.TabIndex = 1;
            buttonFileOpened.Text = "Открыть файл";
            buttonFileOpened.UseVisualStyleBackColor = true;
            buttonFileOpened.Click += buttonFileOpened_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(825, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 80);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelUp
            // 
            panelUp.Controls.Add(textBoxTask);
            panelUp.Controls.Add(buttonDone);
            panelUp.Controls.Add(buttonHelp);
            panelUp.Controls.Add(buttonFileOpened);
            panelUp.Location = new Point(6, 26);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(949, 125);
            panelUp.TabIndex = 3;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(18, 34);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(521, 27);
            textBoxTask.TabIndex = 3;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V13.txt. Вывести в dataGridView. Вывести все числа, меньше 10.\r\nПостроить диаграмму по этим значениям.\r\n";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(panelUp);
            groupBoxTask.Location = new Point(33, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(937, 171);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // panelRezult
            // 
            panelRezult.Controls.Add(splitterRezult);
            panelRezult.Controls.Add(dataGridViewRezult);
            panelRezult.Location = new Point(10, 240);
            panelRezult.Name = "panelRezult";
            panelRezult.Size = new Size(250, 400);
            panelRezult.TabIndex = 1;
            // 
            // splitterRezult
            // 
            splitterRezult.BackColor = SystemColors.Desktop;
            splitterRezult.Location = new Point(0, 0);
            splitterRezult.Name = "splitterRezult";
            splitterRezult.Size = new Size(4, 400);
            splitterRezult.TabIndex = 6;
            splitterRezult.TabStop = false;
            // 
            // dataGridViewRezult
            // 
            dataGridViewRezult.AllowUserToResizeColumns = false;
            dataGridViewRezult.AllowUserToResizeRows = false;
            dataGridViewRezult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRezult.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnResult });
            dataGridViewRezult.Location = new Point(18, 3);
            dataGridViewRezult.Name = "dataGridViewRezult";
            dataGridViewRezult.RowHeadersWidth = 51;
            dataGridViewRezult.Size = new Size(209, 400);
            dataGridViewRezult.TabIndex = 1;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "ColumnNumber";
            ColumnNumber.MinimumWidth = 6;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Width = 50;
            // 
            // ColumnResult
            // 
            ColumnResult.HeaderText = "ColumnResult";
            ColumnResult.MinimumWidth = 6;
            ColumnResult.Name = "ColumnResult";
            ColumnResult.ReadOnly = true;
            ColumnResult.Width = 50;
            // 
            // groupBoxRezult
            // 
            groupBoxRezult.Location = new Point(12, 189);
            groupBoxRezult.Name = "groupBoxRezult";
            groupBoxRezult.Size = new Size(248, 459);
            groupBoxRezult.TabIndex = 5;
            groupBoxRezult.TabStop = false;
            groupBoxRezult.Text = "Вывод:";
            // 
            // panelLegend
            // 
            panelLegend.Controls.Add(chartDiag);
            panelLegend.Location = new Point(316, 189);
            panelLegend.Name = "panelLegend";
            panelLegend.Size = new Size(632, 475);
            panelLegend.TabIndex = 3;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(34, 22);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(561, 432);
            chartDiag.TabIndex = 0;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(panelLegend);
            Controls.Add(panelRezult);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxRezult);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 13 | Шеренков И.Р.";
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            panelRezult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).EndInit();
            panelLegend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonFileOpened;
        private Button buttonHelp;
        private Panel panelUp;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelRezult;
        private GroupBox groupBoxRezult;
        private DataGridView dataGridViewRezult;
        private Splitter splitterRezult;
        private Panel panelLegend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnResult;
    }
}
