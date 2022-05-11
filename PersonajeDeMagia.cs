using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string name, int strength, int magic, int agility)
        {

            Nombre = name;
            Fuerza = strength;
            Agilidad = agility;
            Magia = magic;

        }
        public PersonajeDeMagia(string name, int strength, int agility)
        {
            Nombre = name;
            Fuerza = strength;
            Agilidad = agility;
            Magia = 60;
        }

        public string Atacar()
        {
            return $"{Nombre} hizo {x} de daño gracias a su magia";
        }

        public int CalcularDanio()
        {
            x = Fuerza + Agilidad + Magia * 4;
            return x; 
        }


    }
}
