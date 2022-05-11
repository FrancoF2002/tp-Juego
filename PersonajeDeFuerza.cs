using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    public class PersonajeDeFuerza :  Personaje
    {

        public PersonajeDeFuerza(string name, int magic, int agility)
        {
            Nombre = name;
            Fuerza = 100;
            Agilidad = agility;
            Magia = magic;
        }

        public int CalcularDanio()
        {
            x = (int)(((Fuerza * 3) + (Agilidad * 3) + (Magia * 2)) / 5);
            return x;
        }
    }
}
