using PasswordManager.Scripts;
using PasswordManager.Windows.ErrorWindow;
using PasswordManager.Windows.LoginWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PasswordManager.Config.Objects
{
    class User
    {
        public List<ObjectOfData> listOfProfiles;
        public List<ObjectOfData> listOfPassword;

        public String userName;
        public String pathToProfiles = Path.GetFullPath("Profiles/ProfilesList.csv");
        public String pathToPassword;
        public String title = "Password Manager v.0.2.3C";

        public MainWindow mainWindow = new MainWindow();
        public LoginWindow loginWindow = new LoginWindow();
        public ErrorsWindow errorsWindow = new ErrorsWindow();
    }
}
