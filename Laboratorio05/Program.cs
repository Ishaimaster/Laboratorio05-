namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Real Madrid", 2, 1, 0, 3, 1);
            Equipo equipo2 = new Equipo("Barcelona", 2, 0, 1, 3, 2);
            Equipo equipo3 = new Equipo("PSG", 0, 0, 3, 1, 3);
            Equipo equipo4 = new Equipo("Bayern Munich", 2, 0, 1, 2, 1);
            Equipo equipo5 = new Equipo("Manchester United", 0, 3, 0, 3, 3);
            Equipo equipo6 = new Equipo("Chelsea", 1, 0, 2, 1, 2);
            Equipo equipo7 = new Equipo("MIlan", , 2, 1, 2, 3);
            Equipo equipo8 = new Equipo("Juventus", 1, 1, 1, 2, 2);

           
            for (int i = 0; i < 4; i++) 
            {
            Console.WriteLine(partido.SeleccionarEquipoGanador().GetNombre());
            }
        }
    }
}