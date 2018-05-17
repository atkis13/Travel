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

       
        public static void GenerateID()
        {
            //Generate ID based on travel destination and year
        }

        public static void AddID()
        {
            //Add the generated id to travels table
        }

        public static void AddDestination()
        {
            //Add the data from the add form to the destinations table
        }

        public static void AddRoutes()
        {
            //add routes to database
        }

        public static void AddHousing()
        {
            //add housing to database
        }

        public static void CompleteTravel()
        {
            //update the destinations table comleteed to true
            //add the actual costs to the cost table
            
        }

        
        public static void GetIDs()
        {
            //ge tthe ids from the travels table
        }
    }
}
