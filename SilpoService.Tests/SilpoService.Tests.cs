using Silpo.Service;
using Xunit;

namespace Silpo.UnitTests.Services
{
    public class CheckoutServiceTest
    {
        static CheckoutService _checkoutService;
        Product milk = new Product(7, "Milk");
        Product bread = new Product(5, "Bread");


        public CheckoutServiceTest()
        {
            _checkoutService = new CheckoutService();
            _checkoutService.OpenCheck();

        }

        [Fact]
        void CloseChek_withOneProduct()
        {
            _checkoutService.AddProduct(milk);
            Check check = _checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());

        }

        [Fact]
        void CloseChek_withTwoProduct()
        {
            _checkoutService.AddProduct(milk);
            _checkoutService.AddProduct(bread);
            Check check = _checkoutService.CloseCheck();

            Assert.Equal(12, check.GetTotalCost());

        }

        [Fact]
        void addProduct_whenCheckIsClose_openNewCheck()
        {
            _checkoutService.AddProduct(bread);
            Check check = _checkoutService.CloseCheck();

            _checkoutService.AddProduct(milk);
            check = _checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());

        }

        [Fact]
        void CloseCheck_CalcTotalPoints()
        {
            _checkoutService.AddProduct(milk);
            _checkoutService.AddProduct(bread);
            Check check = _checkoutService.CloseCheck();

            Assert.Equal(12, check.GetTotalPoints());
        }

    }
}