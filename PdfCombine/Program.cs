using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSupergoo.ABCpdf9;

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
            XSettings.InstallRedistributionLicense("X/VKS08wmMhAtn4jNv3DOcikae8bCdcYlqznwb2yXRdhlgzHdjm+CqofKHk/hAUJCckx/CNGokQVw6ghTL59z00gZGKYAXNV42ERQ8qoKE7g5QnEoIE6faKxXECzZmgzRqd0V89ZskpwdhxxryqQbGhYcSuWVW7qn7QV8VMuS4at5Lsu6BWtx3rLsLZXyRpXbh1WvEBTwj/3eSQrDutNrWJThHTNB+RUefvSSH2QTbacAT0027M=");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
