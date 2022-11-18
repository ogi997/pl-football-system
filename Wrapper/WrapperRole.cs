using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PLFootballSystem.Model;
using PLFootballSystem.Util;

namespace PLFootballSystem.Wrapper
{
    class WrapperRole
    {
        private static readonly string SELECT_ALL = "SELECT * FROM `role`";
        public static List<RoleModel> SelectAll()
        {
            List<RoleModel> Roles = new List<RoleModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                Roles.Add(new RoleModel()
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return Roles;
        }
    }
}
