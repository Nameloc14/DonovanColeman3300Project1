using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DonovanColemanProject1.View
{
    /// <summary>
    /// Dialog that collects and validates the details of a new car to add to the inventory.
    /// </summary>
    public partial class AddCarDialog : Form
    {
        /// <summary>
        /// Gets the validated make entered by the user.
        /// </summary>
        public string CarMake { get; private set; } = string.Empty;
        /// <summary>
        /// Gets the validated model entered by the user.
        /// </summary>
        public string CarModel { get; private set; } = string.Empty;
        /// <summary>
        /// Gets the validated miles per gallon entered by the user.
        /// </summary>
        public double CarMpg { get; private set; }
        /// <summary>
        /// Gets the validated price entered by the user.
        /// </summary>
        public decimal CarPrice { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCarDialog"/> class.
        /// </summary>
        public AddCarDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Validates every field and, if all are valid, saves the values and closes the dialog.
        /// </summary>
        /// <param name="sender">The Add Car button.</param>
        /// <param name="e">The event data.</param>
        private void addCarBtn_Click(object sender, EventArgs e)
        {
            string make = makeTxtBox.Text.Trim();
            string model = modelTxtBox.Text.Trim();

            bool isMakeValid = make.Length > 0;
            bool isModelValid = model.Length > 0;

            bool isMpgValid = double.TryParse(mpgTxtBox.Text.Trim(), NumberStyles.Float,
                CultureInfo.CurrentCulture, out double mpg)
                && double.IsFinite(mpg)
                && mpg > 0;

            bool isPriceValid = decimal.TryParse(priceTxtBox.Text.Trim(), NumberStyles.Currency,
                CultureInfo.CurrentCulture, out decimal price)
                && price > 0
                && price == Math.Round(price, 2);

            makeErrorLbl.Visible = !isMakeValid;
            modelErrorLbl.Visible = !isModelValid;
            mpgErrorLbl.Visible = !isMpgValid;
            priceErrorLbl.Visible = !isPriceValid;

            if (!isMakeValid || !isModelValid || !isMpgValid || !isPriceValid)
            {
                return;
            }

            CarMake = make;
            CarModel = model;
            CarMpg = mpg;
            CarPrice = price;
            DialogResult = DialogResult.OK;
        }
    }
}