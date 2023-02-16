using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
 
        public string nacionalidad { get; set; }
  

        public int getEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = 0;

            if (fechaNacimiento.Month > hoy.Month)
            {
                edad = hoy.Year - fechaNacimiento.Year;
            }
            else
            {

                edad = (hoy.Year - fechaNacimiento.Year) - 1;
            }


            return edad;
        }

        public virtual string toString()
        {
          

            return $"Nombre: {nombre}\n Apellido: {apellido}\n Edad: {getEdad()}\n Nacionalidad: {nacionalidad}\n";

        }

      
    }
}
