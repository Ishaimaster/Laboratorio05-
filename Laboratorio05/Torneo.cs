using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Torneo
    {
        public static Equipo[][] SimularTorneo(Equipo[] equipos)
        {
            
            double log2 = Math.Log(equipos.Length, 2);

            if (equipos.Length < 2 || log2 != Math.Floor(log2))
            {
                throw new Exception("La cantidad de equipos debe ser una potencia de dos y deben existir al menos dos equipos");
            }

            int nSize = (int)Math.Log2(equipos.Length) + 1;

            Equipo[][] result = new Equipo[nSize][];

            result[0] = equipos;

            int Restantes = equipos.Length;

            int fase = 1;

            while (Restantes > 1)
            {
                result[fase] = new Equipo[Restantes / 2];

                for (int i = 0; i < Restantes / 2; i++)
                {
                    Partido partido = new Partido(result[fase - 1][i], result[fase - 1][Restantes - i - 1]);
                    Equipo ganador = partido.SeleccionarEquipoGanador();
                    result[fase][i] = ganador;
                }

                Restantes = Restantes / 2;

                fase++;
            }

            return result;
        }

        private static bool isPowerOf2(int x) 
        {
        
         double log2 = Math.Log2(x);

         return (log2 - (int)log2) == 0.0;
        
        
        }

        
            
        
    }
}
