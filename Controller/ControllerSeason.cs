using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerSeason
    { 
        public List<SeasonsModel> FindAll()
        {
            return WrapperSeason.SelectAll();
        }
        public void InsertSeason(string year)
        {
            WrapperSeason.InsertSeason(year);
        }
    }
}
