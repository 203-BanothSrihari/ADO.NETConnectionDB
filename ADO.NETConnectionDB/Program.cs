using System;
using System.Data.SqlClient;


namespace ADO.NETConnectionDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind; integrated security=SSPI");

                //writing sql query
                SqlCommand cm = new SqlCommand("Select * from Employees", con);

                //Opening Connection
                con.Open();

                //Executing the SQL query
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["FirstName"] + " || " + sdr["LastName"] + " || " + sdr["Title"]);
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something is wrong " + e);
            }
        }
    }
}
