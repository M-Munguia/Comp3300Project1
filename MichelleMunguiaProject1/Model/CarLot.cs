namespace MichelleMunguiaProject1.Model;

public class CarLot
{
    public const decimal TaxRate = 0.078m;
    public List<Car> Inventory;

    public CarLot()
    {
        Inventory = new List<Car>();
        StockLotWithDefaultInventory();
    }

    public void StockLotWithDefaultInventory()
    {
        Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
        Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
        Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
        Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
    }

    public List<Car> FindCarsByMake(string make)
    {
        var matchingMakeCars =
            Inventory.Where(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
        return (matchingMakeCars.Count > 0 ? matchingMakeCars : null) ?? throw new InvalidOperationException();
    }

    public Car? FindCarByMakeModel(string make, string model)
    {
        const string msg = "make and Model cannot be null";

        if (string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model))
            throw new ArgumentNullException(msg);

        var matchedCar = Inventory.FirstOrDefault(car =>
            car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
            car.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        return matchedCar;
    }

    public Car? PurchaseCar(string make, string model)
    {
        var purchasedCar = Inventory.FirstOrDefault(c =>
            c.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
            c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        if (purchasedCar == null) return null;
        Inventory.Remove(purchasedCar);
        return purchasedCar;
    }

    public void AddCar(string make, string model, decimal mpg, decimal price)
    {
        var car = new Car(make, model, mpg, price);
        Inventory.Add(car);
    }

    public decimal GetTotalCostOfPurchase(Car car)
    {
        var totalTax = car.Price * TaxRate;
        var totalCost = car.Price + totalTax;

        return totalCost;
    }

    public Car? FindLeastExpensiveCar()
    {
        if (Inventory.Count == 0)
            return null;

        var cheapestCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Price < cheapestCar.Price)) cheapestCar = car;

        return cheapestCar;
    }

    public Car? FindMostExpensiveCar()
    {
        if (Inventory.Count == 0)
            return null;

        var expensiveCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Price > expensiveCar.Price)) expensiveCar = car;

        return expensiveCar;
    }

    public Car? FindBestMPGCar()
    {
        return null;
    }

    public Car? FindWorstMPGCar()
    {
        return null;
    }
}