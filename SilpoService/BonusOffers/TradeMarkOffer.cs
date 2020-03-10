using System;

public class TradeMarkOffer : Offer {
    public Brend Brend;
    int NumberOfExtraPoints;
    public TradeMarkOffer (Brend brend, int numberOfExtraPoints, DateTime expirationDate) {
        Brend = brend;
        NumberOfExtraPoints = numberOfExtraPoints;
        ExpirationDate = expirationDate;

    }

    public TradeMarkOffer (Brend brend, int numberOfExtraPoints) {
        Brend = brend;
        NumberOfExtraPoints = numberOfExtraPoints;
        ExpirationDate = new DateTime (2021, 2, 1, 12, 12, 12);

    }

    public override void Apply (Check check) {
        if (!isExpiried ()) {
            int points = check.GetNumberOfTradeMark (Brend);
            check.AddPoints (points * NumberOfExtraPoints);
        }
    }

}