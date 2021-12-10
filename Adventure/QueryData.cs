using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace game
{
    public static class QueryData
    {

        // Khai báo đối tượng conn kết nối vào DB.
        public static MySqlConnection conn = Main.ConnectDb.GetDBConnection();

        //--Lấy 1 từ ngẫu nhiên trong database 
        public static string getRandomStringFromDb(string typeLevel)
        {
            conn.Open();
            string str = "";    //Kết quả trả về
            try
            {
                string sql = "SELECT " + typeLevel + " FROM dictionary ORDER BY RAND() LIMIT 1";


                // Tạo một đối tượng Command.
                MySqlCommand cmd = new MySqlCommand();

                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            str = reader.GetString(0);
                            return str;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi kết nối cơ sở dữ liệu");
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }
            return str;
        }


        //--Xuất danh sách từ điển trong console
        public static void getDataDictionary()
        {
            try
            {
                conn.Open();
                string sql = "Select * from DICTIONARY";

                // Tạo một đối tượng Command.
                MySqlCommand cmd = new MySqlCommand();

                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(2);  //Cột 2 là hard
                            Console.WriteLine(name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi kết nối cơ sở dữ liệu");
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }

        }


        //-- Nhập dữ liệu từ file .txt vào database
        public static void insertData()
        {
            try
            {
                conn.Open();
                string[] nor = File.ReadAllLines(@"C:\Users\AnNgocLocal1\Desktop\Normal.txt"); 
                string[] har = File.ReadAllLines(@"C:\Users\AnNgocLocal1\Desktop\Hard.txt");

                for (int i = 0; i < nor.LongLength; i++)
                {
                    string sql = "INSERT INTO dictionary(normal, hard) VALUES(@normal, @hard)";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;

                    // Tạo một đối tượng Parameter.
                    MySqlParameter normalWordParam = new MySqlParameter("@normal", MySqlDbType.String);
                    normalWordParam.Value = nor[i];
                    cmd.Parameters.Add(normalWordParam);

                    MySqlParameter hardWordParam = new MySqlParameter("@hard", MySqlDbType.String);
                    hardWordParam.Value = har[i];
                    cmd.Parameters.Add(hardWordParam);

                    // Thực thi Command (Dùng cho delete, insert, update).
                    int rowCount = cmd.ExecuteNonQuery();

                    Console.WriteLine("Row Count affected = " + rowCount);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi kết nối cơ sở dữ liệu");
                Console.WriteLine(" " + e.Message);
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }
        }

        //--Nhập kết quả người chơi
        public static void insertInfoPlayer(string playerName, int score)
        {
            if(string.IsNullOrEmpty(playerName) || score == 0)
            {
                Console.WriteLine("Ket thuc! Khong ghi vao csdl");
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO typershark.hall(player, score) VALUES(@player, @score) ";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;


                    MySqlParameter p0 = new MySqlParameter("@player", MySqlDbType.String);
                    p0.Value = playerName;
                    cmd.Parameters.Add(p0);


                    MySqlParameter p1 = new MySqlParameter("@score", MySqlDbType.Int32);
                    p1.Value = score;
                    cmd.Parameters.Add(p1);


                    // Thực thi Command (Dùng cho delete, insert, update).
                    int rowCount = cmd.ExecuteNonQuery();

                    Console.WriteLine("Insert sucess!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi kết nối cơ sở dữ liệu - insertInfoPlayer - QueryData ");
                    Console.WriteLine(e.Message);
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    // Đóng kết nối.
                    conn.Close();
                    // Tiêu hủy đối tượng, giải phóng tài nguyên.
                    conn.Dispose();
                }
            }
            

        }

    }
}
