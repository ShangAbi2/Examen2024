//a:
public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Milage { get; set; }
    public decimal Price { get; set; }

    // Parameterløs konstruktør for CsvHelper.
    public Car() { }
    
    public Car(string model, int year, string color, int milage, decimal price)
    {
        Model = model;
        Year = year;
        Color = color;
        Milage = milage;
        Price = price;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}, Color: {Color}, Milage: {Milage}, Price: {Price}";
    }
}