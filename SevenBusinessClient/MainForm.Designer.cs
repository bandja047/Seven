namespace SevenBusinessClient
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            MnuArticle = new ToolStripMenuItem();
            MnuAchat = new ToolStripMenuItem();
            MnuVentes = new ToolStripMenuItem();
            traitementToolStripMenuItem = new ToolStripMenuItem();
            MnuArticles = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, traitementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuArticle, MnuAchat, MnuVentes });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // MnuArticle
            // 
            MnuArticle.Name = "MnuArticle";
            MnuArticle.Size = new Size(180, 22);
            MnuArticle.Text = "Articles";
            MnuArticle.Click += MnuArticle_Click;
            // 
            // MnuAchat
            // 
            MnuAchat.Name = "MnuAchat";
            MnuAchat.Size = new Size(180, 22);
            MnuAchat.Text = "Achat";
            MnuAchat.Click += MnuAchat_Click;
            // 
            // MnuVentes
            // 
            MnuVentes.Name = "MnuVentes";
            MnuVentes.Size = new Size(180, 22);
            MnuVentes.Text = "Ventes";
            MnuVentes.Click += MnuVentes_Click;
            // 
            // traitementToolStripMenuItem
            // 
            traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            traitementToolStripMenuItem.Size = new Size(75, 20);
            traitementToolStripMenuItem.Text = "Traitement";
            // 
            // MnuArticles
            // 
            MnuArticles.Name = "MnuArticles";
            MnuArticles.Size = new Size(180, 22);
            MnuArticles.Text = "Gestion Article";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Seven";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem traitementToolStripMenuItem;
        private ToolStripMenuItem MnuArticles;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem MnuAchat;
        private ToolStripMenuItem MnuVentes;
        private ToolStripMenuItem MnuArticle;
    }
}