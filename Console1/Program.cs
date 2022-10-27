using Console1;
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
            Create crud = new Create();
            crud.CreateStudent();
            //Read crud1 = new Read();
            //crud1.ReadStudent();
            //Update crud2 = new Update();
            //crud2.UpdateStudent();
            //Delete crud3 = new Delete();
            //crud3.DeleteStudent();
        }
    }
}
