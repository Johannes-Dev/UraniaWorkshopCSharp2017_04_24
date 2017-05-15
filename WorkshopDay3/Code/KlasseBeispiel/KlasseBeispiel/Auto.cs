using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseBeispiel
{
    class Auto
    {
        public Auto()
        {

        }

        public string Marke { get; set; }

        public int PS { get; set; }

        public int KilometerStand { get; set; }

        private int m_AnzahlSitze;

        public int AnzahlSitze
        {
            get
            {
                return m_AnzahlSitze;
            }
            set           
            {
                m_AnzahlSitze = value;
            }
        }

        public void Fahren (int Strecke)
        {
            KilometerStand = Strecke + KilometerStand;
        }




    }
}
