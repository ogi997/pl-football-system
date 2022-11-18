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
    class WrapperSeason
    {
        private static readonly string INSERT_SEASON = "INSERT INTO `seasons` " +
                                                 "(year) " +
                                                 "VALUES(@year)";
        private static readonly string SELECT_ALL = "SELECT * FROM `seasons`";
        public static List<SeasonsModel> SelectAll()
        {
            List<SeasonsModel> seasonsModels = new List<SeasonsModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                seasonsModels.Add(new SeasonsModel
                {
                    ID = reader.GetInt32(0),
                    year = reader.GetString(1)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return seasonsModels;
        }
        public static void InsertSeason(string year)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@year", ParamTwo = year },
            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_SEASON, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
