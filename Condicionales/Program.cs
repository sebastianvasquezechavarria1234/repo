using System;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto 1

            //Console.WriteLine("Estas inscrito en el evento ?");
            //string Evento = Console.ReadLine();


            //Console.WriteLine("Cual es tu edad ?");
            //byte Edad = byte.Parse(Console.ReadLine());

            //Console.Clear();

            //if (Evento == "si")
            //{
            //    if (Edad >= 18 && Edad <= 25)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Puedes ingresar al evento");
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"No puedes ingresar tu edad es de {Edad}");
            //        Console.ResetColor();
            //    }
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("No puedes ingresar ¡NO ESTAS INSCRITO!");
            //    Console.ResetColor();
            //}


            // Punto 2

            //byte Kilometros = 5;
            //float Ingresos = 600000f;
            //float SalarioMinimo = 1300000f;

            //float Beca = SalarioMinimo - (SalarioMinimo * 0.44f);

            //Console.WriteLine($"La beca es de: {Beca:C0}");
            //Console.WriteLine("----------------------------");

            //Console.WriteLine("Ingrese la distancia entre tu casa hacia tu universidad:");
            //byte KilometrosDigitados = byte.Parse(Console.ReadLine());

            //Console.WriteLine("Ingresa tus ingresos mensuales:");
            //float IngresosDigitados = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el numero de su estracto:");
            //byte Estracto = byte.Parse(Console.ReadLine());

            //Console.Clear();
            //if (KilometrosDigitados > Kilometros && IngresosDigitados < Ingresos)
            //{
            //    if (Estracto == 1 || Estracto == 2)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Tu aplicas ala beca de {Beca}");
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Tu no aplicas. Intentalo en otra ocacion estrato");
            //        Console.ResetColor();
            //    }
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Tu no aplicas. Intentalo en otra ocacion");
            //    Console.ResetColor();
            //}


            // Punto 3

            //Random GeneradorVelocidad = new Random();

            //int NumeroAleatorio = GeneradorVelocidad.Next(0, 180);

            //Console.WriteLine("Fecha:" + DateTime.Now);
            //Console.WriteLine($"La velocidad es de: {NumeroAleatorio}");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("");


            //switch (NumeroAleatorio)
            //{
            //    case int n when (n >= 0 && n <= 30):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Zona Escolares");
            //        Console.WriteLine($"Valocidad transitada: {n}");
            //        Console.WriteLine($"Valocidad Maxima: 30");
            //        Console.ResetColor();
            //        break;

            //    case int n when (n > 30 && n <= 60):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Zona Urbana");
            //        Console.WriteLine($"Valocidad transitada: {n}");
            //        Console.WriteLine($"Valocidad Maxima: 60");
            //        Console.ResetColor();
            //        break;

            //    case int n when (n > 60 && n <= 80):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Zona Urbana");
            //        Console.WriteLine($"Vias rurales: {n}");
            //        Console.WriteLine($"Valocidad Maxima: 80");
            //        Console.ResetColor();
            //        break;

            //    case int n when (n > 80 && n <= 100):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Rutas nacionales");
            //        Console.WriteLine($"Valocidad transitada: {n}");
            //        Console.WriteLine($"Valocidad Maxima: 100");
            //        Console.ResetColor();
            //        break;

            //    case int n when (n > 100):
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"Tu velocidad es de: {n}");
            //        Console.WriteLine("¡Pasate el limite de velocidad que es de 100km/h Por ende tienes una multa de 800.000!");
            //        Console.ResetColor();
            //        break;
            //}

            // Punto 4

            //Console.WriteLine("Ingrese su edad: ");
            //int Edad = int.Parse(Console.ReadLine());

            //float SalarioMinimo = 1423500f;

            //float SubsidioInfantes = SalarioMinimo + (SalarioMinimo * 0.12f);
            //float SubsidioNinos = SalarioMinimo + (SalarioMinimo * 0.10f);
            //float SubsidioPreAdolecente = SalarioMinimo + (SalarioMinimo * 0.05f);
            //float SubsidioAdultoMayor = SalarioMinimo * 0.05f;
            //float SubsidioAdultoMayorCalculado = SubsidioAdultoMayor + SalarioMinimo;


            //Console.WriteLine("-------------------");
            //Console.WriteLine("");

            //switch (Edad)
            //{
            //    case int e when (e > 0 && e <= 5):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Está en un programa de bebés sanos de 0 a 5 años, tu edad es de: {Edad} años");
            //        Console.WriteLine($"Tu subsidio es del 12% del salrio minimo: {SubsidioInfantes:C0}");
            //        Console.ResetColor();
            //        break;

            //    case int e when (e >= 6 && e <= 10):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Está en un programa de niños canguro. de 6 a 10 años, tu edad es de: {Edad} años");
            //        Console.WriteLine($"Tu subsidio es del 10% del salrio minimo: {SubsidioNinos:C0}");
            //        Console.ResetColor();
            //        break;

            //    case int e when (e >= 10 && e <= 15):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Está en un programa de joven sano. de 10 a 15 años, tu edad es de: {Edad} años");
            //        Console.WriteLine($"Tu subsidio es del 5% del salrio minimo: {SubsidioPreAdolecente:C0}");
            //        Console.ResetColor();
            //        break;


            //    case int e when (e >= 56):
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Tu eres un Adulto Anciano, tu edad es de: {Edad} años");
            //        Console.WriteLine($"Tu subsidio es del : {SubsidioAdultoMayorCalculado:C0}");
            //        Console.ResetColor();
            //        break;


            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("¡Tu no aplias al subsisdio intentalo enotra ocacion!");
            //        Console.ResetColor();
            //        break;
            //}

            // Punto 5

            //Console.WriteLine("Eliga algun servicio dependiendo del numero:");
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine("1 servicio de caja");
            //Console.WriteLine("2 servicio al cliente ");
            //Console.WriteLine("3 pago de impuestos ");
            //Console.WriteLine("4 crédito hipotecario ");
            //Console.WriteLine("5 operaciones con tarjeta de crédito ");

            //Console.Write("Ingrese una opcion de las anteriores.");

            //string Opciones = Console.ReadLine();

            //Random Generador = new Random();

            //float Ticked = Generador.Next(0, 9000);

            //string Servicio = "";

            //int Sucursal = 1;

            //switch (Opciones)
            //{
            //    case "1":
            //        Servicio = "1 servicio de caja";
            //        break;
            //    case "2":
            //        Servicio = "2 servicio al cliente";
            //        break;
            //    case "3":
            //        Servicio = "3 pago de impuestos";
            //        break;
            //    case "4":
            //        Servicio = "4 crédito hipotecario";
            //        break;
            //    case "5":
            //        Servicio = "5 operaciones con tarjeta de crédito";
            //        break;
            //    default:
            //        Console.WriteLine("-------------------------");
            //        Console.WriteLine("");
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("¡Opcion no valida!");
            //        Console.ResetColor();
            //        return;

            //}

            //Console.WriteLine("---------------------");
            //Console.WriteLine("");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Fecha: " + DateTime.Now);
            //Console.WriteLine($"Ticked: {Ticked}");
            //Console.WriteLine($"Sucursales: {Sucursal}");
            //Console.WriteLine($"Servicios: {Servicio}");
            //Console.ResetColor();


            // Punto 6

            Console.WriteLine("Bienvenido ala licorera");
            Console.WriteLine("Seleccione  una opcion:");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.WriteLine("1 Ron ($10)");
            Console.WriteLine("2 Vodka ($12)");
            Console.WriteLine("3 Whisky ($15)");
            Console.WriteLine("4 Tequila ($18)");
            Console.WriteLine("5 Ginebra ($20)");

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Seleccione alguna de las opciones anteriores.");
            int Opciones = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la cantidad del licor");
            int Cantidad = int.Parse(Console.ReadLine());

            string Licores = "";
            int Precio = 0;



            switch (Opciones)
            {
                case 1:
                    Licores = "Ron";
                    Precio = 10;
                    break;
                case 2:
                    Licores = "Vodka";
                    Precio = 12;
                    break;
                case 3:
                    Licores = "Whisky";
                    Precio = 15;
                    break;
                case 4:
                    Licores = "Tequila";
                    Precio = 18;
                    break;
                case 5:
                    Licores = "Ginebra";
                    Precio = 20;
                    break;

                case int n when (n > 5):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"¡Lo setimos este numero de producto: {Opciones} no esta disponible!");
                    Console.ResetColor();
                    return;
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Nombre: {Licores}");
            Console.WriteLine($"Precio: {Precio}");

            int Total = Precio * Cantidad;
            Console.WriteLine($"Total de la compra: {Total}");
            Console.WriteLine("!Gracias por tu visita¡");
            Console.ResetColor();




        }
    }
}
