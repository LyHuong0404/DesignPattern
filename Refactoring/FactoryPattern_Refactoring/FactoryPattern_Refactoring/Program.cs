using FactoryPattern_Refactoring.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern_Refactoring
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            Configuare();
            RunBusinessLogin();
        }

            private static Dialog dialog;


        static void Configuare()
        {
            if (Environment.OSVersion.VersionString.Contains("Windows"))
            {
                dialog = new WindowsDialog();
            }
            else
            {
                dialog = new HtmlDialog();
            }
        }

        static void RunBusinessLogin()
        {
            dialog.RenderWindow();
        }
    }
}


