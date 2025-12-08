namespace Tyuiu.MkhitaryanSG.Sprint6.Task0.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_MSG = new GroupBox();
            textBox1 = new TextBox();
            labelTaskUsloviye_MSG = new Label();
            pictureBoxTask = new PictureBox();
            groupBoxX_MSG = new GroupBox();
            textBoxForX_MSG = new TextBox();
            labelX_MSG = new Label();
            groupBoxRes_MSG = new GroupBox();
            labelRes_MSG = new Label();
            textBoxResult_MSG = new TextBox();
            buttonInfo_MSG = new Button();
            buttonDone_MSG = new Button();
            groupBoxTask_MSG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxX_MSG.SuspendLayout();
            groupBoxRes_MSG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MSG
            // 
            groupBoxTask_MSG.Controls.Add(textBox1);
            groupBoxTask_MSG.Controls.Add(labelTaskUsloviye_MSG);
            groupBoxTask_MSG.Controls.Add(pictureBoxTask);
            groupBoxTask_MSG.Location = new Point(12, 12);
            groupBoxTask_MSG.Name = "groupBoxTask_MSG";
            groupBoxTask_MSG.Size = new Size(762, 272);
            groupBoxTask_MSG.TabIndex = 0;
            groupBoxTask_MSG.TabStop = false;
            groupBoxTask_MSG.Text = "Условие";
            groupBoxTask_MSG.Enter += groupBoxTask_MSG_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Дано выражение вычислить его значение при x = 3";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelTaskUsloviye_MSG
            // 
            labelTaskUsloviye_MSG.AutoSize = true;
            labelTaskUsloviye_MSG.Location = new Point(0, 35);
            labelTaskUsloviye_MSG.Name = "labelTaskUsloviye_MSG";
            labelTaskUsloviye_MSG.Size = new Size(0, 20);
            labelTaskUsloviye_MSG.TabIndex = 1;
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(512, 87);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(137, 77);
            pictureBoxTask.TabIndex = 0;
            pictureBoxTask.TabStop = false;
            pictureBoxTask.Click += pictureBoxTask_Click;
            // 
            // groupBoxX_MSG
            // 
            groupBoxX_MSG.Controls.Add(textBoxForX_MSG);
            groupBoxX_MSG.Controls.Add(labelX_MSG);
            groupBoxX_MSG.Location = new Point(12, 302);
            groupBoxX_MSG.Name = "groupBoxX_MSG";
            groupBoxX_MSG.Size = new Size(250, 125);
            groupBoxX_MSG.TabIndex = 0;
            groupBoxX_MSG.TabStop = false;
            groupBoxX_MSG.Text = "Ввод данных";
            // 
            // textBoxForX_MSG
            // 
            textBoxForX_MSG.Location = new Point(6, 72);
            textBoxForX_MSG.Name = "textBoxForX_MSG";
            textBoxForX_MSG.Size = new Size(125, 27);
            textBoxForX_MSG.TabIndex = 3;
            textBoxForX_MSG.TextChanged += textBoxForX_MSG_TextChanged;
            // 
            // labelX_MSG
            // 
            labelX_MSG.AutoSize = true;
            labelX_MSG.Location = new Point(6, 35);
            labelX_MSG.Name = "labelX_MSG";
            labelX_MSG.Size = new Size(111, 20);
            labelX_MSG.TabIndex = 2;
            labelX_MSG.Text = "Переменная Х";
            labelX_MSG.Click += labelX_MSG_Click;
            // 
            // groupBoxRes_MSG
            // 
            groupBoxRes_MSG.Controls.Add(labelRes_MSG);
            groupBoxRes_MSG.Controls.Add(textBoxResult_MSG);
            groupBoxRes_MSG.Location = new Point(524, 302);
            groupBoxRes_MSG.Name = "groupBoxRes_MSG";
            groupBoxRes_MSG.Size = new Size(250, 125);
            groupBoxRes_MSG.TabIndex = 0;
            groupBoxRes_MSG.TabStop = false;
            groupBoxRes_MSG.Text = "Выход данных";
            // 
            // labelRes_MSG
            // 
            labelRes_MSG.AutoSize = true;
            labelRes_MSG.Location = new Point(6, 35);
            labelRes_MSG.Name = "labelRes_MSG";
            labelRes_MSG.Size = new Size(75, 20);
            labelRes_MSG.TabIndex = 5;
            labelRes_MSG.Text = "Результат";
            labelRes_MSG.Click += labelRes_MSG_Click;
            // 
            // textBoxResult_MSG
            // 
            textBoxResult_MSG.Location = new Point(6, 72);
            textBoxResult_MSG.Name = "textBoxResult_MSG";
            textBoxResult_MSG.ReadOnly = true;
            textBoxResult_MSG.Size = new Size(125, 27);
            textBoxResult_MSG.TabIndex = 4;
            textBoxResult_MSG.TextChanged += textBoxResult_MSG_TextChanged;
            // 
            // buttonInfo_MSG
            // 
            buttonInfo_MSG.Location = new Point(298, 337);
            buttonInfo_MSG.Name = "buttonInfo_MSG";
            buttonInfo_MSG.Size = new Size(39, 35);
            buttonInfo_MSG.TabIndex = 1;
            buttonInfo_MSG.Text = "?";
            buttonInfo_MSG.UseVisualStyleBackColor = true;
            buttonInfo_MSG.Click += buttonInfo_MSG_Click;
            // 
            // buttonDone_MSG
            // 
            buttonDone_MSG.Location = new Point(362, 337);
            buttonDone_MSG.Name = "buttonDone_MSG";
            buttonDone_MSG.Size = new Size(115, 45);
            buttonDone_MSG.TabIndex = 2;
            buttonDone_MSG.Text = "Выполнить";
            buttonDone_MSG.UseVisualStyleBackColor = true;
            buttonDone_MSG.Click += buttonDone_MSG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_MSG);
            Controls.Add(groupBoxRes_MSG);
            Controls.Add(buttonInfo_MSG);
            Controls.Add(groupBoxX_MSG);
            Controls.Add(groupBoxTask_MSG);
            Name = "FormMain";
            Text = "Спринт 6 Таск 0 Вариант 7 Мхитарян С.Г.";
            groupBoxTask_MSG.ResumeLayout(false);
            groupBoxTask_MSG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxX_MSG.ResumeLayout(false);
            groupBoxX_MSG.PerformLayout();
            groupBoxRes_MSG.ResumeLayout(false);
            groupBoxRes_MSG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MSG;
        private GroupBox groupBoxX_MSG;
        private Label labelTaskUsloviye_MSG;
        private PictureBox pictureBoxTask;
        private GroupBox groupBoxRes_MSG;
        private Button buttonInfo_MSG;
        private TextBox textBoxForX_MSG;
        private Label labelX_MSG;
        private Label labelRes_MSG;
        private TextBox textBoxResult_MSG;
        private TextBox textBox1;
        private Button buttonDone_MSG;
    }
}
