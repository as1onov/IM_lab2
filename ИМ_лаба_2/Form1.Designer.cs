namespace ИМ_лаба_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edDays = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Minimum = 80D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(352, 24);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Gray;
            series1.LabelBorderWidth = 4;
            series1.LabelFormat = "c";
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = System.Drawing.Color.Silver;
            series1.Name = "$";
            series1.YValuesPerPoint = 3;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.LabelFormat = "c";
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 3;
            series2.Name = "€";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(897, 457);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная цена $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальная цена  € ";
            // 
            // edDollar
            // 
            this.edDollar.DecimalPlaces = 2;
            this.edDollar.Location = new System.Drawing.Point(187, 55);
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(120, 22);
            this.edDollar.TabIndex = 3;
            this.edDollar.Value = new decimal(new int[] {
            9250,
            0,
            0,
            131072});
            // 
            // edEuro
            // 
            this.edEuro.DecimalPlaces = 2;
            this.edEuro.Location = new System.Drawing.Point(187, 88);
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(120, 22);
            this.edEuro.TabIndex = 4;
            this.edEuro.Value = new decimal(new int[] {
            9988,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дни";
            // 
            // edDays
            // 
            this.edDays.Location = new System.Drawing.Point(187, 124);
            this.edDays.Name = "edDays";
            this.edDays.Size = new System.Drawing.Size(120, 22);
            this.edDays.TabIndex = 6;
            this.edDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.GreenYellow;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(37, 183);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(276, 38);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.IndianRed;
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_stop.Location = new System.Drawing.Point(37, 227);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(276, 41);
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 571);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.edDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edEuro);
            this.Controls.Add(this.edDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "laba_2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edDays;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_stop;
    }
}

