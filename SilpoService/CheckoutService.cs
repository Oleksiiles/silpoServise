namespace Silpo.Service
{

    public class CheckoutService
    {
        private Check check;
        public CheckoutService()
        {

        }
        public void OpenCheck()
        {
            check = new Check();


        }
        public void AddProduct(Product product)
        {
            check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            return check;
        }

    }
}
