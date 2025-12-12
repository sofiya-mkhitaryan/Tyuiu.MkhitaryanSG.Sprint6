using Tyuiu.MkhitaryanSG.Sprint6.Task6.V22.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        Class1 ds = new Class1();
        private void buttonResult_Click(object sender, EventArgs e) 
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonOpenFile_Click(object seder, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonResult.Enabled = true;
        }
        private void buttonHelp_Click(object seder, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void textBoxLoadFromFile_TextChanged(object seder, EventArgs e) { }
    }
}
