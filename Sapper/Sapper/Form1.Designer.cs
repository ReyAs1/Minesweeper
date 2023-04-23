namespace Sapper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldSizeToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // fieldSizeToolStripMenuItem
            // 
            this.fieldSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x100ToolStripMenuItem,
            this.x10ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.x5ToolStripMenuItem1});
            this.fieldSizeToolStripMenuItem.Name = "fieldSizeToolStripMenuItem";
            this.fieldSizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fieldSizeToolStripMenuItem.Text = "Field size";
            // 
            // x100ToolStripMenuItem
            // 
            this.x100ToolStripMenuItem.Name = "x100ToolStripMenuItem";
            this.x100ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x100ToolStripMenuItem.Text = "100X100";
            this.x100ToolStripMenuItem.Click += new System.EventHandler(this.x100ToolStripMenuItem_Click);
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x10ToolStripMenuItem.Text = "10X10";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x5ToolStripMenuItem.Text = "10X18";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem1
            // 
            this.x5ToolStripMenuItem1.Name = "x5ToolStripMenuItem1";
            this.x5ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.x5ToolStripMenuItem1.Text = "5X5";
            this.x5ToolStripMenuItem1.Click += new System.EventHandler(this.x5ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 381);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem1;
    }
}

