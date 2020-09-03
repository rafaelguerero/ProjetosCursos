using System.Globalization;

namespace ExProduct.Entities
{
    class ImportedProduct: Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee): base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return Name + " - $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Custom fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
