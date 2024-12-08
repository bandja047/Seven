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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            customProgressBar1 = new VerticalProgressBar1();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DtgProduitsAchat = new DataGridView();
            ColHeadProduit = new DataGridViewTextBoxColumn();
            ColHeadMontantV = new DataGridViewTextBoxColumn();
            ColHeadMontantA = new DataGridViewTextBoxColumn();
            ColHeadBenef = new DataGridViewTextBoxColumn();
            panel11 = new Panel();
            label14 = new Label();
            progressBar5 = new CustomProgressBar();
            label15 = new Label();
            label16 = new Label();
            panel12 = new Panel();
            panel9 = new Panel();
            label11 = new Label();
            progressBar4 = new CustomProgressBar();
            label12 = new Label();
            label13 = new Label();
            panel10 = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            progressBar3 = new CustomProgressBar();
            label9 = new Label();
            label10 = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            progressBar2 = new CustomProgressBar();
            label6 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            progressBar1 = new CustomProgressBar();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgProduitsAchat).BeginInit();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, traitementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 2, 0, 2);
            menuStrip1.Size = new Size(1924, 24);
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
            panel1.Controls.Add(customProgressBar1);
            panel1.Controls.Add(dataGridView4);
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(DtgProduitsAchat);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 578);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // customProgressBar1
            // 
            customProgressBar1.AccessibleRole = AccessibleRole.None;
            customProgressBar1.BackColor = Color.Yellow;
            customProgressBar1.Location = new Point(443, 349);
            customProgressBar1.Name = "customProgressBar1";
            customProgressBar1.Size = new Size(28, 150);
            customProgressBar1.TabIndex = 3;
            customProgressBar1.Value = 50;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.ColumnHeadersHeight = 35;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20 });
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.GridColor = Color.White;
            dataGridView4.Location = new Point(1577, 190);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.Size = new Size(278, 209);
            dataGridView4.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Reference";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Produits";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Quantite";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "PrixUnitaire";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Montant";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 192);
            dataGridViewCellStyle2.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.ColumnHeadersHeight = 35;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15 });
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.White;
            dataGridView3.Location = new Point(1260, 190);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(278, 209);
            dataGridView3.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Reference";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Produits";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Quantite";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "PrixUnitaire";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Montant";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(943, 190);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(278, 209);
            dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Reference";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Produits";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Quantite";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "PrixUnitaire";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Montant";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(626, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(278, 209);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Reference";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Produits";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantite";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "PrixUnitaire";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Montant";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DtgProduitsAchat
            // 
            DtgProduitsAchat.AllowUserToAddRows = false;
            DtgProduitsAchat.AllowUserToDeleteRows = false;
            DtgProduitsAchat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgProduitsAchat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgProduitsAchat.BackgroundColor = Color.White;
            DtgProduitsAchat.BorderStyle = BorderStyle.None;
            DtgProduitsAchat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LimeGreen;
            dataGridViewCellStyle5.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DtgProduitsAchat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DtgProduitsAchat.ColumnHeadersHeight = 35;
            DtgProduitsAchat.Columns.AddRange(new DataGridViewColumn[] { ColHeadProduit, ColHeadMontantV, ColHeadMontantA, ColHeadBenef });
            DtgProduitsAchat.EnableHeadersVisualStyles = false;
            DtgProduitsAchat.GridColor = Color.White;
            DtgProduitsAchat.Location = new Point(309, 190);
            DtgProduitsAchat.Name = "DtgProduitsAchat";
            DtgProduitsAchat.RowHeadersVisible = false;
            DtgProduitsAchat.Size = new Size(278, 209);
            DtgProduitsAchat.TabIndex = 8;
            // 
            // ColHeadProduit
            // 
            ColHeadProduit.HeaderText = "Produits";
            ColHeadProduit.Name = "ColHeadProduit";
            // 
            // ColHeadMontantV
            // 
            ColHeadMontantV.HeaderText = "Montant Vendu";
            ColHeadMontantV.Name = "ColHeadMontantV";
            // 
            // ColHeadMontantA
            // 
            ColHeadMontantA.HeaderText = "Montant Achete";
            ColHeadMontantA.Name = "ColHeadMontantA";
            ColHeadMontantA.ReadOnly = true;
            // 
            // ColHeadBenef
            // 
            ColHeadBenef.HeaderText = "Benefice";
            ColHeadBenef.Name = "ColHeadBenef";
            ColHeadBenef.ReadOnly = true;
            // 
            // panel11
            // 
            panel11.BackColor = Color.WhiteSmoke;
            panel11.Controls.Add(label14);
            panel11.Controls.Add(progressBar5);
            panel11.Controls.Add(label15);
            panel11.Controls.Add(label16);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(1577, 15);
            panel11.Name = "panel11";
            panel11.Size = new Size(278, 130);
            panel11.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(226, 82);
            label14.Name = "label14";
            label14.Size = new Size(30, 18);
            label14.TabIndex = 2;
            label14.Text = "50%";
            // 
            // progressBar5
            // 
            progressBar5.AccessibleRole = AccessibleRole.None;
            progressBar5.BackColor = SystemColors.Highlight;
            progressBar5.Location = new Point(22, 87);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(188, 13);
            progressBar5.TabIndex = 1;
            progressBar5.Value = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(22, 56);
            label15.Name = "label15";
            label15.Size = new Size(101, 24);
            label15.TabIndex = 1;
            label15.Text = "4 000 000 FCFA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(22, 13);
            label16.Name = "label16";
            label16.Size = new Size(74, 18);
            label16.TabIndex = 1;
            label16.Text = "Revenu Total";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Highlight;
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(5, 130);
            panel12.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Controls.Add(label11);
            panel9.Controls.Add(progressBar4);
            panel9.Controls.Add(label12);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(1260, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(278, 130);
            panel9.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(192, 0, 192);
            label11.Location = new Point(226, 82);
            label11.Name = "label11";
            label11.Size = new Size(30, 18);
            label11.TabIndex = 2;
            label11.Text = "50%";
            // 
            // progressBar4
            // 
            progressBar4.AccessibleRole = AccessibleRole.None;
            progressBar4.BackColor = Color.FromArgb(192, 0, 192);
            progressBar4.ForeColor = Color.FromArgb(192, 0, 192);
            progressBar4.Location = new Point(22, 87);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(188, 13);
            progressBar4.TabIndex = 1;
            progressBar4.Value = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 56);
            label12.Name = "label12";
            label12.Size = new Size(101, 24);
            label12.TabIndex = 1;
            label12.Text = "4 000 000 FCFA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(22, 13);
            label13.Name = "label13";
            label13.Size = new Size(74, 18);
            label13.TabIndex = 1;
            label13.Text = "Revenu Total";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(192, 0, 192);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 130);
            panel10.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(progressBar3);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(943, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(278, 130);
            panel7.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(226, 82);
            label8.Name = "label8";
            label8.Size = new Size(30, 18);
            label8.TabIndex = 2;
            label8.Text = "50%";
            // 
            // progressBar3
            // 
            progressBar3.AccessibleRole = AccessibleRole.None;
            progressBar3.BackColor = Color.FromArgb(255, 128, 0);
            progressBar3.ForeColor = Color.FromArgb(255, 128, 0);
            progressBar3.Location = new Point(22, 87);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(188, 13);
            progressBar3.TabIndex = 1;
            progressBar3.Value = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 56);
            label9.Name = "label9";
            label9.Size = new Size(101, 24);
            label9.TabIndex = 1;
            label9.Text = "4 000 000 FCFA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(22, 13);
            label10.Name = "label10";
            label10.Size = new Size(74, 18);
            label10.TabIndex = 1;
            label10.Text = "Revenu Total";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 128, 0);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 130);
            panel8.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(progressBar2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(626, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 130);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(226, 82);
            label5.Name = "label5";
            label5.Size = new Size(30, 18);
            label5.TabIndex = 2;
            label5.Text = "50%";
            // 
            // progressBar2
            // 
            progressBar2.AccessibleRole = AccessibleRole.None;
            progressBar2.BackColor = Color.FromArgb(255, 128, 0);
            progressBar2.ForeColor = Color.FromArgb(255, 128, 0);
            progressBar2.Location = new Point(22, 87);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(188, 13);
            progressBar2.TabIndex = 1;
            progressBar2.Value = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 56);
            label6.Name = "label6";
            label6.Size = new Size(101, 24);
            label6.TabIndex = 1;
            label6.Text = "4 000 000 FCFA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(22, 13);
            label7.Name = "label7";
            label7.Size = new Size(74, 18);
            label7.TabIndex = 1;
            label7.Text = "Revenu Total";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 130);
            panel6.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(70, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 130);
            panel4.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.DodgerBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tous Les Mois", "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" });
            comboBox1.Location = new Point(15, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 32);
            comboBox1.TabIndex = 2;
            comboBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(15, 13);
            label4.Name = "label4";
            label4.Size = new Size(31, 18);
            label4.TabIndex = 3;
            label4.Text = "Mois";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(309, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 130);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(226, 82);
            label3.Name = "label3";
            label3.Size = new Size(30, 18);
            label3.TabIndex = 2;
            label3.Text = "50%";
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.AccessibleRole = AccessibleRole.None;
            progressBar1.BackColor = Color.LimeGreen;
            progressBar1.Location = new Point(22, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(188, 13);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 50;
            progressBar1.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 56);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 1;
            label2.Text = "4 000 000 FCFA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 1;
            label1.Text = "Revenu Total";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 130);
            panel3.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(4F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1924, 602);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgProduitsAchat).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Panel panel3;
        private CustomProgressBar progressBar1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel11;
        private Label label14;
        private CustomProgressBar progressBar5;
        private Label label15;
        private Label label16;
        private Panel panel12;
        private Panel panel9;
        private Label label11;
        private CustomProgressBar progressBar4;
        private Label label12;
        private Label label13;
        private Panel panel10;
        private Panel panel7;
        private Label label8;
        private CustomProgressBar progressBar3;
        private Label label9;
        private Label label10;
        private Panel panel8;
        private Panel panel5;
        private Label label5;
        private CustomProgressBar progressBar2;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private DataGridView DtgProduitsAchat;
        private DataGridViewTextBoxColumn ColHeadReference;
        private DataGridViewTextBoxColumn ColHeadProduit;
        private DataGridViewTextBoxColumn ColHeadQuantite;
        private DataGridViewTextBoxColumn ColHeadPU;
        private DataGridViewTextBoxColumn ColHeadMontant;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn ColHeadMontantV;
        private DataGridViewTextBoxColumn ColHeadMontantA;
        private DataGridViewTextBoxColumn ColHeadBenef;
        private VerticalProgressBar1 customProgressBar1;
    }
}