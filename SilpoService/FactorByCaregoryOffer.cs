public class FactorByCaregoryOffer : Offer
{
    public Category Category;
    public int Factor;
    public FactorByCaregoryOffer(Category category, int factor)
    {
        Category = category;
        Factor = factor;

    }

    public override void Apply(Check check)
    {
        if (true)
        {
            int points = check.GetCostByCategory(Category);
            check.AddPoints(points * (Factor - 1));
        }
    }

}