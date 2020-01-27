using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamensadministration
{
    class Kurs
    {
        public string kursnamn;
        public double högskolepoäng;

        public override string ToString()
        {
            return string.Format("{0} ({1:F1} hp)", kursnamn, högskolepoäng);
        }

    }
}
