using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

        public Frazione(int numeratore, int denominatore) 
        {
            SemplificaFrazione(ref numeratore, ref denominatore);

            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        private void SemplificaFrazione(ref int numeratore, ref int denominatore)
        {
            int  mcd = TrovaMCD(numeratore, denominatore);
            numeratore /= mcd;
            denominatore /= mcd;
        }

        private int TrovaMCD(int n1, int n2)
        {
            while (n2 != 0)
            {
                int t = n2;
                n2 = n1 % n2;
                n1 = t;
            }
             return n1;
        }

        public override string ToString()
        {
            return "(numeratore)/(denominatore)";
        }

        public static Frazione Parse(string s)
        {
            string[] parts = s.Split('/');
            int Numeratore = int.Parse(parts[0]);
            int Denominatore = int.Parse(parts[1]);

            return new Frazione(Numeratore, Denominatore);
        }
    }
}
