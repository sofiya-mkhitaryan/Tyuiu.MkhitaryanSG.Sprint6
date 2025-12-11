namespace Tyuiu.MkhitaryanSG.Sprint6.Task4.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBoxRes = new GroupBox();
            textBoxTable = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(513, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 54);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(426, 72);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(375, 375);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(226, 46);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 46);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(624, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 54);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(737, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(51, 54);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 94);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 50);
            textBox1.TabIndex = 4;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "Старт шага";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 23);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 6;
            label2.Text = "Конец шага";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxEnd);
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Location = new Point(12, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 84);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxTable);
            groupBoxRes.Location = new Point(12, 219);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(366, 219);
            groupBoxRes.TabIndex = 8;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод данных";
            // 
            // textBoxTable
            // 
            textBoxTable.Location = new Point(6, 23);
            textBoxTable.Multiline = true;
            textBoxTable.Name = "textBoxTable";
            textBoxTable.ReadOnly = true;
            textBoxTable.ScrollBars = ScrollBars.Vertical;
            textBoxTable.Size = new Size(185, 190);
            textBoxTable.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(chartResult);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 Таск 4 Вариант 15 Мхитарян С.Г.";
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Button buttonSave;
        private Button buttonHelp;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBoxRes;
        private TextBox textBoxTable;
    }
}
