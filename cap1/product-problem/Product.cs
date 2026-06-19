using System;

class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public double StockTotalValue()
    {
        return Price * Quantity;
    }

    public void AddProducts(int quantity)
    {
        Quantity += quantity;
    }

    public void RemoveProducts(int quantity)
    {
        Quantity -= quantity;
    }

    public string ProductsInfo()
    {
        return $"{Name}, $ {Price:F2}, {Quantity} unidades, Total: $ {StockTotalValue():F2}";
    }
}