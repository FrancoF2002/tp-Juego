using tp_Juego;
//Fuerza
PersonajeDeFuerza michael = new PersonajeDeFuerza("michael", 7, 7);
Console.WriteLine(michael.CalcularDanio());
Console.WriteLine(michael.Atacar());
Console.WriteLine(michael.MeverseEjeX());
Console.WriteLine(michael.MeverseEjeY());

//Agilidad
PersonajeDeAgilidad javier = new PersonajeDeAgilidad("javier", 10, 10, 10);
Console.WriteLine(javier.CalcularDanio());
Console.WriteLine(javier.Atacar());
Console.WriteLine(javier.MeverseEjeX());
Console.WriteLine(javier.MeverseEjeY());

// Magia
PersonajeDeMagia calvin = new PersonajeDeMagia("calvin", 10, 10, 10);
PersonajeDeMagia mirko = new PersonajeDeMagia("mirko", 10, 10);
Console.WriteLine(calvin.CalcularDanio());
Console.WriteLine(calvin.Atacar());
Console.WriteLine(calvin.MeverseEjeX());
Console.WriteLine(calvin.MeverseEjeY());
Console.WriteLine(mirko.CalcularDanio());
Console.WriteLine(mirko.Atacar());
Console.WriteLine(mirko.MeverseEjeX());
Console.WriteLine(mirko.MeverseEjeY());

//Clase Enemigo

Enemigo mov = new Enemigo();
Console.WriteLine("2 Movimientos");
Console.WriteLine(mov.MeverseEjeX());
Enemigo movimineto = new Enemigo();
Console.WriteLine(movimineto.MeverseEjeY());

//Clase Turno

List<Personaje> personajes = new List<Personaje>();
personajes.Add(michael);
personajes.Add(calvin);
personajes.Add(mirko);

Turno.Atacarse(personajes);


List<IMoverse> lista = new();

lista.Add(michael);
lista.Add(calvin);
lista.Add(mirko);
lista.Add(new Enemigo());


foreach (IMoverse x in lista)
{
    Turno.MoverFichas(x);
}


