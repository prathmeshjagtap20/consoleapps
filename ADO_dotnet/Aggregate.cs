using System.Data;
using System;
using System.Data.SqlClient;

namespace ADO_dotnet
{
    class Aggregate
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataReader dr;

        static void Main(string[] args)
        {
            con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
            System.Console.WriteLine(con);

            System.Console.WriteLine("Successfully connected");
            try
            {
                // Open the connection first
                con.Open();

                cmd = new SqlCommand();
                // Associate con with cmd
                cmd.Connection = con;

                // Get the total number of employees
                cmd.CommandText = "SELECT COUNT(*) FROM employee";
                int count = (int)cmd.ExecuteScalar();
                System.Console.WriteLine("Total number of employees: " + count);

                cmd.CommandText = "select Min(salary) from employee";
                decimal min = (decimal)cmd.ExecuteScalar();
                System.Console.WriteLine("The minimum salary of the employee is :- " + min);

                cmd.CommandText = "select Max(salary) from employee";
                decimal max = (decimal)cmd.ExecuteScalar();
                System.Console.WriteLine("The minimum salary of the employee is :- " + max);


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                // Close the SqlDataReader if it was opened
                if (dr != null)
                {
                    dr.Close();
                }
                // Close the connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}