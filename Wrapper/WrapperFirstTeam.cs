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
                                                           "(fk_match_id, fk_fc_id, fk_player_id) " +
                                                           "VALUES(@fk_match_id, @fk_fc_id, @fk_player_id)";
        private static readonly string SELECT_FIRST_TEAM_BY_MATCH_AND_CLUB = "SELECT m.fk_match_id, m.fk_fc_id, m.fk_player_id, p.name, p.image_name, p.id FROM db_pl.first_team m " +
                                                                             "INNER JOIN db_pl.player p ON p.id = m.fk_player_id " +
                                                                             "WHERE m.fk_match_id = @matchId AND m.fk_fc_id = @fkId";

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
                    ID = reader.GetInt32(5)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return playerModels;
        }
        public static void InsertFirstTeam(FirstTeamModel firstTeamModel)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@fk_match_id", ParamTwo = firstTeamModel.Match.ID },
                new Params() { ParamOne = "@fk_fc_id", ParamTwo = firstTeamModel.FC.ID },
                new Params() { ParamOne = "fk_player_id", ParamTwo = firstTeamModel.Player.ID }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_FIRST_TEAM, tmp);

            DBUtil.CloseQuietly(conn);

        }

    }
}
