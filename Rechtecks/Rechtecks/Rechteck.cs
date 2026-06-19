using System;

namespace Rechtecks
{
    internal class Rechteck
    {
        private double hoehe; // Höhe vom Rechteck
        private double breite; // Breite vom Rechteck

        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                // nur erlauben wenn größer als 0
                if (value > 0)
                {
                    hoehe = value;
                }
                else
                {
                    throw new Exception("Höhe muss größer als 0 sein!");
                }
            }
        }
        public double Breite
        {
            get { return breite; }
            set
            {
                // nur erlauben wenn größer als 0
                if (value > 0)
                {
                    breite = value;
                }
                else
                {
                    throw new Exception("Breite muss größer als 0 sein!");
                }
            }
        }

        // Umfang berechnen
        public double Umfang
        {
            get { return 2 * Hoehe + 2 * Breite; }
        }
        // Fläche berechnen
        public double Flaeche
        {
            get { return Hoehe * Breite; }
        }
        // Diagonale berechnen
        public double Diagonal
        {
            get { return Math.Sqrt(Breite * Breite + Hoehe * Hoehe); }
        }
        public Rechteck(double hoeheDesRechtecks, double breiteDesRechtecks)
        {
            // Werte setzen beim Erstellen
            Hoehe = hoeheDesRechtecks;
            Breite = breiteDesRechtecks;
        }
        public void Zoomen(double faktor)
        {
            // check ob faktor ok ist
            if (faktor <= 0)
            {
                throw new Exception("Der Faktor muss größer als 0 sein!");
            }

            // Größe ändern
            Hoehe *= faktor;
            Breite *= faktor;
        }
        public void Drehen()
        {
            // Höhe und Breite tauschen
            double temp = Hoehe;
            Hoehe = Breite;
            Breite = temp;
        }
    }
}