using Tyuiu.SherenkovIR.Sprint6.Task3.V6.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { -2, -10, -8, 1, 11 }, { -15, -9, -4, -15, 18 }, { -15, 12, 7, 6, 9 }, { -14, -10, 10, 18, -5 }, { -1, 7, -19, -19, -4 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            dataGridViewMatrix.RowCount = rows;
            dataGridViewMatrix.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = ds.Calculate(matrix);
            int rows = matrix2.GetLength(0);
            int cols = matrix2.GetLength(1);
            dataGridViewResult.RowCount = rows;
            dataGridViewResult.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(matrix2[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???????? ??????? ?.?. ??????? ?????? ?????-25-1", "??????", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
