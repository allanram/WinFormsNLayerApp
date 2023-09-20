using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Database.Conexoes
{
    /// <summary>
    /// A<c>SqlServer</c> é uma classe estatica com a string de conexao com SqlServer
    /// </summary>
    /// <returns></returns>
    internal class SqlServer
    {
       /// <summary>
       /// Metodo <c>StrConecao()</c> retorna a string de conexao sql
       /// </summary>
       /// <returns></returns>
        
        internal static string StrConexao()
        {
          
            
            return @"Server=.\SQLEXPRESS;Database=iMyApp;User ID=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
            
        }
    } 
}
