namespace Tyuiu.MkhitaryanSG.Sprint6.Task6.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            buttonResult = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            textBoxResult = new TextBox();
            textBoxLoadFromFile = new TextBox();
            groupBoxOutPutData = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBoxOutPutData.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonResult
            // 
            buttonResult.Image = (Image)resources.GetObject("buttonResult.Image");
            buttonResult.Location = new Point(673, 26);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(65, 56);
            buttonResult.TabIndex = 0;
            toolTipTask.SetToolTip(buttonResult, "Производят поиск в файле и вывеодит первое слово каждой строки\r\n");
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(602, 28);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(65, 56);
            buttonOpenFile.TabIndex = 1;
            toolTipTask.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(748, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(46, 43);
            buttonHelp.TabIndex = 5;
            toolTipTask.SetToolTip(buttonHelp, "Информация о разработчике");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 29);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(386, 304);
            textBoxResult.TabIndex = 2;
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(13, 26);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(314, 304);
            textBoxLoadFromFile.TabIndex = 3;
            textBoxLoadFromFile.TextChanged += textBoxLoadFromFile_TextChanged;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Controls.Add(groupBox1);
            groupBoxOutPutData.Location = new Point(0, 111);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(800, 339);
            groupBoxOutPutData.TabIndex = 4;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод данных";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(366, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 313);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(buttonResult);
            groupBox2.Controls.Add(buttonOpenFile);
            groupBox2.Controls.Add(buttonHelp);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 105);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 67);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxOutPutData);
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 6 Вариант 22 Мхитарян С.Г.";
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipTask;
        private Button buttonResult;
        private Button buttonOpenFile;
        private TextBox textBoxResult;
        private TextBox textBoxLoadFromFile;
        private GroupBox groupBoxOutPutData;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button buttonHelp;
    }
}
