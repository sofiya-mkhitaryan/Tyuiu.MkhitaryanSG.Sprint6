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
            groupBoxUsl = new GroupBox();
            textBoxUsl = new TextBox();
            buttonSaveFile_MSG = new Button();
            buttonOpenFile_MSG = new Button();
            buttonDone_MSG = new Button();
            panelVvod = new Panel();
            groupBoxVvod = new GroupBox();
            dataGridViewInMatrix = new DataGridView();
            panelVsvod = new Panel();
            groupBoxVsvod = new GroupBox();
            dataGridViewOutMatrix = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelKnopki.SuspendLayout();
            groupBoxUsl.SuspendLayout();
            panelVvod.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panelVsvod.SuspendLayout();
            groupBoxVsvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // panelKnopki
            // 
            panelKnopki.Controls.Add(buttonHelp_MSG);
            panelKnopki.Controls.Add(groupBoxUsl);
            panelKnopki.Controls.Add(buttonSaveFile_MSG);
            panelKnopki.Controls.Add(buttonOpenFile_MSG);
            panelKnopki.Controls.Add(buttonDone_MSG);
            panelKnopki.Dock = DockStyle.Top;
            panelKnopki.Location = new Point(0, 0);
            panelKnopki.MinimumSize = new Size(0, 139);
            panelKnopki.Name = "panelKnopki";
            panelKnopki.Size = new Size(1214, 157);
            panelKnopki.TabIndex = 0;
            // 
            // buttonHelp_MSG
            // 
            buttonHelp_MSG.Anchor = AnchorStyles.Right;
            buttonHelp_MSG.FlatStyle = FlatStyle.Flat;
            buttonHelp_MSG.Image = (Image)resources.GetObject("buttonHelp_MSG.Image");
            buttonHelp_MSG.Location = new Point(1135, 3);
            buttonHelp_MSG.Name = "buttonHelp_MSG";
            buttonHelp_MSG.Size = new Size(73, 48);
            buttonHelp_MSG.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp_MSG, "Информация о разработчике");
            buttonHelp_MSG.UseVisualStyleBackColor = true;
            buttonHelp_MSG.Click += buttonHelp_MSG_Click;
            buttonHelp_MSG.MouseEnter += buttonHelp_MSG_MouseEnter;
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxUsl.Controls.Add(textBoxUsl);
            groupBoxUsl.Location = new Point(12, 57);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(1202, 94);
            groupBoxUsl.TabIndex = 0;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBoxUsl
            // 
            textBoxUsl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsl.BorderStyle = BorderStyle.None;
            textBoxUsl.Location = new Point(0, 26);
            textBoxUsl.Multiline = true;
            textBoxUsl.Name = "textBoxUsl";
            textBoxUsl.Size = new Size(1196, 46);
            textBoxUsl.TabIndex = 0;
            textBoxUsl.Text = resources.GetString("textBoxUsl.Text");
            textBoxUsl.TextChanged += textBoxUsl_TextChanged;
            // 
            // buttonSaveFile_MSG
            // 
            buttonSaveFile_MSG.Enabled = false;
            buttonSaveFile_MSG.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_MSG.Image = (Image)resources.GetObject("buttonSaveFile_MSG.Image");
            buttonSaveFile_MSG.Location = new Point(142, 3);
            buttonSaveFile_MSG.Name = "buttonSaveFile_MSG";
            buttonSaveFile_MSG.Size = new Size(59, 48);
            buttonSaveFile_MSG.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSaveFile_MSG, "Сохранить данные для файла в формате csv");
            buttonSaveFile_MSG.UseVisualStyleBackColor = true;
            buttonSaveFile_MSG.Click += buttonSaveFile_MSG_Click;
            buttonSaveFile_MSG.MouseEnter += buttonSaveFile_MSG_MouseEnter;
            // 
            // buttonOpenFile_MSG
            // 
            buttonOpenFile_MSG.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MSG.Image = (Image)resources.GetObject("buttonOpenFile_MSG.Image");
            buttonOpenFile_MSG.Location = new Point(12, 3);
            buttonOpenFile_MSG.Name = "buttonOpenFile_MSG";
            buttonOpenFile_MSG.Size = new Size(59, 48);
            buttonOpenFile_MSG.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile_MSG, "Открыть файл для обработки данных в формате csv");
            buttonOpenFile_MSG.UseVisualStyleBackColor = true;
            buttonOpenFile_MSG.Click += buttonOpenFile_MSG_Click;
            buttonOpenFile_MSG.MouseEnter += buttonOpenFile_MSG_MouseEnter;
            // 
            // buttonDone_MSG
            // 
            buttonDone_MSG.Enabled = false;
            buttonDone_MSG.FlatStyle = FlatStyle.Flat;
            buttonDone_MSG.Image = (Image)resources.GetObject("buttonDone_MSG.Image");
            buttonDone_MSG.Location = new Point(77, 3);
            buttonDone_MSG.Name = "buttonDone_MSG";
            buttonDone_MSG.Size = new Size(59, 48);
            buttonDone_MSG.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone_MSG, "Выполнить обработку данных");
            buttonDone_MSG.UseVisualStyleBackColor = true;
            buttonDone_MSG.Click += buttonDone_MSG_Click;
            buttonDone_MSG.MouseEnter += buttonDone_MSG_MouseEnter;
            // 
            // panelVvod
            // 
            panelVvod.Controls.Add(groupBoxVvod);
            panelVvod.Dock = DockStyle.Fill;
            panelVvod.Location = new Point(0, 157);
            panelVvod.Name = "panelVvod";
            panelVvod.Size = new Size(1214, 470);
            panelVvod.TabIndex = 2;
            panelVvod.Paint += panelVvod_Paint;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(dataGridViewInMatrix);
            groupBoxVvod.Dock = DockStyle.Fill;
            groupBoxVvod.Location = new Point(0, 0);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(1214, 470);
            groupBoxVvod.TabIndex = 0;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод";
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.AllowUserToAddRows = false;
            dataGridViewInMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(3, 26);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersVisible = false;
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(1192, 438);
            dataGridViewInMatrix.TabIndex = 4;
            // 
            // panelVsvod
            // 
            panelVsvod.Controls.Add(groupBoxVsvod);
            panelVsvod.Dock = DockStyle.Right;
            panelVsvod.Location = new Point(575, 157);
            panelVsvod.Name = "panelVsvod";
            panelVsvod.Size = new Size(639, 470);
            panelVsvod.TabIndex = 0;
            // 
            // groupBoxVsvod
            // 
            groupBoxVsvod.Controls.Add(dataGridViewOutMatrix);
            groupBoxVsvod.Dock = DockStyle.Fill;
            groupBoxVsvod.Location = new Point(0, 0);
            groupBoxVsvod.Name = "groupBoxVsvod";
            groupBoxVsvod.Size = new Size(639, 470);
            groupBoxVsvod.TabIndex = 0;
            groupBoxVsvod.TabStop = false;
            groupBoxVsvod.Text = "Вывод";
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.AllowUserToAddRows = false;
            dataGridViewOutMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOutMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(6, 26);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersVisible = false;
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutMatrix.Size = new Size(627, 437);
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
            ClientSize = new Size(1214, 627);
            Controls.Add(panelVsvod);
            Controls.Add(panelVvod);
            Controls.Add(panelKnopki);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 7 Вариант 18 Мхитарян С. Г.";
            panelKnopki.ResumeLayout(false);
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            panelVvod.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panelVsvod.ResumeLayout(false);
            groupBoxVsvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelKnopki;
        private Button buttonHelp_MSG;
        private Button buttonSaveFile_MSG;
        private Button buttonDone_MSG;
        private Button buttonOpenFile_MSG;
        private Panel panelVvod;
        private Panel panelVsvod;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private GroupBox groupBoxUsl;
        private TextBox textBoxUsl;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxVsvod;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
    }
}
