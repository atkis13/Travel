﻿using System;
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
            string query = "INSERT INTO travels(travel_id) VALUES(@id);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            //Add the generated id to travels table

        }

        public static void AddDestination(string id, string dest, string date_start, string date_end, string start_loc, string ppl, string notes, int s_money)
        {
            //Add the data from the add form to the destinations table
            string query = "INSERT INTO destinations(travel_id, destinations, date_start, date_end, start_location, no_ppl, notes, spending_money, iscompleted) VALUES(@id, @dest, @date_start, @date_end, @start_loc, @ppl, @notes, @s_money, @completed);";
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

        public static void AddRoutes(string id, string from, string to, string via, int cost, CheckBox cb)
        {
            string retur = null;
            if (cb.Checked)
            {
                retur = "yes";
            }
            else
            {
                retur = "no";
            }
            string query = "INSERT INTO routes(id_travel, from_d, to_d, by_d, cost_per_person, return_t) VALUES(@id, @from, @to, @via, @cost, @retur);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@via", via);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@retur", retur);
            cmd.ExecuteNonQuery();
            conn.Close();

            //add routes to database
        }

        public static void AddHousing(string id, string location, DateTimePicker checkin, DateTimePicker checkout, int cost_night)
        {
            int t_nights = 0;
            t_nights = checkout.Value.Day - checkin.Value.Day;
            string query = "INSERT INTO housings(travel_id, housing_location, in_date, out_date, total_nights, cost_night) VALUES(@id, @location, @checkin, @checkout,@tot_nights, @cost_night);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@checkin", checkin.Text);
            cmd.Parameters.AddWithValue("@checkout", checkout.Text);
            cmd.Parameters.AddWithValue("@tot_nights", t_nights);
            cmd.Parameters.AddWithValue("@cost_night", cost_night);
            cmd.ExecuteNonQuery();
            conn.Close();

            //add housing to database
        }

        public static void CompleteTravel(string id)
        {
            string query = "UPDATE destinations SET iscompleted =@completed WHERE travel_id =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@completed", "true");
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        
        public static void GetIDs(ComboBox cb)
        {
            string query = "Select * FROM travels;";
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

        public static void AddSpending(string id, int cost, string switcher)
        {
            string query = null;
            if (switcher == "spending")
            {
                query = "INSERT INTO cost(id_travel, estimate_spending) VALUES(@id, @cost);";
            }
            else if(switcher == "housing")
            {
                query = "UPDATE cost SET est_total_housing =@cost WHERE id_travel =@id;";
            }
            else if (switcher == "transport")
            {
                query = "UPDATE cost SET est_total_transp =@cost WHERE id_travel =@id;";
            }
            else if (switcher == "total_est")
            {
                query = "UPDATE cost SET estimate_total =@cost WHERE id_travel =@id;";
            }

            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static int getEstExpense(string id)
        {
            int total = 0;
            string query = "Select * FROM cost WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                total += red.GetInt32("est_total_housing");
                total += red.GetInt32("est_total_transp");
                total += red.GetInt32("estimate_spending");
            }
            conn.Close();
            return total;
        }

        public static int getPeople(string id)
        {
            int people = 0;
            string query = "Select * FROM destinations WHERE travel_id =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                people = red.GetInt32("no_ppl");               
            }
            conn.Close();
            return people;

        }

        public static void loadDest(string id,Label loc, Label start, Label end, Label startloc, Label noofppl, Label notes)
        {
            string query = "Select * FROM destinations WHERE travel_id =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                loc.Text = red.GetString("destinations");
                start.Text = red.GetString("date_start");
                end.Text = red.GetString("date_end");
                startloc.Text = red.GetString("start_location");
                noofppl.Text = red.GetInt32("no_ppl").ToString();
                notes.Text = red.GetString("notes");
            }
            conn.Close();

        }

        public static void loadHousing(string id, Label lbl)
        {
            lbl.Text = null;
            string query = "Select * FROM housings WHERE travel_id =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                lbl.Text += "Location: " + red.GetString("housing_location")  + "\n" + "Check In: " + red.GetString("in_date") + "\n" + "Check Out: " + red.GetString("out_date") + "\n" + "Nights: " + red.GetInt32("total_nights").ToString() + "\n" + "Cost per Night: " + red.GetInt32("cost_night").ToString() +"\n--------------------------\n" ;
            }
            conn.Close();

        }

        public static void loadRoutes(string id, Label lbl)
        {
            lbl.Text = null;
            string query = "Select * FROM routes WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                lbl.Text += "From: " + red.GetString("from_d") + "\n" + "To: " + red.GetString("to_d") + "\n" + "By: " + red.GetString("by_d") + "\n" + "Cost per Person: " + red.GetInt32("cost_per_person").ToString()+ "\n" + "Return: " + red.GetString("return_t") + "\n--------------------------\n";
            }
            conn.Close();

        }

        public static bool isCompleted(string id)
        {
            bool flag = false;
            string query = "Select * FROM destinations WHERE travel_id =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                if(red.GetString("iscompleted") == "true")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                
            }
            return flag;
        }

        public static void getCosts(string id, Label housing, Label transp, Label spending, Label total,string type)
        {   
                       
            string query = "Select * FROM cost WHERE id_travel =@id;";          
           
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                if(type == "estimate")
                {
                    housing.Text = red.GetInt32("est_total_housing").ToString();
                    transp.Text = red.GetString("est_total_transp");
                    spending.Text = red.GetString("estimate_spending");
                    total.Text = red.GetString("estimate_total");
                }
                else if(type == "actual")
                {
                    housing.Text = red.GetInt32("act_total_housing").ToString();
                    transp.Text = red.GetString("act_total_transp");
                    spending.Text = red.GetString("actual_spending");
                    total.Text = red.GetString("actual_total");
                }
                
                
            }
            conn.Close();

        }
        
        public static void AddActualCost(string id, int act_housing, int actual_transp, int act_spending, int act_total, int balance)
        {
            string query = "UPDATE cost SET act_total_housing =@act_housing, act_total_transp =@act_trans, actual_spending =@act_spend, actual_total =@act_total, balance =@balance WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@act_housing", act_housing);            
            cmd.Parameters.AddWithValue("@act_trans", actual_transp);
            cmd.Parameters.AddWithValue("@act_spend", act_spending);
            cmd.Parameters.AddWithValue("@act_total", act_total);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static int getTotalEstimate(string id)
        {
            int estimate = 0;
            string query = "Select * FROM cost WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                estimate = red.GetInt32("estimate_total");

            }
            return estimate;

        }

        public static void AddBalance(string id, int balance)
        {
            string query = "UPDATE cost SET balance =@balance WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@balance", balance);            
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void getBalance (string id, Label lb)
        {
            
            string query = "Select * FROM cost WHERE id_travel =@id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                lb.Text = red.GetInt32("balance").ToString();

            }
            

        }



    }
}
