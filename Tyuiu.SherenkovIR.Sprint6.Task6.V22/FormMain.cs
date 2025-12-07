using System.IO;
using Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string? path;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(path);
            groupBoxIn.Text = groupBoxIn.Text + " " + openFileDialogTask.FileName;

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                textBoxOut.Text = ds.CollectTextFromFile(path!);
            }
            catch
            {
                MessageBox.Show("?? ???????, ???-?? ????? ?? ???", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
