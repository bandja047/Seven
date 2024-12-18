namespace MotherStoreBusiness
{
    partial class FrmSaisieAchat
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
            gbCategorie = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            panel5 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            gbProduits = new GroupBox();
            BtnModifier = new Button();
            checkedListBox1 = new CheckedListBox();
            panel6 = new Panel();
            textBox2 = new TextBox();
            panel7 = new Panel();
            label4 = new Label();
            gbFournisseurs = new GroupBox();
            comboBox1 = new ComboBox();
            gbMontantFournisseurs = new GroupBox();
            panel10 = new Panel();
            textBox4 = new TextBox();
            panel9 = new Panel();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox5 = new GroupBox();
            DtgProduitsAchat = new DataGridView();
            ColHeadReference = new DataGridViewTextBoxColumn();
            ColHeadProduit = new DataGridViewTextBoxColumn();
            ColHeadQuantite = new DataGridViewTextBoxColumn();
            ColHeadPU = new DataGridViewTextBoxColumn();
            ColHeadMontant = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            label2 = new Label();
            BtnAjouter = new Button();
            gbRecapAchat = new GroupBox();
            panel8 = new Panel();
            textBox6 = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            textBox5 = new TextBox();
            label1 = new Label();
            gbCategorie.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            gbProduits.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            gbFournisseurs.SuspendLayout();
            gbMontantFournisseurs.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgProduitsAchat).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbRecapAchat.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // gbCategorie
            // 
            gbCategorie.Controls.Add(checkedListBox2);
            gbCategorie.Controls.Add(panel5);
            gbCategorie.Controls.Add(panel4);
            gbCategorie.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCategorie.Location = new Point(12, 62);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Size = new Size(227, 195);
            gbCategorie.TabIndex = 0;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "Categorie";
            gbCategorie.Enter += gbCategorie_Enter;
            // 
            // checkedListBox2
            // 
            checkedListBox2.Dock = DockStyle.Bottom;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Alimentation", "Cosmetique", "Transport", "Energie" });
            checkedListBox2.Location = new Point(3, 68);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(221, 124);
            checkedListBox2.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(90, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(131, 35);
            panel5.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 18);
            textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(6, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(78, 35);
            panel4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 8);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 5;
            label3.Text = "Recherche :";
            // 
            // gbProduits
            // 
            gbProduits.Controls.Add(BtnModifier);
            gbProduits.Controls.Add(checkedListBox1);
            gbProduits.Controls.Add(panel6);
            gbProduits.Controls.Add(panel7);
            gbProduits.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbProduits.Location = new Point(12, 263);
            gbProduits.Name = "gbProduits";
            gbProduits.Size = new Size(227, 352);
            gbProduits.TabIndex = 1;
            gbProduits.TabStop = false;
            gbProduits.Text = "Produits";
            // 
            // BtnModifier
            // 
            BtnModifier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModifier.BackColor = Color.DodgerBlue;
            BtnModifier.FlatStyle = FlatStyle.Flat;
            BtnModifier.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModifier.ForeColor = Color.White;
            BtnModifier.Location = new Point(126, 312);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(97, 35);
            BtnModifier.TabIndex = 10;
            BtnModifier.Text = "Ajouter";
            BtnModifier.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Yaourt", "Huile", "Voiture", "Gaz" });
            checkedListBox1.Location = new Point(10, 65);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(213, 244);
            checkedListBox1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(91, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(131, 35);
            panel6.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Bottom;
            textBox2.Location = new Point(0, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 18);
            textBox2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RosyBrown;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(7, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(78, 35);
            panel7.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 8);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 5;
            label4.Text = "Recherche :";
            // 
            // gbFournisseurs
            // 
            gbFournisseurs.Controls.Add(comboBox1);
            gbFournisseurs.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFournisseurs.Location = new Point(245, 62);
            gbFournisseurs.Name = "gbFournisseurs";
            gbFournisseurs.Size = new Size(633, 55);
            gbFournisseurs.TabIndex = 2;
            gbFournisseurs.TabStop = false;
            gbFournisseurs.Text = "Fournisseurs";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(0, 192, 192);
            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(619, 26);
            comboBox1.TabIndex = 1;
            // 
            // gbMontantFournisseurs
            // 
            gbMontantFournisseurs.Controls.Add(panel10);
            gbMontantFournisseurs.Controls.Add(panel9);
            gbMontantFournisseurs.Controls.Add(label7);
            gbMontantFournisseurs.Controls.Add(label6);
            gbMontantFournisseurs.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbMontantFournisseurs.Location = new Point(245, 461);
            gbMontantFournisseurs.Name = "gbMontantFournisseurs";
            gbMontantFournisseurs.Size = new Size(633, 106);
            gbMontantFournisseurs.TabIndex = 3;
            gbMontantFournisseurs.TabStop = false;
            gbMontantFournisseurs.Text = "Payé au fournisseur";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(textBox4);
            panel10.Location = new Point(353, 63);
            panel10.Name = "panel10";
            panel10.Size = new Size(255, 35);
            panel10.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Dock = DockStyle.Bottom;
            textBox4.Location = new Point(0, 13);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(251, 18);
            textBox4.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(textBox3);
            panel9.Location = new Point(353, 21);
            panel9.Name = "panel9";
            panel9.Size = new Size(255, 35);
            panel9.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Bottom;
            textBox3.Location = new Point(0, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 18);
            textBox3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 69);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 7;
            label7.Text = "Reste A Payer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 27);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 5;
            label6.Text = "Montant Payé";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DtgProduitsAchat);
            groupBox5.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(245, 123);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(633, 233);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Liste Des Produits Achete";
            // 
            // DtgProduitsAchat
            // 
            DtgProduitsAchat.AllowUserToAddRows = false;
            DtgProduitsAchat.AllowUserToDeleteRows = false;
            DtgProduitsAchat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgProduitsAchat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgProduitsAchat.BackgroundColor = Color.White;
            DtgProduitsAchat.BorderStyle = BorderStyle.None;
            DtgProduitsAchat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DtgProduitsAchat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgProduitsAchat.Columns.AddRange(new DataGridViewColumn[] { ColHeadReference, ColHeadProduit, ColHeadQuantite, ColHeadPU, ColHeadMontant });
            DtgProduitsAchat.GridColor = Color.White;
            DtgProduitsAchat.Location = new Point(3, 21);
            DtgProduitsAchat.Name = "DtgProduitsAchat";
            DtgProduitsAchat.Size = new Size(627, 209);
            DtgProduitsAchat.TabIndex = 1;
            // 
            // ColHeadReference
            // 
            ColHeadReference.HeaderText = "Reference";
            ColHeadReference.Name = "ColHeadReference";
            ColHeadReference.ReadOnly = true;
            // 
            // ColHeadProduit
            // 
            ColHeadProduit.HeaderText = "Produits";
            ColHeadProduit.Name = "ColHeadProduit";
            // 
            // ColHeadQuantite
            // 
            ColHeadQuantite.HeaderText = "Quantite";
            ColHeadQuantite.Name = "ColHeadQuantite";
            // 
            // ColHeadPU
            // 
            ColHeadPU.HeaderText = "PrixUnitaire";
            ColHeadPU.Name = "ColHeadPU";
            ColHeadPU.ReadOnly = true;
            // 
            // ColHeadMontant
            // 
            ColHeadMontant.HeaderText = "Montant";
            ColHeadMontant.Name = "ColHeadMontant";
            ColHeadMontant.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(BtnAjouter);
            panel1.Location = new Point(245, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 42);
            panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(108, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(99, 35);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 8);
            label2.Name = "label2";
            label2.Size = new Size(30, 18);
            label2.TabIndex = 5;
            label2.Text = "Date";
            // 
            // BtnAjouter
            // 
            BtnAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAjouter.BackColor = Color.MediumSeaGreen;
            BtnAjouter.FlatStyle = FlatStyle.Flat;
            BtnAjouter.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAjouter.ForeColor = Color.White;
            BtnAjouter.Location = new Point(533, 4);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(97, 35);
            BtnAjouter.TabIndex = 4;
            BtnAjouter.Text = "Enregistrer";
            BtnAjouter.UseVisualStyleBackColor = false;
            BtnAjouter.Click += BtnAjouter_Click;
            // 
            // gbRecapAchat
            // 
            gbRecapAchat.Controls.Add(panel8);
            gbRecapAchat.Controls.Add(label5);
            gbRecapAchat.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbRecapAchat.Location = new Point(245, 362);
            gbRecapAchat.Name = "gbRecapAchat";
            gbRecapAchat.Size = new Size(633, 93);
            gbRecapAchat.TabIndex = 4;
            gbRecapAchat.TabStop = false;
            gbRecapAchat.Text = "Reacapitulatif de L'achat";
            gbRecapAchat.Enter += gbRecapAchat_Enter;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(textBox6);
            panel8.Location = new Point(355, 35);
            panel8.Name = "panel8";
            panel8.Size = new Size(255, 35);
            panel8.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Dock = DockStyle.Bottom;
            textBox6.Location = new Point(0, 13);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(251, 18);
            textBox6.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 45);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 3;
            label5.Text = "Montant";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 0, 0, 0);
            panel2.Size = new Size(866, 53);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(624, 13);
            label9.Name = "label9";
            label9.Size = new Size(54, 18);
            label9.TabIndex = 6;
            label9.Text = "Numero :";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(684, 11);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 23);
            textBox5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 0;
            label1.Text = "FICHE ENREGISTREMENT ACHATS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmSaisieAchat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(890, 630);
            Controls.Add(panel2);
            Controls.Add(gbRecapAchat);
            Controls.Add(panel1);
            Controls.Add(gbMontantFournisseurs);
            Controls.Add(groupBox5);
            Controls.Add(gbFournisseurs);
            Controls.Add(gbProduits);
            Controls.Add(gbCategorie);
            Name = "FrmSaisieAchat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Achats";
            gbCategorie.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            gbProduits.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            gbFournisseurs.ResumeLayout(false);
            gbMontantFournisseurs.ResumeLayout(false);
            gbMontantFournisseurs.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtgProduitsAchat).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbRecapAchat.ResumeLayout(false);
            gbRecapAchat.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCategorie;
        private GroupBox gbProduits;
        private GroupBox gbFournisseurs;
        private GroupBox gbMontantFournisseurs;
        private GroupBox groupBox5;
        private Panel panel1;
        private GroupBox gbRecapAchat;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button BtnAjouter;
        private DateTimePicker dateTimePicker1;
        private Panel panel5;
        private TextBox textBox1;
        private Panel panel4;
        private Label label3;
        private Panel panel6;
        private TextBox textBox2;
        private Panel panel7;
        private Label label4;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel10;
        private TextBox textBox4;
        private Panel panel9;
        private TextBox textBox3;
        private Panel panel8;
        private TextBox textBox6;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private Button BtnModifier;
        private DataGridView DtgProduitsAchat;
        private DataGridViewTextBoxColumn ColHeadReference;
        private DataGridViewTextBoxColumn ColHeadProduit;
        private DataGridViewTextBoxColumn ColHeadQuantite;
        private DataGridViewTextBoxColumn ColHeadPU;
        private DataGridViewTextBoxColumn ColHeadMontant;
        private Label label9;
        private TextBox textBox5;
    }
}