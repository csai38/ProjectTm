using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTm.EppmWs.AuthenticationService;

namespace ProjectTm
{
    public partial class LoginEppm : Form
    {

        public event EppmConnect OnEppmConnected;
        
        ReadDatabaseInstancesResponseDatabaseInstance[] dbInsts { set; get; }

        AuthenticationService authService = new AuthenticationService();

        public LoginEppm()
        {
            InitializeComponent();
        }

        private void LoginEppm_Load(object sender, EventArgs e)
        {
            authService.Url = String.Format("{0}/p6ws/services/AuthenticationService", Properties.Settings.Default.EppmWsUrl);
            authService.CookieContainer = new System.Net.CookieContainer();
            authService.LoginCompleted += AuthService_LoginCompleted;
            authService.ReadDatabaseInstancesCompleted += AuthService_ReadDatabaseInstancesCompleted;
            authService.ReadDatabaseInstancesAsync("");
        }

        private void AuthService_LoginCompleted(object sender, LoginCompletedEventArgs e)
        {
           
            if (e.Result.Return)
            {
                EppmConnection connect = new EppmConnection();
                connect.dbType = dbInsts[dbCmb.SelectedIndex].DatabaseType;
                connect.sessionCookie = authService.CookieContainer;
                connect.dbName = dbCmb.Text;
                this.OnEppmConnected.Invoke(connect);
                this.Close();
            }
            else
            {
                MessageBox.Show(e.Error.Message);
                dbCmb.Enabled = true;
                eppmLogin.Enabled = true;
                eppmPasswd.Enabled = true;
                eppmConnect.Enabled = true;
            }
           
        }

        private void AuthService_ReadDatabaseInstancesCompleted(object sender, ReadDatabaseInstancesCompletedEventArgs e)
        {
            this.dbInsts = e.Result;
            for (int i = 0; i < dbInsts.Length; i++)
            {
                dbCmb.Items.Add(dbInsts[i].DatabaseName);
            }
            dbCmb.Enabled = true;
            eppmLogin.Enabled = true;
            eppmPasswd.Enabled = true;
            eppmConnect.Enabled = true;
        }

        private void eppmConnect_Click(object sender, EventArgs e)
        {
            //
            dbCmb.Enabled = false;
            eppmLogin.Enabled = false;
            eppmPasswd.Enabled = false;
            eppmConnect.Enabled = false;
            //
            Login ppmLogin = new Login();
            int instIdx = dbCmb.SelectedIndex;
            ppmLogin.DatabaseInstanceId = instIdx;
            ppmLogin.UserName = eppmLogin.Text;
            ppmLogin.Password = eppmPasswd.Text;
            authService.LoginAsync(ppmLogin);
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
