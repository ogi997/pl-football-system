using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerFirstTeam
    {
        public List<PlayerModel> FindMatchByIdAndClub(int matchId, int footballClubId)
        {
            return WrapperFirstTeam.SelectFirstTeamByMatchAndClubId(matchId, footballClubId);
        }
        public void InsertFirstTeam(FirstTeamModel firstTeamModel)
        {
            WrapperFirstTeam.InsertFirstTeam(firstTeamModel);
        }
    }
}
