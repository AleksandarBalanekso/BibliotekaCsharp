using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaServer
{
    public static class Baza
    {
        public static SqlCommand GetSqlCommand(string comm)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AF1L428\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Biblioteka");

            conn.Open();
            return new SqlCommand(comm, conn);
        }

        public static bool CommandExecuteNumQuery(string comm)
        {
            SqlCommand command = GetSqlCommand(comm);
            if (command.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
