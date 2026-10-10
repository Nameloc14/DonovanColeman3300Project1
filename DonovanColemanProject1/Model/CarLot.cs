namespace DonovanColemanProject1.Model
{
    /// <summary>
    /// Represents a car lot that manages an inventory of cars for sale.
    /// </summary>
    public class CarLot
    {
        /// <summary>
        /// The sales tax rate (7.8%) applied to every car purchase.
        /// </summary>
        public const decimal TaxRate = 0.078m;

        private readonly List<Car> inventory;
        /// <summary>
        /// Gets the total number of cars in the inventory.
        /// </summary>
        public int Count => inventory.Count;
        /// <summary>
        /// Gets the list of cars in the lot's inventory.
        /// </summary>
        public List<Car> Inventory => inventory;
        /// <summary>
        /// Initializes a new instance of the <see cref="CarLot"/> class
        /// and stocks it with the default inventory of cars.
        /// </summary>
        public CarLot()
        {
            inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }
        /// <summary>
        /// Creates a new car from the specified values and adds it to the inventory.
        /// </summary>
        /// <param name="make">The make of the car. Cannot be null, empty, or whitespace.</param>
        /// <param name="model">The model of the car. Cannot be null, empty, or whitespace.</param>
        /// <param name="mpg">The miles per gallon the car gets. Must be greater than zero.</param>
        /// <param name="price">The price of the car. Must be greater than zero.</param>
        /// <exception cref="ArgumentException">Thrown when make or model is null, empty, or whitespace.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when mpg or price is not greater than zero.</exception>
        public void AddCar(string make, string model, double mpg, decimal price)
        {
            Car newCar = new Car(make, model, mpg, price);
            inventory.Add(newCar);
        }
        /// <summary>
        /// Calculates the total cost of purchasing a car, including tax, rounded to the nearest cent.
        /// </summary>
        /// <param name="car">The car being purchased. Cannot be null.</param>
        /// <returns>The car's price plus tax.</returns>
        /// <exception cref="ArgumentNullException">Thrown when car is null.</exception>
        public decimal GetTotalCostOfPurchase(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }
            decimal totalCost = car.Price * (1 + TaxRate);
            return Math.Round(totalCost, 2, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// Adds the four default cars to the inventory.
        /// </summary>
        private void StockLotWithDefaultInventory()
        {
            AddCar("Ford", "Focus ST", 28.3, 26298.98m);
            AddCar("Chevrolet", "Camaro ZL1", 19, 65401.23m);
            AddCar("Honda", "Accord Sedan EX", 30.2, 26780m);
            AddCar("Lexus", "ES 350", 24.1, 42101.10m);
        }
    }
}