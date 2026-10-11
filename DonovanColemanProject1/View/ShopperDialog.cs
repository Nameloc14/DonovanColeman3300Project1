using System.Globalization;
using DonovanColemanProject1.Model;
namespace DonovanColemanProject1.View
{
    /// <summary>
    /// Dialog that collects a shopper's name and money available, then returns the new Shopper.
    /// </summary>
    public partial class ShopperDialog : Form
    {
        /// <summary>
        /// Gets the shopper created from the user's input, or null if the dialog was cancelled.
        /// </summary>
        public Shopper? CreatedShopper { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperDialog"/> class.
        /// </summary>
        public ShopperDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Validates the input and, if valid, creates the shopper and closes the dialog.
        /// </summary>
        /// <param name="sender">The OK button.</param>
        /// <param name="e">The event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBox.Text.Trim();
            bool isNameValid = name.Length > 0;

            bool isMoneyValid = decimal.TryParse(moneyTxtBox.Text.Trim(), NumberStyles.Currency,
                                    CultureInfo.CurrentCulture, out decimal moneyAvailable)
                                && moneyAvailable >= 0
                                && moneyAvailable == Math.Round(moneyAvailable, 2);

            nameErrorLbl.Visible = !isNameValid;
            moneyErrorLbl.Visible = !isMoneyValid;

            if (!isNameValid || !isMoneyValid)
            {
                return;
            }

            CreatedShopper = new Shopper(name, moneyAvailable);
            DialogResult = DialogResult.OK;
        }
    }
}