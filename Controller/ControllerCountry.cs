using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerCountry
    {
        public List<CountryModel> FindAll()
        {
            return WrapperCountry.SelectAll();
        }
        public void InsertCountry(string name, string image_name)
        {
            WrapperCountry.InsertCountry(name, image_name);
        }
    }
}
