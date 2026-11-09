using Damas_Week05_Work04;
using System;
using System.Windows.Forms;

namespace ProductApp
{
    static class Program
    {
        [STAThread]                                 // needed by Windows Forms apps
        static void Main()                          // the first method that runs
        {
            Application.EnableVisualStyles();       // modern look for buttons etc.
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductForm());     // open ProductForm and keep the app alive
        }
    }
}