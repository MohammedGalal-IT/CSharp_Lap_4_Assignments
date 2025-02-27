
using System;
using System.Windows.Forms;

namespace Lap4_RegisterationFoem
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

            Application.Run(new frmSignUp());
            Application.Run(new LoginForm());
            Application.Run(new frmQuestionnaire());
            Application.Run(new frmProductManager());
            



        }
    }
}
