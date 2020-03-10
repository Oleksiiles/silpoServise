using System;

public class AnyGoodsOffer : Offer
{
    public int TotalCost { get; set; } = 0;
    public int Points { get; set; } = 0;
public AnyGoodsOffer(int totalCost, int points)
    {
        TotalCost = totalCost;
        Points = points;
        ExpirationDate = new DateTime(2021, 2, 1, 12, 12, 12);

    }

    public AnyGoodsOffer(int totalCost, int points, DateTime expirationDate)
    {
        TotalCost = totalCost;
        Points = points;
        ExpirationDate = expirationDate;

    }

    public override void Apply(Check check)
    {
        if (TotalCost <= check.GetTotalCost() && !isExpiried())
        {
            check.AddPoints(Points);

        }
    }
}