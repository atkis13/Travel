using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Travel
{
    class Form_Methods
    {
        static DBConnection conn;

       
        public static string GenerateID(string input, DateTimePicker dt)
        {
            string word = null;
            word = input.Replace(" ", null);
            return word + dt.Value.Year.ToString();
            //Generate ID based on travel destination and year
        }

        public static void AddID(string id)
        {
            string query = "INSERT INTO travels(traveld_id) VALUES(@id);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            //Add the generated id to travels table
        }

        public static void AddDestination(string id, string dest, string date_start, string date_end, string start_loc, string ppl, string notes, string s_money)
        {
            //Add the data from the add form to the destinations table
            string query = "INSERT INTO destinations(traveld_id, destinations, date_start, date_end, start_location, no_ppl, notes, spending_money, completed) VALUES(@id, @dest, @date_start, @date_end, @start_loc, @ppl, @notes, @s_money, @completed);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@dest", dest);
            cmd.Parameters.AddWithValue("@date_start", date_start);
            cmd.Parameters.AddWithValue("@date_end", date_end);
            cmd.Parameters.AddWithValue("@start_loc", start_loc);
            cmd.Parameters.AddWithValue("@ppl", ppl);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.Parameters.AddWithValue("@s_money", s_money);
            cmd.Parameters.AddWithValue("@completed", "false");            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddRoutes(string id, string from, string to, string via, string cost, string retur)
        {
            string query = "INSERT INTO routes(id_travel, from, to, by, cost_per_person, return) VALUES(@id, @from, @to, @via, @cost, @retur);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@via", via);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@retur", retur);
            
            //add routes to database
        }

        public static void AddHousing(string id, string location, string checkin, string checkout, string cost_night)
        {
            string query = "INSERT INTO housings(id_travel, housing_location, in_date, out_date, cost_per_night) VALUES(@id, @location, @checkin, @checkout, @cost_night);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@checkout", checkout);
            cmd.Parameters.AddWithValue("@cost_night", cost_night);
            
            //add housing to database
        }

        public static void CompleteTravel()
        {
            //update the destinations table comleteed to true
            //add the actual costs to the cost table
            
        }

        
        public static void GetIDs(ComboBox cb)
        {
            string query = "Select * travels;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string id = red.GetString("travel_id");
                cb.Items.Add(id);
            }
            conn.Close();
            //ge tthe ids from the travels table
        }
    }
}
