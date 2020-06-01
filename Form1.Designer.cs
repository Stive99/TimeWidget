namespace TimeWidget
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поВерхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВерхВсехОконToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            // 
            // поВерхВсехОконToolStripMenuItem
            // 
            this.поВерхВсехОконToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вклToolStripMenuItem,
            this.выклToolStripMenuItem});
            this.поВерхВсехОконToolStripMenuItem.Name = "поВерхВсехОконToolStripMenuItem";
            this.поВерхВсехОконToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.поВерхВсехОконToolStripMenuItem.Text = "По верх всех окон";
            // 
            // вклToolStripMenuItem
            // 
            this.вклToolStripMenuItem.Name = "вклToolStripMenuItem";
            this.вклToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.вклToolStripMenuItem.Text = "Вкл";
            this.вклToolStripMenuItem.Click += new System.EventHandler(this.вклToolStripMenuItem_Click);
            // 
            // выклToolStripMenuItem
            // 
            this.выклToolStripMenuItem.Name = "выклToolStripMenuItem";
            this.выклToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.выклToolStripMenuItem.Text = "Выкл";
            this.выклToolStripMenuItem.Click += new System.EventHandler(this.выклToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 42);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseDown);
            this.labelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseMove);
            this.labelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseUp);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(191, 59);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeWidget";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поВерхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вклToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выклToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
    }
}

