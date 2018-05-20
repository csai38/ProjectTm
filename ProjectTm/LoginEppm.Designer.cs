namespace ProjectTm
{
    partial class LoginEppm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dbCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eppmLogin = new System.Windows.Forms.TextBox();
            this.eppmPasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eppmConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных:";
            // 
            // dbCmb
            // 
            this.dbCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbCmb.Enabled = false;
            this.dbCmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dbCmb.FormattingEnabled = true;
            this.dbCmb.Location = new System.Drawing.Point(124, 16);
            this.dbCmb.Name = "dbCmb";
            this.dbCmb.Size = new System.Drawing.Size(152, 21);
            this.dbCmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя пользователя:";
            // 
            // eppmLogin
            // 
            this.eppmLogin.Enabled = false;
            this.eppmLogin.Location = new System.Drawing.Point(124, 44);
            this.eppmLogin.Name = "eppmLogin";
            this.eppmLogin.Size = new System.Drawing.Size(152, 20);
            this.eppmLogin.TabIndex = 3;
            this.eppmLogin.Text = "admin";
            // 
            // eppmPasswd
            // 
            this.eppmPasswd.Enabled = false;
            this.eppmPasswd.Location = new System.Drawing.Point(124, 70);
            this.eppmPasswd.Name = "eppmPasswd";
            this.eppmPasswd.PasswordChar = 'X';
            this.eppmPasswd.Size = new System.Drawing.Size(152, 20);
            this.eppmPasswd.TabIndex = 4;
            this.eppmPasswd.Text = "sFx2Doobay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // eppmConnect
            // 
            this.eppmConnect.Enabled = false;
            this.eppmConnect.Location = new System.Drawing.Point(15, 104);
            this.eppmConnect.Name = "eppmConnect";
            this.eppmConnect.Size = new System.Drawing.Size(123, 23);
            this.eppmConnect.TabIndex = 6;
            this.eppmConnect.Text = "Подключиться";
            this.eppmConnect.UseVisualStyleBackColor = true;
            this.eppmConnect.Click += new System.EventHandler(this.eppmConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginEppm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 141);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.eppmConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eppmPasswd);
            this.Controls.Add(this.eppmLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbCmb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginEppm";
            this.Text = "Подключение EPPM";
            this.Load += new System.EventHandler(this.LoginEppm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dbCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eppmLogin;
        private System.Windows.Forms.TextBox eppmPasswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eppmConnect;
        private System.Windows.Forms.Button btnCancel;
    }
}