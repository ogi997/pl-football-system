using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    class FCSeasonsModel
    {
        public FootballClubModel FC { get; set; }
        public SeasonsModel Seasons { get; set; }
        public int TablePosition { get; set; }

        public override bool Equals(object obj)
        {
            return obj is FCSeasonsModel model &&
                   EqualityComparer<FootballClubModel>.Default.Equals(FC, model.FC) &&
                   EqualityComparer<SeasonsModel>.Default.Equals(Seasons, model.Seasons);
        }

        public override int GetHashCode()
        {
            int hashCode = -1982036849;
            hashCode = hashCode * -1521134295 + EqualityComparer<FootballClubModel>.Default.GetHashCode(FC);
            hashCode = hashCode * -1521134295 + EqualityComparer<SeasonsModel>.Default.GetHashCode(Seasons);
            return hashCode;
        }
    }
}
