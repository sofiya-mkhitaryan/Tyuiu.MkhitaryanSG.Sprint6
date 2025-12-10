using Tyuiu.MkhitaryanSG.Sprint6.Task3.V7.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {


            dataGridViewTask.Columns.Clear();
            dataGridViewTask.Rows.Clear();


            dataGridViewTask.ColumnHeadersVisible = false;
            dataGridViewTask.RowHeadersVisible = false;


            for (int i = 0; i < 5; i++)
            {
                dataGridViewTask.Columns.Add($"Col{i + 1}", $"Column {i + 1}");
            }


            dataGridViewTask.AllowUserToAddRows = false;


            foreach (DataGridViewColumn col in dataGridViewTask.Columns)
            {
                col.Width = 95;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            int[,] matrix =
            {
                { 31, 25, -18, 12,  9 },
                { 6 , 34, -2 , 2 , -18},
                { -5, 4 , 27 , 4 , -1 },
                { 4 , 15, 34 , -6, -10},
                { 0 , 8 , 5  , 14, -17}
            };

            Class1 ds = new Class1();


            int[,] result = ds.Calculate(matrix);


            for (int i = 0; i < result.GetLength(0); i++)
            {
                object[] row = new object[result.GetLength(1)];
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    row[j] = result[i, j];
                }
                dataGridViewTask.Rows.Add(row);
            }
        }
    }
}
