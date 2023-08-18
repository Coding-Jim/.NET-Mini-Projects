List<IRentals> rentals = new List<IRentals>();
List<IPurchasables> purchasables = new List<IPurchasables>();

CarModel car = new CarModel { ProductName = "Tesla", ProductQuantity = 80, Capacity = 5, CarProperty = "Car goes VROOM" };
MotorcycleModel motorcycle = new MotorcycleModel { ProductName = "Yamaha", ProductQuantity = 200, Capacity = 2, MotorcycleProperty = "Motorycycle goes BRRRR" };
TruckModel truck = new TruckModel { ProductName = "DAF", ProductQuantity = 30, Capacity = 2, TruckProperty = "Truck goes TOOTOO" };

rentals.Add(car);
rentals.Add(truck);
purchasables.Add(car);
purchasables.Add(motorcycle);

Console.Write("Do you want to rent or purchase (rent/purchase): ");
string wantToRentorPurchase = Console.ReadLine();

if (wantToRentorPurchase.ToLower() == "rent")
{
    foreach (IRentals item in rentals)
    {
        Console.WriteLine($"Do you want to rent {item.ProductName}? (yes/no): ");
        string wantToRent = Console.ReadLine();
        if (wantToRent.ToLower() == "yes")
        {
            Console.WriteLine($"{item.ProductName} has been rented.");
        }

        Console.WriteLine($"Do you want to return {item.ProductName}? (yes/no): ");
        string wantToReturn = Console.ReadLine();
        if (wantToReturn.ToLower() == "yes")
        {
            Console.WriteLine($"{item.ProductName} has been returned.");
        }
    }
}

if (wantToRentorPurchase.ToLower() == "purchase")
{
    foreach (IPurchasables item in purchasables)
    {
        Console.WriteLine($"Do you want to purchase {item.ProductName}? (yes/no): ");
        string wantToPurchase = Console.ReadLine();
        if (wantToPurchase.ToLower() == "yes")
        {
            Console.WriteLine($"{item.ProductName} has been purchased.");
        }
    }
}

Console.WriteLine("We are done here.");

public interface IInventory
{
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
}

public interface IRentals : IInventory
{
    void Rent();
    void Return();
}

public interface IPurchasables : IInventory
{
    void Purchase();
}

public class Vehicle : IInventory
{
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public int Capacity { get; set; }
    public void Drive() { Console.WriteLine("I'm driving"); }
    public void Break() { Console.WriteLine("I'm breaking"); }
}

public class CarModel : Vehicle, IPurchasables, IRentals
{
    public string CarProperty { get; set; }
    public void Purchase()
    {
        Console.WriteLine("this car is purchased.");
    }
    public void Rent()
    {
        Console.WriteLine("this car is rented.");
    }
    public void Return()
    {
        Console.WriteLine("this car is returned.");
    }
}

public class MotorcycleModel : Vehicle, IPurchasables
{
    public string MotorcycleProperty { get; set; }
    public void Purchase()
    {
        Console.WriteLine("this motorcycle is purchased.");
    }
}

public class TruckModel : Vehicle, IRentals
{
    public string TruckProperty { get; set; }
    public void Rent()
    {
        Console.WriteLine("this truck is rented.");
    }
    public void Return()
    {
        Console.WriteLine("this truck is returned.");
    }
}