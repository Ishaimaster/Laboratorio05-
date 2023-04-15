using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Equipo
    {
        private string Nombre;
        private int PartidosGanados;
        private int PartidosEmpatados;
        private int PartidosPerdidos;
        private int GolesaFavor;
        private int GolesenContra;

        public Equipo(string nombre, int partidosGanados, int partidosEmpatados, int partidosPerdidos, int golesFavor, int golesContra)
        {
        
            this.Nombre = nombre;
            this.PartidosGanados = partidosGanados;
            this.PartidosEmpatados = partidosEmpatados;
            this.PartidosPerdidos = partidosPerdidos;
            this.GolesaFavor = golesFavor;
            this.GolesenContra = golesContra;

            if (partidosGanados + partidosEmpatados + partidosPerdidos != 3 || golesFavor < 0 || golesContra < 0)
            {
                throw new Exception("Revise el equipo. La sumatoria de partidos debe ser igual a 3 y los goles anotados y a favor deben ser mayores o iguales a cero.");
            }
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int GetPartidosGanados()
        {
            return PartidosGanados;
        }

        public int GetPartidosEmpatados()
        {
            return PartidosEmpatados;
        }

        public int GetPartidosPerdidos()
        {
            return PartidosPerdidos;
        }

        public int GetGolesFavor()
        {
            return GolesaFavor;
        }

        public int GetGolesContra()
        {
            return GolesenContra;
        }
    }
}
