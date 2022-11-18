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
    class WrapperPlayerPosition
    {
        private static readonly string INSERT_PLAYER_POSITION = "INSERT INTO `position` " +
                                                 "(description) " +
                                                 "VALUES(@description)";
        private static readonly string SELECT_ALL = "SELECT * FROM `position`";

        public static List<PositionModel> SelectAll()
        {
            List<PositionModel> positionModels = new List<PositionModel>();

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                positionModels.Add(new PositionModel
                {
                    ID = reader.GetInt32(0),
                    Description = reader.GetString(1)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return positionModels;
        }
        public static void InsertPlayerPosition(string description)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@description", ParamTwo = description },
            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_PLAYER_POSITION, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
