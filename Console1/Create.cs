using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Create
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True");
        public void CreateStudent()
        {
            try
            {
                sqlConnection.Open();
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
