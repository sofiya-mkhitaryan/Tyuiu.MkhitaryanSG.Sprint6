using Tyuiu.MkhitaryanSG.Sprint6.Task7.V18.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;

        Class1 ds = new Class1();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);

            file = file.Replace('\n', '\r'); 
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonOpenFile_MSG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_MSG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_MSG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelp_MSG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_MSG_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFile = openFileDialogTask.FileName;

            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFile);

            dataGridViewInMatrix.RowCount = rows;
            dataGridViewInMatrix.ColumnCount = columns;
            dataGridViewOutMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 50;
                dataGridViewOutMatrix.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            matrix = ds.GetMatrix(openFile);
            buttonDone_MSG.Enabled = true;
        }

        private void buttonDone_MSG_Click(object sender, EventArgs e)
        {
            int[,] matrixNew = new int[rows, columns];
            matrixNew = ds.GetMatrix(openFile);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix.Rows[r].Cells[c].Value = matrixNew[r, c];
                }
            }
            buttonSaveFile_MSG.Enabled = true;
        }
        private void buttonSaveFile_MSG_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutMatrix.RowCount;
            int columns = dataGridViewOutMatrix.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void textBoxUsl_TextChanged(object sender, EventArgs e) { }

        private void buttonHelp_MSG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
