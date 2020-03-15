using System;

public class DiscountOfferMain : Offer
{
    int Discount { get; set; }

    public DiscountOfferMain(int discount, DateTime expirationDate)
    {

        Discount = discount;
        ExpirationDate = expirationDate;

    }

    public DiscountOfferMain(int discount)
    {

        Discount = discount;
        ExpirationDate = new DateTime(2021, 2, 1, 12, 12, 12);

    }
    public override void Apply(Check check)
    {
        check.Discount = Discount;
    }
}