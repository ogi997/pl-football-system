using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerRole
    {
        public List<RoleModel> FindAll()
        {
            return WrapperRole.SelectAll();
        }
    }
}
