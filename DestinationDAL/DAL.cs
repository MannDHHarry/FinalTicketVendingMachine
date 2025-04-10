using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DestinationDAL
{
    public class DAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["TicketMachineDB"].ConnectionString;

        public List<string> GetAllDestinations()
        {
            List<string> destinations = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Destinations WHERE IsActive = 1", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    destinations.Add(reader["Name"].ToString());
                }
            }
            return destinations;
        }
    }
}
