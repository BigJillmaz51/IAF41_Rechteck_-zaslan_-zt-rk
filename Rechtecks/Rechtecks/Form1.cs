using System;
using System.Windows.Forms;

namespace Rechtecks
{
    public partial class Form1 : Form
    {
        private Rechteck r; // speichert das aktuelle Rechteck

        public Form1()
        {
            InitializeComponent();
        }

        // aktualisiert alle Anzeigen im Formular
        private void Aktualisieren()
        {
            tbxHoehe.Text = r.Hoehe.ToString();
            tbxBreite.Text = r.Breite.ToString();

            tbxFlaeche.Text = r.Flaeche.ToString();
            tbxUmfang.Text = r.Umfang.ToString();
            tbxDiagonal.Text = r.Diagonal.ToString("F2"); // 2 Nachkommastellen
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                // check ob Rechteck schon existiert
                if (r == null)
                {
                    MessageBox.Show("Bitte zuerst ein Rechteck berechnen!");
                    return;
                }

                r.Drehen(); // Höhe und Breite tauschen
                Aktualisieren(); // Werte neu anzeigen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Fehler anzeigen
            }
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Werte aus den Textboxen holen
                double h = Convert.ToDouble(tbxHoehe.Text);
                double b = Convert.ToDouble(tbxBreite.Text);

                r = new Rechteck(h, b); // neues Rechteck erstellen

                Aktualisieren(); // alles anzeigen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Fehler anzeigen
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

                r.Zoomen(faktor); // Größe verändern

                Aktualisieren(); // Anzeige aktualisieren
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Fehler anzeigen
            }
        }
    }
}