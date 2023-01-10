using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    class FirstTeamModel
    {
        public int ID { get; set; }
        public MatchModel Match { get; set; }
        public FootballClubModel FC { get; set; }
        public PlayerModel Player { get; set; }
       // public int position { get; set; }

        public override bool Equals(object obj)
        {
            return obj is FirstTeamModel model &&
                   ID == model.ID &&
                   EqualityComparer<MatchModel>.Default.Equals(Match, model.Match);
        }

        public override int GetHashCode()
        {
            int hashCode = -1695961706;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<MatchModel>.Default.GetHashCode(Match);
            return hashCode;
        }
    }
}
