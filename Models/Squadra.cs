using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraSSCuadre.Models
{
    public class Squadra
    {
        public static int progressivoNumero = 1;
        public int Numero { get; set; }
        public string Nome { get; set; }
        public int[] QuesitiPunti { get; set; }
        public bool[] QuesitiRisolti { get; set; }
        public int QuesitoJolly { get; set; } = -1;

        public int PuntiTotali
        {
            get
            {
                int puntiIniziali = 0;
                foreach (var punti in QuesitiPunti)
                    puntiIniziali += punti;
                return puntiIniziali;
            }
        }

        public Squadra(string nome, int numProblemi)
        {
            Numero = progressivoNumero++;

            Nome = nome;
            QuesitiPunti = new int[numProblemi];
            QuesitiRisolti = new bool[numProblemi];
        }
    }
}
