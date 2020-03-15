using System.Collections.Generic;
namespace Silpo.Service
{

    public class CheckoutService
    {
        private Check check;
        private bool isCheckClose = false;

        public List<Offer> allOffers = new List<Offer>();

        public void OpenCheck()
        {
            check = new Check();

        }
        public void AddProduct(Product product)
        {
            if (isCheckClose)
            {
                OpenCheck();
                isCheckClose = false;
            }

            check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            foreach (var offer in allOffers)
            {
                offer.CheckAndApply(check);
            }
            isCheckClose = true;
            return check;

        }

        public void useOffer(Offer offer)
        {
            allOffers.Add(offer);
        }


    }
}
