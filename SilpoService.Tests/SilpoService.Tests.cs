using Silpo.Service;
using Xunit;

namespace Silpo.UnitTests.Services
{
    public class CheckoutServiceTest
    {
        CheckoutService Cheout = new CheckoutService();


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
            _checkoutService.AddProduct(new Product(0, "Bred"));

            Check check = _checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());

        }

        [Fact]
        void addProduct_whenCheckIsClose_openNewCheck()
        {
            CheckoutService _checkoutService = new CheckoutService();
            _checkoutService.OpenCheck();
            _checkoutService.AddProduct(new Product(7, "Milk"));

            Check milkCheck = _checkoutService.CloseCheck();

            _checkoutService.AddProduct(new Product(7, "Bred"));
            Check breadCheck = _checkoutService.CloseCheck();
            Assert.Equal(7, breadCheck.GetTotalCost());

        }


    }
}