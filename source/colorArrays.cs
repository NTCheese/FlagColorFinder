using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagColorFinder
{
    public class ColorArrays
    {

        static string connStr = "server=127.0.0.1;user=root;database=world;port=3306;password=TheBestServerEverWillBeStoredHere123!;";
        MySqlConnection conn = new MySqlConnection(connStr);
        public string Color(string color)
        {
            //string connStr = "server=127.0.0.1;user=root;database=world;port=3306;password=TheBestServerEverWillBeStoredHere123!;";
            //MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = $"SELECT SUM({color}) FROM flags;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                string output = "";

                while (rdr.Read())
                {
                    output = rdr[0].ToString();
                }

                rdr.Close();
                conn.Close();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return $"AAAAAAAAAAAAAGHHHHHHHHHHHHHHHHHHHH";
            }
        }

        public string[] DoubleColorNames()
        {
            //string connStr = "server=127.0.0.1;user=root;database=world;port=3306;password=TheBestServerEverWillBeStoredHere123!;";
            //MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Connecting to MySQL...");
                //conn.Open();

                //string sql = $"SELECT * FROM flags WHERE ID = {id}";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //MySqlDataReader rdr = cmd.ExecuteReader();
                string[] colors = ["red", "orange", "yellow", "green", "blue", "purple", "black", "white", "brown", "gray", "pink"];
                int colorLength = 0;
                for (int i = colors.Length; i >= 0; i--)
                {
                    colorLength += i;
                }
                colorLength = colorLength - colors.Length;

                int k = 0; //may have broken it change it to colorlength if borkwn
                string[] doubleColorsFrontend = new string[colorLength];
                for (int i = 0; i < colors.Length; i++)
                {
                    for (int j = 0 + i; j < colors.Length - 1; j++)
                    {
                        doubleColorsFrontend[k] = colors[i] + " and " + colors[j + 1];
                        k++;
                    }
                }

                //rdr.Close();
                //conn.Close();
                return doubleColorsFrontend;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return ["AAAGGHHHHH"];
            }
        }

        public string[] DoubleColorValues()
        {
            try
            {
                string[] colors = ["red", "orange", "yellow", "green", "blue", "purple", "black", "white", "brown", "gray", "pink"];
                int length = DoubleLength();
                int[] doubleColorValues = new int[length];
                int k = 0;
                int id = 0;

                Console.WriteLine("Connecting to MySQL...");
                string sql = "";
                MySqlCommand cmd = null;
                MySqlDataReader rdr = null;

                for (int AMONGUS = 0; AMONGUS < length; AMONGUS++)
                {
                    conn.Open();
                    sql = $"SELECT * FROM flags WHERE ID = {id}";
                    cmd = new MySqlCommand(sql, conn);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        k = 0;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            for (int j = i + 1; j < colors.Length; j++)
                            {
                                if (int.Parse($"{rdr[i]} ") == 1)
                                {
                                    if (int.Parse($"{rdr[j]} ") == 1)
                                    {
                                        doubleColorValues[k]++;
                                        //MessageBox.Show(doubleColorValues[k].ToString());
                                    }
                                }
                                k++;
                            }
                        }
                    }
                    id++;
                    conn.Close();
                    rdr.Close();
                }

                string[] output = new string[doubleColorValues.Length];

                for (int AOIUSFHOASIDFHSDAPF = 0; AOIUSFHOASIDFHSDAPF < output.Length; AOIUSFHOASIDFHSDAPF++)
                {
                    output[AOIUSFHOASIDFHSDAPF] = doubleColorValues[AOIUSFHOASIDFHSDAPF].ToString();
                }

                rdr.Close();
                conn.Close();
                return output;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return ["AISYOHGYUKSDGBVUHYSFDIUOQFGUAGVAYISGDUFYGSDJFAJKSDFGAUSFUAHHHHHHHHHHH"];

            }
        }

        public int DoubleLength()
        {
            //string connStr = "server=127.0.0.1;user=root;database=world;port=3306;password=TheBestServerEverWillBeStoredHere123!;";
            //MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = $"SELECT COUNT(*) FROM flags;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                int output = 0;

                while (rdr.Read())
                {
                    output = int.Parse(rdr[0].ToString());
                }

                rdr.Close();
                conn.Close();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return 0000000;
            }
        }
    }
}
