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
    /// Dialog that shows a detailed report of the car lot's inventory,
    /// including the most/least expensive cars and best/worst MPG cars.
    /// </summary>
    public partial class InventoryReportDialog : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryReportDialog"/> class.
        /// </summary>
        /// <param name="carLot">The car lot to report on. Cannot be null.</param>
        /// <exception cref="ArgumentNullException">Thrown when carLot is null.</exception>
        public InventoryReportDialog(CarLot carLot)
        {
            if (carLot == null)
            {
                throw new ArgumentNullException(nameof(carLot), "Car lot cannot be null.");
            }

            InitializeComponent();
            reportTxtBox.Text = BuildInventoryReport(carLot);
        }

        /// <summary>
        /// Builds the full inventory report text for the specified car lot.
        /// </summary>
        /// <param name="carLot">The car lot to report on.</param>
        /// <returns>The formatted report.</returns>
        private static string BuildInventoryReport(CarLot carLot)
        {
            StringBuilder report = new StringBuilder();
            string carWord = carLot.Count == 1 ? "car" : "cars";

            report.AppendLine($"Inventory of {carLot.Count} {carWord}.");

            foreach (Car car in carLot.Inventory)
            {
                report.AppendLine(car.ToString());
            }

            AppendReportSection(report, "Most expensive:", carLot.FindMostExpensiveCar());
            AppendReportSection(report, "Least expensive:", carLot.FindLeastExpensiveCar());
            AppendReportSection(report, "Best MPG:", carLot.FindBestMPGCar());
            AppendReportSection(report, "Worst MPG:", carLot.FindWorstMPG());

            return report.ToString();
        }

        /// <summary>
        /// Appends a heading followed by the car's details (or a "none" message) to the report.
        /// </summary>
        /// <param name="report">The report being built.</param>
        /// <param name="heading">The section heading, such as "Best MPG:".</param>
        /// <param name="car">The car for this section, or null if the inventory is empty.</param>
        private static void AppendReportSection(StringBuilder report, string heading, Car? car)
        {
            report.AppendLine(heading);
            report.AppendLine(car?.ToString() ?? "None - the inventory is empty.");
        }
    }
}
