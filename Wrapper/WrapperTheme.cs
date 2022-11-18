using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PLFootballSystem.Model;
using PLFootballSystem.Util;

namespace PLFootballSystem.Wrapper
{
    class WrapperTheme
    {
        private static readonly string SELECT_ALL = "SELECT * FROM `theme`";
        public static List<ThemeModel> SelectAll()
        {
            List<ThemeModel> Themes = new List<ThemeModel>();
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                Themes.Add(new ThemeModel
                {
                    ID = reader.GetInt32(0),
                    Description = reader.GetString(1),
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return Themes;
        }
    }
}
