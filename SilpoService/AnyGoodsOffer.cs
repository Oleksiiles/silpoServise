public class AnyGoodsOffer : Offer
{
    public int TotalCost { get; set; } = 0;
    public int Points { get; set; } = 0;
    public AnyGoodsOffer(int totalCost, int points)
    {
        TotalCost = totalCost;
        Points = points;
    }

    public override void Apply(Check check)
    {
        // FactorByCaregoryOffer fbOffer = new FactorByCaregoryOffer;

        // int points = check.GetCostByCategory(fbOffer.Category);
        // check.AddPoints(points * (fbOffer.Factor - 1));
    }
}