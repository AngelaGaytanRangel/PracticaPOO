namespace Supermercado
{
    public class FixedPriceProduct : Product
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public override decimal ValueToPay()
        {
            return Price + (decimal)Tax * Price;
        }
    }
}
