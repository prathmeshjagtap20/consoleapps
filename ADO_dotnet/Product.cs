// using System;
// using System.Data;
// using System.Data.SqlClient;
 
// namespace ADO_ConnectedDemo
// {
//     class Product
//     {
//         public static SqlConnection con;
//         public static SqlCommand cmd;
//         public static SqlDataReader dr;
 
//         public static void Main(string[] args)
//         {
//             string name;
//             Console.WriteLine("Enter name:");
//             name = Console.ReadLine();
 
//             try
//             {
//                 // Corrected the typo in the connection string
//                 con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
//                 Console.WriteLine(con);
               
//                 cmd = new SqlCommand();
//                 cmd.Connection = con;
//                 cmd.CommandText = "SELECT ProducctCode, productname FROM Products WHERE productname = @name";
 
//                 // Correctly create and add the SqlParameter
//                 SqlParameter p = new SqlParameter("@name", SqlDbType.VarChar);
//                 p.Value = name;
//                 cmd.Parameters.Add(p);
 
//                 con.Open();
//                 dr = cmd.ExecuteReader();
 
//                 if (dr.Read())
//                 {
//                     Console.WriteLine($"id : {dr[0]} name: {dr[1]}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("No product found with the given name.");
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error: {ex.Message}");
//             }
//             finally
//             {
//                 dr.Close();
//                 con.Close();
//             }
//         }
//     }
// }