namespace GalacticaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.planetList = new System.Windows.Forms.ListBox();
            this.dayCounterLabel = new System.Windows.Forms.Label();
            this.chartTitle = new System.Windows.Forms.Label();
            this.sunButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.nameAndPosList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.dayCountSpeed = new System.Windows.Forms.NumericUpDown();
            this.yearCounterLabel = new System.Windows.Forms.Label();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metricLaber1 = new System.Windows.Forms.Label();
            this.metricLaber2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCountSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.AxisX.Interval = 1000D;
            chartArea6.AxisX.IsStartedFromZero = false;
            chartArea6.AxisX.MajorGrid.Interval = 5000D;
            chartArea6.AxisX.MajorGrid.LineWidth = 2;
            chartArea6.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea6.AxisX.Maximum = 5000D;
            chartArea6.AxisX.Minimum = -5000D;
            chartArea6.AxisX.MinorGrid.Enabled = true;
            chartArea6.AxisX.MinorGrid.Interval = 500D;
            chartArea6.AxisY.Interval = 1000D;
            chartArea6.AxisY.IsStartedFromZero = false;
            chartArea6.AxisY.MajorGrid.Interval = 5000D;
            chartArea6.AxisY.MajorGrid.LineWidth = 2;
            chartArea6.AxisY.Maximum = 5000D;
            chartArea6.AxisY.Minimum = -5000D;
            chartArea6.AxisY.MinorGrid.Enabled = true;
            chartArea6.AxisY.MinorGrid.Interval = 500D;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            legend6.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(300, 87);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.MarkerSize = 10;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series1";
            dataPoint11.BorderColor = System.Drawing.Color.Black;
            series6.Points.Add(dataPoint11);
            series6.Points.Add(dataPoint12);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(562, 562);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(890, 535);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 900;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(276, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // planetList
            // 
            this.planetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.planetList.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetList.FormattingEnabled = true;
            this.planetList.ItemHeight = 25;
            this.planetList.Location = new System.Drawing.Point(58, 129);
            this.planetList.Margin = new System.Windows.Forms.Padding(2);
            this.planetList.Name = "planetList";
            this.planetList.Size = new System.Drawing.Size(158, 300);
            this.planetList.TabIndex = 5;
            this.planetList.SelectedIndexChanged += new System.EventHandler(this.planetList_SelectedIndexChanged);
            // 
            // dayCounterLabel
            // 
            this.dayCounterLabel.AutoSize = true;
            this.dayCounterLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCounterLabel.Location = new System.Drawing.Point(1047, 497);
            this.dayCounterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayCounterLabel.Name = "dayCounterLabel";
            this.dayCounterLabel.Size = new System.Drawing.Size(64, 21);
            this.dayCounterLabel.TabIndex = 6;
            this.dayCounterLabel.Text = "Days: 0";
            // 
            // chartTitle
            // 
            this.chartTitle.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTitle.Location = new System.Drawing.Point(375, 32);
            this.chartTitle.Name = "chartTitle";
            this.chartTitle.Size = new System.Drawing.Size(453, 40);
            this.chartTitle.TabIndex = 7;
            this.chartTitle.Text = "label1";
            this.chartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunButton
            // 
            this.sunButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunButton.FlatAppearance.BorderSize = 0;
            this.sunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunButton.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunButton.Location = new System.Drawing.Point(58, 87);
            this.sunButton.Name = "sunButton";
            this.sunButton.Size = new System.Drawing.Size(158, 37);
            this.sunButton.TabIndex = 9;
            this.sunButton.Text = "sunBotton";
            this.sunButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunButton.UseVisualStyleBackColor = false;
            this.sunButton.Click += new System.EventHandler(this.sunButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(811, 32);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 11;
            // 
            // nameAndPosList
            // 
            this.nameAndPosList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameAndPosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.nameAndPosList.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAndPosList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.nameAndPosList.HideSelection = false;
            this.nameAndPosList.Location = new System.Drawing.Point(928, 129);
            this.nameAndPosList.MultiSelect = false;
            this.nameAndPosList.Name = "nameAndPosList";
            this.nameAndPosList.Size = new System.Drawing.Size(213, 276);
            this.nameAndPosList.TabIndex = 12;
            this.nameAndPosList.UseCompatibleStateImageBehavior = false;
            this.nameAndPosList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 175;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(1001, 443);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(58, 33);
            this.playButton.TabIndex = 13;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(937, 443);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(58, 33);
            this.stopButton.TabIndex = 14;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // dayCountSpeed
            // 
            this.dayCountSpeed.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCountSpeed.Location = new System.Drawing.Point(1065, 449);
            this.dayCountSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayCountSpeed.Name = "dayCountSpeed";
            this.dayCountSpeed.Size = new System.Drawing.Size(47, 22);
            this.dayCountSpeed.TabIndex = 15;
            this.dayCountSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearCounterLabel
            // 
            this.yearCounterLabel.AutoSize = true;
            this.yearCounterLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCounterLabel.Location = new System.Drawing.Point(942, 497);
            this.yearCounterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearCounterLabel.Name = "yearCounterLabel";
            this.yearCounterLabel.Size = new System.Drawing.Size(68, 21);
            this.yearCounterLabel.TabIndex = 16;
            this.yearCounterLabel.Text = "Years: 0";
            // 
            // zoomSlider
            // 
            this.zoomSlider.Location = new System.Drawing.Point(253, 129);
            this.zoomSlider.Maximum = 50;
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomSlider.Size = new System.Drawing.Size(45, 423);
            this.zoomSlider.TabIndex = 17;
            this.zoomSlider.Value = 50;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Orbiters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zoom ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metricLaber1
            // 
            this.metricLaber1.AutoSize = true;
            this.metricLaber1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricLaber1.Location = new System.Drawing.Point(331, 72);
            this.metricLaber1.Name = "metricLaber1";
            this.metricLaber1.Size = new System.Drawing.Size(74, 13);
            this.metricLaber1.TabIndex = 20;
            this.metricLaber1.Text = "metricLaber1";
            // 
            // metricLaber2
            // 
            this.metricLaber2.AutoSize = true;
            this.metricLaber2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricLaber2.Location = new System.Drawing.Point(867, 611);
            this.metricLaber2.Name = "metricLaber2";
            this.metricLaber2.Size = new System.Drawing.Size(74, 13);
            this.metricLaber2.TabIndex = 21;
            this.metricLaber2.Text = "metricLaber2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.metricLaber2);
            this.Controls.Add(this.metricLaber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomSlider);
            this.Controls.Add(this.yearCounterLabel);
            this.Controls.Add(this.dayCountSpeed);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.nameAndPosList);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.sunButton);
            this.Controls.Add(this.chartTitle);
            this.Controls.Add(this.dayCounterLabel);
            this.Controls.Add(this.planetList);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCountSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox planetList;
        private System.Windows.Forms.Label dayCounterLabel;
        private System.Windows.Forms.Label chartTitle;
        private System.Windows.Forms.Button sunButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView nameAndPosList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown dayCountSpeed;
        private System.Windows.Forms.Label yearCounterLabel;
        private System.Windows.Forms.TrackBar zoomSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label metricLaber1;
        private System.Windows.Forms.Label metricLaber2;
    }
}

