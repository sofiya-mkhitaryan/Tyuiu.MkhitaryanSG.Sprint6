using System.Windows.Forms;
using Tyuiu.MkhitaryanSG.Sprint6.Task3.V7.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        Class1 ds = new Class1();
        public FormMain()
        {
            InitializeComponent();
        }
        int[,] matrix = new int[5, 5]
        {   { 31,  25,  -18,  12,   9 },

            {  6,  34,   -2,   2,  -18},

            { -5,   4,   27,   4,  -1 },

            {  4,  15,   34,  -6,  -10},

            {  0,   8,    5,  14,  -17}
        };

        private void buttonDone_Click_2(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridViewTask.ColumnCount = coll;
            dataGridViewTask.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewTask.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void buttonInf_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РППб25-1 Мхитарян София Геворковна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewTask.ColumnCount = columns;
            dataGridViewTask.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void textBoxUsl_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBoxRes_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    
