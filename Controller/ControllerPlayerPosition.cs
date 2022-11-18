using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerPlayerPosition
    {
        public List<PositionModel> FindAll()
        {
            return WrapperPlayerPosition.SelectAll();
        }
        public void InsertPlayerPosition(string description)
        {
            WrapperPlayerPosition.InsertPlayerPosition(description);
        }
    }
}
