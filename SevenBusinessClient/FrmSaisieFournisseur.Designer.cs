namespace MotherStoreBusiness
{
    partial class FrmSaisieFournisseur
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
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtPrenom = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label7 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            label1.Size = new Size(30, 18);
            label1.TabIndex = 1;
            label1.Text = "Nom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 70);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 11;
            label6.Text = "Prenom";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrenom);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 122);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information generale";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(123, 65);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(255, 23);
            txtPrenom.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(702, 385);
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
            button2.Location = new Point(599, 385);
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
            panel1.Size = new Size(415, 53);
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
            label9.Size = new Size(319, 31);
            label9.TabIndex = 0;
            label9.Text = "FICHE ENREGISTREMENT FOURNISSEURS";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(444, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 122);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contacts";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 11;
            label3.Text = "Telephone";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(12, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(787, 122);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information generale";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(555, 65);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(201, 23);
            textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(555, 32);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(203, 23);
            textBox8.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(449, 32);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 19;
            label7.Text = "Quartier";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(449, 70);
            label10.Name = "label10";
            label10.Size = new Size(67, 18);
            label10.TabIndex = 20;
            label10.Text = "Code Postal";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 23);
            textBox5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 32);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 1;
            label4.Text = "Pays";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 70);
            label5.Name = "label5";
            label5.Size = new Size(30, 18);
            label5.TabIndex = 11;
            label5.Text = "Ville";
            // 
            // FrmSaisieFournisseur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 440);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmSaisieFournisseur";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FICHE ENREGISTREMENT FOURNISSEURS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label6;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private TextBox txtPrenom;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label7;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
    }
}