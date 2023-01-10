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
    class WrapperPlayer
    {
        public static readonly string FOLDER = "PlayerImages";

        private static readonly string INSERT_PLAYER = "INSERT INTO `player` " +
                                                       "(number, fk_position_id, name, date_birth, status, fk_country_id_player, fk_football_club_id, image_name) " +
                                                       "VALUES(@number, @fk_position_id, @name, @date_birth, @status, @fk_country_id_player, @fk_football_club_id, @image_name)";
       
        private static readonly string SELECT_ALL_PLAYER_BY_CLUB = "SELECT p.id, p.number, po.id, po.description, p.name, p.date_birth, p.status, c.id, c.name, c.image_name, p.image_name  FROM `player` p " +
                                                                   "INNER JOIN `position` po ON p.fk_position_id = po.id " +
                                                                   "INNER JOIN `country` c ON p.fk_country_id_player = c.id " +
                                                                   "WHERE fk_football_club_id = @football_club_id";
        private static readonly string SELECT_PLAYER_BY_ID = "SELECT p.id, p.number, po.id, po.description, p.name, p.date_birth, p.status, c.id, c.name, c.image_name, p.image_name  FROM `player` p " +
                                                             "INNER JOIN `position` po ON p.fk_position_id = po.id " +
                                                             "INNER JOIN `country` c ON p.fk_country_id_player = c.id " + 
                                                             "WHERE p.id = @playerId";
        private static readonly string SELECT_ALL_PLAYERS = "SELECT p.id, p.name, po.id, po.description, p.status FROM `player` p " +
                                                            "INNER JOIN `position` po ON po.id = p.fk_position_id";
        private static readonly string UPDATE_PLAYER_STATUS = "UPDATE `player` " +
                                                               "SET status = @status " +
                                                               "WHERE id = @id";
        private static readonly string SELECT_STATUS_ID = "SELECT status FROM `player` WHERE id = @id";

        private static readonly string UPDATE_PLAYER = "UPDATE `player` " +
                                                       "SET number = @number, fk_position_id = @pos, name = @name, date_birth = @date, fk_country_id_player = @country, fk_football_club_id = @fc " +
                                                       "WHERE id = @id";
        public static void UpdateByPlayerId(PlayerModel player)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() {ParamOne = "@number", ParamTwo = player.Number},
                new Params() {ParamOne = "@pos", ParamTwo = player.Position.ID},
                new Params() {ParamOne = "@name", ParamTwo = player.Name},
                new Params() {ParamOne = "@date", ParamTwo = player.Date},
                new Params() {ParamOne = "@country", ParamTwo = player.Country.ID},
                new Params() {ParamOne = "@fc", ParamTwo = player.FootballClub.ID},
                new Params() {ParamOne = "@id", ParamTwo = player.ID}
            };

            MySqlConnection conn = DBUtil.GetConnection();

            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_PLAYER, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static int? SelectStatus(int id)
        {
            int? result = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@id", ParamTwo = id }
            };
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_STATUS_ID, tmp);

            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }

            return result;
        }
        public static void UpdateStatusById(int status, int id)
        {
            //int? result = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@status", ParamTwo = status },
                new Params() { ParamOne = "@id", ParamTwo = id }
            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_PLAYER_STATUS, tmp);

            DBUtil.CloseQuietly(conn);

        }
        public static List<PlayerModel> SelectAll()
        {
            List<PlayerModel> playerModels = new List<PlayerModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL_PLAYERS);

            while (reader.Read())
            {
                playerModels.Add(new PlayerModel
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Position = new PositionModel { ID = reader.GetInt32(2), Description = reader.GetString(3)},
                    Status = reader.GetInt32(4)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return playerModels;
        }
        public static PlayerModel SelectByPlayerId(int playerId)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() {ParamOne = "@playerId", ParamTwo = playerId}
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_PLAYER_BY_ID, tmp);
            PlayerModel playerModel = null;
            while(reader.Read())
            {
                playerModel = new PlayerModel
                {
                    ID = reader.GetInt32(0),
                    Number = reader.GetInt32(1),
                    Position = new PositionModel { ID = reader.GetInt32(2), Description = reader.GetString(3) },
                    Name = reader.GetString(4),
                    Date = reader.GetDateTime(5),
                    Status = reader.GetInt32(6),
                    Country = new CountryModel { ID = reader.GetInt32(7), Name = reader.GetString(8), ImageName = reader.GetString(9) },
                    ImageName = reader.GetString(10)
                };
            }

            DBUtil.CloseQuietly(reader, conn);

            return playerModel;

        }
        public static List<PlayerModel> SelectByClubId(int clubId)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params()  {ParamOne = "@football_club_id", ParamTwo = clubId}
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_ALL_PLAYER_BY_CLUB, tmp);

            List<PlayerModel> playerModels = new List<PlayerModel>();

            while(reader.Read())
            {
                playerModels.Add(new PlayerModel
                {
                    ID = reader.GetInt32(0),
                    Number = reader.GetInt32(1),
                    Position = new PositionModel { ID = reader.GetInt32(2), Description = reader.GetString(3)},
                    Name = reader.GetString(4),
                    Date = reader.GetDateTime(5),
                    Status = reader.GetInt32(6),
                    Country = new CountryModel { ID = reader.GetInt32(7), Name = reader.GetString(8), ImageName = reader.GetString(9) },
                    ImageName = reader.GetString(10)
                });
            }

            DBUtil.CloseQuietly(reader, conn);
            
            return playerModels;
        }
        
        public static void InsertPlayer(PlayerModel playerModel)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@number", ParamTwo = playerModel.Number },
                new Params() { ParamOne = "@fk_position_id", ParamTwo = playerModel.Position.ID },
                new Params() { ParamOne = "@name", ParamTwo = playerModel.Name},
                new Params() {ParamOne = "@date_birth", ParamTwo = playerModel.Date},
                new Params() {ParamOne = "@status", ParamTwo=1},
                new Params() {ParamOne = "@fk_country_id_player", ParamTwo=playerModel.Country.ID},
                new Params() {ParamOne = "@fk_football_club_id", ParamTwo=playerModel.FootballClub.ID},
                new Params() {ParamOne = "@image_name", ParamTwo=playerModel.ImageName},

            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_PLAYER, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
