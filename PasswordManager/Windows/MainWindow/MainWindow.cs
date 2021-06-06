using PasswordManager.Scripts;
using PasswordManager.Scripts.Windows;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            MainWindowLogic.InitializeForm();
        }

        private void CloseWindow(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ShowWindow()
        {
            MainWindowLogic.ShowWindow();
        }

        private void saveDataBtn(object sender, EventArgs e)
        {
            MainWindowLogic.saveDataBtn();
        }

        private void searchBtn(object sender, EventArgs e)
        {
            MainWindowLogic.searchBtn();
        }
    }
}
