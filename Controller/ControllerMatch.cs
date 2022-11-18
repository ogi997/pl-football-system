using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerMatch
    {
        public MatchModel FindMatchById(int matchId)
        {
            return WrapperMatch.SelectMatchById(matchId);
        }
        public List<MatchModel> FindMatchBySeasonId(int seasonId)
        {
            return WrapperMatch.SelectMatchBySeasonId(seasonId);
        }
        public int? InsertMatch(MatchModel match)
        {
            return WrapperMatch.Insert(match);
        }
    }
}
