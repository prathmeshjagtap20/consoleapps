// using System.Data;
// using System;
// using System.Data.SqlClient;

// namespace ADO_dotnet
// {
//     class Program
//     {
//         private static SqlConnection con;
//         private static SqlCommand cmd;
//         private static SqlDataReader dr;
//         static void Main(string[] args)
//         {

//             con = new SqlConnection("data source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;TrustServerCertificate=true");
//             System.Console.WriteLine(con);

//             System.Console.WriteLine("successfully conntected");
//             try
//             {


//                 cmd = new SqlCommand();
//                 //asssociate con with cmd
//                 cmd.Connection = con;
//                 cmd.CommandText = "select id,fname,lname,salary from employee where id=@id";

//                 //parameterised query
//                 SqlParameter p = new SqlParameter("@id", SqlDbType.Int);
//                 int id;
//                 System.Console.WriteLine("Enter id ");
//                 id = Convert.ToInt32(Console.ReadLine());
//                 p.Value = id;
//                 cmd.Parameters.Add(p);
//                 //cmd.commandtype=commandtype.text;

//                 //select query is execute calling executtereader() method.
//                 con.Open();
//                 dr = cmd.ExecuteReader();
//                 while (dr.Read())
//                 {
//                     System.Console.WriteLine($"id:-  {dr[0]} first name :- {dr[1]} lastname :-{dr[2]}  salary:- {dr[3]}");
//                 }
//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }

//             finally
//             {
//                 dr.Close();
//                 con.Close();

//             }




//             //step 1 connect obj
//             //step 2 command obj
//             //step 3 
//             //step 4
//         }
//     }
// }