using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Database.Conexoes
{
    internal class SqlServer
    {
        internal static string StrConexao()
        {

            return @"Server=.\SQLEXPRESS;Database=iMyApp;User ID=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
            //return @"Server=.\SQLEXPRESS;Database=iMyApp;User Id=sa;Password=sql2022;";
        }
    }
}
