using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    internal class Enemigo : IMoverse

    {
        public int Vida;
        public int Nivel;

        public Enemigo()
        {
            Vida = 300;
            Nivel = 0;
        }

        public string MeverseEjeX()
        {
            return "Movimiento Horizontal (ejeX)";
        }

        public string MeverseEjeY()
        {
            return "Movimiento Vertical (EjeY)";
        }


    }
}
