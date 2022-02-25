
using ListExample1;
using ListExample1.arraylist;
//using ListExample1.linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    ArrayList team1 = new ArrayList();
    ArrayList team2 = new ArrayList();
    ArrayList team3 = new ArrayList();


    team1.AddAtTail("Hugo");
    team1.AddAtTail("Paco");
    team1.AddAtTail("Luis");

    team2.AddAtFront("Tadeo");
    team2.AddAtFront("Pirru");
    team2.AddAtFront("Mateo");

    team3.AddAtFront("Imelda");
    team3.AddAtFront("Ime");
    team3.AddAtFront("Mermelada");

ArrayListIterator iterator;

    iterator = team1.GetIterator();


    while (iterator.HasNext())
    { //Si podemos agregar mas datos /todavia tienes otro
     string name = iterator.Next(); //muevete al siguiente
    Console.WriteLine(name);
}


    iterator = team2.GetIterator();

    while (iterator.HasNext())
    {
        string name = iterator.Next();
        Console.WriteLine(name);
}


    team1.Remove(0);
    team1.AddAtFront("Rebeca");
    Console.WriteLine("Team 1 tiene: " + team1.GetSize() + " integrantes");

    iterator = team1.GetIterator();

    while (iterator.HasNext())
    {
        String name = iterator.Next();

         Console.WriteLine(name);
}

    team2.Remove(2);
    team2.AddAtTail("Reby");
    Console.WriteLine("Team 2 tiene: " + team2.GetSize() + " integrantes");

    iterator = team2.GetIterator();

    while (iterator.HasNext())
    {
        string name = iterator.Next();
        Console.WriteLine(name);
}


    team3.Remove(0);
    team3.Remove(0); // El elemento no existe pero el programa no debe cerrarse por algún error

    team3.AddAtTail("Mime");

    Console.WriteLine("Team 3 tiene: " + team3.GetSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

    iterator = team3.GetIterator();

    while (iterator.HasNext())
    {
        string name = iterator.Next();
    Console.WriteLine(name);
}

    // Debió haber impreso
    // Tadeo
    // Isai

    if (team1.GetAt(1).Equals("Salomón"))
    {
        team1.SetAt(1, "Luis");
    }

Console.WriteLine("Team 1 tiene: " + team1.GetSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

    iterator = team1.GetIterator(); //SE UTILIZA ISMA VARIABLE

while (iterator.HasNext())
{
    string name = iterator.Next();
    Console.WriteLine(name);
}
/*
LinkedList team1 = new LinkedList();
LinkedList team2 = new LinkedList();
LinkedList team3 = new LinkedList();
team1.AddAtTail("Jesús");
team1.AddAtTail("Salomón");
team1.AddAtTail("Yael");
team2.AddAtFront("Cristian");
team2.AddAtFront("Daniel");
team2.AddAtFront("Diego");
team3.AddAtFront("Imelda");
LinkedListIterator iterator;
iterator = team1.GetIterator(); //creamos iterador
                                //forma de moverte estandar
while (iterator.HasNext())
{ //Si podemos agregar mas datos /todavia tienes otro
    String name = iterator.Next(); //muevete al siguiente
    Console.WriteLine(name);
}
// Debió haber impreso
// Jesús
// Salomón
// Yael
iterator = team2.GetIterator();
while (iterator.HasNext())
{
    String name = iterator.Next();
    Console.WriteLine(name);
}
// Debió haber impreso
// Diego
// Daniel
// Cristian
team1.Remove(0);
team1.AddAtFront("Rebeca");
Console.WriteLine("Team 1 tiene: " + team1.GetSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"
iterator = team1.GetIterator();
while (iterator.HasNext())
{
    String name = iterator.Next();
    Console.WriteLine(name); 
}
// Debió haber impreso
// Rebeca
// Salomón
// Yael
team2.Remove(2);
team2.AddAtTail("Rita");
Console.WriteLine("Team 2 tiene: " + team2.GetSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"
iterator = team2.GetIterator();
while (iterator.HasNext())
{
    String name = iterator.Next();
    Console.WriteLine(name);
}
// Debió haber impreso
// Diego
// Daniel
// Rita
team3.Remove(0);
team3.Remove(0); // El elemento no existe pero el programa no debe cerrarse por algún error
team3.AddAtTail("Tadeo");
team3.AddAtFront("Isai");
Console.WriteLine("Team 3 tiene: " + team3.GetSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"
iterator = team3.GetIterator();
while (iterator.HasNext())
{
    String name = iterator.Next();
   Console.WriteLine(name);
}
// Debió haber impreso
// Tadeo
// Isai

if (team1.GetAt(1).Equals("Salomón"))
{
    team1.SetAt(1, "Luis");
}

Console.WriteLine("Team 1 tiene: " + team1.GetSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"
iterator = team1.GetIterator(); //SE UTILIZA ISMA VARIABLE
while (iterator.HasNext())
{
    String name = iterator.Next();
    Console.WriteLine(name);
}
// Debió haber impreso
// Rebeca
// Luis
// Yael
*/