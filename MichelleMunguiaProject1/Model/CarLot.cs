namespace MichelleMunguiaProject1.Model
{
    public class CarLot
    {
        public List<Car> Inventory;

        public const double TaxRate = 0.078;

        public CarLot()
        {
            Inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        public void StockLotWithDefaultInventory()
        {
            Inventory.Add(new Car("Ford", "Focus ST", 28.3, 26298.98));
            Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19, 65401.23));
            Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2, 26780));
            Inventory.Add(new Car("Lexus", "ES 350", 24.1, 42101.10));
        }

        public List<Car> FindCarsByMake(string make)
        {
            return null;
        }

        public List<Car> FindCarByMakeModel(string make, string model)
        {
            return null;
        }

        public List<Car> PurchaseCar(string make, string model)
        {
            return null;
        }

        public void AddCar(Car car)
        {
            Inventory.Add(car);
        }

        public void RemoveCar(Car car)
        {
            Inventory.Remove(car);
        }

    }
}
