namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!
        public void AddProduct(string name, double price)
        {
            _products.Add(new Product(name, price));
        }

        public void RemoveProduct(string productName)
        {
            Product targetProduct = _products.FirstOrDefault(x => x.Name == productName);
            if (targetProduct != null)
            {
                _products.Remove(targetProduct);
                return;
            }
            throw new InvalidOperationException();

        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (var item in _products)
            {
               totalPrice += item.Price;
            }
            return totalPrice;
        }
        public List<Product> GetProducts()
        {
            return new List<Product>(_products);
        }

    }
}
