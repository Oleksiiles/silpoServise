using System;

public class DiscountOffer : Offer
{
    int Discount { get; set; }

    public DiscountOffer(int discount, DateTime expirationDate)
    {

        Discount = discount;
        ExpirationDate = expirationDate;

    }

    public DiscountOffer(int discount)
    {

        Discount = discount;
        ExpirationDate = new DateTime(2021, 2, 1, 12, 12, 12);

    }
    public override void Apply(Check check)
    {
        check.Discount = Discount;
    }
}