using System.Windows.Forms;
using Tyuiu.SherenkovIR.Sprint6.Task5.V13.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V13.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRezult.ColumnCount = 2;
            dataGridViewRezult.Columns[0].Width = 20;
            dataGridViewRezult.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();
            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRezult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonFileOpened_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБСКБ 25-1 Шеренков Иван Романович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
