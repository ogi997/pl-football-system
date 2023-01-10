using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class PlayerModel
    {
        private readonly string folder = "";
        public int ID { get; set; }
        public int Number { get; set; }
        public PositionModel Position { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public CountryModel Country { get; set; }
        public FootballClubModel FootballClub { get; set; }
        public string ImageName { get; set; }
        public int pos { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PlayerModel model &&
                   ID == model.ID &&
                   Number == model.Number &&
                   Name == model.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1057889574;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
