namespace MichelleMunguiaProject1.Model
{
    public class Car
    {
        private string _model = string.Empty;
        private string _make = string.Empty;
        private double _mpg; 
        private double _price;

        public Car(string make, string model, double mpg, double price)
        {
            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }

        public string Make
        {
            get => _make;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First Name cannot be null");
                _make = value.Trim();
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First Name cannot be null");
                _model = value.Trim();
            }
        }

        public double Mpg
        {
            get => _mpg;
            set
            {
                const string msg = "MPG cannot be less than 0";
                if (value is < 0)
                    throw new ArgumentOutOfRangeException(nameof(Mpg), msg);
                _mpg = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                const string msg = "Score must be between 0 and 100.";
                if (value is < 0 )
                    throw new ArgumentOutOfRangeException(nameof(Price), msg);
                _price = value;
            }
        }


    }
}
