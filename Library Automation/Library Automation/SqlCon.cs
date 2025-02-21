using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public static class SqlCon
    {
        readonly static string connectionString = ("DATA SOURCE = DESKTOP-STMAJ7C\\SQLEXPRESS; INITIAL CATALOG = myGameSalesAutomation; INTEGRATED SECURITY = TRUE ");
        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
