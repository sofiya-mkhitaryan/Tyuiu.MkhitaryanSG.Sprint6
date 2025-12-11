namespace Tyuiu.MkhitaryanSG.Sprint6.Task5.V8
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
            dataGridViewData = new DataGridView();
            buttonInfo = new Button();
            buttonOpenData = new Button();
            groupBoxUsl = new GroupBox();
            textBox1 = new TextBox();
            groupBoxDone = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            groupBoxUsl.SuspendLayout();
            groupBoxDone.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(452, 34);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(101, 48);
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
            chartResult.Location = new Point(250, 26);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(505, 273);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            chartResult.Click += chartResult_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(12, 26);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(219, 273);
            dataGridViewData.TabIndex = 2;
            dataGridViewData.CellContentClick += this.dataGridViewData_CellContentClick;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(659, 34);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(52, 48);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpenData
            // 
            buttonOpenData.Location = new Point(559, 34);
            buttonOpenData.Name = "buttonOpenData";
            buttonOpenData.Size = new Size(94, 48);
            buttonOpenData.TabIndex = 4;
            buttonOpenData.Text = "Открыть файл";
            buttonOpenData.UseVisualStyleBackColor = true;
            buttonOpenData.Click += buttonOpenData_Click;
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBox1);
            groupBoxUsl.Location = new Point(21, 12);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(425, 122);
            groupBoxUsl.TabIndex = 5;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V8.txt. Вывести в dataGridView.";
            // 
            // groupBoxDone
            // 
            groupBoxDone.Controls.Add(chartResult);
            groupBoxDone.Controls.Add(dataGridViewData);
            groupBoxDone.Location = new Point(21, 140);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(755, 298);
            groupBoxDone.TabIndex = 6;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxDone);
            Controls.Add(groupBoxUsl);
            Controls.Add(buttonOpenData);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 Таск 5 Вариант 8 Мхитарян С.Г.";
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxDone.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewData;
        private Button buttonInfo;
        private Button buttonOpenData;
        private GroupBox groupBoxUsl;
        private TextBox textBox1;
        private GroupBox groupBoxDone;
    }
}
