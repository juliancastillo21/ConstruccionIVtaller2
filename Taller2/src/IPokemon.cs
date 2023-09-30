public interface IPokemon
{
    string Nombre { get; }
    string Tipo { get; }
    int[] Ataques { get; }
    int Defensa { get; }
    int Atacar();
    double Defend();
}