using System;
public abstract class Offer
{
    public  DateTime ExpirationDate;
   public abstract void Apply(Check check);

    protected bool isExpiried()
    {
        return ExpirationDate <= DateTime.Today;
    }

}