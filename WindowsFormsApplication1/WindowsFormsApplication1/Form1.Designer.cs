namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборОбработкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводРезультатаовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрогреммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(785, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(910, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборОбработкиToolStripMenuItem,
            this.вводДанныхToolStripMenuItem,
            this.выводРезультатаовToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // выборОбработкиToolStripMenuItem
            // 
            this.выборОбработкиToolStripMenuItem.Name = "выборОбработкиToolStripMenuItem";
            this.выборОбработкиToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.выборОбработкиToolStripMenuItem.Text = "Выбор обработки";
            this.выборОбработкиToolStripMenuItem.Click += new System.EventHandler(this.выборОбработкиToolStripMenuItem_Click);
            // 
            // вводДанныхToolStripMenuItem
            // 
            this.вводДанныхToolStripMenuItem.Name = "вводДанныхToolStripMenuItem";
            this.вводДанныхToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.вводДанныхToolStripMenuItem.Text = "Ввод данных";
            this.вводДанныхToolStripMenuItem.Click += new System.EventHandler(this.вводДанныхToolStripMenuItem_Click);
            // 
            // выводРезультатаовToolStripMenuItem
            // 
            this.выводРезультатаовToolStripMenuItem.Name = "выводРезультатаовToolStripMenuItem";
            this.выводРезультатаовToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.выводРезультатаовToolStripMenuItem.Text = "Вывод результатаов";
            this.выводРезультатаовToolStripMenuItem.Click += new System.EventHandler(this.выводРезультатаовToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрогреммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрогреммеToolStripMenuItem
            // 
            this.оПрогреммеToolStripMenuItem.Name = "оПрогреммеToolStripMenuItem";
            this.оПрогреммеToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.оПрогреммеToolStripMenuItem.Text = "О программе";
            this.оПрогреммеToolStripMenuItem.Click += new System.EventHandler(this.оПрогреммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-6, -27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(910, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборОбработкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводРезультатаовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрогреммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

