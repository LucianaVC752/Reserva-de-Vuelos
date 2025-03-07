using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vuelos
{
    public class Vuelo
    {
        public string Codigo { get; set; }
        public string OrigenVuelo { get; set; }
        public string DestinoVuelo { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPuestos { get; set; }
        public Vuelo(string codigo, string origenVuelo, string destinoVuelo, DateTime fechaSalida, int cantidadPuestos) 
        {
            Codigo = codigo;
            OrigenVuelo = origenVuelo;
            DestinoVuelo = destinoVuelo;
            FechaSalida = fechaSalida;
            CantidadPuestos = cantidadPuestos;
        }

        
    }

    public static class VuelosLista
    {
        public static List<Vuelo> ListaVuelos = new List<Vuelo>();
    }

    
}
