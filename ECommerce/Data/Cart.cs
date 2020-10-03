using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Data
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void SubItem(Product product, int quantity)
        {
            var line = lineCollection
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();
            if (line.Quantity >= 2)
            {
                line.Quantity -= quantity;
            }
        }

        public virtual void RemoveLine(Product product) =>
            lineCollection.RemoveAll(l => l.Product.Id == product.Id);

        public virtual double ComputeTotalValue() =>
            lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
