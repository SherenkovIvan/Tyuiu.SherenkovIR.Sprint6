namespace Tyuiu.SherenkovIR.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxHeading = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelHeading = new Label();
            groupBoxImport = new GroupBox();
            labelStop = new Label();
            labelImportData = new Label();
            textBoxImportStop = new TextBox();
            textBoxImportStart = new TextBox();
            buttonResult = new Button();
            buttonHelp = new Button();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxImport.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(pictureBox1);
            groupBoxHeading.Controls.Add(label1);
            groupBoxHeading.Controls.Add(labelHeading);
            groupBoxHeading.Location = new Point(14, 16);
            groupBoxHeading.Margin = new Padding(3, 4, 3, 4);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Padding = new Padding(3, 4, 3, 4);
            groupBoxHeading.Size = new Size(438, 323);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 108);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 104);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 47);
            label1.Name = "label1";
            label1.Size = new Size(386, 20);
            label1.TabIndex = 1;
            label1.Text = "Результат вывести в DataGridView и построить график";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Location = new Point(7, 25);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(419, 20);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Протабулировать функцию ниже на  заданном диапозоне";
            // 
            // groupBoxImport
            // 
            groupBoxImport.Controls.Add(labelStop);
            groupBoxImport.Controls.Add(labelImportData);
            groupBoxImport.Controls.Add(textBoxImportStop);
            groupBoxImport.Controls.Add(textBoxImportStart);
            groupBoxImport.Location = new Point(14, 364);
            groupBoxImport.Margin = new Padding(3, 4, 3, 4);
            groupBoxImport.Name = "groupBoxImport";
            groupBoxImport.Padding = new Padding(3, 4, 3, 4);
            groupBoxImport.Size = new Size(384, 135);
            groupBoxImport.TabIndex = 1;
            groupBoxImport.TabStop = false;
            groupBoxImport.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(238, 57);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(80, 20);
            labelStop.TabIndex = 5;
            labelStop.Text = "Стоп шага";
            // 
            // labelImportData
            // 
            labelImportData.AutoSize = true;
            labelImportData.Location = new Point(7, 57);
            labelImportData.Name = "labelImportData";
            labelImportData.Size = new Size(85, 20);
            labelImportData.TabIndex = 4;
            labelImportData.Text = "Старт шага";
            // 
            // textBoxImportStop
            // 
            textBoxImportStop.Location = new Point(238, 81);
            textBoxImportStop.Margin = new Padding(3, 4, 3, 4);
            textBoxImportStop.Name = "textBoxImportStop";
            textBoxImportStop.Size = new Size(116, 27);
            textBoxImportStop.TabIndex = 3;
            // 
            // textBoxImportStart
            // 
            textBoxImportStart.Location = new Point(7, 81);
            textBoxImportStart.Margin = new Padding(3, 4, 3, 4);
            textBoxImportStart.Name = "textBoxImportStart";
            textBoxImportStart.Size = new Size(116, 27);
            textBoxImportStart.TabIndex = 2;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(256, 549);
            buttonResult.Margin = new Padding(3, 4, 3, 4);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(150, 44);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Blue;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(161, 528);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(61, 65);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(495, 8);
            groupBoxResult.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult.Size = new Size(858, 592);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // chartResult
            // 
            chartArea2.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult.Legends.Add(legend2);
            chartResult.Location = new Point(315, 19);
            chartResult.Margin = new Padding(3, 4, 3, 4);
            chartResult.Name = "chartResult";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult.Series.Add(series2);
            chartResult.Size = new Size(425, 560);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult.Location = new Point(7, 25);
            dataGridViewResult.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(280, 520);
            dataGridViewResult.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 600);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonHelp);
            Controls.Add(buttonResult);
            Controls.Add(groupBoxImport);
            Controls.Add(groupBoxHeading);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 6 | Шеренков И.Р.";
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxImport.ResumeLayout(false);
            groupBoxImport.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHeading;
        private Label labelHeading;
        private Label label1;
        private GroupBox groupBoxImport;
        private Label labelStop;
        private Label labelImportData;
        private TextBox textBoxImportStop;
        private TextBox textBoxImportStart;
        private Button buttonResult;
        private Button buttonHelp;
        private GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private PictureBox pictureBox1;
    }
}
