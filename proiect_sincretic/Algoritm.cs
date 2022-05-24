using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_sincretic
{
    class Algoritm
    {

        private bool estePatratPerfect(UInt64 numar)
        {
            double radacina = Math.Sqrt(numar);
            // daca un numar rotunjit este egal cu el insusi, numarul este intreg
            // daca radacina este nr intreg, atunci numarul este PP
            return Math.Round(radacina) == radacina;
        }

        public int numaraPatratePerfecte(List<UInt64> listaNumere)
        {
            int numarPP = 0;
            foreach (UInt64 numar in listaNumere)
            {
                if (estePatratPerfect(numar))
                    numarPP++;
            }
            return numarPP;
        }
    }
}
