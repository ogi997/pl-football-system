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
    class WrapperMatch
    {
        private static readonly string INSERT_MATCH = "INSERT INTO `match` " +
                                                       "(goals_scored_home_fc, goals_received_away_fc, seasone_id_for_match, date, fk_home_football_club_id, fk_away_football_club_id) " +
                                                       "VALUES(@goals_scored_home_fc, @goals_received_away_fc, @seasone_id_for_match, @date, @fk_home_football_club_id, @fk_away_football_club_id)";

        private static readonly string SELECT_MATCH_BY_SEASON_ID = "SELECT m.id, m.goals_scored_home_fc, fc.name, m.goals_received_away_fc, fc1.name, m.date, m.fk_home_football_club_id, m.fk_away_football_club_id, m.seasone_id_for_match FROM `match` m " +
                                                                   "INNER JOIN `football_club` fc ON m.fk_home_football_club_id = fc.id " +
                                                                   "INNER JOIN `football_club` fc1 ON m.fk_away_football_club_id = fc1.id " +
                                                                   "WHERE m.seasone_id_for_match = @seasonId";
        private static readonly string SELECT_MATCH_BY_ID = "SELECT m.id, m.fk_home_football_club_id, m.fk_away_football_club_id FROM `match` m " +
                                                            "WHERE m.id = @matchId";
        public static MatchModel SelectMatchById(int matchId)
        {
            MatchModel matchModel = new MatchModel();

            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@matchId", ParamTwo = matchId }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_MATCH_BY_ID, tmp);

            while(reader.Read())
            {
                matchModel.FCHome = new FootballClubModel() { ID = reader.GetInt32(1) };
                matchModel.FCAway = new FootballClubModel() { ID = reader.GetInt32(2) };
               // matchModel.FCHome.ID = reader.GetInt32(0);
               // matchModel.FCAway.ID = reader.GetInt32(1);
            }

            //Console.WriteLine(matchModel.FCHome.ID);

            DBUtil.CloseQuietly(reader, conn);

            return matchModel;
        }
        public static List<MatchModel> SelectMatchBySeasonId(int seasonId)
        {
            List<MatchModel> matchModels = new List<MatchModel>();

            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "seasonId", ParamTwo = seasonId}
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_MATCH_BY_SEASON_ID, tmp);

            while(reader.Read())
            {
                matchModels.Add(new MatchModel()
                {
                    ID = reader.GetInt32(0),
                    GoalsScoredHome = reader.GetInt32(1),
                    FCHome = new FootballClubModel { ID = reader.GetInt32(6), Name = reader.GetString(2)},
                    GoalsReceivedAway = reader.GetInt32(3),
                    FCAway = new FootballClubModel { ID = reader.GetInt32(7), Name = reader.GetString(4)},
                    Date = reader.GetDateTime(5)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return matchModels;

        }
        public static int? Insert(MatchModel match)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@goals_scored_home_fc", ParamTwo = match.GoalsScoredHome },
                new Params() { ParamOne = "@goals_received_away_fc", ParamTwo = match.GoalsReceivedAway },
                new Params() { ParamOne = "@seasone_id_for_match", ParamTwo = match.Season.ID},
                new Params() {ParamOne = "@date", ParamTwo = match.Date},
                new Params() {ParamOne = "@fk_home_football_club_id", ParamTwo=match.FCHome.ID},
                new Params() {ParamOne = "@fk_away_football_club_id", ParamTwo=match.FCAway.ID}

            };
            MySqlConnection conn = DBUtil.GetConnection();
            int? id = DBUtil.PrepareInsertWithParametersAndGetId(conn, INSERT_MATCH, tmp);

            DBUtil.CloseQuietly(conn);

            return id;
        }
    }
}
