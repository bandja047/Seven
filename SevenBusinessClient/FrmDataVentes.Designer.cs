namespace MotherStoreBusiness
{
    partial class FrmDataVentes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            BtnAjouter = new Button();
            button2 = new Button();
            BtnModifier = new Button();
            LvVente = new ListView();
            ColHeadReference = new ColumnHeader();
            ColHeadProduits = new ColumnHeader();
            ColHeadDate = new ColumnHeader();
            ColHeadQuantite = new ColumnHeader();
            ColHeadVente = new ColumnHeader();
            ColHeadMontant = new ColumnHeader();
            ColHeadFournisseur = new ColumnHeader();
            ColHeadNumAppro = new ColumnHeader();
            ColHeadFacture = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 0;
            label1.Text = "LISTES DES VENTES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8, 0, 0, 0);
            panel1.Size = new Size(908, 53);
            panel1.TabIndex = 1;
            // 
            // BtnAjouter
            // 
            BtnAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAjouter.BackColor = Color.MediumSeaGreen;
            BtnAjouter.FlatStyle = FlatStyle.Flat;
            BtnAjouter.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAjouter.ForeColor = Color.White;
            BtnAjouter.Location = new Point(799, 59);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(97, 35);
            BtnAjouter.TabIndex = 3;
            BtnAjouter.Text = "Ajouter";
            BtnAjouter.UseVisualStyleBackColor = false;
            BtnAjouter.Click += Ajouter_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(799, 141);
            button2.Name = "button2";
            button2.Size = new Size(97, 35);
            button2.TabIndex = 4;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnModifier
            // 
            BtnModifier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModifier.BackColor = Color.DodgerBlue;
            BtnModifier.FlatStyle = FlatStyle.Flat;
            BtnModifier.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModifier.ForeColor = Color.White;
            BtnModifier.Location = new Point(799, 100);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(97, 35);
            BtnModifier.TabIndex = 5;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = false;
            BtnModifier.Click += Modifier_Click;
            // 
            // LvVente
            // 
            LvVente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LvVente.BorderStyle = BorderStyle.None;
            LvVente.Columns.AddRange(new ColumnHeader[] { ColHeadReference, ColHeadProduits, ColHeadDate, ColHeadQuantite, ColHeadVente, ColHeadMontant, ColHeadFournisseur, ColHeadNumAppro, ColHeadFacture });
            LvVente.Location = new Point(12, 59);
            LvVente.Name = "LvVente";
            LvVente.Size = new Size(781, 430);
            LvVente.TabIndex = 7;
            LvVente.UseCompatibleStateImageBehavior = false;
            LvVente.View = View.Details;
            // 
            // ColHeadReference
            // 
            ColHeadReference.Text = "Reference Produits";
            // 
            // ColHeadProduits
            // 
            ColHeadProduits.Text = "Produits";
            // 
            // ColHeadDate
            // 
            ColHeadDate.Text = "Date";
            // 
            // ColHeadQuantite
            // 
            ColHeadQuantite.Text = "Quantite";
            // 
            // ColHeadVente
            // 
            ColHeadVente.Text = "Prix Vente";
            // 
            // ColHeadMontant
            // 
            ColHeadMontant.Text = "Montant";
            // 
            // ColHeadFournisseur
            // 
            ColHeadFournisseur.Text = "Fournisseur";
            // 
            // ColHeadNumAppro
            // 
            ColHeadNumAppro.Text = "Numero Approvisionnement";
            // 
            // ColHeadFacture
            // 
            ColHeadFacture.Text = "Facture";
            // 
            // FrmDataVentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(908, 560);
            Controls.Add(LvVente);
            Controls.Add(BtnModifier);
            Controls.Add(button2);
            Controls.Add(BtnAjouter);
            Controls.Add(panel1);
            Name = "FrmDataVentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnAjouter;
        private Button button2;
        private Button BtnModifier;
        private ListView LvVente;
        private ColumnHeader ColHeadReference;
        private ColumnHeader ColHeadProduits;
        private ColumnHeader ColHeadDate;
        private ColumnHeader ColHeadQuantite;
        private ColumnHeader ColHeadVente;
        private ColumnHeader ColHeadMontant;
        private ColumnHeader ColHeadFournisseur;
        private ColumnHeader ColHeadNumAppro;
        private ColumnHeader ColHeadFacture;
    }
}
