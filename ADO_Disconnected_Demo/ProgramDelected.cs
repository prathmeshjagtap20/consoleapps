using System.Data;
using System.Data.SqlClient;

namespace ADO_Disconnected_Demo
{
    class ProgramDelecte
    {
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt1;
        public static DataTable dt2;
        public static SqlCommandBuilder cb;
        public static void Main()
        {

            try
            {



                con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
                //create dataadpater obj

                da = new SqlDataAdapter("select id,fname,lname,salary from employee", con);
                ds = new DataSet();
                da.Fill(ds);

                cb = new SqlCommandBuilder();
                cb.DataAdapter = da;

                int id;

                System.Console.WriteLine("To delete employee enter id ");
                id = Convert.ToInt32(Console.ReadLine());


                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (Convert.ToInt32(row["id"].ToString()) == id)
                    {
                        ds.Tables[0].Rows.Remove(row);
                        da.Update(ds.Tables[0]);
                        System.Console.WriteLine("Record Delected Successfully ");
                    }
                }

            }

            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }




        }


    }
}