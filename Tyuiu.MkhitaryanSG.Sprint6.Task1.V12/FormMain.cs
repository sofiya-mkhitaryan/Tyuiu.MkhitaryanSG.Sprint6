using Tyuiu.MkhitaryanSG.Sprint6.Task1.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnd.Text);

                string strLine;
                int len = (ds.GetMassFunction(startStep, stopStep)).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("+    X    |   F(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения для начала и конца диапазона!");
            }
        }

        private void buttonInfo_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РППб25-1 Мхитарян София Геворковна");
        }
    }
}
