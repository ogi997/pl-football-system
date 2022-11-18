using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerFCHasSeason
    {
        public List<FootballClubModel> FindBySeasonId(int id)
        {
            return WrapperFCHasSeason.SelectBySeasonId(id);
        }
        public void Insert(FCSeasonsModel fCSeasons)
        {
            WrapperFCHasSeason.Insert(fCSeasons);
        }
    }
}
