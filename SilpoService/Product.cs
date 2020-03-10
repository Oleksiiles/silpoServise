public class Product {
    public int Price;
    public string Name;
    public Category Category;

    public Brend Brend;

    public Product (int price, string name) {
        Price = price;
        Name = name;
    }
    public Product (int price, string name, Category category) {
        Price = price;
        Name = name;
        Category = category;
    }

    public Product (int price, string name, Brend brend) {
        Price = price;
        Name = name;
        Brend = brend;
    }
}