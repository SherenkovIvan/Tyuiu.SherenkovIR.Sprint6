using Tyuiu.SherenkovIR.Sprint6.Task1.V3.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonResult.Click += buttonResult_Click;
        }
        DataService ds = new DataService();
        public void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxImportData.Text);
                int stopstep = Convert.ToInt32(textBoxDataImportStop.Text);
                string strLine;
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(startstep, stopstep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    |   {1,5:f2}  | ", startstep, array[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startstep++;
                }
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("??????? ???????? ??????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???? 1 ???????? ??????? ?????-25-1 ??????? ?????? ?????????????", "?????????", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
