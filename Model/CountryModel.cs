using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class CountryModel
    {
        private readonly string folder = "";
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CountryModel model &&
                   ID == model.ID &&
                   Name == model.Name &&
                   ImageName == model.ImageName;
        }

        public override int GetHashCode()
        {
            int hashCode = -846078313;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImageName);
            return hashCode;
        }
    }
}
