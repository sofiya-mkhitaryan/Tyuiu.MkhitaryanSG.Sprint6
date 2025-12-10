namespace Tyuiu.MkhitaryanSG.Sprint6.Task2.V11
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
            dataGridViewTask = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            chartTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTask).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridViewTask.Location = new Point(6, 39);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.RowHeadersVisible = false;
            dataGridViewTask.RowHeadersWidth = 51;
            dataGridViewTask.ScrollBars = ScrollBars.Vertical;
            dataGridViewTask.Size = new Size(127, 188);
            dataGridViewTask.TabIndex = 0;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 50;
            // 
            // ColumnFx
            // 
            ColumnFx.HeaderText = "F(X)";
            ColumnFx.MinimumWidth = 6;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.Width = 125;
            // 
            // chartTask
            // 
            chartArea1.Name = "ChartArea1";
            chartTask.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTask.Legends.Add(legend1);
            chartTask.Location = new Point(139, 26);
            chartTask.Name = "chartTask";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTask.Series.Add(series1);
            chartTask.Size = new Size(316, 287);
            chartTask.TabIndex = 1;
            chartTask.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 50);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(304, 63);
            textBox3.TabIndex = 2;
            textBox3.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Controls.Add(textBoxEnd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(3, 58);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(163, 58);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 23);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Старт шага:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewTask);
            groupBox3.Controls.Add(chartTask);
            groupBox3.Location = new Point(341, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(455, 392);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(622, 410);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(46, 29);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(674, 410);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(102, 29);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 Таск 2 Вариант 11 Мхитарян С.Г.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTask).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Label label2;
        private Label label1;
        private Button buttonInfo;
        private Button buttonDone;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;
    }
}
