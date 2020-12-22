using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

//Fatura - a ser exibida no final.
namespace POO_TarefaInterfaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            return 
            "Pagamento básico: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento total: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

