using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            //Account newAccount = new Account { Username = "msm123", Password = "aA1234567890", FirstName = "John", LastName = "Smith", BodyWeight = 500, TargetCalories = 250 };
            //AccountList list = new AccountList(newAccount);
            //Application.Run(new MainForm(list, 0));
        }
    }
}
