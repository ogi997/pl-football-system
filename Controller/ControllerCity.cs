using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerCity
    {
        public List<CityModel> FindAll()
        {
            return WrapperCity.SelectAll();
        }
        public void InsertCity(string name)
        {
            WrapperCity.InsertCity(name);
        }
    }
}
