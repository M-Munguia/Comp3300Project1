namespace MichelleMunguiaProject1.Model;

/// <summary>
/// Car Lot Class
/// </summary>
public class CarLot
{
    public const decimal TaxRate = 0.078m;

    /// <summary>
    /// Initializes a new instance of the <see cref="CarLot"/> class.
    /// </summary>
    public CarLot()
    {
        Inventory = new List<Car>();
        StockLotWithDefaultInventory();
    }

    /// <summary>
    /// Gets the count.
    /// </summary>
    /// <value>
    /// The count.
    /// </value>
    public int Count => Inventory.Count;

    public List<Car> Inventory { get; }

    /// <summary>
    /// Stocks the lot with default inventory.
    /// </summary>
    public void StockLotWithDefaultInventory()
    {
        Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
        Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
        Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
        Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
    }

    /// <summary>
    /// Finds the cars by make.
    /// </summary>
    /// <param name="make">The make.</param>
    /// <returns></returns>
    /// <exception cref="System.InvalidOperationException"></exception>
    public List<Car> FindCarsByMake(string make)
    {
        var matchingMakeCars =
            Inventory.Where(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
        return (matchingMakeCars.Count > 0 ? matchingMakeCars : null) ?? throw new InvalidOperationException();
    }

    /// <summary>
    /// Finds the car by make model.
    /// </summary>
    /// <param name="make">The make.</param>
    /// <param name="model">The model.</param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentNullException"></exception>
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

    /// <summary>
    /// Purchases the car.
    /// </summary>
    /// <param name="make">The make.</param>
    /// <param name="model">The model.</param>
    /// <returns></returns>
    public Car? PurchaseCar(string make, string model)
    {
        var purchasedCar = Inventory.FirstOrDefault(c =>
            c.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
            c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        if (purchasedCar == null) return null;
        Inventory.Remove(purchasedCar);
        return purchasedCar;
    }

    /// <summary>
    /// Adds the car.
    /// </summary>
    /// <param name="make">The make.</param>
    /// <param name="model">The model.</param>
    /// <param name="mpg">The MPG.</param>
    /// <param name="price">The price.</param>
    public void AddCar(string make, string model, decimal mpg, decimal price)
    {
        var car = new Car(make, model, mpg, price);
        Inventory.Add(car);
    }

    /// <summary>
    /// Gets the total cost of purchase.
    /// </summary>
    /// <param name="car">The car.</param>
    /// <returns></returns>
    public decimal GetTotalCostOfPurchase(Car car)
    {
        var totalTax = car.Price * TaxRate;
        var totalCost = car.Price + totalTax;

        return totalCost;
    }

    /// <summary>
    /// Finds the least expensive car.
    /// </summary>
    /// <returns></returns>
    public Car? FindLeastExpensiveCar()
    {
        if (Count == 0)
            return null;

        var cheapestCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Price < cheapestCar.Price)) cheapestCar = car;

        return cheapestCar;
    }

    /// <summary>
    /// Finds the most expensive car.
    /// </summary>
    /// <returns></returns>
    public Car? FindMostExpensiveCar()
    {
        if (Count == 0)
            return null;

        var expensiveCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Price > expensiveCar.Price)) expensiveCar = car;

        return expensiveCar;
    }

    /// <summary>
    /// Finds the best MPG car.
    /// </summary>
    /// <returns></returns>
    public Car? FindBestMpgCar()
    {
        if (Count == 0)
            return null;

        var bestMpgCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Mpg > bestMpgCar.Mpg)) bestMpgCar = car;

        return bestMpgCar;
    }

    /// <summary>
    /// Finds the worst MPG car.
    /// </summary>
    /// <returns></returns>
    public Car? FindWorstMpgCar()
    {
        if (Count == 0)
            return null;

        var worstMpgCar = Inventory[0];

        foreach (var car in Inventory.Where(car => car.Mpg < worstMpgCar.Mpg)) worstMpgCar = car;

        return worstMpgCar;
    }
}