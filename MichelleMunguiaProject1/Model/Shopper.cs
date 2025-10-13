namespace MichelleMunguiaProject1.Model;

/// <summary>
///     Shopper Class
/// </summary>
public class Shopper
{
    private decimal _moneyAvailable;

    private string _name = string.Empty;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Shopper" /> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="moneyAvailable">The money available.</param>
    public Shopper(string name, decimal moneyAvailable)
    {
        Name = name;
        MoneyAvailable = moneyAvailable;
        Cars = [];
    }

    private List<Car> Cars { get; }

    /// <summary>
    ///     Gets & sets the name.
    /// </summary>
    /// <value>
    ///     The name.
    /// </value>
    /// <exception cref="System.ArgumentException">Name cannot be null</exception>
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be null");
            _name = value.Trim();
        }
    }

    /// <summary>
    ///     Gets & sets the money available.
    /// </summary>
    /// <value>
    ///     The money available.
    /// </value>
    /// <exception cref="System.ArgumentOutOfRangeException">MoneyAvailable</exception>
    public decimal MoneyAvailable
    {
        get => _moneyAvailable;
        set
        {
            const string msg = "Money cannot be less than 0";
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(MoneyAvailable), msg);
            _moneyAvailable = value;
        }
    }

    public IReadOnlyList<Car> OwnedCars => Cars.AsReadOnly();

    /// <summary>
    ///     Determines whether this instance can purchase the specified car.
    /// </summary>
    /// <param name="car">The car.</param>
    /// <returns>
    ///     <c>true</c> if this instance can purchase the specified car; otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="System.ArgumentNullException">car</exception>
    public bool CanPurchase(Car car)
    {
        const string msg = "Car cannot be null.";

        if (car == null)
            throw new ArgumentNullException(nameof(car), msg);

        var totalCost = car.Price + car.Price * CarLot.TaxRate;

        return MoneyAvailable >= totalCost;
    }

    /// <summary>
    ///     Purchases the car.
    /// </summary>
    /// <param name="car">The car.</param>
    /// <exception cref="System.ArgumentNullException">car</exception>
    /// <exception cref="System.InvalidOperationException">Shopper does not have enough money to purchase this car.</exception>
    public void PurchaseCar(Car car)
    {
        const string msg = "Car cannot be null.";
        if (car == null)
            throw new ArgumentNullException(nameof(car), msg);

        var totalCost = car.Price + car.Price * CarLot.TaxRate;

        if (MoneyAvailable < totalCost)
            throw new InvalidOperationException("Shopper does not have enough money to purchase this car.");

        Cars.Add(car);
        MoneyAvailable -= totalCost;
    }
}