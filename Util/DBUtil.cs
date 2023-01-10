using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
namespace PLFootballSystem.Util
{
   public static class DBUtil
   {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["db_pl"].ConnectionString;
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            } catch
            {
                MessageBox.Show("DATABASE ERROR.");
            }
           
            return conn;
        }
        public static MySqlDataReader PrepareReader(MySqlConnection conn, string SQL_QUERY)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                reader = cmd.ExecuteReader();
            } catch
            {
                MessageBox.Show("DATABASE ERROR.");
            }
            return reader;
        }
        public static int? PrepareInsertWithParametersAndGetId(MySqlConnection conn , string SQL_QUERY, List<Params> values)
        {
            string query2 = "Select @@Identity";

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                foreach (var p in values)
                {
                    cmd.Parameters.AddWithValue((string)p.ParamOne, p.ParamTwo);
                }

                cmd.ExecuteNonQuery();
                cmd.CommandText = query2;
                Int32 id = Convert.ToInt32(cmd.ExecuteScalar());
                //MessageBox.Show("Successfully added.");
                return id;
            }
            catch (MySqlException e)
            {
               // Console.WriteLine(e);
                MessageBox.Show(e.Number == 1062 ? "Username exists." : "Database error aaaa1.");
                return -1;
            }
        }

        public static void PrepareDeleteWithParameters(MySqlConnection conn, string SQL_QUERY, List<Params> values)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                foreach (var p in values)
                {
                    cmd.Parameters.AddWithValue((string)p.ParamOne, p.ParamTwo);
                }
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Successfully deleted.");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number == 1062 ? "Username exists." : "Database error.");
            }
        }

        public static void PrepareInsertWithParameters(MySqlConnection conn, string SQL_QUERY, List<Params> values)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                foreach(var p in values)
                {
                    cmd.Parameters.AddWithValue((string)p.ParamOne, p.ParamTwo);
                }
                cmd.ExecuteNonQuery();
                
               // MessageBox.Show("Successfully added.");
            } catch(MySqlException e)
            {
                MessageBox.Show(e.Number == 1062 ? "Username exists." : "Database error.");
            }
        }

        public static void PrepareUpdateWithParameters(MySqlConnection conn, string SQL_QUERY, List<Params> values)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                foreach (Params p in values)
                {
                    cmd.Parameters.AddWithValue((string)p.ParamOne, p.ParamTwo);
                }

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Successfully updated");
            } catch (MySqlException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("DATABASE ERROR.");
            }
            
        }

        public static MySqlDataReader PrepareReaderWithParameters(MySqlConnection conn, string SQL_QUERY, List<Params> values)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL_QUERY;
                foreach(Params p in values)
                {
                    //Console.WriteLine(p.ParamOne + " " + p.ParamTwo);
                    cmd.Parameters.AddWithValue((string)p.ParamOne, p.ParamTwo);
                }
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                //Console.WriteLine("Error: " + e);
                MessageBox.Show("DATABASE ERROR aaa.");
            }
            return reader;
        }
        public static void CloseQuietly(MySqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            } catch { MessageBox.Show("DATABASE ERROR."); }
        }
        public static void CloseQuietly(MySqlDataReader reader)
        {
            try
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch { MessageBox.Show("DATABASE ERROR."); }
        }
        public static void CloseQuietly(MySqlDataReader reader, MySqlConnection conn)
        {
            CloseQuietly(reader);
            CloseQuietly(conn);
        }
    }
}
