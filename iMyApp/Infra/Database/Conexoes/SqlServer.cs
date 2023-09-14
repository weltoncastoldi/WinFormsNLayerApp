using Microsoft.Extensions.Configuration;
using System.Xml.Linq;

namespace Database.Conexoes
{
    internal static class SqlServer
    {

        internal static string StrConexao()
        {
            return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
        }
    }
}
