namespace lab1filters
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.повышеннаяЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.размытиеПоГауссуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button1 = new System.Windows.Forms.Button();
      this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.button2 = new System.Windows.Forms.Button();
      this.операцииМатморфологииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(12, 21);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1561, 554);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.операцииМатморфологииToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1585, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // фильтрыToolStripMenuItem
      // 
      this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
      this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
      this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.фильтрыToolStripMenuItem.Text = "Фильтры";
      // 
      // точечныеToolStripMenuItem
      // 
      this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.повышеннаяЯркостьToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem});
      this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
      this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.точечныеToolStripMenuItem.Text = "Точечные";
      // 
      // инверсияToolStripMenuItem
      // 
      this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
      this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.инверсияToolStripMenuItem.Text = "Инверсия";
      this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
      // 
      // оттенкиСерогоToolStripMenuItem
      // 
      this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
      this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
      this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
      // 
      // сепияToolStripMenuItem
      // 
      this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
      this.сепияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.сепияToolStripMenuItem.Text = "Сепия";
      this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
      // 
      // повышеннаяЯркостьToolStripMenuItem
      // 
      this.повышеннаяЯркостьToolStripMenuItem.Name = "повышеннаяЯркостьToolStripMenuItem";
      this.повышеннаяЯркостьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.повышеннаяЯркостьToolStripMenuItem.Text = "Повышенная яркость";
      this.повышеннаяЯркостьToolStripMenuItem.Click += new System.EventHandler(this.повышеннаяЯркостьToolStripMenuItem_Click);
      // 
      // матричныеToolStripMenuItem
      // 
      this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.размытиеПоГауссуToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem});
      this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
      this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.матричныеToolStripMenuItem.Text = "Матричные";
      // 
      // размытиеToolStripMenuItem
      // 
      this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
      this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.размытиеToolStripMenuItem.Text = "Размытие";
      this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
      // 
      // размытиеПоГауссуToolStripMenuItem
      // 
      this.размытиеПоГауссуToolStripMenuItem.Name = "размытиеПоГауссуToolStripMenuItem";
      this.размытиеПоГауссуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.размытиеПоГауссуToolStripMenuItem.Text = "Размытие по Гауссу";
      this.размытиеПоГауссуToolStripMenuItem.Click += new System.EventHandler(this.размытиеПоГауссуToolStripMenuItem_Click);
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.WorkerSupportsCancellation = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 581);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(1453, 23);
      this.progressBar1.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(1471, 581);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(87, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Отмена";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // фильтрСобеляToolStripMenuItem
      // 
      this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
      this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
      this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляToolStripMenuItem_Click_1);
      // 
      // резкостьToolStripMenuItem
      // 
      this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
      this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.резкостьToolStripMenuItem.Text = "Резкость";
      this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
      // 
      // тиснениеToolStripMenuItem
      // 
      this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
      this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.тиснениеToolStripMenuItem.Text = "Тиснение";
      this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
      // 
      // идеальныйОтражательToolStripMenuItem
      // 
      this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
      this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
      this.идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
      this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem_Click);
      // 
      // эффектСтеклаToolStripMenuItem
      // 
      this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
      this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
      this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
      this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(1480, 27);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(78, 25);
      this.button2.TabIndex = 6;
      this.button2.Text = "Сохранить";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // операцииМатморфологииToolStripMenuItem
      // 
      this.операцииМатморфологииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradientToolStripMenuItem});
      this.операцииМатморфологииToolStripMenuItem.Name = "операцииМатморфологииToolStripMenuItem";
      this.операцииМатморфологииToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
      this.операцииМатморфологииToolStripMenuItem.Text = "Операции мат.морфологии";
      // 
      // dilationToolStripMenuItem
      // 
      this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
      this.dilationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.dilationToolStripMenuItem.Text = "Dilation";
      this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
      // 
      // erosionToolStripMenuItem
      // 
      this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
      this.erosionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.erosionToolStripMenuItem.Text = "Erosion";
      this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
      // 
      // openingToolStripMenuItem
      // 
      this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
      this.openingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.openingToolStripMenuItem.Text = "Opening";
      this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
      // 
      // closingToolStripMenuItem
      // 
      this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
      this.closingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.closingToolStripMenuItem.Text = "Closing";
      this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
      // 
      // gradientToolStripMenuItem
      // 
      this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
      this.gradientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.gradientToolStripMenuItem.Text = "Gradient";
      this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
      // 
      // медианныйФильтрToolStripMenuItem
      // 
      this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
      this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
      this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1585, 616);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem размытиеПоГауссуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem повышеннаяЯркостьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ToolStripMenuItem операцииМатморфологииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
  }
}

