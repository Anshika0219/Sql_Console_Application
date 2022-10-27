using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Read
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True");
        public void ReadStudent()
        {
            try
            {
                sqlConnection.Open();
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
