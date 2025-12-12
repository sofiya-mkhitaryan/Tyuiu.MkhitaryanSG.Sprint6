using Tyuiu.MkhitaryanSG.Sprint6.Task5.V8.Lib;
using System.IO;

namespace Tyuiu.MkhitaryanSG.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private static readonly string path = @"C:\DataSprint6\InPutDataFileTask5V8.txt";
        Class1 ds = new Class1();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            chartResult.Series[0].Points.Clear();

            dataGridViewData.ColumnCount = 2;
            dataGridViewData.Columns[0].Width = 20;
            dataGridViewData.Columns[1].Width = 50;

            chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewData.Rows.Add(i + 1, serviceArray[i]);
                chartResult.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы РППб 25-1 Мхитарян С.Г.", "Справка");
        }
        private void buttonOpenData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void chartResult_Click(object sender, EventArgs e) { }
        private void dataGridViewData_CellContentClick(object sender, EventArgs e) { }
    }
}
