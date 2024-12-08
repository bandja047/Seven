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
            mnuClient = new ToolStripMenuItem();
            mnuFournisseur = new ToolStripMenuItem();
            traitementToolStripMenuItem = new ToolStripMenuItem();
            MnuArticles = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, traitementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 2, 0, 2);
            menuStrip1.Size = new Size(883, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuArticle, MnuAchat, MnuVentes, mnuClient, mnuFournisseur });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // MnuArticle
            // 
            MnuArticle.Name = "MnuArticle";
            MnuArticle.Size = new Size(140, 22);
            MnuArticle.Text = "Articles";
            MnuArticle.Click += MnuArticle_Click;
            // 
            // MnuAchat
            // 
            MnuAchat.Name = "MnuAchat";
            MnuAchat.Size = new Size(140, 22);
            MnuAchat.Text = "Achat";
            MnuAchat.Click += MnuAchat_Click;
            // 
            // MnuVentes
            // 
            MnuVentes.Name = "MnuVentes";
            MnuVentes.Size = new Size(140, 22);
            MnuVentes.Text = "Ventes";
            MnuVentes.Click += MnuVentes_Click;
            // 
            // mnuClient
            // 
            mnuClient.Name = "mnuClient";
            mnuClient.Size = new Size(140, 22);
            mnuClient.Text = "Clients";
            mnuClient.Click += mnuClient_Click;
            // 
            // mnuFournisseur
            // 
            mnuFournisseur.Name = "mnuFournisseur";
            mnuFournisseur.Size = new Size(140, 22);
            mnuFournisseur.Text = "Fournisseurs";
            mnuFournisseur.Click += mnuFournisseur_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 426);
            panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(4F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(883, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
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
        private ToolStripMenuItem mnuClient;
        private ToolStripMenuItem mnuFournisseur;
        private Panel panel1;
    }
}