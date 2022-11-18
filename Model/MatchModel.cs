using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class MatchModel
    {
        public int ID { get; set; }
        public int GoalsScoredHome { get; set; }
        public int GoalsReceivedAway { get; set; }
        public SeasonsModel Season { get; set; }
        public DateTime Date { get; set; }
        public FootballClubModel FCHome { get; set; }
        public FootballClubModel FCAway { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MatchModel model &&
                   ID == model.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}
