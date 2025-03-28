using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
{
    double totalProductCost = 0;

    foreach (var product in _products)
    {
        totalProductCost += product.GetTotalCost();
    }

    double shippingCost;

    if (_customer.IsInUSA())
    {
        shippingCost = 5.00;
    }
    else
    {
        shippingCost = 35.00;
    }

    return totalProductCost + shippingCost;
}

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{_customer.Name}\n";
        label += _customer.CustomerAddress.GetFullAddress();

        return label;
    }
}
