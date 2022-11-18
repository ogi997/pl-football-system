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
    class WrapperCity
    {
        private static readonly string INSERT_CITY = "INSERT INTO `city` " +
                                                  "(name) " +
                                                  "VALUES(@name)";
        private static readonly string SELECT_ALL = "SELECT * FROM `city`";

        public static List<CityModel> SelectAll()
        {
            List<CityModel> cityModels = new List<CityModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                cityModels.Add(new CityModel()
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return cityModels;
        }

        public static void InsertCity(string name)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@name", ParamTwo = name },
            };

            MySqlConnection conn = DBUtil.GetConnection();

            DBUtil.PrepareInsertWithParameters(conn, INSERT_CITY, tmp);

            DBUtil.CloseQuietly(conn);
        }

    }
}
