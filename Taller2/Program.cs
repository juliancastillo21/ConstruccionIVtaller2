using System;

Console.WriteLine("Ingrese los datos del Pokémon 1:");
Console.Write("Nombre: ");
string nombre1 = Console.ReadLine();
Console.Write("Tipo: ");
string tipo1 = Console.ReadLine();
int[] ataques1 = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Ataque {i + 1}: ");
    ataques1[i] = int.Parse(Console.ReadLine());
}

Console.Write("Defensa: ");
int defensa1 = int.Parse(Console.ReadLine());

Console.WriteLine("\nIngrese los datos del Pokémon 2:");
Console.Write("Nombre: ");
string nombre2 = Console.ReadLine();
Console.Write("Tipo: ");
string tipo2 = Console.ReadLine();
int[] ataques2 = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Ataque {i + 1}: ");
    ataques2[i] = int.Parse(Console.ReadLine());
}

Console.Write("Defensa: ");
int defensa2 = int.Parse(Console.ReadLine());

IPokemon pokemon1 = new Pokemon(nombre1, tipo1, ataques1, defensa1);
IPokemon pokemon2 = new Pokemon(nombre2, tipo2, ataques2, defensa2);

Console.WriteLine("\n¡Comienza la batalla!");

int resultadoBatalla = SimularBatalla(pokemon1, pokemon2);

if (resultadoBatalla == 0)
{
    Console.WriteLine("¡La batalla terminó en empate!");
}
else if (resultadoBatalla > 0)
{
    Console.WriteLine($"¡{pokemon1.Nombre} ganó la batalla!");
}
else
{
    Console.WriteLine($"¡{pokemon2.Nombre} ganó la batalla!");
}

int SimularBatalla(IPokemon pokemon1, IPokemon pokemon2)
{
    int resultado = 0;

    for (int turno = 1; turno <= 3; turno++)
    {
        Console.WriteLine($"\nTurno {turno}:");

        int ataque1 = pokemon1.Atacar();
        int ataque2 = pokemon2.Atacar();
        double defensa2 = pokemon2.Defend();
        double defensa1 = pokemon1.Defend();

        Console.WriteLine($"{pokemon1.Nombre} atacó con {ataque1} puntos.");
        Console.WriteLine($"{pokemon2.Nombre} atacó con {ataque2} puntos.");
        Console.WriteLine($"{pokemon1.Nombre} se defendió con {defensa1} puntos.");
        Console.WriteLine($"{pokemon2.Nombre} se defendió con {defensa2} puntos.");

        if (ataque1 > defensa2)
        {
            Console.WriteLine($"{pokemon1.Nombre} ganó este turno.");
            resultado++;
        }
        else if (ataque2 > defensa1)
        {
            Console.WriteLine($"{pokemon2.Nombre} ganó este turno.");
            resultado--;
        }
        else
        {
            Console.WriteLine("Este turno terminó en empate.");
        }
    }
    return resultado;
}