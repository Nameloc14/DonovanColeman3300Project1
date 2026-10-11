using System.Globalization;
using DonovanColemanProject1.View;

namespace DonovanColemanProject1
{
    /// <summary>
    /// Entry point for the Car Lot Manager application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Use U.S. formatting so money always displays like $15,124.56,
            // no matter what region the computer is set to.
            CultureInfo usCulture = CultureInfo.GetCultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = usCulture;
            CultureInfo.DefaultThreadCurrentUICulture = usCulture;
            CultureInfo.CurrentCulture = usCulture;
            CultureInfo.CurrentUICulture = usCulture;

            ApplicationConfiguration.Initialize();
            Application.Run(new CarLotForm());
        }
    }
}