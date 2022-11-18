using PLFootballSystem.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLFootballSystem.Model;
using MySql.Data.MySqlClient;

namespace PLFootballSystem.Wrapper
{
    class WrapperFCHasSeason
    {
        private static readonly string INSERT = "INSERT INTO `football_club_has_seasone` " +
                                                "(football_club_id, seasone_id, table_position) " +
                                                "VALUES(@football_club_id, @seasone_id, @table_position)";
        private static readonly string SELECT_BY_SEASON_ID = "SELECT fc.name, p.table_position FROM `football_club_has_seasone` p " +
                                                             "INNER JOIN `football_club` fc ON fc.id = p.football_club_id " +
                                                             "WHERE p.seasone_id = @id " +   
                                                             "ORDER BY p.table_position ASC";
        public static List<FootballClubModel> SelectBySeasonId(int id)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@id", ParamTwo = id}
            };

            List<FootballClubModel> footballClubModels = new List<FootballClubModel>();

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_BY_SEASON_ID, tmp);

            while(reader.Read())
            {
                footballClubModels.Add(new FootballClubModel
                {
                    Name = reader.GetString(0)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return footballClubModels;
        }
        public static void Insert(FCSeasonsModel fCSeasonModel )
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@football_club_id", ParamTwo = fCSeasonModel.FC.ID },
                new Params() { ParamOne = "@seasone_id", ParamTwo = fCSeasonModel.Seasons.ID },
                new Params() { ParamOne = "@table_position", ParamTwo = fCSeasonModel.TablePosition},


            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT, tmp);

            DBUtil.CloseQuietly(conn);
        }
    }
}
