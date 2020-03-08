public class AnyGoodsOffer
{
    public int TotalCost { get; set; } = 0;
    public int Points { get; set; } = 0;
    public AnyGoodsOffer(int totalCost, int points)
    {
        TotalCost = totalCost;
        Points = points;
    }
}