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

            tbxHoehe = new TextBox();
            tbxBreite = new TextBox();
            lblHöhe = new Label();
            lblBreite = new Label();
            tbxFlaeche = new TextBox();
            tbxUmfang = new TextBox();
            lblUmfang = new Label();
            lblFläche = new Label();
            btnZoom = new Button();
            label1 = new Label();
            btnDrehen = new Button();
            btnBerechnen = new Button();
            tbxDiagonal = new TextBox();
            lblDiagonal = new Label();
            tbxFaktor = new TextBox();
            lblZoom = new Label();
            SuspendLayout();
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(449, 119);
            tbxHoehe.Margin = new Padding(6);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(182, 39);
            tbxHoehe.TabIndex = 0;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(449, 213);
            tbxBreite.Margin = new Padding(6);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(182, 39);
            tbxBreite.TabIndex = 1;
            // 
            // lblHöhe
            // 
            lblHöhe.AutoSize = true;
            lblHöhe.Location = new Point(449, 81);
            lblHöhe.Margin = new Padding(6, 0, 6, 0);
            lblHöhe.Name = "lblHöhe";
            lblHöhe.Size = new Size(84, 32);
            lblHöhe.TabIndex = 2;
            lblHöhe.Text = "Höhe :";
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(449, 175);
            lblBreite.Margin = new Padding(6, 0, 6, 0);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(88, 32);
            lblBreite.TabIndex = 3;
            lblBreite.Text = "Breite :";
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(449, 305);
            tbxFlaeche.Margin = new Padding(6);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.Size = new Size(182, 39);
            tbxFlaeche.TabIndex = 4;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(449, 403);
            tbxUmfang.Margin = new Padding(6);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(182, 39);
            tbxUmfang.TabIndex = 5;
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(449, 365);
            lblUmfang.Margin = new Padding(6, 0, 6, 0);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(111, 32);
            lblUmfang.TabIndex = 6;
            lblUmfang.Text = "Umfang :";
            // 
            // lblFläche
            // 
            lblFläche.AutoSize = true;
            lblFläche.Location = new Point(449, 269);
            lblFläche.Margin = new Padding(6, 0, 6, 0);
            lblFläche.Name = "lblFläche";
            lblFläche.Size = new Size(94, 32);
            lblFläche.TabIndex = 7;
            lblFläche.Text = "Fläche :";
            // 
            // btnZoom
            // 
            btnZoom.Location = new Point(449, 700);
            btnZoom.Margin = new Padding(6);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(139, 49);
            btnZoom.TabIndex = 8;
            btnZoom.Text = "Zoom";
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(763, 303);
            btnDrehen.Margin = new Padding(6);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(139, 49);
            btnDrehen.TabIndex = 10;
            btnDrehen.Text = "Drehen 90°";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(763, 403);
            btnBerechnen.Margin = new Padding(6);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(139, 49);
            btnBerechnen.TabIndex = 11;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // tbxDiagonal
            // 
            tbxDiagonal.Location = new Point(449, 521);
            tbxDiagonal.Margin = new Padding(6);
            tbxDiagonal.Name = "tbxDiagonal";
            tbxDiagonal.Size = new Size(182, 39);
            tbxDiagonal.TabIndex = 12;
            // 
            // lblDiagonal
            // 
            lblDiagonal.AutoSize = true;
            lblDiagonal.Location = new Point(449, 482);
            lblDiagonal.Margin = new Padding(6, 0, 6, 0);
            lblDiagonal.Name = "lblDiagonal";
            lblDiagonal.Size = new Size(121, 32);
            lblDiagonal.TabIndex = 13;
            lblDiagonal.Text = "Diagonal :";
            // 
            // tbxFaktor
            // 
            tbxFaktor.Location = new Point(449, 638);
            tbxFaktor.Margin = new Padding(6);
            tbxFaktor.Name = "tbxFaktor";
            tbxFaktor.Size = new Size(182, 39);
            tbxFaktor.TabIndex = 14;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(449, 599);
            lblZoom.Margin = new Padding(6, 0, 6, 0);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(161, 32);
            lblZoom.TabIndex = 15;
            lblZoom.Text = "Zoom Faktor :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(lblZoom);
            Controls.Add(tbxFaktor);
            Controls.Add(lblDiagonal);
            Controls.Add(tbxDiagonal);
            Controls.Add(btnBerechnen);
            Controls.Add(btnDrehen);
            Controls.Add(label1);
            Controls.Add(btnZoom);
            Controls.Add(lblFläche);
            Controls.Add(lblUmfang);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFlaeche);
            Controls.Add(lblBreite);
            Controls.Add(lblHöhe);
            Controls.Add(tbxBreite);
            Controls.Add(tbxHoehe);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxHoehe;
        private TextBox tbxBreite;
        private Label lblHöhe;
        private Label lblBreite;
        private TextBox tbxFlaeche;
        private TextBox tbxUmfang;
        private Label lblUmfang;
        private Label lblFläche;
        private Button btnZoom;
        private Label label1;
        private Button btnDrehen;
        private Button btnBerechnen;
        private TextBox tbxDiagonal;
        private Label lblDiagonal;
        private TextBox tbxFaktor;
        private Label lblZoom;

    }
}
