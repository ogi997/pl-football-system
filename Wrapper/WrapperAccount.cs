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
    class WrapperAccount
    {
        private static readonly string SELECT_ALL = "SELECT u.id, u.username, u.password, t.id, t.description, r.id, r.name, status  FROM `account` u " +
                                                    "INNER JOIN `role` r ON r.id = u.fk_role_id " +
                                                    "INNER JOIN `theme` t ON t.id = u.fk_theme_id";

        private static readonly string SELECT_ACCOUNT = "SELECT u.id, u.username, u.password, u.status, r.id, r.name, t.id, t.description FROM `account` u " + 
                                                        "INNER JOIN `role` r ON r.id = u.fk_role_id " + 
                                                        "INNER JOIN `theme` t ON t.id = u.fk_theme_id WHERE username = @username AND password = @password";

        private static readonly string SELECT_STATUS_ID = "SELECT status FROM `account` WHERE id = @id";

        private static readonly string UPDATE_ACCOUNT_STATUS = "UPDATE `account` " +
                                                               "SET status = @status " +
                                                               "WHERE id = @id";
        private static readonly string SELECT_ACCOUNT_BY_ID = "SELECT u.id, u.username, u.password, t.id, t.description, r.id, r.name, status  FROM `account` u " +
                                                              "INNER JOIN `role` r ON r.id = u.fk_role_id " +
                                                              "INNER JOIN `theme` t ON t.id = u.fk_theme_id " +
                                                              "WHERE u.id = @id";
        private static readonly string UPDATE_ROLE_BY_ID = "UPDATE `account` " +
                                                           "SET fk_role_id = @role " +
                                                           "WHERE id = @id";
        private static readonly string INSERT_ACCOUNT = "INSERT INTO `account` " +
                                                        "(username, password, fk_theme_id, fk_role_id, status) " +
                                                        "VALUES(@username, @password, @fk_theme_id, @fk_role_id, @status)";
        private static readonly string SELECT_BY_USERNAME = "SELECT u.id, u.username, u.password, t.id, t.description, r.id, r.name, status  FROM `account` u " +
                                                              "INNER JOIN `role` r ON r.id = u.fk_role_id " +
                                                              "INNER JOIN `theme` t ON t.id = u.fk_theme_id " +
                                                              "WHERE u.username = @username";
        private static readonly string UPDATE_ACCOUNT = "UPDATE `account` " +
                                                        "SET username = @username, password = @password, fk_role_id = @role " +
                                                        "WHERE id = @id";
        private static readonly string UPDATE_THEME = "UPDATE `account` " +
                                                      "SET fk_theme_id = @theme " +
                                                      "WHERE id = @id";
        private static readonly string SELECT_THEME = "SELECT a.id, a.fk_theme_id, t.description FROM `account` a " +
                                                      "INNER JOIN `theme` t ON t.id = a.fk_theme_id " +
                                                      "WHERE a.id = @id";
        public static string GetTheme(int userId)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() {ParamOne = "@id", ParamTwo = userId}
            };

            MySqlConnection conn = DBUtil.GetConnection();

            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_THEME, tmp);
            string theme = null;
            while(reader.Read())
            {
                theme = reader.GetString(2);
            }

            DBUtil.CloseQuietly(reader, conn);

            return theme;
        }
        public static void UpdateTheme(int userId, int themeId)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@theme", ParamTwo = themeId},
                new Params() { ParamOne = "@id", ParamTwo = userId}
            };

            MySqlConnection conn = DBUtil.GetConnection();

            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_THEME, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static void UpdateAccountById(AccountModel ac)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@username", ParamTwo = ac.Username},
                new Params() {ParamOne = "@password", ParamTwo = ac.Password},
                new Params() {ParamOne = "@role", ParamTwo = ac.Role.ID},
                new Params() {ParamOne = "@id", ParamTwo = ac.ID}
            };

            MySqlConnection conn = DBUtil.GetConnection();

            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_ACCOUNT, tmp);

            DBUtil.CloseQuietly(conn);

        }

        public static AccountModel SelectByUsername(string username)
        {
            AccountModel account = null;
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@username", ParamTwo = username },
            };
            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_BY_USERNAME, tmp);
            while(reader.Read())
            {
                account = new AccountModel()
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Theme = new ThemeModel { ID = reader.GetInt32(3), Description = reader.GetString(4) },
                    Role = new RoleModel { ID = reader.GetInt32(5), Name = reader.GetString(6) },
                    Status = reader.GetInt32(7)
                };
            }

            DBUtil.CloseQuietly(reader, conn);

            return account;
        }
        public static void Insert(AccountModel account)
        {
            List<Params> tmp = new List<Params>() {
                new Params() { ParamOne = "@username", ParamTwo = account.Username },
                new Params() { ParamOne = "@password", ParamTwo = account.Password },
                new Params() { ParamOne = "@fk_theme_id", ParamTwo = 1},
                new Params() {ParamOne = "@fk_role_id", ParamTwo = account.Role.ID},
                new Params() {ParamOne = "@status", ParamTwo=account.Status}

            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareInsertWithParameters(conn, INSERT_ACCOUNT, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static void UpdateRoleById(int role, int id)
        {
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@role", ParamTwo = role },
                new Params() { ParamOne = "@id", ParamTwo = id }
            };
            MySqlConnection conn = DBUtil.GetConnection();
            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_ROLE_BY_ID, tmp);

            DBUtil.CloseQuietly(conn);
        }
        public static AccountModel SelectAccountById(int id)
        {
            AccountModel am = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@id", ParamTwo = id }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_ACCOUNT_BY_ID, tmp);
            while(reader.Read())
            {
                am = new AccountModel()
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Theme = new ThemeModel { ID = reader.GetInt32(3), Description = reader.GetString(4) },
                    Role = new RoleModel { ID = reader.GetInt32(5), Name = reader.GetString(6) },
                    Status = reader.GetInt32(7)
                };
            }
            DBUtil.CloseQuietly(reader, conn);
            return am;
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
            DBUtil.PrepareUpdateWithParameters(conn, UPDATE_ACCOUNT_STATUS, tmp);

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

            while(reader.Read())
            {
                result = reader.GetInt32(0);
            }

            return result;
        }

        public static List<AccountModel> SelectAll()
        {
            List<AccountModel> Accounts = new List<AccountModel>();

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReader(conn, SELECT_ALL);

            while(reader.Read())
            {
                Accounts.Add(new AccountModel()
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Theme = new ThemeModel
                    {
                        ID = reader.GetInt32(3),
                        Description = reader.GetString(4)
                    },
                    Role = new RoleModel
                    {
                        ID = reader.GetInt32(5),
                        Name = reader.GetString(6)
                    },
                    Status = reader.GetInt32(7)
                });
            }

            DBUtil.CloseQuietly(reader, conn);

            return Accounts;
        }
        public static AccountModel SelectUserByUsernameAndPassword(string username, string password)
        {
            AccountModel User = null;
            List<Params> tmp = new List<Params>()
            {
                new Params() { ParamOne = "@username", ParamTwo = username },
                new Params() { ParamOne = "@password", ParamTwo = password }
            };

            MySqlConnection conn = DBUtil.GetConnection();
            MySqlDataReader reader = DBUtil.PrepareReaderWithParameters(conn, SELECT_ACCOUNT, tmp);

            while (reader.Read())
            {
                User = new AccountModel
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Status = reader.GetInt32(3),
                    Role = new RoleModel { ID = reader.GetInt32(4), Name = reader.GetString(5) },
                    Theme = new ThemeModel { ID = reader.GetInt32(6), Description = reader.GetString(7) },
                };
            }

            DBUtil.CloseQuietly(reader, conn);

            return User;
        }
    }
}
