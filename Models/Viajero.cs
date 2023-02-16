using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Viajero:Persona
    {
        public bool boleto { get; set; }
        public string destino { get; set; }
        public string pasaporte { get; set; }
        public DateOnly vencimientoPasaporte { get; set; }
        public DateOnly fechadeViaje { get; set; }
        public string tieneBoleto;





        public override string toString()
        {

            if (boleto == true)
            {
                tieneBoleto = "SI";
            }

            if (boleto == false)
            {
                tieneBoleto = "NO";
            }
            return $"{base.toString()} Boleto: {tieneBoleto}\n Destino: {destino}\n Fecha de Viaje: {fechadeViaje}\n " +
                $"Numero de Pasaporte {pasaporte}\n Fecha de Vencimiento {vencimientoPasaporte}\n";
        }
    }
}
