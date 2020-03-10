using System.Collections.Generic;

public class Check
{
    private List<Product> products = new List<Product>();
    private int totalPoints { get; set; } = 0;

    public int GetTotalCost(int discount = 0)
    {
        int totalCost = 0;
        foreach (var product in products)
        {

            totalCost += product.Price;

        }
        if (discount != 0)
        {
            return totalCost - totalCost * discount / 100;
        }
        else
        {
            return totalCost;

        }
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

    public int GetTotalPoints()
    {
        totalPoints += GetTotalCost();
        return totalPoints;
    }

    public void AddPoints(int points)
    {
        totalPoints += points;
    }

    public int GetCostByCategory(Category category)
    {
        int sum = 0;
        foreach (var product in products)
        {
            if (product.Category == category)
            {
                sum += product.Price;
            }
        }
        return sum;
    }
}