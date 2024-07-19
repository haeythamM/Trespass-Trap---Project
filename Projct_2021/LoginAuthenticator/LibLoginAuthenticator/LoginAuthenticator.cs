using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//copuright @ code for Haeytham Almalak
namespace LibLoginAuthenticator
{
    public class LoginAuthenticator
    {
        public string userName { get; set; }
        public string password { private get; set; }

        private String _usr = "tpj";
        private string _id = "123";

      
        public bool? Authenticate()
        {
            if(userName == "" || password == "")
            {
                return null;
            }
            if (userName == _usr && password == _id)
            {
                return true;

            }
            else if (userName != _usr && password != _id)
            {
                return false;
            }
            else
            {
                return null;
            }
        }

    }
}
