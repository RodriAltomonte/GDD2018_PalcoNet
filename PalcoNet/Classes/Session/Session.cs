using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Session
{
    class Session
    {
        private static Session instance;
        public string LoggedUsername { get; private set; }

        private Session() { }

        public static Session Instance() 
        {
            if (instance == null)
            {
                instance = new Session();
            }

            return instance;
        }

        public void OpenSession(string username)
        {
            LoggedUsername = username;
        }

        public void CloseSession() 
        {
            instance = null;
        }
    }
}
