namespace genetic
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.label1 = new System.Windows.Forms.Label();
      this.nudCount = new System.Windows.Forms.NumericUpDown();
      this.calcStep = new System.Windows.Forms.Button();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.clean = new System.Windows.Forms.Button();
      this.generate = new System.Windows.Forms.Button();
      this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.calc = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Количество особей:";
      // 
      // nudCount
      // 
      this.nudCount.Location = new System.Drawing.Point(8, 24);
      this.nudCount.Margin = new System.Windows.Forms.Padding(2);
      this.nudCount.Name = "nudCount";
      this.nudCount.Size = new System.Drawing.Size(108, 20);
      this.nudCount.TabIndex = 2;
      this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // calcStep
      // 
      this.calcStep.Location = new System.Drawing.Point(8, 73);
      this.calcStep.Margin = new System.Windows.Forms.Padding(2);
      this.calcStep.Name = "calcStep";
      this.calcStep.Size = new System.Drawing.Size(108, 43);
      this.calcStep.TabIndex = 10;
      this.calcStep.Text = "Рассчитать (один шаг)";
      this.calcStep.UseVisualStyleBackColor = true;
      this.calcStep.Click += new System.EventHandler(this.calc_Click);
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.AllowUserToDeleteRows = false;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv.Location = new System.Drawing.Point(0, 0);
      this.dgv.Margin = new System.Windows.Forms.Padding(2);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowTemplate.Height = 28;
      this.dgv.Size = new System.Drawing.Size(1299, 300);
      this.dgv.TabIndex = 12;
      // 
      // clean
      // 
      this.clean.Location = new System.Drawing.Point(8, 149);
      this.clean.Margin = new System.Windows.Forms.Padding(2);
      this.clean.Name = "clean";
      this.clean.Size = new System.Drawing.Size(108, 24);
      this.clean.TabIndex = 13;
      this.clean.Text = "Очистить";
      this.clean.UseVisualStyleBackColor = true;
      this.clean.Click += new System.EventHandler(this.clean_Click);
      // 
      // generate
      // 
      this.generate.Location = new System.Drawing.Point(8, 45);
      this.generate.Margin = new System.Windows.Forms.Padding(2);
      this.generate.Name = "generate";
      this.generate.Size = new System.Drawing.Size(108, 24);
      this.generate.TabIndex = 14;
      this.generate.Text = "Сгенерировать";
      this.generate.UseVisualStyleBackColor = true;
      this.generate.Click += new System.EventHandler(this.generate_Click);
      // 
      // chartPoints
      // 
      chartArea1.Name = "ChartArea1";
      this.chartPoints.ChartAreas.Add(chartArea1);
      this.chartPoints.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Name = "Legend1";
      this.chartPoints.Legends.Add(legend1);
      this.chartPoints.Location = new System.Drawing.Point(0, 0);
      this.chartPoints.Name = "chartPoints";
      this.chartPoints.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series1.Legend = "Legend1";
      series1.MarkerSize = 10;
      series1.Name = "Series1";
      series1.YValuesPerPoint = 32;
      this.chartPoints.Series.Add(series1);
      this.chartPoints.Size = new System.Drawing.Size(1299, 297);
      this.chartPoints.TabIndex = 15;
      this.chartPoints.Text = "chartPoints";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(121, 12);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dgv);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.chartPoints);
      this.splitContainer1.Size = new System.Drawing.Size(1299, 601);
      this.splitContainer1.SplitterDistance = 300;
      this.splitContainer1.TabIndex = 16;
      // 
      // calc
      // 
      this.calc.Location = new System.Drawing.Point(8, 121);
      this.calc.Name = "calc";
      this.calc.Size = new System.Drawing.Size(108, 23);
      this.calc.TabIndex = 17;
      this.calc.Text = "Рассчитать";
      this.calc.UseVisualStyleBackColor = true;
      this.calc.Click += new System.EventHandler(this.calc_Click_1);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1420, 625);
      this.Controls.Add(this.calc);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.generate);
      this.Controls.Add(this.clean);
      this.Controls.Add(this.calcStep);
      this.Controls.Add(this.nudCount);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Генетический алгоритм";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudCount;
    private System.Windows.Forms.Button calcStep;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.Button clean;
    private System.Windows.Forms.Button generate;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button calc;
  }
}

