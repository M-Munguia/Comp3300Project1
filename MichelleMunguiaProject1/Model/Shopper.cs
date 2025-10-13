namespace MichelleMunguiaProject1.Model
{
    public class Shopper
    {

        private string _name = string.Empty;

        private decimal _moneyAvailable;
        private List<Car> Cars { get; }

        public Shopper(string name, decimal moneyAvailable)
        {
            Name = name;
            MoneyAvailable = moneyAvailable;
            Cars = [];
        }

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

        public bool CanPurchase(Car car)
        {
            const string msg = "Car cannot be null.";

            if (car == null)
                throw new ArgumentNullException(nameof(car), msg);

            var totalCost = car.Price + (car.Price * CarLot.TaxRate);

            return MoneyAvailable >= totalCost;
        }

        public void PurchaseCar(Car car)
        {
            const string msg = "Car cannot be null.";
            if (car == null)
                throw new ArgumentNullException(nameof(car), msg);

            var totalCost = car.Price + (car.Price * CarLot.TaxRate);

            if (MoneyAvailable < totalCost)
                throw new InvalidOperationException("Shopper does not have enough money to purchase this car.");

            Cars.Add(car);

            MoneyAvailable -= totalCost;
        }



    }
}
