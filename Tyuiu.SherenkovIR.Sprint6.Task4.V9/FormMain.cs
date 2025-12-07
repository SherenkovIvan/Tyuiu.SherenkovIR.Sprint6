using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Tyuiu.SherenkovIR.Sprint6.Task4.V9.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private double[]? currentXValues;
        private double[]? currentYValues;

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction.Series[0].Points.Clear();

                chartFunction.Series[0].ChartType = SeriesChartType.Spline;

                currentXValues = new double[len];
                currentYValues = new double[len];

                string resultText = "";

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    currentXValues[i] = currentX;
                    currentYValues[i] = valueArray[i];
                    chartFunction.Series[0].Points.AddXY(currentX, valueArray[i]);

                    resultText += Convert.ToString(currentX) + "\t" + Convert.ToString(valueArray[i]) + "\r\n";
                }

                textBoxResult.Text = resultText;

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÈÁÊÑá-25-1 Êàðïåíêî Àðò¸ì Ëåîíèäîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string path = Path.Combine(tempPath, "OutPutFileTask4V9.txt");

                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show(" файл " + path + " сохранено успешно\nОткрыть его?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("Cáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chartRezult_Click(object sender, EventArgs e)
        {

        }
    }
}
