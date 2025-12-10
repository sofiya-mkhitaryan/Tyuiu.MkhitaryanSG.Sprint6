namespace Tyuiu.MkhitaryanSG.Sprint6.Task1.V12
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
            labelUslove = new Label();
            groupBoxRes = new GroupBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            groupBoxShag = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBoxUsl.SuspendLayout();
            groupBoxRes.SuspendLayout();
            groupBoxShag.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(labelUslove);
            groupBoxUsl.Location = new Point(12, 43);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(433, 218);
            groupBoxUsl.TabIndex = 0;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // labelUslove
            // 
            labelUslove.AutoSize = true;
            labelUslove.Location = new Point(6, 37);
            labelUslove.Name = "labelUslove";
            labelUslove.Size = new Size(376, 20);
            labelUslove.TabIndex = 2;
            labelUslove.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(labelResult);
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(465, 43);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(323, 327);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 23);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(19, 55);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(283, 254);
            textBoxResult.TabIndex = 0;
            // 
            // groupBoxShag
            // 
            groupBoxShag.Controls.Add(textBoxEnd);
            groupBoxShag.Controls.Add(textBoxStart);
            groupBoxShag.Controls.Add(label3);
            groupBoxShag.Controls.Add(label4);
            groupBoxShag.Location = new Point(12, 285);
            groupBoxShag.Name = "groupBoxShag";
            groupBoxShag.Size = new Size(250, 125);
            groupBoxShag.TabIndex = 1;
            groupBoxShag.TabStop = false;
            groupBoxShag.Text = "Ввод данных";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(125, 58);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(89, 27);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 58);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(85, 27);
            textBoxStart.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Старт шага";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 31);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 4;
            label4.Text = "Конец шага";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(268, 316);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(59, 54);
            buttonInfo.TabIndex = 0;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click_3;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(333, 316);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 54);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxShag);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 6 Такс 1 Вариант 12 Мхитарян С.Г.";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            groupBoxShag.ResumeLayout(false);
            groupBoxShag.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl;
        private GroupBox groupBoxRes;
        private TextBox textBoxResult;
        private Label labelResult;
        private Label labelUslove;
        private GroupBox groupBoxShag;
        private Label label3;
        private Label label4;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
    }
}
