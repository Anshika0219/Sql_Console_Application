using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Delete
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True");
        public void DeleteStudent()
        {
            try
            {
                sqlConnection.Open();
                int st_id;
                Console.WriteLine("enter the student id that is to be deleted");
                st_id = Convert.ToInt32(Console.ReadLine());
                string deletequery = "delete from studentinfo  where studentid = " + st_id;
                SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                deletecommand.ExecuteNonQuery();
                Console.WriteLine("data succesfull deleted");
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

