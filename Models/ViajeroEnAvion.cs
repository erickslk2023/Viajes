using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ViajeroEnAvion: Viajero, IRequisitos
    {
        public string VerificarRequisitos()
        {

            if (base.vencimientoPasaporte <= base.fechadeViaje)
            {
                return "Su Pasaporte Expiro, No puede Viajar.";
            }
            else
            {
                return " !!! Feliz Viaje !!!";
            }
         
        }
    }
}
