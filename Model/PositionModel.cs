using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class PositionModel
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PositionModel model &&
                   ID == model.ID &&
                   Description == model.Description;
        }

        public override int GetHashCode()
        {
            int hashCode = -1355608983;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }
    }
}
