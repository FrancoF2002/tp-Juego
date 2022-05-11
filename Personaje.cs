using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre = "";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public int x;
        public string Mensaje = "";


        public int CalcularDanio(int Fuerza, int Magia, int Agilidad)
        {
            return  x;
        }

        public string Atacar()
        {
            Mensaje = $"{Nombre} hizo {x} daños";
            return Mensaje;
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
