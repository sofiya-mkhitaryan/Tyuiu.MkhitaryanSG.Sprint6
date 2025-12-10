using Tyuiu.MkhitaryanSG.Sprint6.Task2.V11.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnd.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                this.dataGridViewTask.Rows.Clear();
                this.chartTask.Series[0].Points.Clear();

                this.chartTask.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartTask.ChartAreas[0].AxisY.Title = "Ось Y";

                int x = startStep;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewTask.Rows.Add(x.ToString(), valueArray[i].ToString());
                    this.chartTask.Series[0].Points.AddXY(x, valueArray[i]);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные значения для начала и конца диапазона!");
            }
        }
        private void ButtonInfo(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы РППб25-1 Мхитарян София Геворковна");
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Purple;
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.White;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
    }
}
