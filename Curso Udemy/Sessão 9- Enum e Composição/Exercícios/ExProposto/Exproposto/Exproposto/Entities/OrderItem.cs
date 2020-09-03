using System.Globalization;
using System.Text;

namespace Exproposto.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity,  Product product)
        {
            Quantity = quantity;            
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", ");
            sb.Append(Product.Price.ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Sub-total: $");
            sb.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
