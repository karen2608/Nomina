using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXamen
{
    public class Nomina 
    {
        private int totalvalor;
        private int diaslaborados;
        private int valordia;

        public int Diaslaborados { get => diaslaborados; set => diaslaborados = value; }
        public int Valordia { get => valordia; set => valordia = value; }

        public int calularnomina(int DiasLa, int Valor)
        {
            totalvalor = (DiasLa * Valor);
            return totalvalor;
        }

    }
}
