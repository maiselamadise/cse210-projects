using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double subtotal = 0;
        foreach (Product p in _products)
        {
            subtotal += p.GetTotalCost();
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;

        return subtotal + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Product p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
