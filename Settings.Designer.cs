namespace TimeWidget
{
    partial class Settings
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
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonWidgetColor = new System.Windows.Forms.Button();
            this.buttonTextColor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFonts = new System.Windows.Forms.ComboBox();
            this.checkBoxRunWithWindows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTopMost.Location = new System.Drawing.Point(12, 12);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(156, 24);
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.Text = "По верх все окон";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // buttonWidgetColor
            // 
            this.buttonWidgetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWidgetColor.Location = new System.Drawing.Point(318, 12);
            this.buttonWidgetColor.Name = "buttonWidgetColor";
            this.buttonWidgetColor.Size = new System.Drawing.Size(119, 40);
            this.buttonWidgetColor.TabIndex = 2;
            this.buttonWidgetColor.Text = "Сменить цвет виджета";
            this.buttonWidgetColor.UseVisualStyleBackColor = true;
            this.buttonWidgetColor.Click += new System.EventHandler(this.ButtonWidgetColor_Click);
            // 
            // buttonTextColor
            // 
            this.buttonTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTextColor.Location = new System.Drawing.Point(193, 12);
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.Size = new System.Drawing.Size(119, 40);
            this.buttonTextColor.TabIndex = 3;
            this.buttonTextColor.Text = "Сменить цвет времени\r\n";
            this.buttonTextColor.UseVisualStyleBackColor = true;
            this.buttonTextColor.Click += new System.EventHandler(this.ButtonTextColor_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "24 часовой",
            "12 часовой",
            "Без секунд (12)",
            "Без секунд (24)"});
            this.comboBox1.Location = new System.Drawing.Point(316, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "BZH Studio © 2020 - 2021";
            // 
            // comboBoxFonts
            // 
            this.comboBoxFonts.FormattingEnabled = true;
            this.comboBoxFonts.Location = new System.Drawing.Point(281, 99);
            this.comboBoxFonts.Name = "comboBoxFonts";
            this.comboBoxFonts.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFonts.TabIndex = 12;
            this.comboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonts_SelectedIndexChanged);
            // 
            // checkBoxRunWithWindows
            // 
            this.checkBoxRunWithWindows.AutoSize = true;
            this.checkBoxRunWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxRunWithWindows.Location = new System.Drawing.Point(12, 42);
            this.checkBoxRunWithWindows.Name = "checkBoxRunWithWindows";
            this.checkBoxRunWithWindows.Size = new System.Drawing.Size(188, 24);
            this.checkBoxRunWithWindows.TabIndex = 13;
            this.checkBoxRunWithWindows.Text = "Запустить с Windows";
            this.checkBoxRunWithWindows.UseVisualStyleBackColor = true;
            this.checkBoxRunWithWindows.CheckedChanged += new System.EventHandler(this.checkBoxRunWithWindows_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 206);
            this.Controls.Add(this.comboBoxFonts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonTextColor);
            this.Controls.Add(this.buttonWidgetColor);
            this.Controls.Add(this.checkBoxTopMost);
            this.Controls.Add(this.checkBoxRunWithWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonWidgetColor;
        private System.Windows.Forms.Button buttonTextColor;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.CheckBox checkBoxTopMost;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxFonts;
        public System.Windows.Forms.CheckBox checkBoxRunWithWindows;
    }
}