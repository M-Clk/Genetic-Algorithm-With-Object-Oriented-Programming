namespace GeneticAlgorithm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSeckinlik = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMutasyon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numCaprazlama = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBoyut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdUygunluk = new System.Windows.Forms.RadioButton();
            this.rdIterasyon = new System.Windows.Forms.RadioButton();
            this.numJenerasyon = new System.Windows.Forms.NumericUpDown();
            this.lblJenerasyon = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdMinimization = new System.Windows.Forms.RadioButton();
            this.rdMaximization = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeckinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoyut)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJenerasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "En Iyi Sonucu Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSeckinlik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numMutasyon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numCaprazlama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numBoyut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // numSeckinlik
            // 
            this.numSeckinlik.Location = new System.Drawing.Point(128, 92);
            this.numSeckinlik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeckinlik.Name = "numSeckinlik";
            this.numSeckinlik.Size = new System.Drawing.Size(113, 20);
            this.numSeckinlik.TabIndex = 7;
            this.numSeckinlik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seçkinlik";
            // 
            // numMutasyon
            // 
            this.numMutasyon.DecimalPlaces = 4;
            this.numMutasyon.Location = new System.Drawing.Point(128, 66);
            this.numMutasyon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMutasyon.Name = "numMutasyon";
            this.numMutasyon.Size = new System.Drawing.Size(113, 20);
            this.numMutasyon.TabIndex = 5;
            this.numMutasyon.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mutasyon Oranı";
            // 
            // numCaprazlama
            // 
            this.numCaprazlama.DecimalPlaces = 2;
            this.numCaprazlama.Location = new System.Drawing.Point(127, 40);
            this.numCaprazlama.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCaprazlama.Name = "numCaprazlama";
            this.numCaprazlama.Size = new System.Drawing.Size(113, 20);
            this.numCaprazlama.TabIndex = 3;
            this.numCaprazlama.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çaprazlama Oranı";
            // 
            // numBoyut
            // 
            this.numBoyut.Location = new System.Drawing.Point(128, 14);
            this.numBoyut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBoyut.Name = "numBoyut";
            this.numBoyut.Size = new System.Drawing.Size(113, 20);
            this.numBoyut.TabIndex = 1;
            this.numBoyut.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Popülasyon Boyutu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdUygunluk);
            this.groupBox2.Controls.Add(this.rdIterasyon);
            this.groupBox2.Controls.Add(this.numJenerasyon);
            this.groupBox2.Controls.Add(this.lblJenerasyon);
            this.groupBox2.Location = new System.Drawing.Point(259, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // rdUygunluk
            // 
            this.rdUygunluk.AutoSize = true;
            this.rdUygunluk.Location = new System.Drawing.Point(128, 19);
            this.rdUygunluk.Name = "rdUygunluk";
            this.rdUygunluk.Size = new System.Drawing.Size(103, 17);
            this.rdUygunluk.TabIndex = 3;
            this.rdUygunluk.Text = "Uygunluk Değeri";
            this.rdUygunluk.UseVisualStyleBackColor = true;
            this.rdUygunluk.CheckedChanged += new System.EventHandler(this.rdIterasyon_CheckedChanged);
            // 
            // rdIterasyon
            // 
            this.rdIterasyon.AutoSize = true;
            this.rdIterasyon.Checked = true;
            this.rdIterasyon.Location = new System.Drawing.Point(8, 19);
            this.rdIterasyon.Name = "rdIterasyon";
            this.rdIterasyon.Size = new System.Drawing.Size(102, 17);
            this.rdIterasyon.TabIndex = 2;
            this.rdIterasyon.TabStop = true;
            this.rdIterasyon.Text = "İterasyon Sayısı";
            this.rdIterasyon.UseVisualStyleBackColor = true;
            this.rdIterasyon.CheckedChanged += new System.EventHandler(this.rdIterasyon_CheckedChanged);
            // 
            // numJenerasyon
            // 
            this.numJenerasyon.Location = new System.Drawing.Point(125, 45);
            this.numJenerasyon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numJenerasyon.Name = "numJenerasyon";
            this.numJenerasyon.Size = new System.Drawing.Size(113, 20);
            this.numJenerasyon.TabIndex = 1;
            this.numJenerasyon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblJenerasyon
            // 
            this.lblJenerasyon.AutoSize = true;
            this.lblJenerasyon.Location = new System.Drawing.Point(0, 47);
            this.lblJenerasyon.Name = "lblJenerasyon";
            this.lblJenerasyon.Size = new System.Drawing.Size(93, 13);
            this.lblJenerasyon.TabIndex = 0;
            this.lblJenerasyon.Text = "Jenerasyon Sayısı";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.LightCoral;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 203);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.LabelToolTip = "d";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Cyan;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Results";
            series1.ShadowColor = System.Drawing.Color.Maroon;
            series1.ShadowOffset = 1;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1376, 556);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // rdMinimization
            // 
            this.rdMinimization.AutoSize = true;
            this.rdMinimization.Location = new System.Drawing.Point(8, 55);
            this.rdMinimization.Name = "rdMinimization";
            this.rdMinimization.Size = new System.Drawing.Size(187, 17);
            this.rdMinimization.TabIndex = 5;
            this.rdMinimization.Text = "En Kucuk Degeri Bul (Minimization)";
            this.rdMinimization.UseVisualStyleBackColor = true;
            // 
            // rdMaximization
            // 
            this.rdMaximization.AutoSize = true;
            this.rdMaximization.Checked = true;
            this.rdMaximization.Location = new System.Drawing.Point(8, 31);
            this.rdMaximization.Name = "rdMaximization";
            this.rdMaximization.Size = new System.Drawing.Size(192, 17);
            this.rdMaximization.TabIndex = 4;
            this.rdMaximization.TabStop = true;
            this.rdMaximization.Text = "En Buyuk Degeri Bul (Maximization)";
            this.rdMaximization.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdMinimization);
            this.groupBox3.Controls.Add(this.rdMaximization);
            this.groupBox3.Location = new System.Drawing.Point(259, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 78);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optimizasyon Turu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 762);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1376, 194);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametreler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 762);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeckinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoyut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJenerasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSeckinlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMutasyon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCaprazlama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBoyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numJenerasyon;
        private System.Windows.Forms.Label lblJenerasyon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rdUygunluk;
        private System.Windows.Forms.RadioButton rdIterasyon;
        private System.Windows.Forms.RadioButton rdMinimization;
        private System.Windows.Forms.RadioButton rdMaximization;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

