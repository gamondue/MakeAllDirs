using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaunchAll
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // MakeAllDirs
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
            {
                Application.Run(new frmMakeAllDirs(args[0]));
            }
            else if (args.Length == 2) 
            {
                Application.Run(new frmMakeAllDirs(args[0], args[1]));
            }
            else
                Application.Run(new frmMakeAllDirs());
        }
    }
}
