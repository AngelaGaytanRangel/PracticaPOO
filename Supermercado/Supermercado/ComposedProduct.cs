namespace Supermercado
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public Product Products { get; set; }
        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
