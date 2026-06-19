using System;
using System.Windows.Forms;

namespace Rechtecks
{
    public partial class Form1 : Form
    {
        private Rechteck r; // hier wird das Rechteck gespeichert

        public Form1()
        {
            InitializeComponent();
        }

        private void Aktualisieren()
        {
            tbxHoehe.Text = r.Hoehe.ToString();
            tbxBreite.Text = r.Breite.ToString();

            tbxFlaeche.Text = r.Flaeche.ToString();
            tbxUmfang.Text = r.Umfang.ToString();
            tbxDiagonal.Text = r.Diagonal.ToString("F2");
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Bitte zuerst ein Rechteck berechnen!");
                    return;
                }

                r.Drehen();
                Aktualisieren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(tbxHoehe.Text);
                double b = Convert.ToDouble(tbxBreite.Text);

                r = new Rechteck(h, b);

                Aktualisieren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Bitte zuerst ein Rechteck berechnen!");
                    return;
                }

                double faktor = Convert.ToDouble(tbxFaktor.Text);

                r.Zoomen(faktor);

                Aktualisieren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}