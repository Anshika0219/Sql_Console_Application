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
            Main crud = new Main();
            //crud.insertEmploye("Anshika Agrawal",20,1,1);
            //crud.UpdateEmploye(1, "Anshi Sinha", 23);
            //crud.DeleteEmploye(1);
            crud.ReadEmploye();
            //crud.InsertDepartment("IT");
            //crud.UpdateDepartmentt(1, "HSR");
            //crud.InsertSallery(50000);
            //crud.UpdateSallery(1, 600000);
        }
    }
}
