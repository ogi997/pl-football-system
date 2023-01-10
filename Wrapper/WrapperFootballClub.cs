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
    class WrapperFootballClub
    {
        public static readonly string FOLDER = "FootballClubImages";
        public static readonly string FOLDER_TSHIRT = FOLDER + Path.DirectorySeparatorChar + "Tshirts";
        private static readonly string INSERT_FOOTBALLCLUB = "INSERT INTO `football_club` " +
                                                       "(founded, owner, name, nick_name, fk_city_id_for_fc, image_name, tshirt_image_name) " +
                                                       "VALUES(@founded, @owner, @name, @nick_name, @fk_city_id_for_fc, @image_name, @tshirt_image_name)";
        private static readonly string SELECT_ALL = "SELECT fc.id, fc.founded, fc.owner, fc.name, fc.nick_name, c.id, c.name, fc.image_name, fc.tshirt_image_name  FROM `football_club` fc " +
                                                    "INNER JOIN `city` c ON c.id = fc.fk_city_id_for_fc";
        private static readonly string DELETE_BY_ID = "DELETE FROM `football_club` " +
                                                       "WHERE id = @footballClubId";
        private static readonly string SELECT_FC_BY_ID = "SELECT fc.id, fc.founded, fc.owner, fc.name, fc.nick_name, c.name, fc.image_name, fc.tshirt_image_name FROM `football_club` fc " +
                                                         "INNER JOIN `city` c ON c.id = fc.fk_city_id_for_fc " +
                                                         "WHERE fc.id = @id";
        private static readonly string UPDATE_FC = "UPDATE `football_club` " +
                                                   "SET founded = @founded, owner = @owner, name = @name, nick_name = @nickName, fk_city_id_for_fc = @city, image_name = @imageName, tshirt_image_name = @tshirt " +
                                                   "WHERE id = @id";

        public static void UpdateByClubId(FootballClubModel fc)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@founded", ParamTwo = fc.Date},
                new Params() {ParamOne = "@owner", ParamTwo = fc.Owner},
                new Params() {ParamOne = "@name", ParamTwo = fc.Name},
                new Params() {ParamOne = "@nickName", ParamTwo = fc.NickName},
                new Params() {ParamOne = "@city", ParamTwo = fc.City.ID},
                new Params() {ParamOne = "@imageName", ParamTwo = fc.ImageName},
                new Params() {ParamOne = "@tshirt", ParamTwo = fc.TshirtImageName},
                new Params() {ParamOne = "@id", ParamTwo = fc.ID}
            };

            MySqlConnection conn = DBUtil.GetConnection();

            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_FC, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static FootballClubModel SelectClubById(int clubId)
        {
            FootballClubModel footballClubModel = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@id", ParamTwo = clubId }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_FC_BY_ID, tmp);

            while(reader.Read())
            {
                footballClubModel = new FootballClubModel()
                {
                    ID = reader.GetInt32(0),
                    Date = reader.GetDateTime(1),
                    Owner = reader.GetString(2),
                    Name = reader.GetString(3),
                    NickName = reader.GetString(4),
                    City = new CityModel { Name = reader.GetString(5) },
                    ImageName = reader.GetString(6),
                    TshirtImageName = reader.GetString(7)
                };
            }

            DBUtil.CloseQuietly(reader, conn);

            return footballClubModel;
        }
        public static void DeleteById(int footballClubId)
        {
            List<Params> tmp = new List<Params>
            {
                new Params() { ParamOne = "@footballClubId", ParamTwo = footballClubId}
            };

            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareDeleteWithParameters(conn, DELETE_BY_ID, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static List<FootballClubModel> SelectAll()
        {
            List<FootballClubModel> footballClubModels = new List<FootballClubModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                footballClubModels.Add(new FootballClubModel
                {
                    ID = reader.GetInt32(0),
                    Date = reader.GetDateTime(1),
                    Owner = reader.GetString(2),
                    Name = reader.GetString(3),
                    NickName = reader.GetString(4),
                    City = new CityModel { ID = reader.GetInt32(5), Name = reader.GetString(6)},
                    ImageName = reader.GetString(7),
                    TshirtImageName = reader.GetString(8)
                });
            }

            DBUtil.CloseQuietly(reader, conn);
            return footballClubModels;
        }
        public static void Insert(FootballClubModel fc)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@founded", ParamTwo = fc.Date },
                new Params() { ParamOne = "@owner", ParamTwo = fc.Owner },
                new Params() { ParamOne = "@name", ParamTwo = fc.Name},
                new Params() {ParamOne = "@nick_name", ParamTwo = fc.NickName},
                new Params() {ParamOne = "@fk_city_id_for_fc", ParamTwo=fc.City.ID},
                new Params() {ParamOne = "@image_name", ParamTwo=fc.ImageName},
                new Params() {ParamOne = "@tshirt_image_name", ParamTwo=fc.TshirtImageName}

            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_FOOTBALLCLUB, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
