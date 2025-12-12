namespace Tyuiu.MkhitaryanSG.Sprint6.Task7.V18
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
            panelKnopki = new Panel();
            buttonHelp_MSG = new Button();
            buttonSaveFile_MSG = new Button();
            buttonDone_MSG = new Button();
            buttonOpenFile_MSG = new Button();
            panelUsl = new Panel();
            groupBoxUsl = new GroupBox();
            textBoxUsl = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewInMatrix = new DataGridView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewOutMatrix = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelKnopki.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // panelKnopki
            // 
            panelKnopki.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelKnopki.Controls.Add(buttonHelp_MSG);
            panelKnopki.Controls.Add(buttonSaveFile_MSG);
            panelKnopki.Controls.Add(buttonDone_MSG);
            panelKnopki.Controls.Add(buttonOpenFile_MSG);
            panelKnopki.Location = new Point(12, 0);
            panelKnopki.Name = "panelKnopki";
            panelKnopki.Size = new Size(1196, 60);
            panelKnopki.TabIndex = 0;
            // 
            // buttonHelp_MSG
            // 
            buttonHelp_MSG.FlatStyle = FlatStyle.Flat;
            buttonHelp_MSG.Image = (Image)resources.GetObject("buttonHelp_MSG.Image");
            buttonHelp_MSG.Location = new Point(1117, 7);
            buttonHelp_MSG.Name = "buttonHelp_MSG";
            buttonHelp_MSG.Size = new Size(73, 48);
            buttonHelp_MSG.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp_MSG, "Информация о разработчике");
            buttonHelp_MSG.UseVisualStyleBackColor = true;
            buttonHelp_MSG.Click += buttonHelp_MSG_Click;
            buttonHelp_MSG.MouseEnter += buttonHelp_MSG_MouseEnter;
            // 
            // buttonSaveFile_MSG
            // 
            buttonSaveFile_MSG.Enabled = false;
            buttonSaveFile_MSG.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_MSG.Image = (Image)resources.GetObject("buttonSaveFile_MSG.Image");
            buttonSaveFile_MSG.Location = new Point(142, 7);
            buttonSaveFile_MSG.Name = "buttonSaveFile_MSG";
            buttonSaveFile_MSG.Size = new Size(59, 48);
            buttonSaveFile_MSG.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSaveFile_MSG, "Сохранить данные для файла в формате csv");
            buttonSaveFile_MSG.UseVisualStyleBackColor = true;
            buttonSaveFile_MSG.Click += buttonSaveFile_MSG_Click;
            buttonSaveFile_MSG.MouseEnter += buttonSaveFile_MSG_MouseEnter;
            // 
            // buttonDone_MSG
            // 
            buttonDone_MSG.Enabled = false;
            buttonDone_MSG.FlatStyle = FlatStyle.Flat;
            buttonDone_MSG.Image = (Image)resources.GetObject("buttonDone_MSG.Image");
            buttonDone_MSG.Location = new Point(77, 7);
            buttonDone_MSG.Name = "buttonDone_MSG";
            buttonDone_MSG.Size = new Size(59, 48);
            buttonDone_MSG.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone_MSG, "Выполнить обработку данных");
            buttonDone_MSG.UseVisualStyleBackColor = true;
            buttonDone_MSG.Click += buttonDone_MSG_Click;
            buttonDone_MSG.MouseEnter += buttonDone_MSG_MouseEnter;
            // 
            // buttonOpenFile_MSG
            // 
            buttonOpenFile_MSG.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MSG.Image = (Image)resources.GetObject("buttonOpenFile_MSG.Image");
            buttonOpenFile_MSG.Location = new Point(12, 7);
            buttonOpenFile_MSG.Name = "buttonOpenFile_MSG";
            buttonOpenFile_MSG.Size = new Size(59, 48);
            buttonOpenFile_MSG.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile_MSG, "Открыть файл для обработки данных в формате csv");
            buttonOpenFile_MSG.UseVisualStyleBackColor = true;
            buttonOpenFile_MSG.Click += buttonOpenFile_MSG_Click;
            buttonOpenFile_MSG.MouseEnter += buttonOpenFile_MSG_MouseEnter;
            // 
            // panelUsl
            // 
            panelUsl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelUsl.Location = new Point(0, 61);
            panelUsl.Name = "panelUsl";
            panelUsl.Size = new Size(1214, 99);
            panelUsl.TabIndex = 1;
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxUsl.Location = new Point(0, 61);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(1214, 99);
            groupBoxUsl.TabIndex = 0;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBoxUsl
            // 
            textBoxUsl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsl.BorderStyle = BorderStyle.None;
            textBoxUsl.Location = new Point(9, 77);
            textBoxUsl.Multiline = true;
            textBoxUsl.Name = "textBoxUsl";
            textBoxUsl.Size = new Size(1199, 59);
            textBoxUsl.TabIndex = 0;
            textBoxUsl.Text = resources.GetString("textBoxUsl.Text");
            textBoxUsl.TextChanged += textBoxUsl_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 375);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewInMatrix);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 372);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(9, 26);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersVisible = false;
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(505, 340);
            dataGridViewInMatrix.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(681, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 375);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOutMatrix);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 372);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(6, 26);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersVisible = false;
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutMatrix.Size = new Size(509, 340);
            dataGridViewOutMatrix.TabIndex = 5;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxUsl);
            Controls.Add(groupBoxUsl);
            Controls.Add(panelUsl);
            Controls.Add(panelKnopki);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 7 Вариант 18 Мхитарян С. Г.";
            panelKnopki.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelKnopki;
        private Button buttonHelp_MSG;
        private Button buttonSaveFile_MSG;
        private Button buttonDone_MSG;
        private Button buttonOpenFile_MSG;
        private Panel panelUsl;
        private Panel panel1;
        private Panel panel2;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private GroupBox groupBoxUsl;
        private TextBox textBoxUsl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
    }
}
