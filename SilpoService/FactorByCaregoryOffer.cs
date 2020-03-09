public class FactorByCaregoryOffer : AnyGoodsOffer
{
    public Category Category;
    public int Factor;
    public FactorByCaregoryOffer(Category category, int factor)
    : base(0, 0)
    {
        Category = category;
        Factor = factor;
    }


}