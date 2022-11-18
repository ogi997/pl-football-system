using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Model
{
    public class AccountModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ThemeModel Theme { get; set; }
        public RoleModel Role { get; set; }
        public int Status { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AccountModel model &&
                   ID == model.ID &&
                   Username == model.Username;
        }

        public override int GetHashCode()
        {
            int hashCode = 1683842873;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            return hashCode;
        }
    }
}
