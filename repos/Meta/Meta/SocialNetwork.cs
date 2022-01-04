using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta
{
    public class SocialNetwork
    {
        public IFacebook _facebook;

        public SocialNetwork(IFacebook facebook)
        {
            _facebook = facebook;
        }

        public void RegisterUser(string command)
        {
            if (command == "User")
            {
                _facebook.Register();
            }
        }
    }
}
