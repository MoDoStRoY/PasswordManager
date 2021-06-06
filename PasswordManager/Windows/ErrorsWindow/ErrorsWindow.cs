using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Windows.ErrorWindow
{
    public partial class ErrorsWindow : Form
    {
        public ErrorsWindow()
        {
            InitializeComponent();
        }

        private void btnOk(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
