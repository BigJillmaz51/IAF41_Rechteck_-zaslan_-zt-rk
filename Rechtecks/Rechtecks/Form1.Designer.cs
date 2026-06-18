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
            btnDrehen = new Button();
            btnBerechnen = new Button();
            tbxDiagonal = new TextBox();
            lblDiagonal = new Label();
            tbxZoom = new TextBox();
            lblZoom = new Label();
            SuspendLayout();
            // 
            // tbxHöhe
            // 
            tbxHöhe.Location = new Point(242, 56);
            tbxHöhe.Name = "tbxHöhe";
            tbxHöhe.Size = new Size(100, 23);
            tbxHöhe.TabIndex = 0;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(242, 100);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(100, 23);
            tbxBreite.TabIndex = 1;
            // 
            // lblHöhe
            // 
            lblHöhe.AutoSize = true;
            lblHöhe.Location = new Point(242, 38);
            lblHöhe.Name = "lblHöhe";
            lblHöhe.Size = new Size(42, 15);
            lblHöhe.TabIndex = 2;
            lblHöhe.Text = "Höhe :";
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(242, 82);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(43, 15);
            lblBreite.TabIndex = 3;
            lblBreite.Text = "Breite :";
            // 
            // tbxFläche
            // 
            tbxFläche.Location = new Point(242, 143);
            tbxFläche.Name = "tbxFläche";
            tbxFläche.Size = new Size(100, 23);
            tbxFläche.TabIndex = 4;
            tbxFläche.TextChanged += textBox1_TextChanged;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(242, 189);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(100, 23);
            tbxUmfang.TabIndex = 5;
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(242, 171);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(56, 15);
            lblUmfang.TabIndex = 6;
            lblUmfang.Text = "Umfang :";
            // 
            // lblFläche
            // 
            lblFläche.AutoSize = true;
            lblFläche.Location = new Point(242, 126);
            lblFläche.Name = "lblFläche";
            lblFläche.Size = new Size(47, 15);
            lblFläche.TabIndex = 7;
            lblFläche.Text = "Fläche :";
            // 
            // btnZoom
            // 
            btnZoom.Location = new Point(242, 328);
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
            // btnDrehen
            // 
            btnDrehen.Location = new Point(411, 142);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(75, 23);
            btnDrehen.TabIndex = 10;
            btnDrehen.Text = "Drehen 90°";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(411, 189);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(75, 23);
            btnBerechnen.TabIndex = 11;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            // 
            // tbxDiagonal
            // 
            tbxDiagonal.Location = new Point(242, 244);
            tbxDiagonal.Name = "tbxDiagonal";
            tbxDiagonal.Size = new Size(100, 23);
            tbxDiagonal.TabIndex = 12;
            // 
            // lblDiagonal
            // 
            lblDiagonal.AutoSize = true;
            lblDiagonal.Location = new Point(242, 226);
            lblDiagonal.Name = "lblDiagonal";
            lblDiagonal.Size = new Size(60, 15);
            lblDiagonal.TabIndex = 13;
            lblDiagonal.Text = "Diagonal :";
            lblDiagonal.Click += label2_Click;
            // 
            // tbxZoom
            // 
            tbxZoom.Location = new Point(242, 299);
            tbxZoom.Name = "tbxZoom";
            tbxZoom.Size = new Size(100, 23);
            tbxZoom.TabIndex = 14;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(242, 281);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(81, 15);
            lblZoom.TabIndex = 15;
            lblZoom.Text = "Zoom Faktor :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblZoom);
            Controls.Add(tbxZoom);
            Controls.Add(lblDiagonal);
            Controls.Add(tbxDiagonal);
            Controls.Add(btnBerechnen);
            Controls.Add(btnDrehen);
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
        private Button btnDrehen;
        private Button btnBerechnen;
        private TextBox tbxDiagonal;
        private Label lblDiagonal;
        private TextBox tbxZoom;
        private Label lblZoom;
    }
}
