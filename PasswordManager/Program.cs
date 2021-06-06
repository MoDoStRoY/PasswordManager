using PasswordManager.Config.Objects;
using PasswordManager.Scripts;
using PasswordManager.Windows.ErrorWindow;
using PasswordManager.Windows.LoginWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{

    
    static class Program
    {
        public static User user = new User();


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(user.loginWindow);
        }
    }
}
