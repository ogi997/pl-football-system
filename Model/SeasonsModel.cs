using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class SeasonsModel
    {
        public int ID { get; set; }
        public string year { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SeasonsModel model &&
                   ID == model.ID &&
                   year == model.year;
        }

        public override int GetHashCode()
        {
            int hashCode = -153886852;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(year);
            return hashCode;
        }
    }
}
