using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSupergoo.ABCpdf8;

namespace PdfCombine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XSettings.InstallRedistributionLicense("WuJbSzVR9+1XpyYSM/zSObfMSeMZVIAlrse7n7O2Qh5YqX6WOi69N5FqZD02mwUKbtYw9T5CriIU1aEiT7J4xzkZWATfWHBOrCgxVcOyR0LmwU3y8sASXYXiZV2yYWFgGO5IUMBS/gJwaRx8rSiGKSk7XiebHErqiagd8Fc4DsfIx7lh8h3j5zipyYBMjmxZZk4uy3tk+VatMkI2I7B6m0lJmUXSbaE=");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
