using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro_Milhoes
{
    class euromilhoes
    {
        private int nestrelas = 0, nnumero = 0;
        private string cruz = "✗";
        private bool[] numeros = new bool[50];
        private bool[] estrelas = new bool[12];

        public string numero(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumero--;
            }
            else if (nnumero < 5)
            {
                numeros[n] = true;
                nnumero++;
            }
            if (numeros[n]) return cruz;
            else return "";
        }



        public string estrela(int n)
        {
            if (estrelas[n])
            {
                estrelas[n] = false;
                nestrelas--;
            }
            else if (nestrelas < 2)
            {
                estrelas[n] = true;
                nestrelas++;
            }
            if (estrelas[n]) return cruz;
            else return "";
        }

        public string listanum
        {
            get
            {
                return "1+2+3+4+5";
            }
        }
    }
}
