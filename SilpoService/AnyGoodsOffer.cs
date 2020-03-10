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
        if (TotalCost <= check.GetTotalCost())
        {
            check.AddPoints(Points);

        }
    }
}