namespace DonovanColemanProject1.Model
{
    /// <summary>
    /// Represents a shopper who has money available and can purchase cars.
    /// </summary>
    public class Shopper
    {
        private readonly List<Car> cars;
        /// <summary>
        /// Gets the name of the shopper.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gets the amount of money the shopper currently has available to purchase cars.
        /// </summary>
        public decimal MoneyAvailable { get; private set; }
        /// <summary>
        /// Gets a read-only view of the cars the shopper has purchased.
        /// Added so the UI can display purchased cars without being able to change the list.
        /// </summary>
        public IReadOnlyList<Car> PurchasedCars => cars.AsReadOnly();
        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper"/> class with an empty list of cars.
        /// </summary>
        /// <param name="name">The shopper's name. Cannot be null, empty, or whitespace.</param>
        /// <param name="moneyAvailable">The money the shopper has available. Cannot be negative.</param>
        /// <exception cref="ArgumentException">Thrown when name is null, empty, or whitespace.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when moneyAvailable is negative.</exception>
        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null, empty, or whitespace.", nameof(name));
            }

            if (moneyAvailable < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(moneyAvailable), "Money available cannot be negative.");
            }

            Name = name.Trim();
            MoneyAvailable = moneyAvailable;
            cars = new List<Car>();
        }
        /// <summary>
        /// Determines whether the shopper has enough money to cover the specified total cost.
        /// </summary>
        /// <param name="totalCost">The total cost of the purchase, including tax. Cannot be negative.</param>
        /// <returns>True if the shopper has enough money available; otherwise, false.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when totalCost is negative.</exception>
        public bool CanPurchase(decimal totalCost)
        {
            if (totalCost < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(totalCost), "Total cost cannot be negative.");
            }

            return MoneyAvailable >= totalCost;
        }
        /// <summary>
        /// Adds the car to the shopper's purchased cars and deducts the total cost from their money available.
        /// </summary>
        /// <param name="car">The car being purchased. Cannot be null.</param>
        /// <param name="totalCost">The total cost of the purchase, including tax. Cannot be negative.</param>
        /// <exception cref="ArgumentNullException">Thrown when car is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when totalCost is negative.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the shopper cannot afford the total cost.</exception>
        public void PurchaseCar(Car car, decimal totalCost)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }

            if (!CanPurchase(totalCost))
            {
                throw new InvalidOperationException("The shopper does not have enough money to purchase this car.");
            }

            cars.Add(car);
            MoneyAvailable -= totalCost;
        }
    }
}