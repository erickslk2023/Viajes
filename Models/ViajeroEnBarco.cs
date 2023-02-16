using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ViajeroEnBarco: Viajero, IRequisitos
    {


        public string VerificarRequisitos()
        {

            if (base.destino == "Roatan") 
            { if (base.boleto == false)
                {
                    return "si su destino es Roatan, Puede comprar un Boleto";
                }
               return "!!!Feliz Viaje!!!";
               }
            else
            {
              return "No puede Viajar por Barco, Busque otro medio de Transporte";
            }
        }



    }
}
