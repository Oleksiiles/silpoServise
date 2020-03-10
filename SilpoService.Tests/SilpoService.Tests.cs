using Silpo.Service;
using Xunit;

namespace Silpo.UnitTests.Services {
    public class CheckoutServiceTest {
        static CheckoutService _checkoutService;
        Product milk = new Product (7, "Milk", Category.MILK);
        Product bread = new Product (5, "Bread");

        Product Shampoo = new Product (8, "Shampoo", Brend.ProcterAndGamble);

        public CheckoutServiceTest () {
            _checkoutService = new CheckoutService ();
            _checkoutService.OpenCheck ();

        }

        [Fact]
        void CloseChek_withOneProduct () {
            _checkoutService.AddProduct (milk);
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (7, check.GetTotalCost ());

        }

        [Fact]
        void CloseChek_withTwoProduct () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (12, check.GetTotalCost ());

        }

        [Fact]
        void addProduct_whenCheckIsClose_openNewCheck () {
            _checkoutService.AddProduct (bread);
            Check check = _checkoutService.CloseCheck ();

            _checkoutService.AddProduct (milk);
            check = _checkoutService.CloseCheck ();

            Assert.Equal (7, check.GetTotalCost ());

        }

        [Fact]
        void CloseCheck_CalcTotalPoints () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (12, check.GetTotalPoints ());
        }

        [Fact]
        void UseOffer_addOfferPoints () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);

            _checkoutService.useOffer (new AnyGoodsOffer (6, 2));
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (14, check.GetTotalPoints ());
        }

        [Fact]
        void UseOffer_whenCostLessThenRequired_doNothing () {
            _checkoutService.AddProduct (bread);

            _checkoutService.useOffer (new AnyGoodsOffer (6, 2));
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (5, check.GetTotalPoints ());
        }

        [Fact]
        void UseOffer_factorByCategory () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);

            _checkoutService.useOffer (new FactorByCaregoryOffer (Category.MILK, 2));
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (33, check.GetTotalPoints ());
        }

        [Fact]
        void UseOfferWithExpiried_ () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);

            _checkoutService.useOffer (new FactorByCaregoryOffer (Category.MILK, 2, new System.DateTime (2020, 1, 10, 23, 59, 59)));
            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (19, check.GetTotalPoints ());
        }

        [Fact]
        void UseOfferUntilClose_ () {
            _checkoutService.AddProduct (milk);
            _checkoutService.useOffer (new FactorByCaregoryOffer (Category.MILK, 2));

            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);

            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (33, check.GetTotalPoints ());
        }

        [Fact]
        void UseBonusOffer_ () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);

            _checkoutService.useOffer (new DiscountOffer (50, new System.DateTime (2020, 1, 10, 23, 59, 59)));

            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (6, check.GetTotalCost ());
        }

        [Fact]
        void UseOfferTrademark () {
            _checkoutService.AddProduct (milk);
            _checkoutService.AddProduct (bread);
            _checkoutService.AddProduct (Shampoo);
            // _checkoutService.AddProduct (Shampoo);

            _checkoutService.useOffer (new TradeMarkOffer (Brend.ProcterAndGamble, 10, new System.DateTime (2021, 1, 10, 23, 59, 59)));

            Check check = _checkoutService.CloseCheck ();

            Assert.Equal (30, check.GetTotalPoints ());
        }
    }

}