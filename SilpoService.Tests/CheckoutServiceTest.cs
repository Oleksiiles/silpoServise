using Xunit;
using Silpo.Services;

namespace Silpo.UnitTests.Services
{
    public class CheckoutServiceTest
    {
        private readonly CheckoutService _checkoutService;

        public SilpoService_Test()
        {
            checkoutService = new CheckoutService();
        }


        void closeChek_withOneProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openChel();

            checkoutService.addProduct(new Product(7, "Milk"));
            Check check = checkoutService.closeCheck();

            // Test ? 

            assertThat(check.getTotalCost(), is (7));

            // **** 
        }

        void closeChek_withTwoProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openChek();

            checkoutService.addProduct(new Product(7, "Milk"));
            checkoutService.addProduct(new Product(3, "Bred"));

            Chek chek = checkoutService.closeCheck();
            check.products.clear();

            // Test ? 

            assertThat(check.getTotalCost(), is (10));

            // ****         
        }
    }
}