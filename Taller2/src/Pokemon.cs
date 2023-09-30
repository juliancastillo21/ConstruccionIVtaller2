using System;

public class Pokemon : PokemonBase
{
    public Pokemon(string nombre, string tipo, int[] ataques, int defensa) : base(nombre, tipo, ataques, defensa){}
    public override int Atacar()
    {
        Random random = new Random();
        int ataqueSeleccionado = random.Next(Ataques.Length);
        int puntajeAtaque = Ataques[ataqueSeleccionado];
        int multiplicador = random.Next(2); 
        return puntajeAtaque * multiplicador;
    }
    
    public override double Defend()
    {
        Random random = new Random();
        if (random.Next(2) == 0)
        {
            return 0.5 * Defensa;
        }
        return Defensa;
    }
}