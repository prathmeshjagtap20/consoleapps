using System.Data;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository
{
    class CourseRepository : ICourseRepository
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;

        static DataTable dt;
        public CourseRepository()
        {
            string connection = "Data Source=YISC1101243LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            con = new SqlConnection(connection);
            //  Console.WriteLine("Connection established successfully!");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }




        public int AddCourse(Course course)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into Courses(Title,Description,userid,CourseStartDate,CourseEndDate,Category,Level) values (@Title,@Description,@userid,@CourseStartDate,@CourseEndDate,@Category,@Level)";

                cmd.Parameters.AddWithValue("@Title", course.Title);
                cmd.Parameters.AddWithValue("@Description", course.Description);
                cmd.Parameters.AddWithValue("@CourseStartDate", course.CourseStartDate);
                cmd.Parameters.AddWithValue("@CourseEndDate", course.CourseEndDate);
                 cmd.Parameters.AddWithValue("@UserId", course.UserId);
                cmd.Parameters.AddWithValue("@Category", course.Category);
                cmd.Parameters.AddWithValue("@Level", course.Level);

                con.Open();
                int result = cmd.ExecuteNonQuery();//insert update delete
                con.Close();
                return result;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return 0;

        }

        public DataSet GetAllCourses()
        {
            string sql = "select * from Courses";
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

       

        public int updateCourse(Course course)
        {
            // cmd.Parameters.Clear();
            // cmd.CommandText = "select Title,Description,CourseStartDate,CourseEndDate,UserId,Category,Level from Courses where CourseId=@CourseId";
            // cmd.Parameters.AddWithValue("@CourseId", course.CourseId);
            // ds = new DataSet();
            // da = new SqlDataAdapter();
            // da.SelectCommand = cmd;
            // da.Fill(ds);
            // dt = ds.Tables[0];
            // if (dt.Rows.Count == 0)
            // {
            //     System.Console.WriteLine("not Course found");
            //     return -1;
            // }
 
 
            // dt.Rows[0]["Title"] = course.Title;
            // dt.Rows[0]["Description"] = course.Description;
            // dt.Rows[0]["CourseStartDate"] = course.CourseStartDate;
            // dt.Rows[0]["CourseEndDate"] = course.CourseEndDate;
            // dt.Rows[0]["Category"] = course.Category;
            // dt.Rows[0]["Level"] = course.Level;
            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE Courses SET Title = @Title, Description = @Description, CourseStartDate = @CourseStartDate, CourseEndDate = @CourseEndDate, Category = @Category, Level = @Level WHERE CourseId = @CourseId";
            cmd.Parameters.AddWithValue("@Title", course.Title);
            cmd.Parameters.AddWithValue("@Description", course.Description);
            cmd.Parameters.AddWithValue("@CourseStartDate", course.CourseStartDate);
            cmd.Parameters.AddWithValue("@CourseEndDate", course.CourseEndDate);
            cmd.Parameters.AddWithValue("@Category", course.Category);
            cmd.Parameters.AddWithValue("@Level", course.Level);
            cmd.Parameters.AddWithValue("@CourseId", course.CourseId); // Replace with the actual primary key value
            da.UpdateCommand=cmd;
            // da.Update(ds.Tables[0]);
            con.Open();
            int res=cmd.ExecuteNonQuery();
            con.Close();
 
            return res;
        }

        public DataSet GetCourseByUser(int userid)
        {
              
           
            da = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.CommandText = "select CourseId, Title,Description,CourseStartDate,CourseEndDate,UserId,Category,Level from Courses where UserId=@userid";
            cmd.Parameters.AddWithValue("@UserId", userid);
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
 
    }
}