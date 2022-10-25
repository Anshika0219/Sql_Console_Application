using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_console_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SqlConnection sqlConnection;
            string connectionstring = @"Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True";
            try
            {
               sqlConnection = new SqlConnection(connectionstring);    
                sqlConnection.Open();
                Console.WriteLine("connection established succesfully");
                //...create databse....//
                Console.WriteLine("enter your name");
                string stu_name = Console.ReadLine();
                Console.WriteLine("enter mobile number");
                double Mob_number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter your age");
                int stu_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your emailid");
                string stu_emailId = Console.ReadLine();
                string insertquery = "insert into studentinfo(studentname,Mobilenumber,studentage,studentemailId) values('" + stu_name + "','" + Mob_number + "','" + stu_age + "','" + stu_emailId + "')";
                SqlCommand insertcommand = new SqlCommand(insertquery, sqlConnection);
                insertcommand.ExecuteNonQuery();
                Console.WriteLine("data succesfully inserted into table");
    
                //.....read data......//
                string displayquery = "select * from studentinfo";
                SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine("id : " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("name : " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("mobilenumber : " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("Age : " + dataReader.GetValue(3).ToString());
                    Console.WriteLine("emailId : " + dataReader.GetValue(4).ToString());
                }
                dataReader.Close();

                //....update query....//
                int s_id;
                int s_age;
                Console.WriteLine("enter the update student id");
                s_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the update student age");
                s_age = Convert.ToInt32(Console.ReadLine());
                string updatequery = "update studentinfo set studentage = " + s_age + "where studentid = " + s_id ;
                SqlCommand updatecommand = new SqlCommand(updatequery, sqlConnection);
                updatecommand.ExecuteNonQuery();
                Console.WriteLine("Data update sucessfully");

                //.....Delete query....//
                int st_id;
                Console.WriteLine("enter the student id that is to be deleted");
                st_id = Convert.ToInt32(Console.ReadLine());
                string deletequery = "delete from studentinfo  where studentid = " + st_id;
                SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                deletecommand.ExecuteNonQuery();
                Console.WriteLine("data succesfull deleted");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
