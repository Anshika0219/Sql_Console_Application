using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Update
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True");
        public void UpdateStudent()
        {
            try
            {
                sqlConnection.Open();
                int s_id;
                int s_age;
                Console.WriteLine("enter the update student id");
                s_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the update student age");
                s_age = Convert.ToInt32(Console.ReadLine());
                string updatequery = "update studentinfo set studentage = " + s_age + "where studentid = " + s_id;
                SqlCommand updatecommand = new SqlCommand(updatequery, sqlConnection);
                updatecommand.ExecuteNonQuery();
                Console.WriteLine("Data update sucessfully");
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
