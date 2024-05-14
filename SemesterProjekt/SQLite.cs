using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SemesterProjekt
{
   public class SQLite
    {
        public static List<Måling> ReadRoom1()
        {
            string connectionString = @"Data Source=C:\Users\nomis\Documents\GitHub\Semesterprojekt2\database.db";
            List<Måling> målingerRum1 = new List<Måling>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Rum1 ", conn))
                {
                    using(SQLiteDataReader reader =cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Måling Ny = new Måling
                            {
                                Tidspunkt = DateTime.Parse(reader["Time"].ToString()),
                                Temprature = Convert.ToDouble(reader["Tempratur"]),
                                Aktivitet = Convert.ToInt32(reader["Aktivitet"])


                            };
                            målingerRum1.Add(Ny);
                        }
                    }
                }
            }
            return målingerRum1;
        }







        public static List<Måling> ReadRoom2()
        {
            string connectionString = @"Data Source=C:\Users\nomis\Documents\GitHub\Semesterprojekt2\database.db";
            List<Måling> målingerRum2 = new List<Måling>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Rum2", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            Måling Ny = new Måling
                            {
                                Tidspunkt = DateTime.Parse(reader["Time"].ToString()),
                                Temprature = Convert.ToDouble(reader["Tempratur"]),
                                Aktivitet = Convert.ToInt32(reader["Aktivitet"])

                            };
                            målingerRum2.Add(Ny);
                        }
                    }
                }
            }
            return målingerRum2;
        }


    }



    
}
