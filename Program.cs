using ConsoleApp1.Models;

ViajeroEnBarco v1 = new ViajeroEnBarco()

{
  nombre = "Brianna",
  apellido = "Osorto",
  fechaNacimiento = new DateTime(1990,05,26),
  nacionalidad= "Honduras",
  boleto= true,
  fechadeViaje= new DateOnly(2023,02,15),
  destino= "Roatan",
  pasaporte="d233445",
  vencimientoPasaporte= new DateOnly(2024,11,26)
  
};

Console.WriteLine($"{v1.toString()} {v1.VerificarRequisitos()}\n");


ViajeroEnAvion v2 = new ViajeroEnAvion()
{

    nombre = "Erick",
    apellido = "Osorto",
    fechaNacimiento = new DateTime(1985, 05, 26),
    nacionalidad = "Honduras",
    boleto = true,
    fechadeViaje= new DateOnly(2023,02,16),
    destino = "Miami",
    pasaporte = "d233445",
    vencimientoPasaporte = new DateOnly(2026, 01, 26)
};
Console.WriteLine($"{v2.toString()} {v2.VerificarRequisitos()}\n");

ViajeroEnBus v3 = new ViajeroEnBus()
{
    nombre = "Bessy",
    apellido = "Martinez",
    fechaNacimiento = new DateTime(1990, 05, 27),
    nacionalidad = "Honduras",
    boleto = false,
    fechadeViaje = new DateOnly(2023, 02, 17),
    destino = "La Ceiba",
    pasaporte = "d233445",
    vencimientoPasaporte = new DateOnly(2023, 01, 26)

};
Console.WriteLine($"{v3.toString()} {v3.VerificarRequisitos()}\n");
