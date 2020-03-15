using System;

public class BonusOffer : Offer, IReward
{
    public BonusOffer()
    {

    }

    public override void Apply(Check check)
    {

    }
    public int CalcPoint(Check check)
    {
        return 5;
    }

}