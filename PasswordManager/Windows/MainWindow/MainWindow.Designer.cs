
namespace PasswordManager
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fxSearchField = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.fxDataZoneDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fxDataZoneDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(571, 29);
            this.button2.TabIndex = 34;
            this.button2.Text = "Сохранить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveDataBtn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Поиск по таблице:";
            // 
            // fxSearchField
            // 
            this.fxSearchField.Location = new System.Drawing.Point(12, 632);
            this.fxSearchField.Name = "fxSearchField";
            this.fxSearchField.Size = new System.Drawing.Size(381, 27);
            this.fxSearchField.TabIndex = 38;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 632);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 29);
            this.button5.TabIndex = 40;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.searchBtn);
            // 
            // fxDataZoneDGV
            // 
            this.fxDataZoneDGV.AllowUserToResizeColumns = false;
            this.fxDataZoneDGV.AllowUserToResizeRows = false;
            this.fxDataZoneDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fxDataZoneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxDataZoneDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.fxDataZoneDGV.Location = new System.Drawing.Point(13, 13);
            this.fxDataZoneDGV.Name = "fxDataZoneDGV";
            this.fxDataZoneDGV.RowHeadersVisible = false;
            this.fxDataZoneDGV.RowHeadersWidth = 51;
            this.fxDataZoneDGV.RowTemplate.Height = 29;
            this.fxDataZoneDGV.Size = new System.Drawing.Size(570, 536);
            this.fxDataZoneDGV.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название сервиса";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Логин";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Пароль";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 671);
            this.Controls.Add(this.fxDataZoneDGV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fxSearchField);
            this.Controls.Add(this.button2);
            this.Name = "MainWindow";
            this.Text = "Password Manager v.0.2.3C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseWindow);
            this.Load += new System.EventHandler(this.InitializeForm);
            ((System.ComponentModel.ISupportInitialize)(this.fxDataZoneDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox fxSearchField;
        public System.Windows.Forms.DataGridView fxDataZoneDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

