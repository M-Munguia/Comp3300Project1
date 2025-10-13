namespace MichelleMunguiaProject1.Model
{
    public class Car
    {
        private string _model = string.Empty;
        private string _make = string.Empty;
        private decimal _mpg; 
        private decimal _price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        public Car(string make, string model, decimal mpg, decimal price)
        {
            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }

        /// <summary>
        /// Gets and sets the make.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        /// <exception cref="System.ArgumentException">Make cannot be null</exception>
        public string Make
        {
            get => _make;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Make cannot be null");
                _make = value.Trim();
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Model cannot be null");
                _model = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the MPG.
        /// </summary>
        /// <value>
        /// The MPG.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Mpg</exception>
        public decimal Mpg
        {
            get => _mpg;
            set
            {
                const string msg = "MPG cannot be less than 0";
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Mpg), msg);
                _mpg = value;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Price</exception>
        public decimal Price
        {
            get => _price;
            set
            {
                const string msg = "Score must be between 0 and 100.";
                if (value < 0 )
                    throw new ArgumentOutOfRangeException(nameof(Price), msg);
                _price = value;
            }
        }


    }
}
