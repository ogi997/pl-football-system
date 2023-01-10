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
        public FormationModel FindFormation(int matchId, int footballClubId)
        {
            return WrapperFirstTeam.SelectFormationForMatch(matchId, footballClubId);
        }
        public List<PlayerModel> FindMatchByIdAndClub(int matchId, int footballClubId)
        {
            return WrapperFirstTeam.SelectFirstTeamByMatchAndClubId(matchId, footballClubId);
        }
        public void InsertFirstTeam(FirstTeamModel firstTeamModel, int formationId, int position)
        {
            WrapperFirstTeam.InsertFirstTeam(firstTeamModel, formationId, position);
        }
    }
}
