using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaDevintaPaskaita.Models
{
    public struct Invoice
    {
        public string Sender { get; }
        public decimal Amount { get; }
        public string InvoiceNumber { get; }

        private static int InvoiceSeriesNumber { get; set; } = 0;

        public Invoice(string sender, decimal amount) : this()
        {
            Sender = sender;
            Amount = amount;
            InvoiceNumber = $"Nr_{DateTime.Today.Year}_{DateTime.Today.Month}_{DateTime.Today.Day}_{InvoiceSeriesNumber++}";
        }
    }
}
