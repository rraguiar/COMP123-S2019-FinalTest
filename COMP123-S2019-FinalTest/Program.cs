using COMP123_S2019_FinalTest.Objects;
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
        public static HeroGenerator heroGenerator;
        public static Hero Character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Character = new Hero();
            heroGenerator = new HeroGenerator();
            Application.Run(heroGenerator);
        }
    }
}
