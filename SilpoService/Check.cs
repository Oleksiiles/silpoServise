using System.Collections.Generic;
public class Check
{
    private List<Product> products = new List<Product>();
    private int totalCost;
    public int GetTotalCost()
    {
        int totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.Price;
        }
        return totalCost;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        // if (products.ContainsKey(product))
        // {
        //     products[product]++;

        // }
        // else
        // {
        //     products.Add(product, 1);

        // }

    }




}