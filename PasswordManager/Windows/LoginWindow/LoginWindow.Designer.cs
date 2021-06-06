
namespace PasswordManager.Windows.LoginWindow
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fxLoginTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fxPasswordTxt = new System.Windows.Forms.TextBox();
            this.fxRegCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fxLoginTxt
            // 
            this.fxLoginTxt.Location = new System.Drawing.Point(12, 12);
            this.fxLoginTxt.Name = "fxLoginTxt";
            this.fxLoginTxt.Size = new System.Drawing.Size(264, 27);
            this.fxLoginTxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginBtn);
            // 
            // fxPasswordTxt
            // 
            this.fxPasswordTxt.Location = new System.Drawing.Point(12, 45);
            this.fxPasswordTxt.Name = "fxPasswordTxt";
            this.fxPasswordTxt.Size = new System.Drawing.Size(264, 27);
            this.fxPasswordTxt.TabIndex = 1;
            // 
            // fxRegCB
            // 
            this.fxRegCB.AutoSize = true;
            this.fxRegCB.Location = new System.Drawing.Point(12, 78);
            this.fxRegCB.Name = "fxRegCB";
            this.fxRegCB.Size = new System.Drawing.Size(279, 24);
            this.fxRegCB.TabIndex = 3;
            this.fxRegCB.Text = "Регистрация новой учётной записи";
            this.fxRegCB.UseVisualStyleBackColor = true;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 162);
            this.Controls.Add(this.fxPasswordTxt);
            this.Controls.Add(this.fxRegCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fxLoginTxt);
            this.Name = "LoginWindow";
            this.Text = "Password Manager v.0.2.3C";
            this.Load += new System.EventHandler(this.InitializeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox fxLoginTxt;
        public System.Windows.Forms.TextBox fxPasswordTxt;
        public System.Windows.Forms.CheckBox fxRegCB;
    }
}