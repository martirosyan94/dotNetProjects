using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta
{
    public class Application
    {
        IFacebook _facebook;
        public Application(IFacebook facebook)
        {
            _facebook = facebook;
        }

        public void Run() 
        {
            
        }
    }
}
