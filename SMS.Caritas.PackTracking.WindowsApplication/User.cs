using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Caritas.PackTracking.WindowsApplication
{
    public class User
    {
        private  string _currentUser;
        public  string CurrentUser
        {
            get
            {
                return _currentUser;
            }

            set
            {
                _currentUser = value;
            }
        }

        public  bool isAdministrator
        {
            get
            {
                return _currentUser == Costanti.UTENTE_AMMINISTRATORE;
            }
        }

        private static User instance;

        private User() { }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }
    }
}
