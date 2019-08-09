using COMP123_S2019_FinalTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTest
{
    static class Program
    {
        //this is a temporary form
        public static MasterForm masterform;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            masterform = new MasterForm();
            Application.Run(masterform);
        }
    }
}
