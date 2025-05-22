namespace laboratorna__11
{
    partial class mainForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.базовийКласToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базовийКласToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createMyStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.похіднийКласToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkEqualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divindingNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базовийКласToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 28);
            // 
            // базовийКласToolStripMenuItem
            // 
            this.базовийКласToolStripMenuItem.Name = "базовийКласToolStripMenuItem";
            this.базовийКласToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.базовийКласToolStripMenuItem.Text = "Базовий клас";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базовийКласToolStripMenuItem1,
            this.похіднийКласToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базовийКласToolStripMenuItem1
            // 
            this.базовийКласToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMyStringToolStripMenuItem});
            this.базовийКласToolStripMenuItem1.Name = "базовийКласToolStripMenuItem1";
            this.базовийКласToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.базовийКласToolStripMenuItem1.Text = "Базовий клас";
            // 
            // createMyStringToolStripMenuItem
            // 
            this.createMyStringToolStripMenuItem.Name = "createMyStringToolStripMenuItem";
            this.createMyStringToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.createMyStringToolStripMenuItem.Text = "Створення стрічки ";
            this.createMyStringToolStripMenuItem.Click += new System.EventHandler(this.createMyStringToolStripMenuItem_Click);
            // 
            // похіднийКласToolStripMenuItem
            // 
            this.похіднийКласToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkEqualsToolStripMenuItem,
            this.plusNumberToolStripMenuItem,
            this.minusNumberToolStripMenuItem,
            this.multiplicationNumberToolStripMenuItem,
            this.divindingNumberToolStripMenuItem});
            this.похіднийКласToolStripMenuItem.Name = "похіднийКласToolStripMenuItem";
            this.похіднийКласToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.похіднийКласToolStripMenuItem.Text = "Похідний клас";
            // 
            // checkEqualsToolStripMenuItem
            // 
            this.checkEqualsToolStripMenuItem.Name = "checkEqualsToolStripMenuItem";
            this.checkEqualsToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.checkEqualsToolStripMenuItem.Text = "Перевірка на рівність ";
            this.checkEqualsToolStripMenuItem.Click += new System.EventHandler(this.checkEqualsToolStripMenuItem_Click);
            // 
            // plusNumberToolStripMenuItem
            // 
            this.plusNumberToolStripMenuItem.Name = "plusNumberToolStripMenuItem";
            this.plusNumberToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.plusNumberToolStripMenuItem.Text = "Додавання чисел";
            this.plusNumberToolStripMenuItem.Click += new System.EventHandler(this.plusNumberToolStripMenuItem_Click);
            // 
            // minusNumberToolStripMenuItem
            // 
            this.minusNumberToolStripMenuItem.Name = "minusNumberToolStripMenuItem";
            this.minusNumberToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.minusNumberToolStripMenuItem.Text = "Віднімання чисел";
            this.minusNumberToolStripMenuItem.Click += new System.EventHandler(this.minusNumberToolStripMenuItem_Click);
            // 
            // multiplicationNumberToolStripMenuItem
            // 
            this.multiplicationNumberToolStripMenuItem.Name = "multiplicationNumberToolStripMenuItem";
            this.multiplicationNumberToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.multiplicationNumberToolStripMenuItem.Text = "Множення чисел";
            this.multiplicationNumberToolStripMenuItem.Click += new System.EventHandler(this.multiplicationNumberToolStripMenuItem_Click);
            // 
            // divindingNumberToolStripMenuItem
            // 
            this.divindingNumberToolStripMenuItem.Name = "divindingNumberToolStripMenuItem";
            this.divindingNumberToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.divindingNumberToolStripMenuItem.Text = "Ділення чисел";
            this.divindingNumberToolStripMenuItem.Click += new System.EventHandler(this.divindingNumberToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Лабораторна робота №11";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базовийКласToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базовийКласToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem похіднийКласToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMyStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkEqualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minusNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divindingNumberToolStripMenuItem;
    }
}

