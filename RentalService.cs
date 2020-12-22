using System;
using System.Collections.Generic;
using System.Text;
using POO_TarefaInterfaces.Services;
using POO_TarefaInterfaces.Entities;

/*
Cálculos: 
Duração = (25 / 06 / 2018 14:40)-(25 / 06 / 2018 10:30) = 4:10 = 5 hours
Pagamento Básico = 5 * 10 = 50 
Taxa = 50 * 20% = 50 * 0.2 = 10
*/
namespace POO_TarefaInterfaces.Services
{
        class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private BrazilTaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, BrazilTaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                /*
                 *Ceiling() is a Math class method. 
                 *This method is used to find the smallest integer , which is greater than or equal to the passed argument. 
                 *The Celing method operates both functionalities in decimal and double. 
                 *This method can be overload by passing different arguments to it.
                */
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
