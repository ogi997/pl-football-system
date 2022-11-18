using MySql.Data.MySqlClient;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Wrapper
{
   
    class WrapperCountry
    {
        public static readonly string FOLDER = "CountryFlagImages";
        private static readonly string INSERT_COUNTRY = "INSERT INTO `country` " +
                                                   "(name, image_name) " +
                                                   "VALUES(@name, @image_name)";
        private static readonly string SELECT_ALL = "SELECT * FROM `country`";
        public static List<CountryModel> SelectAll()
        {
            List<CountryModel> countryModels = new List<CountryModel>();

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                countryModels.Add(new CountryModel
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    ImageName = reader.GetString(2)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return countryModels;
        }
        public static void InsertCountry(string name, string image_name) 
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@name", ParamTwo = name },
                new Params() { ParamOne = "@image_name", ParamTwo = image_name }
            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_COUNTRY, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
