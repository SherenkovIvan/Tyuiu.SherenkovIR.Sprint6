using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SherenkovIR.Sprint6.Task4.V9
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxBin = new GroupBox();
            GroupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            GroupBoxSt = new GroupBox();
            textBoxStart = new TextBox();
            panelTask = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            panelResult = new Panel();
            splitter1 = new Splitter();
            panelCharResult = new Panel();
            chartFunction = new Chart();
            groupBoxTask.SuspendLayout();
            groupBoxBin.SuspendLayout();
            GroupBoxStop.SuspendLayout();
            GroupBoxSt.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(8, 9);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(774, 100);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.ControlLight;
            textBoxTask.Location = new Point(13, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(751, 71);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nрезультат вывести в textBox построить график функции \r\nи сохранить в файл.\r\n";
            // 
            // groupBoxBin
            // 
            groupBoxBin.BackColor = SystemColors.ButtonHighlight;
            groupBoxBin.Controls.Add(GroupBoxStop);
            groupBoxBin.Controls.Add(GroupBoxSt);
            groupBoxBin.Location = new Point(799, 12);
            groupBoxBin.Name = "groupBoxBin";
            groupBoxBin.Size = new Size(281, 97);
            groupBoxBin.TabIndex = 1;
            groupBoxBin.TabStop = false;
            groupBoxBin.Text = "Ввод данных";
            // 
            // GroupBoxStop
            // 
            GroupBoxStop.Controls.Add(textBoxStop);
            GroupBoxStop.Location = new Point(143, 26);
            GroupBoxStop.Name = "GroupBoxStop";
            GroupBoxStop.Size = new Size(105, 64);
            GroupBoxStop.TabIndex = 1;
            GroupBoxStop.TabStop = false;
            GroupBoxStop.Text = "Конец шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(87, 27);
            textBoxStop.TabIndex = 0;
            // 
            // GroupBoxSt
            // 
            GroupBoxSt.Controls.Add(textBoxStart);
            GroupBoxSt.Location = new Point(16, 26);
            GroupBoxSt.Name = "GroupBoxSt";
            GroupBoxSt.Size = new Size(107, 64);
            GroupBoxSt.TabIndex = 0;
            GroupBoxSt.TabStop = false;
            GroupBoxSt.Text = "Старт шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(92, 27);
            textBoxStart.TabIndex = 0;
            // 
            // panelTask
            // 
            panelTask.BackColor = SystemColors.Control;
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(buttonSave);
            panelTask.Controls.Add(buttonDone);
            panelTask.Controls.Add(groupBoxBin);
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1305, 137);
            panelTask.TabIndex = 2;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.Cyan;
            buttonHelp.Location = new Point(1140, 85);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 39);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Cправка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.RoyalBlue;
            buttonSave.Location = new Point(1190, 9);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 43);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(1086, 9);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(5, 5);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(336, 537);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(330, 511);
            textBoxResult.TabIndex = 0;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(groupBoxResult);
            panelResult.Dock = DockStyle.Left;
            panelResult.Location = new Point(0, 137);
            panelResult.Name = "panelResult";
            panelResult.Padding = new Padding(5);
            panelResult.Size = new Size(346, 547);
            panelResult.TabIndex = 5;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(346, 137);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 547);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // panelCharResult
            // 
            panelCharResult.Location = new Point(0, 0);
            panelCharResult.Name = "panelCharResult";
            panelCharResult.Size = new Size(200, 100);
            panelCharResult.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(578, 206);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(500, 400);
            chartFunction.TabIndex = 7;
            chartFunction.Text = "График функции";
            chartFunction.Click += chartRezult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 684);
            Controls.Add(chartFunction);
            Controls.Add(splitter1);
            Controls.Add(panelResult);
            Controls.Add(panelTask);
            Controls.Add(panelCharResult);
            MaximizeBox = false;
            MinimumSize = new Size(1323, 661);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 9 | Шеренков И.Р.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxBin.ResumeLayout(false);
            GroupBoxStop.ResumeLayout(false);
            GroupBoxStop.PerformLayout();
            GroupBoxSt.ResumeLayout(false);
            GroupBoxSt.PerformLayout();
            panelTask.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxBin;
        private GroupBox GroupBoxSt;
        private TextBox textBoxStart;
        private GroupBox GroupBoxStop;
        private TextBox textBoxStop;
        private Panel panelTask;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBoxResult;
        private Button buttonHelp;
        private TextBox textBoxResult;
        private Panel panelResult;
        private Splitter splitter1;
        private Panel panelCharResult;
        private Chart FormsPlotchartRezult;
        private Chart chartFunction;
    }
    
}

