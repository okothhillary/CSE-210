using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private decimal _shippingCost;

    public Order(List<Product> products, Customer customer, decimal shippingCost)
    {
        _products = products;
        _customer = customer;
        _shippingCost = shippingCost;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculatePrice();
        }
        return totalCost + _shippingCost;
    }

    public string GeneratePackingLabel()
    {
        
        return $"Packing Label for {_customer.Name}";
    }

    public string GenerateShippingLabel()
    {
        
        return $"Shipping Label for {_customer.Name}";
    }
}
