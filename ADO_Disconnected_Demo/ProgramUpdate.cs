// using System.Data;
// using System.Data.SqlClient;
 
// namespace ADO_Disconnected_Demo
// {
//     class Program
//     {
//         public static SqlConnection con;
//         public static SqlDataAdapter da;
//         public static DataSet ds;
//         public static DataTable dt1;
//         public static DataTable dt2;
//         public static SqlCommandBuilder cb;
//         public static void Main()
//         {
//             con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
//             //create dataadpater obj
 
//             da = new SqlDataAdapter("select id,fname,lname,salary from employee", con);
//             ds = new DataSet();
//             da.Fill(ds);
//             dt1 = new DataTable();
//             dt1 = ds.Tables[0];
//             cb = new SqlCommandBuilder();
//             cb.DataAdapter = da;
//             string fname, lname;
//             decimal salary;
//             int id;
//             System.Console.WriteLine("enter id");
//             id = Convert.ToInt32(Console.ReadLine());
//             System.Console.WriteLine("enter fname");
//             fname = Console.ReadLine();
//             System.Console.WriteLine("enter lneme");
//             lname = Console.ReadLine();
//             System.Console.WriteLine("enter sal");
//             salary = Convert.ToDecimal(Console.ReadLine());
 
 
 
//             foreach (DataRow row in dt1.Rows)
//             {
 
//                 if (Convert.ToInt32(row["id"].ToString()) == id)
//                 {
//                     row["fname"] = fname;
//                     row["lname"] = lname;
//                     row["salary"] = salary;
//                     da.Update(ds.Tables[0]);
//                     System.Console.WriteLine("recoed updtaed suss");
//                 }
 
//             }
//         }
//     }
// }