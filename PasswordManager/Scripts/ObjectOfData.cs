using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Scripts
{
    class ObjectOfData
    {
        public String nameOfService;
        public String login;
        public String password;

        public ObjectOfData() { }

        public ObjectOfData(String nameOfService, String login, String password)
        {
            this.nameOfService = nameOfService;
            this.login = login;
            this.password = password;
        }
    }
}
