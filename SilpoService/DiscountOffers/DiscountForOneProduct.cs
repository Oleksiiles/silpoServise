using System;

public class DiscountForOneProduct : Offer
{
    int Discount { get; set; }
    public Product Product { get; set; }

    public DiscountForOneProduct(int discount, Product product, DateTime expirationDate)
    {

        Product = product;
        Discount = discount;
        ExpirationDate = expirationDate;

    }

    public DiscountForOneProduct(int discount)
    {

        Discount = discount;
        ExpirationDate = new DateTime(2021, 2, 1, 12, 12, 12);

    }
    public override void Apply(Check check)
    {
        int PriceDiscountProduct = check.GetPriceDiscountProduct(Product);
        if (Discount == 50)
        {
            check.DiscountForOneProduct = PriceDiscountProduct / 2;
        }
        if (Discount == 100)
        {
            check.DiscountForOneProduct = PriceDiscountProduct + 1;
        }
    }
}