namespace homework.Models;

public class CarVM
{
    public string Name { get; set; }
    public string Img { get; set; }
    public string Icon { get; set; }
    public decimal Price { get; set; }
    public decimal Total => Price * Quantity;
    public int Quantity { get; set; }

    public CarVM() { }

    public CarVM(string name, string img, string icon, decimal price, int quanti)
    {
        Name = name;
        Img = img;
        Icon = icon;
        Price = price;
        Quantity = quanti;
    }
}
