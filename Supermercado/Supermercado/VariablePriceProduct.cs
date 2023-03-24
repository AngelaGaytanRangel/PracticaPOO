using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return (decimal)Quantity * (Price + (decimal)Tax * Price) ;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...:{$"{Quantity:N2}",15}";
        }
    }
}
