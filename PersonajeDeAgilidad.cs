using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string name, int strength,int magic, int agility)
        {
           
                Nombre = name;
                Fuerza = strength;
                Agilidad = agility;
                Magia = magic;

        }

        public int CalcularDanio()
        {
            x = Fuerza / 2 * Agilidad * Magia / 2;
            return x;
        }
    }
}
