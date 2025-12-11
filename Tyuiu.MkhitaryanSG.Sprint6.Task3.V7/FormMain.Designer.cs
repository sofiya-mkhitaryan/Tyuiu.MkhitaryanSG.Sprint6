namespace Tyuiu.MkhitaryanSG.Sprint6.Task3.V7
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
            groupBoxUsl = new GroupBox();
            dataGridViewTask = new DataGridView();
            textBoxUsl = new TextBox();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            labelRes = new Label();
            buttonDone = new Button();
            buttonInf = new Button();
            groupBoxUsl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(dataGridViewTask);
            groupBoxUsl.Controls.Add(textBoxUsl);
            groupBoxUsl.Location = new Point(12, 12);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(615, 367);
            groupBoxUsl.TabIndex = 0;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Location = new Point(272, 32);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.RowHeadersWidth = 51;
            dataGridViewTask.Size = new Size(300, 188);
            dataGridViewTask.TabIndex = 1;
            // 
            // textBoxUsl
            // 
            textBoxUsl.Location = new Point(6, 32);
            textBoxUsl.Multiline = true;
            textBoxUsl.Name = "textBoxUsl";
            textBoxUsl.Size = new Size(239, 144);
            textBoxUsl.TabIndex = 2;
            textBoxUsl.Text = "Дана матрица 5 на 5 \r\n31  25 -18  12   9\r\n6    34  -2    2   -18\r\n-5   4    27   4   -1\r\n4    15   34  -6   -10\r\n0     8     5    14   -17\r\n";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Controls.Add(labelRes);
            groupBoxRes.Location = new Point(636, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(152, 280);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Ввод данных";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 46);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 1;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(6, 23);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(75, 20);
            labelRes.TabIndex = 0;
            labelRes.Text = "Результат";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(681, 322);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 29);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            // 
            // buttonInf
            // 
            buttonInf.Location = new Point(642, 322);
            buttonInf.Name = "buttonInf";
            buttonInf.Size = new Size(28, 29);
            buttonInf.TabIndex = 5;
            buttonInf.Text = "?";
            buttonInf.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInf);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 5 Таск 3 Вариант 7 Мхитарян С.Г.";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxUsl;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private Label labelRes;
        private DataGridView dataGridViewTask;
        private Button buttonInfo;
        private Button buttonDone;
        private Button buttonInf;
    }
}
