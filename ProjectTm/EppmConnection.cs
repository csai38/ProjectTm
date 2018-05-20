using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTm.EppmWs.AuthenticationService;

namespace ProjectTm
{
    public delegate void EppmConnect(EppmConnection eppmConnection);

    public class EppmConnection
    {
        public DatabaseTypeType dbType { set; get; }
        public System.Net.CookieContainer sessionCookie { set; get; }
        public string dbName { set; get; }
        public string userLogin { set; get; }
    }
}
