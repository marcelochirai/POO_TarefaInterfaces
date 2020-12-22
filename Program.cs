using System;
using System.Globalization;
using POO_TarefaInterfaces.Entities;
using POO_TarefaInterfaces.Services;

//CONTEÚDO DISPONÍVEL NA AULA DO DIA 30/11/20 (SLIDES 5, 6, 7 E 8);
//Desenvolva um programa que leia os dados da locação (modelo do carro, instante inicial e final da locação),
//bem como o valor por hora e o valor diário de locação.


namespace POO_TarefaInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inmforme os dados da locação");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Check-out (dd/mm/aaaa HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check-in (dd/MM/aaaa HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Informe o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o preço da diária: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("FATURA:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}