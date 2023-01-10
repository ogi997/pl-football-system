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
    class WrapperFirstTeam
    {
        private static readonly string INSERT_FIRST_TEAM = "INSERT INTO `first_team` " +
                                                           "(fk_match_id, fk_fc_id, fk_player_id, fk_formation_id, player_position) " +
                                                           "VALUES(@fk_match_id, @fk_fc_id, @fk_player_id, @formation, @position)";
        private static readonly string SELECT_FIRST_TEAM_BY_MATCH_AND_CLUB = "SELECT m.fk_match_id, m.fk_fc_id, m.fk_player_id, p.name, p.image_name, p.id, m.player_position FROM `first_team` m " +
                                                                             "INNER JOIN db_pl.player p ON p.id = m.fk_player_id " +
                                                                             "WHERE m.fk_match_id = @matchId AND m.fk_fc_id = @fkId";
        private static readonly string SELECT_FORMATION = "SELECT ft.fk_formation_id, f.id, f.description FROM `first_team` ft " +
                                                          "INNER JOIN `formation` f ON f.id = ft.fk_formation_id " +
                                                          "WHERE ft.fk_match_id = @matchId AND ft.fk_fc_id = @fkId";

        public static FormationModel SelectFormationForMatch(int matchId, int footballClubId)
        {
            FormationModel formationModel = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@matchId", ParamTwo = matchId },
                new Params() { ParamOne = "@fkId", ParamTwo = footballClubId }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_FORMATION, tmp);

            while (reader.Read())
            {
                formationModel = new FormationModel(){
                    ID = reader.GetInt32(1),
                    Description = reader.GetString(2)
                };
            }

            DBUtil.CloseQuietly(reader, conn);

            return formationModel;
        }

        public static List<PlayerModel> SelectFirstTeamByMatchAndClubId(int matchId, int footballClubId)
        {
            List<PlayerModel> playerModels = new List<PlayerModel>();

            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@matchId", ParamTwo = matchId },
                new Params() { ParamOne = "@fkId", ParamTwo = footballClubId }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_FIRST_TEAM_BY_MATCH_AND_CLUB, tmp);

            while(reader.Read())
            {
                playerModels.Add(new PlayerModel
                {
                    Name = reader.GetString(3),
                    ImageName = reader.GetString(4),
                    ID = reader.GetInt32(5),
                    pos = reader.GetInt32(6)
                }); ;
            }

            DBUtil.CloseQuietly(reader, conn);

            return playerModels;
        }
        public static void InsertFirstTeam(FirstTeamModel firstTeamModel, int formationId, int position)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@fk_match_id", ParamTwo = firstTeamModel.Match.ID },
                new Params() { ParamOne = "@fk_fc_id", ParamTwo = firstTeamModel.FC.ID },
                new Params() { ParamOne = "@fk_player_id", ParamTwo = firstTeamModel.Player.ID },
                new Params() { ParamOne = "@formation", ParamTwo = formationId },
                new Params() { ParamOne = "@position", ParamTwo = position}
            };

            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_FIRST_TEAM, tmp);

            DBUtil.CloseQuietly(conn);

        }

    }
}
