using PasswordManager.Config.Objects;
using PasswordManager.Scripts;
using PasswordManager.Scripts.Windows;
using PasswordManager.Windows.ErrorWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Windows.LoginWindow
{
    public partial class LoginWindow : Form
    {
        static User user = new User();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            LoginWindowLogic.InitializeForm();
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            LoginWindowLogic.btnLogin();
        }
    }
}
