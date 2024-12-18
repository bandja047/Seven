namespace MotherStoreBusiness
{
    partial class CategorieEntryView
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
            txtName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtDescription = new RichTextBox();
            label6 = new Label();
            cmbCategorie = new ComboBox();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtReference = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(36, 18);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 112);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(123, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(255, 138);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 70);
            label6.Name = "label6";
            label6.Size = new Size(41, 18);
            label6.TabIndex = 11;
            label6.Text = "Parent";
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(123, 70);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(257, 23);
            cmbCategorie.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(cmbCategorie);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 302);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information sur les categories";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(351, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 35);
            btnSave.TabIndex = 17;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(248, 433);
            button2.Name = "button2";
            button2.Size = new Size(97, 35);
            button2.TabIndex = 18;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtReference
            // 
            txtReference.Location = new Point(125, 15);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(255, 23);
            txtReference.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 17);
            label8.Name = "label8";
            label8.Size = new Size(59, 18);
            label8.TabIndex = 18;
            label8.Text = "Reference";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(txtReference);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(17, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 53);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 0, 0, 0);
            panel2.Size = new Size(460, 53);
            panel2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 0);
            label9.Name = "label9";
            label9.Size = new Size(195, 31);
            label9.TabIndex = 0;
            label9.Text = "FICHE ENREGISTREMENT";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(17, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(426, 302);
            panel3.TabIndex = 21;
            // 
            // CategorieEntryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 489);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CategorieEntryView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Saisie Categorie";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label4;
        private RichTextBox txtDescription;
        private Label label6;
        private ComboBox cmbCategorie;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtReference;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Panel panel3;
    }
}