using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TarefaInterfaces.Services
{
    class BrazilTaxService
    {
        //o valor do imposto conforme regras do país que, no caso do Brasil, é 20% para valores até 100.00,
        //ou 15% para valores acima de 100.00.
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
