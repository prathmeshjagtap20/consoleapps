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
//         public static void Main()
//         {
//             con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
//             //create dataadpater obj
 
//             da = new SqlDataAdapter("select id,fname,lname,salary from employee", con);
//             ds = new DataSet();
//             da.Fill(ds);
//             dt1 = new DataTable();
//             dt1 = ds.Tables[0];
//             foreach (DataRow dr in dt1.Rows)
//             {
//                 System.Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
//             }
//         }
//     }
// }