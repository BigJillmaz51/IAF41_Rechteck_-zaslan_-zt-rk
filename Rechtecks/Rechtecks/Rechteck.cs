using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rechtecks
{
    internal class Rechteck
    {
        private double hoehe;
        private double breite;
        // Eigenschaften 
        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                // TODO: Wert prüfen: muss > 0 sein 
                if (value > 0)
                {
                    hoehe = value;
                }
                else
                {
                    // Exception werfen 
                    throw new Exception("Höhe muss größer als 0 sein!");
                }
            }
        }
        public double Breite
        {
            //analog zur Eigenschaft breite 
            get { return breite; }
            set
            {
                if (value > 0)
                {
                    breite = value;
                }
                else
                {
                    // Exception werfen
                    throw new Exception("Breite muss größer als 0 sein!");
                }
            }
        }
        // Schreibgeschützte Eigenschaften (berechnet) 
        public double Umfang
        {
            get
            {
                //Umfang wird mit Formel berechnet, dann mit return zurückgegeben 
                return 2 * hoehe + 2 * breite;


            }

        }
        public double Flaeche
        {
            
            get
            {
                return hoehe * breite;
            }

        }
        public double Diagonal
        {
            //orientiere dich an der Eigenschaft Diagonale
            get
            {
                return Math.Sqrt((breite * breite)+(hoehe * hoehe));
            }

        }
        public Rechteck(double hoeheDesRechtecks, double breiteDesRechtecks)
        {
            // Aufruf der Setter für jede Eigenschaft
            Breite = breiteDesRechtecks;
            Hoehe = hoeheDesRechtecks;
        }

    }
}
