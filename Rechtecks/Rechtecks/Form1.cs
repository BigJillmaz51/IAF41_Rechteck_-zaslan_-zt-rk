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
            // Werte ins Textfeld schreiben
            tbxHoehe.Text = r.Hoehe.ToString();
            tbxBreite.Text = r.Breite.ToString();

            tbxFlaeche.Text = r.Flaeche.ToString();
            tbxUmfang.Text = r.Umfang.ToString();
            tbxDiagonal.Text = r.Diagonal.ToString("F2"); // nur 2 Nachkommastellen
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                // check ob Rechteck schon da ist
                if (r == null)
                {
                    MessageBox.Show("Bitte zuerst ein Rechteck berechnen!");
                    return;
                }

                r.Drehen(); // Höhe und Breite tauschen

                Aktualisieren(); // Anzeige neu machen
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
                // Werte aus Textbox holen
                double h = Convert.ToDouble(tbxHoehe.Text);
                double b = Convert.ToDouble(tbxBreite.Text);

                r = new Rechteck(h, b); // neues Rechteck erstellen

                Aktualisieren(); // anzeigen
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
                // check ob Rechteck existiert
                if (r == null)
                {
                    MessageBox.Show("Bitte zuerst ein Rechteck berechnen!");
                    return;
                }

                double faktor = Convert.ToDouble(tbxFaktor.Text); // zoom faktor holen

                r.Zoomen(faktor); // Größe ändern

                Aktualisieren(); // neu anzeigen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}