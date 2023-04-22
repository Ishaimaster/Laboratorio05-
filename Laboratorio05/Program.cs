namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Equipo1", 3, 0, 0, 0, 0);
            Equipo equipo2 = new Equipo("Equipo2" ,1, 1, 1, 1, 1);
           
            Partido partido = new Partido(equipo1 , equipo2);

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine(partido.SeleccionarEquipoGanador().GetNombre());
            }

            Torneo.SimularTorneo(null);
            

           
       
        }
    }
}