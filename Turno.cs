using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    public class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            personajes.Select(personaje => personaje.Atacar());
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MeverseEjeX();
            ficha.MeverseEjeY();
        }
    }
}
