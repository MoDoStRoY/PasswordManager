using Newtonsoft.Json;
using PasswordManager.Config.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PasswordManager.Scripts.Windows
{
    class LoginWindowLogic
    {
        static User user = Program.user;

        public static void InitializeForm()
        {
            try { user.listOfProfiles = JsonConvert.DeserializeObject<List<ObjectOfData>>(File.ReadAllText(user.pathToProfiles)); }
            catch (Exception) { user.listOfProfiles = new List<ObjectOfData>(); }
        }

        public static void btnLogin()
        {
            if (!user.loginWindow.fxRegCB.Checked)
            {
                for (int i = 0; i < user.listOfProfiles.Count; i++)
                {
                    if (user.loginWindow.fxLoginTxt.Text.Equals(user.listOfProfiles[i].login) && user.loginWindow.fxPasswordTxt.Text.Equals(user.listOfProfiles[i].password))
                    {
                        user.userName = user.loginWindow.fxLoginTxt.Text;
                        user.pathToPassword = Path.GetFullPath("Profiles/" + user.userName + ".txt");
                        user.listOfPassword = JsonConvert.DeserializeObject<List<ObjectOfData>>(File.ReadAllText(user.pathToPassword));

                        user.loginWindow.Hide();
                        user.mainWindow.ShowWindow();
                    }
                }
            }
            else 
            {
                user.userName = user.loginWindow.fxLoginTxt.Text;
                user.pathToPassword = Path.GetFullPath("Profiles/" + user.userName + ".txt");
                user.listOfProfiles.Add(new ObjectOfData("NONE", user.loginWindow.fxLoginTxt.Text, user.loginWindow.fxPasswordTxt.Text));
                File.WriteAllText(user.pathToProfiles, JsonConvert.SerializeObject(user.listOfProfiles));
                user.listOfPassword = new List<ObjectOfData>
                {
                    new ObjectOfData("anyService.com", "NONE", "1passwd")
                };

                user.loginWindow.Hide();
                user.mainWindow.ShowWindow();
            }
        }
    }
}
