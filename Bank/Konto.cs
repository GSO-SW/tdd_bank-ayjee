using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace Bank
{
    public class Konto
    {
        private int guthaben;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        static void KontoNr(int kontoNr)
        {
            kontoNr = 0;
        }

        public Konto(int guthaben)
        {
            if (guthaben >= 0)
            {
                this.guthaben = guthaben;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Konto darf nicht negativ sein");
            }
        }

        public void Einzahlen(int betrag)
        {
            if (betrag > 0)
            {
                guthaben += betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Betrag darf nicht negativ sein.");
            }
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
