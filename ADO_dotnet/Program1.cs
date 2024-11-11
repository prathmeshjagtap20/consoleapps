// using System.Data;
// using System;
// using System.Data.SqlClient;

// namespace ADO_dotnet
// {
//     class Program1
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
//                 // cmd.CommandText = "select id,fname,lname,salary from employee";

//                 // //cmd.commandtype=commandtype.text;

//                 // //select query is execute calling executtereader() method.
//                 // con.Open();
//                 // dr = cmd.ExecuteReader();
//                 // while (dr.Read())
//                 // {
//                 //     System.Console.WriteLine($"id:-  {dr[0]} first name :- {dr[1]} lastname :-{dr[2]}  salary:- {dr[3]}");
//                 // }

//                 System.Console.WriteLine(".......To add new Employee records ...............");

//                 System.Console.WriteLine("Enter fname ");
//                 string fname = Console.ReadLine();
//                 System.Console.WriteLine("Enter last name ");
//                 string lname = Console.ReadLine();
//                 System.Console.WriteLine("Enter salary ");
//                 decimal salary = Convert.ToDecimal(Console.ReadLine());

//                 cmd.CommandText = "insert into employee(fname,lname,salary)values(@fname,@lname,@salary)";
//                 SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
//                 SqlParameter p2 = new SqlParameter("@lname", SqlDbType.VarChar);
//                 SqlParameter p3 = new SqlParameter("@salary", SqlDbType.Decimal);
//                 p1.Value = fname;
//                 p2.Value = lname;
//                 p3.Value = salary;

//                 cmd.Parameters.Add(p1);
//                 cmd.Parameters.Add(p2);
//                 cmd.Parameters.Add(p3);
//                 con.Open();

//                 int rows = cmd.ExecuteNonQuery();

//                 if (rows > 0)
//                 {
//                     System.Console.WriteLine("Record addes successfully ");
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Some things bad happened");
//                 }

//                 //for insert, update, delete we use executeNonquery







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