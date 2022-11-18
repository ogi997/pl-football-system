using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;

namespace PLFootballSystem.Controller
{
    class ControllerTheme
    {
        public List<ThemeModel> FindAll()
        {
            return WrapperTheme.SelectAll();
        }
    }
}
