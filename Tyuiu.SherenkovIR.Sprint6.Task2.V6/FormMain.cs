using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SherenkovIR.Sprint6.Task2.V6.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxImportStart.Text);
                int stopStep = Convert.ToInt32(textBoxImportStop.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valuearray;
                valuearray = new double[len];
                valuearray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult.Titles.Add("График функции ");
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startStep), Convert.ToString(valuearray[i]));
                    this.chartResult.Series[0].Points.AddXY(startStep, valuearray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {
            //
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???? 1 ???????? ??????? ?????-25-1 ??????? ?????? ?????????????", "?????????", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
