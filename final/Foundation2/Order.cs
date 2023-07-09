using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }
        totalCost += customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += "Name: " + product.Name + ", Product ID: " + product.ProductID + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Name: " + customer.Name + "\n" + customer.Address.GetAddressAsString();
    }
}
