using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraSSCuadre.Models
{
    public class Problema
    {
        public static int progressivoNumero = 1;
        public int Numero { get; set; }
        public int Soluzione { get; set; }
        public int SquadreCheHannoRisolto { get; set; } = 0;
        public int PunteggioCorrente { get; set; } = 10;

        public Problema(int soluzione)
        {
            Numero = progressivoNumero++;
            Soluzione = soluzione;
        }
    }
}
