using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Main
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=student;Integrated Security=True");

        //..................Insert Employe............//
        public void insertEmploye(string Employename, int Employeage, int DepartmentId, int SalleryId)
        {
            try
            {
                sqlConnection.Open();
                string insertquery = "Exec SP_InsertEmploye '" + Employename + "'," + Employeage + "," + DepartmentId + " , " + SalleryId + "";
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

        //.............Select Employe.........//
        public void ReadEmploye()
        {
            try
            {
                sqlConnection.Open();
                string displayquery = "select * from SP_SelectEmploye";
                SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine("Employid : " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("Employename : " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("Employeage : " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("DepartmentId : " + dataReader.GetValue(3).ToString());
                    Console.WriteLine("Departmentname : " + dataReader.GetValue(4).ToString());
                    Console.WriteLine("SalleryId: " + dataReader.GetValue(5).ToString());
                    Console.WriteLine("sallery : " + dataReader.GetValue(6).ToString());

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

        //............Update Employe...............//
        public void UpdateEmploye(int Employeid, string Employename, int Employeage)
        {
            try
            {
                sqlConnection.Open();

                string updatequery = "exec SP_UpdateEmploye " + Employeid + ",'" + Employename + "'," + Employeage + "";
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

        //..............Delete Employe............//
        public void DeleteEmploye(int Employeid)
        {
            try
            {
                sqlConnection.Open();
                string deletequery = "Exec SP_DeleteEmploye " + Employeid + " ";
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

        //.............Insert Department....................//
        public void InsertDepartment(string Departmentname)
        {
            try
            {
                sqlConnection.Open();
                string insertquery1 = "Exec SP_InsertDepartment'" + Departmentname + "'";
                SqlCommand insertcommand1 = new SqlCommand(insertquery1, sqlConnection);
                insertcommand1.ExecuteNonQuery();
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

        //.............update Department.............//
        public void UpdateDepartmentt(int DepartmentId, string Departmentname)
        {
            try
            {
                sqlConnection.Open();
                string updatequery1 = "Exec SP_updateDepartment " + DepartmentId + ",'" + Departmentname + "'";
                SqlCommand updatecommand1 = new SqlCommand(updatequery1, sqlConnection);
                updatecommand1.ExecuteNonQuery();
                Console.WriteLine("data succesfully updated into table");
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

        //.........Insert Sallery.............//
        public void InsertSallery(double Sallery)
        {
            try
            {
                sqlConnection.Open();
                string insertquery2 = "Exec  SP_Insertsallery'" + Sallery + "'";
                SqlCommand insertcommand2 = new SqlCommand(insertquery2, sqlConnection);
                insertcommand2.ExecuteNonQuery();
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

        //.............update sallery.............//
        public void UpdateSallery(int SalleryId, double Sallery)
        {
            try
            {
                sqlConnection.Open();
                string updatequery2 = "Exec SP_UpdateSallery " + SalleryId + "," + Sallery + " ";
                SqlCommand updatecommand2 = new SqlCommand(updatequery2, sqlConnection);
                updatecommand2.ExecuteNonQuery();
                Console.WriteLine("data succesfully updated into table");
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

