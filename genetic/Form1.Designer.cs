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
      this.label1 = new System.Windows.Forms.Label();
      this.nudCount = new System.Windows.Forms.NumericUpDown();
      this.calc = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.clean = new System.Windows.Forms.Button();
      this.generate = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(161, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Количество особей:";
      // 
      // nudCount
      // 
      this.nudCount.Location = new System.Drawing.Point(12, 37);
      this.nudCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.nudCount.Name = "nudCount";
      this.nudCount.Size = new System.Drawing.Size(162, 26);
      this.nudCount.TabIndex = 2;
      this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // calc
      // 
      this.calc.Location = new System.Drawing.Point(12, 112);
      this.calc.Name = "calc";
      this.calc.Size = new System.Drawing.Size(162, 37);
      this.calc.TabIndex = 10;
      this.calc.Text = "Рассчитать";
      this.calc.UseVisualStyleBackColor = true;
      this.calc.Click += new System.EventHandler(this.calc_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(245, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 20);
      this.label3.TabIndex = 11;
      this.label3.Text = "Результаты:";
      // 
      // dgv
      // 
      this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Location = new System.Drawing.Point(249, 37);
      this.dgv.Name = "dgv";
      this.dgv.RowTemplate.Height = 28;
      this.dgv.Size = new System.Drawing.Size(757, 401);
      this.dgv.TabIndex = 12;
      // 
      // clean
      // 
      this.clean.Location = new System.Drawing.Point(12, 155);
      this.clean.Name = "clean";
      this.clean.Size = new System.Drawing.Size(162, 37);
      this.clean.TabIndex = 13;
      this.clean.Text = "Очистить";
      this.clean.UseVisualStyleBackColor = true;
      this.clean.Click += new System.EventHandler(this.clean_Click);
      // 
      // generate
      // 
      this.generate.Location = new System.Drawing.Point(12, 69);
      this.generate.Name = "generate";
      this.generate.Size = new System.Drawing.Size(162, 37);
      this.generate.TabIndex = 14;
      this.generate.Text = "Сгенерировать";
      this.generate.UseVisualStyleBackColor = true;
      this.generate.Click += new System.EventHandler(this.generate_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1018, 450);
      this.Controls.Add(this.generate);
      this.Controls.Add(this.clean);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.calc);
      this.Controls.Add(this.nudCount);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Генетический алгоритм";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudCount;
    private System.Windows.Forms.Button calc;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.Button clean;
    private System.Windows.Forms.Button generate;
  }
}

