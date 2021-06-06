using Newtonsoft.Json;
using PasswordManager.Config.Objects;
using System;
using System.Collections.Generic;
using System.IO;

namespace PasswordManager.Scripts.Windows
{
    class MainWindowLogic
    {
        static User user = Program.user;
        static int currentIndex = 0;
        static int lastIndex = 0;

        public static void InitializeForm()
        {

        }

        public static void ShowWindow()
        {
            user.mainWindow.Show();
            UpdateData();
        }

        public static void UpdateData()
        {
            user.mainWindow.fxDataZoneDGV.Rows.Clear();

            for (int i = 0; i < user.listOfPassword.Count; i++)
            {
                user.mainWindow.fxDataZoneDGV.Rows.Add();

                user.mainWindow.fxDataZoneDGV.Rows[i].Cells[0].Value = user.listOfPassword[i].nameOfService;
                user.mainWindow.fxDataZoneDGV.Rows[i].Cells[1].Value = user.listOfPassword[i].login;
                user.mainWindow.fxDataZoneDGV.Rows[i].Cells[2].Value = user.listOfPassword[i].password;
            }
        }

        public static void saveDataBtn()
        {   
            for (int i = 0; i < user.mainWindow.fxDataZoneDGV.Rows.Count-1; i++)
            {
                if (user.mainWindow.fxDataZoneDGV.Rows[i].Cells[0].Value == null && user.mainWindow.fxDataZoneDGV.Rows[i].Cells[1].Value == null && user.mainWindow.fxDataZoneDGV.Rows[i].Cells[2].Value == null)
                {
                    user.mainWindow.fxDataZoneDGV.Rows.RemoveAt(i);
                    i--;
                }    
            }

            for (int i = 0; i < user.mainWindow.fxDataZoneDGV.Rows.Count - 1; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    if (user.mainWindow.fxDataZoneDGV.Rows[i].Cells[i1].Value == null)
                        user.mainWindow.fxDataZoneDGV.Rows[i].Cells[i1].Value = "N/A";
                }
            }

            user.listOfPassword = new List<ObjectOfData>();
            for (int i = 0; i < user.mainWindow.fxDataZoneDGV.Rows.Count-1; i++)
            {
                user.listOfPassword.Add(new ObjectOfData(user.mainWindow.fxDataZoneDGV.Rows[i].Cells[0].Value.ToString(),
                    user.mainWindow.fxDataZoneDGV.Rows[i].Cells[1].Value.ToString(),
                    user.mainWindow.fxDataZoneDGV.Rows[i].Cells[2].Value.ToString()));
            }

            File.WriteAllText(user.pathToPassword, JsonConvert.SerializeObject(user.listOfPassword));
        }

        public static void searchBtn()
        {
            for (; currentIndex < user.mainWindow.fxDataZoneDGV.Rows.Count-1; currentIndex++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    if (user.mainWindow.fxDataZoneDGV.Rows[currentIndex].Cells[i1].Value.ToString().Contains(user.mainWindow.fxSearchField.Text))
                    {
                        user.mainWindow.fxDataZoneDGV.FirstDisplayedScrollingRowIndex = lastIndex;
                        user.mainWindow.fxDataZoneDGV.ClearSelection();
                        user.mainWindow.fxDataZoneDGV.Rows[currentIndex].Selected = true;
                        lastIndex = currentIndex;
                        currentIndex++;
                    }
                }
            }

            if (currentIndex == lastIndex+1)
            {
                currentIndex = 0;
                lastIndex = 0;
            }
        }
    }
}
