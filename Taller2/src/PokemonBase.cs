public abstract class PokemonBase : IPokemon
{
    public string Nombre { get; }
    public string Tipo { get; }
    public int[] Ataques { get; }
    public int Defensa { get; }

    public PokemonBase(string nombre, string tipo, int[] ataques, int defensa)
    {
        Nombre = nombre;
        Tipo = tipo;
        Ataques = ataques;
        Defensa = defensa;
    }
    public abstract int Atacar();
    public abstract double Defend();
}