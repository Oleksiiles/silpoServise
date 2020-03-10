using System;
public abstract class Offer
{
    public readonly DateTime expirationDate;
   public abstract void Apply(Check check);

    protected bool isExpiried()
    {
        return expirationDate <= DateTime.Today;
    }

   