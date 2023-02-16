using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ViajeroEnBus:Viajero, IRequisitos
    {
        public string VerificarRequisitos()
        {

            if ((base.destino == "San Pedro Sula")||(base.destino=="La Ceiba"))
            { 
                if (base.boleto == false)
                {
                    return "si Viaja a San Pedro sula o La Ceiba, Puede comprar un boleto";
                }

                return "!!!Feliz Viaje!!!";
            }
            else
            {
                return "No puede Viajar, Busque otro medio de trasnporte";
            }

         
        }

    }
}
