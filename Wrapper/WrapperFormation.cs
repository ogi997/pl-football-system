using MySql.Data.MySqlClient;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Wrapper
{
    class WrapperFormation
    {
        private static readonly string SELECT_ALL = "SELECT id, description FROM `formation` ";

        public static List<FormationModel> SelectAll()
        {

            List<FormationModel> formationModels = new List<FormationModel>();

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                formationModels.Add(new FormationModel
                {
                    ID = reader.GetInt32(0),
                    Description = reader.GetString(1)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return formationModels;
        }
    }
}
