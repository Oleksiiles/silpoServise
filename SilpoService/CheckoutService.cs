public class CheckoutService
{
    private Check check;
    public void CheckoutService()
    {

    }
    public openCheck()
    {
        check = new Check();
        check.products = new ArrayList<>();
        check.totalCost = 0;

    }
    public void addProduct(Product product)
    {
        check.products.add(product);
    }

    public closeCheck()
    {
        foreach(var product in check.products)
        {
            check.totalCost += product.price;
        }
        return check;
    }


}