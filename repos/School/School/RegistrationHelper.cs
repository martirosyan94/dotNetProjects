using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public interface IRegistrationHelper
    {
        void Register(string name);
    }

    public class RegistrationHelper : IRegistrationHelper
    {

        public void Register(string name)
        {
            System.Diagnostics.Debug.WriteLine(name);
        }
    }
}
