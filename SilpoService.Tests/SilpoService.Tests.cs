using Xunit;
using Silpo.Service;

namespace Silpo.UnitTests.Services
{
    public class CheckoutServiceTest
    {
        // private  CheckoutService _checkoutService;

        // public  CheckoutServiceTest()
        // {
        //     _checkoutService = new CheckoutService();
        // }

        [Fact]
        void CloseChek_withOneProduct()
        {
            CheckoutService _checkoutService = new CheckoutService();

            _checkoutService.OpenCheck();

            _checkoutService.AddProduct(new Product(7, "Milk"));
            Check check = _checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());

        }

        [Fact]
        void CloseChek_withTwoProduct()
        {
            CheckoutService _checkoutService = new CheckoutService();

            _checkoutService.OpenCheck();

            _checkoutService.AddProduct(new Product(7, "Milk"));
            _checkoutService.AddProduct(new Product(3, "Bred"));

            Check check = _checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());

        }
    }
}