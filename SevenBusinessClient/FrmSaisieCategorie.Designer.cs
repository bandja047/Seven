namespace SevenBusinessClient
{
    partial class FrmSaisieCategorie
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
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
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
            label6.Size = new Size(41, 18);
            label6.TabIndex = 11;
            label6.Text = "Parent";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 23);
            comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(43, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 286);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information sur les categories";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(372, 427);
            button1.Name = "button1";
            button1.Size = new Size(97, 35);
            button1.TabIndex = 17;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(263, 427);
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
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(43, 59);
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
            panel2.Size = new Size(516, 53);
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
            // FrmSaisieCategorie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 507);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmSaisieCategorie";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Saisie Categorie";
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
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox6;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
    }
}