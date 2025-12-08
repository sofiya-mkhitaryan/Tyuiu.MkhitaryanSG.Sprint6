using Tyuiu.MkhitaryanSG.Sprint6.Task0.V7.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxTask_MSG_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_MSG_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_MSG.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxForX_MSG.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxForX_MSG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_MSG_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_MSG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РППб25-1 Мхитарян София Геворковна");
        }

        private void pictureBoxTask_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRes_MSG_Click(object sender, EventArgs e)
        {

        }

        private void labelX_MSG_Click(object sender, EventArgs e)
        {

        }
    }
}