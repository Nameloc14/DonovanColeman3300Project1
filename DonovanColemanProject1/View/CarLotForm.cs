using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DonovanColemanProject1.Model;

namespace DonovanColemanProject1.View
{
    /// <summary>
    /// Main window of the application. Displays the car lot's inventory and the current shopper,
    /// and lets the user add cars, create a shopper, purchase cars, and view inventory details.
    /// </summary>
    public partial class CarLotForm : Form
    {
        private readonly CarLot carLot;
        private Shopper? shopper;
        private string? currentMakeFilter;
        /// <summary>
        /// Initializes a new instance of the <see cref="CarLotForm"/> class
        /// and loads the car lot with its default cars.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            carLot = new CarLot();
            RefreshInventoryDisplay();
            RefreshShopperDisplay();
        }
        /// <summary>
        /// Opens the Add Car dialog and, if the user saves a valid car, adds it to the inventory.
        /// </summary>
        /// <param name="sender">The Add Car menu item.</param>
        /// <param name="e">The event data.</param>
        private void addCarMenuItem_Click(object sender, EventArgs e)
        {
            using AddCarDialog addCarDialog = new AddCarDialog();

            if (addCarDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            carLot.AddCar(addCarDialog.CarMake, addCarDialog.CarModel, addCarDialog.CarMpg, addCarDialog.CarPrice);
            // Show the full inventory so the new car is visible even if a make filter was active.
            ClearMakeFilter();

            MessageBox.Show($"{addCarDialog.CarMake} {addCarDialog.CarModel} was added to the inventory.",
                "Car Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Opens the Create Shopper dialog and, if a shopper is returned, displays them on the form.
        /// </summary>
        /// <param name="sender">The Create Shopper button.</param>
        /// <param name="e">The event data.</param>
        private void createShopperBtn_Click(object sender, EventArgs e)
        {
            if (shopper != null)
            {
                DialogResult replaceChoice = MessageBox.Show(
                    $"{shopper.Name} is the current shopper. Replace them with a new shopper?",
                    "Replace Shopper", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (replaceChoice != DialogResult.Yes)
                {
                    return;
                }
            }

            using ShopperDialog shopperDialog = new ShopperDialog();

            if (shopperDialog.ShowDialog(this) == DialogResult.OK && shopperDialog.CreatedShopper != null)
            {
                shopper = shopperDialog.CreatedShopper;
                RefreshShopperDisplay();
            }
        }
        /// <summary>
        /// Lets the current shopper purchase the car selected in the inventory list box.
        /// </summary>
        /// <param name="sender">The Purchase button.</param>
        /// <param name="e">The event data.</param>
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            if (shopper == null)
            {
                MessageBox.Show("Please create a shopper before purchasing a car.",
                    "No Shopper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inventoryListBox.SelectedItem is not Car selectedCar)
            {
                MessageBox.Show("Please select a car from the inventory list.",
                    "No Car Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalCost = carLot.GetTotalCostOfPurchase(selectedCar);

            if (!shopper.CanPurchase(totalCost))
            {
                MessageBox.Show(
                    $"Sorry, {shopper.Name}, you don't have enough money for the {selectedCar.Make} {selectedCar.Model}."
                    + $"{Environment.NewLine}{Environment.NewLine}Total cost (with tax): {totalCost:C}"
                    + $"{Environment.NewLine}Money available: {shopper.MoneyAvailable:C}"
                    + $"{Environment.NewLine}You are short by: {totalCost - shopper.MoneyAvailable:C}",
                    "Not Enough Money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Car? purchasedCar = carLot.PurchaseCar(selectedCar.Make, selectedCar.Model);

            if (purchasedCar == null)
            {
                MessageBox.Show("That car is no longer in the inventory.",
                    "Car Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshInventoryDisplay();
                return;
            }

            shopper.PurchaseCar(purchasedCar, totalCost);
            RefreshInventoryDisplay();
            RefreshShopperDisplay();

            MessageBox.Show(
                $"Congratulations, {shopper.Name}! You purchased the {purchasedCar.Make} {purchasedCar.Model}."
                + $"{Environment.NewLine}{Environment.NewLine}Price: {purchasedCar.Price:C}"
                + $"{Environment.NewLine}MPG: {purchasedCar.Mpg:F1}"
                + $"{Environment.NewLine}Tax ({CarLot.TaxRate:P1}): {totalCost - purchasedCar.Price:C}"
                + $"{Environment.NewLine}Total cost: {totalCost:C}"
                + $"{Environment.NewLine}{Environment.NewLine}Money remaining: {shopper.MoneyAvailable:C}",
                "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Opens a dialog showing the detailed inventory report.
        /// Shared by the View Inventory Details button and menu item.
        /// </summary>
        /// <param name="sender">The button or menu item that was clicked.</param>
        /// <param name="e">The event data.</param>
        private void viewInventory_Click(object sender, EventArgs e)
        {
            using InventoryReportDialog reportDialog = new InventoryReportDialog(carLot);
            reportDialog.ShowDialog(this);
        }
        /// <summary>
        /// Filters the inventory list box to show only cars of the make entered in the filter text box.
        /// Shared by the Find button and menu item.
        /// </summary>
        /// <param name="sender">The button or menu item that was clicked.</param>
        /// <param name="e">The event data.</param>
        private void findByMake_Click(object sender, EventArgs e)
        {
            string make = makeFilterTxtBox.Text.Trim();

            if (make.Length == 0)
            {
                MessageBox.Show("Please enter a make to search for (for example, Ford).",
                    "Enter a Make", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makeFilterTxtBox.Focus();
                return;
            }

            if (carLot.FindCarsByMake(make) == null)
            {
                MessageBox.Show($"No cars made by \"{make}\" were found in the inventory.",
                    "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentMakeFilter = make;
            RefreshInventoryDisplay();
        }
        /// <summary>
        /// Resets the inventory list box to show every car in the lot.
        /// Shared by the Show All button and menu item.
        /// </summary>
        /// <param name="sender">The button or menu item that was clicked.</param>
        /// <param name="e">The event data.</param>
        private void showAllCars_Click(object sender, EventArgs e)
        {
            ClearMakeFilter();
        }
        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">The Exit menu item.</param>
        /// <param name="e">The event data.</param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Removes any make filter and redisplays the full inventory.
        /// </summary>
        private void ClearMakeFilter()
        {
            currentMakeFilter = null;
            makeFilterTxtBox.Clear();
            RefreshInventoryDisplay();
        }
        /// <summary>
        /// Reloads the inventory list box, applying the current make filter if one is active.
        /// If the filter no longer matches any cars (e.g., the last one was sold), the full inventory is shown.
        /// </summary>
        private void RefreshInventoryDisplay()
        {
            List<Car> carsToShow = carLot.Inventory;

            if (currentMakeFilter != null)
            {
                List<Car>? matchingCars = carLot.FindCarsByMake(currentMakeFilter);

                if (matchingCars == null)
                {
                    currentMakeFilter = null;
                }
                else
                {
                    carsToShow = matchingCars;
                }
            }

            inventoryListBox.BeginUpdate();
            inventoryListBox.Items.Clear();

            foreach (Car car in carsToShow)
            {
                inventoryListBox.Items.Add(car);
            }

            inventoryListBox.EndUpdate();

            inventoryDisplayLbl.Text = currentMakeFilter == null
                ? $"Showing all {FormatCarCount(carsToShow.Count)}"
                : $"Showing {FormatCarCount(carsToShow.Count)} made by {currentMakeFilter}";
        }
        /// <summary>
        /// Updates the shopper labels and purchased-cars list box to match the current shopper.
        /// </summary>
        private void RefreshShopperDisplay()
        {
            purchasedCarsListBox.Items.Clear();

            if (shopper == null)
            {
                shopperNameLbl.Text = "(no shopper yet)";
                shopperMoneyLbl.Text = "-";
                return;
            }

            shopperNameLbl.Text = shopper.Name;
            shopperMoneyLbl.Text = shopper.MoneyAvailable.ToString("C");

            foreach (Car car in shopper.PurchasedCars)
            {
                purchasedCarsListBox.Items.Add(car);
            }
        }
        /// <summary>
        /// Formats a car count with the correct singular or plural word, such as "1 car" or "4 cars".
        /// </summary>
        /// <param name="count">The number of cars.</param>
        /// <returns>The formatted count.</returns>
        private static string FormatCarCount(int count)
        {
            return count == 1 ? "1 car" : $"{count} cars";
        }
    }
}
