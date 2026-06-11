namespace Rechtecks
{
    partial class Form1
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
            tbxHöhe = new TextBox();
            tbxBreite = new TextBox();
            lblHöhe = new Label();
            lblBreite = new Label();
            tbxFläche = new TextBox();
            tbxUmfang = new TextBox();
            lblUmfang = new Label();
            lblFläche = new Label();
            btnZoom = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbxHöhe
            // 
            tbxHöhe.Location = new Point(12, 55);
            tbxHöhe.Name = "tbxHöhe";
            tbxHöhe.Size = new Size(100, 23);
            tbxHöhe.TabIndex = 0;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(12, 99);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(100, 23);
            tbxBreite.TabIndex = 1;
            // 
            // lblHöhe
            // 
            lblHöhe.AutoSize = true;
            lblHöhe.Location = new Point(12, 37);
            lblHöhe.Name = "lblHöhe";
            lblHöhe.Size = new Size(42, 15);
            lblHöhe.TabIndex = 2;
            lblHöhe.Text = "Höhe :";
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(12, 81);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(43, 15);
            lblBreite.TabIndex = 3;
            lblBreite.Text = "Breite :";
            // 
            // tbxFläche
            // 
            tbxFläche.Location = new Point(12, 142);
            tbxFläche.Name = "tbxFläche";
            tbxFläche.Size = new Size(100, 23);
            tbxFläche.TabIndex = 4;
            tbxFläche.TextChanged += textBox1_TextChanged;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(12, 188);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(100, 23);
            tbxUmfang.TabIndex = 5;
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(12, 170);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(56, 15);
            lblUmfang.TabIndex = 6;
            lblUmfang.Text = "Umfang :";
            // 
            // lblFläche
            // 
            lblFläche.AutoSize = true;
            lblFläche.Location = new Point(12, 125);
            lblFläche.Name = "lblFläche";
            lblFläche.Size = new Size(47, 15);
            lblFläche.TabIndex = 7;
            lblFläche.Text = "Fläche :";
            // 
            // btnZoom
            // 
            btnZoom.Location = new Point(12, 226);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(75, 23);
            btnZoom.TabIndex = 8;
            btnZoom.Text = "Zoom";
            btnZoom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnZoom);
            Controls.Add(lblFläche);
            Controls.Add(lblUmfang);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFläche);
            Controls.Add(lblBreite);
            Controls.Add(lblHöhe);
            Controls.Add(tbxBreite);
            Controls.Add(tbxHöhe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxHöhe;
        private TextBox tbxBreite;
        private Label lblHöhe;
        private Label lblBreite;
        private TextBox tbxFläche;
        private TextBox tbxUmfang;
        private Label lblUmfang;
        private Label lblFläche;
        private Button btnZoom;
        private Label label1;
    }
}
