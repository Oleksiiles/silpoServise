namespace Silpo.Service
{

    public class CheckoutService
    {
        private Check check;
        private bool isCheckClose = false;

        // public CheckoutService()
        // {

        // }
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
            isCheckClose = true;
            return check;

        }

        public void useOffer(Offer offer)
        {
            offer.Apply(check);
        }

    }
}