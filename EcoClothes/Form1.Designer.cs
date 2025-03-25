namespace EcoClothes
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поръчкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фактуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.служителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.куриериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(53, 103);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 96);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Продукти";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.ContextMenuStrip = this.contextMenuStrip1;
            this.metroButton2.Location = new System.Drawing.Point(223, 103);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(139, 96);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Поръчки";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.ContextMenuStrip = this.contextMenuStrip2;
            this.metroButton3.Location = new System.Drawing.Point(403, 103);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(309, 46);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Друго";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поръчкиToolStripMenuItem,
            this.фактуриToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 52);
            // 
            // поръчкиToolStripMenuItem
            // 
            this.поръчкиToolStripMenuItem.Name = "поръчкиToolStripMenuItem";
            this.поръчкиToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.поръчкиToolStripMenuItem.Text = "Поръчки";
            this.поръчкиToolStripMenuItem.Click += new System.EventHandler(this.поръчкиToolStripMenuItem_Click);
            // 
            // фактуриToolStripMenuItem
            // 
            this.фактуриToolStripMenuItem.Name = "фактуриToolStripMenuItem";
            this.фактуриToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.фактуриToolStripMenuItem.Text = "Фактури";
            this.фактуриToolStripMenuItem.Click += new System.EventHandler(this.фактуриToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.служителиToolStripMenuItem,
            this.куриериToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(154, 52);
            // 
            // служителиToolStripMenuItem
            // 
            this.служителиToolStripMenuItem.Name = "служителиToolStripMenuItem";
            this.служителиToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.служителиToolStripMenuItem.Text = "Служители";
            this.служителиToolStripMenuItem.Click += new System.EventHandler(this.служителиToolStripMenuItem_Click);
            // 
            // куриериToolStripMenuItem
            // 
            this.куриериToolStripMenuItem.Name = "куриериToolStripMenuItem";
            this.куриериToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.куриериToolStripMenuItem.Text = "Куриери";
            this.куриериToolStripMenuItem.Click += new System.EventHandler(this.куриериToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поръчкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фактуриToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem служителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem куриериToolStripMenuItem;
    }
}

