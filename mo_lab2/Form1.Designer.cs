namespace mo_lab2
{
    partial class OneDimensionalSearchForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOutDichotomy = new System.Windows.Forms.TextBox();
            this.tbOutGolden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "График";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(560, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x^3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "-10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "x^2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 341);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "c";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(369, 341);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "b0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 386);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "a0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 386);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 433);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "0,01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "e";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 596);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Провести расчеты";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShowChart
            // 
            this.btnShowChart.Location = new System.Drawing.Point(131, 596);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(114, 23);
            this.btnShowChart.TabIndex = 20;
            this.btnShowChart.Text = "Показать график";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Метод дихотомии";
            // 
            // tbOutDichotomy
            // 
            this.tbOutDichotomy.Location = new System.Drawing.Point(12, 490);
            this.tbOutDichotomy.Multiline = true;
            this.tbOutDichotomy.Name = "tbOutDichotomy";
            this.tbOutDichotomy.ReadOnly = true;
            this.tbOutDichotomy.Size = new System.Drawing.Size(219, 100);
            this.tbOutDichotomy.TabIndex = 22;
            // 
            // tbOutGolden
            // 
            this.tbOutGolden.Location = new System.Drawing.Point(253, 490);
            this.tbOutGolden.Multiline = true;
            this.tbOutGolden.Name = "tbOutGolden";
            this.tbOutGolden.ReadOnly = true;
            this.tbOutGolden.Size = new System.Drawing.Size(219, 100);
            this.tbOutGolden.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Метод золотого сечения";
            // 
            // OneDimensionalSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 631);
            this.Controls.Add(this.tbOutGolden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbOutDichotomy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Name = "OneDimensionalSearchForm";
            this.Text = "Методы дихотомии и золотого сечения";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOutDichotomy;
        private System.Windows.Forms.TextBox tbOutGolden;
        private System.Windows.Forms.Label label10;
    }
}

