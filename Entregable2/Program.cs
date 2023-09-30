using Entregable2.src;

public class Jugador:IJugador
{
    public string Nombre {get; private set;}
    public string Posicion {get; private set;}
    public int Rendimiento {get; private set;}

    public Jugador (string Nombre, string Posicion, int Rendimiento){
        this.Nombre = Nombre;
        this.Posicion = Posicion;
        this.Rendimiento = Rendimiento;
    }

    public string getNombre(){
       return this.Nombre; 
    }
    public string getPosicion(){
        return this.Posicion;
    }
    public int getRendimiento(){
        return this.Rendimiento;
    }
}

class Equipo
{
    private List<IJugador> jugadores = new List<IJugador>();

    public void AgregarJugador(IJugador jugador)
    {
        this.jugadores.Add(jugador);
    }

    public int CalcularPuntaje()
    {
        int puntajeTotal = 0;
        foreach (var jugador in jugadores)
        {
            puntajeTotal += jugador.Rendimiento;
        }
        return puntajeTotal;   
    }
}

class Partido
{
    static void Main(string[] args)
    {   
          Jugador Anderson = new Jugador ("Anderson", "Delantero", 8);
          Jugador Jeison = new Jugador ("Jeison","Defensa", 7);
          Jugador Julian = new Jugador ("Julian","Portero" , 6);
          Jugador Jhon = new Jugador ("Jhon","Extremo", 5);
          Jugador Duban = new Jugador ("Duban","Defensa Central", 8);
          Jugador Steven = new Jugador ("Steven","Defensa Lateral", 4);
          List<IJugador> listaJugadores = new List<IJugador>();

          listaJugadores.Add(Anderson);
          listaJugadores.Add(Jeison);
          listaJugadores.Add(Julian);
          listaJugadores.Add(Jhon);
          listaJugadores.Add(Duban);
          listaJugadores.Add(Steven);

          Equipo equipo1 = new Equipo();
          Equipo equipo2 = new Equipo();
          
          Random random = new Random();
          
          List<IJugador> jugadoresEquipo1 = new List<IJugador>();
          List<IJugador> jugadoresEquipo2 = new List<IJugador>();
          
          while (listaJugadores.Count > 0){
            
            int agregar = random.Next(listaJugadores.Count);
            IJugador jugadorSeleccionado = listaJugadores[agregar];

            if (equipo1.CalcularPuntaje() <= equipo2.CalcularPuntaje())
            {

                equipo1.AgregarJugador(jugadorSeleccionado);
                jugadoresEquipo1.Add(jugadorSeleccionado);
            }
            else 
            {
                equipo2.AgregarJugador(jugadorSeleccionado);
                jugadoresEquipo2.Add(jugadorSeleccionado);
            }
            listaJugadores.RemoveAt(agregar);
        }
        Console.WriteLine("Jugadores del Equipo 1:");
        foreach (var jugador in jugadoresEquipo1)
        {

            Console.WriteLine(jugador.Nombre + ", Rendimiento: " + jugador.Rendimiento);
        }
        Console.WriteLine("***********************");

        Console.WriteLine("Jugadores del Equipo 2:");
        foreach (var jugador in jugadoresEquipo2)
        {

            Console.WriteLine(jugador.Nombre + ", Rendimiento: " + jugador.Rendimiento);
        }

        Console.WriteLine("***********************");
        Console.WriteLine("Puntaje Equipo 1 : " + equipo1.CalcularPuntaje());
        Console.WriteLine("Puntaje Equipo 2 : " + equipo2.CalcularPuntaje());

        if (equipo1.CalcularPuntaje() > equipo2.CalcularPuntaje()) 
        {
            Console.WriteLine("El Equipo 1 gana el partido.");
        
        } else if (equipo1.CalcularPuntaje() < equipo2.CalcularPuntaje())
        {
            Console.WriteLine("El Equipo 2 gana el partido.");

        } else
        {
            Console.WriteLine("El partido termina en empate.");
        }
    }
}