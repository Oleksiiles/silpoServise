using System;

public class FactorByCaregoryOffer : Offer
{
    public Category Category;
    public int Factor;



    public FactorByCaregoryOffer(Category category, int factor, DateTime expirationDate)
    {
        Category = category;
        Factor = factor;
        ExpirationDate = expirationDate;


    }

    public FactorByCaregoryOffer(Category category, int factor)
    {
        Category = category;
        Factor = factor;
        ExpirationDate = new DateTime(2021, 2, 1, 12, 12, 12);

    }

    public override void Apply(Check check)
    {
        int points = check.GetCostByCategory(Category);
        check.AddPoints(points * (Factor - 1));
    }

}