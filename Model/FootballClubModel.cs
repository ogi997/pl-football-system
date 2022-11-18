using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class FootballClubModel
    {
        private readonly string folder = "";
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public CityModel City { get; set; }
        public string ImageName { get; set; }
        public string TshirtImageName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is FootballClubModel model &&
                   ID == model.ID &&
                   Name == model.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
