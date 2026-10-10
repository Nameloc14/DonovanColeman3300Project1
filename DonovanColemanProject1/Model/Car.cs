namespace DonovanColemanProject1.Model
{
    /// <summary>
    /// Represents a single car with a make, model, fuel economy, and price.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets the name of the car maker (for example, "Ford").
        /// </summary>
        public string Make { get; }
        /// <summary>
        /// Gets the name of the car model (for example, "Focus ST").
        /// </summary>
        public string Model { get; }
        /// <summary>
        /// Gets the number of miles per gallon the car gets.
        /// </summary>
        public double Mpg { get; }
        /// <summary>
        /// Gets the price of the car in dollars.
        /// </summary>
        public decimal Price { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="make">The name of the car maker. Cannot be null, empty, or whitespace.</param>
        /// <param name="model">The name of the car model. Cannot be null, empty, or whitespace.</param>
        /// <param name="mpg">The miles per gallon the car gets. Must be greater than zero.</param>
        /// <param name="price">The price of the car. Must be greater than zero.</param>
        /// <exception cref="ArgumentException">Thrown when make or model is null, empty, or whitespace.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when mpg or price is not greater than zero.</exception>
        public Car(string make, string model, double mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null, empty, or whitespace.", nameof(make));
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null, empty, or whitespace.", nameof(model));
            }

            if (!double.IsFinite(mpg) || mpg <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mpg), "MPG must be a number greater than zero.");
            }

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than zero.");
            }

            Make = make.Trim();
            Model = model.Trim();
            Mpg = mpg;
            Price = price;
        }
        /// <summary>
        /// Returns the car's details in the format "Make Model $Price MPGmpg",
        /// for example "Ford Focus ST $26,298.98 28.3mpg".
        /// </summary>
        /// <returns>A display string describing the car.</returns>
        public override string ToString()
        {
            return $"{Make} {Model} {Price:C} {Mpg:F1}mpg";
        }
    }
}