namespace SevenBusinessClient
{
    partial class FrmSaisieArticle
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            BtnAddCategorie = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox6 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 1;
            label1.Text = "Designation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 3;
            label2.Text = "Prix Achat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(515, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 32);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 5;
            label3.Text = "Prix Vente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(515, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 4;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(123, 112);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(255, 138);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 70);
            label6.Name = "label6";
            label6.Size = new Size(56, 18);
            label6.TabIndex = 11;
            label6.Text = "Categorie";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 23);
            comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAddCategorie);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 286);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information sur l'article";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnAddCategorie
            // 
            BtnAddCategorie.BackColor = Color.White;
            BtnAddCategorie.FlatAppearance.BorderColor = Color.White;
            BtnAddCategorie.FlatStyle = FlatStyle.Flat;
            BtnAddCategorie.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddCategorie.ForeColor = Color.Green;
            BtnAddCategorie.Location = new Point(355, 69);
            BtnAddCategorie.Name = "BtnAddCategorie";
            BtnAddCategorie.Size = new Size(23, 23);
            BtnAddCategorie.TabIndex = 21;
            BtnAddCategorie.Text = "+";
            BtnAddCategorie.UseCompatibleTextRendering = true;
            BtnAddCategorie.UseVisualStyleBackColor = false;
            BtnAddCategorie.Click += BtnAddCategorie_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 121);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 16;
            label5.Text = "Quantite";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(515, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(409, 163);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 14;
            label7.Text = "Unite De Vente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(515, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 23);
            textBox5.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(691, 431);
            button1.Name = "button1";
            button1.Size = new Size(97, 35);
            button1.TabIndex = 17;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(588, 431);
            button2.Name = "button2";
            button2.Size = new Size(97, 35);
            button2.TabIndex = 18;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(125, 15);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(255, 23);
            textBox6.TabIndex = 17;
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
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 53);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 0, 0, 0);
            panel2.Size = new Size(811, 53);
            panel2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 0);
            label9.Name = "label9";
            label9.Size = new Size(262, 31);
            label9.TabIndex = 0;
            label9.Text = "FICHE ENREGISTREMENT ARTICLE";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmSaisieArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 507);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmSaisieArticle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saisie Article";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox6;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Button BtnAddCategorie;
    }
}