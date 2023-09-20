namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica com a string 
    /// de conexão com SqlServer
    /// </summary>
    internal static class SqlServer
    {

        /// <summary>
        /// Metodo <c>StrConexao()</c> retorna a string de conexão sql 
        /// </summary>
        /// <returns>string: ConnectionString</returns>
        internal static string StrConexao()
        {
            
            return @"Data Source=localhost;Initial Catalog=iMyApp;User ID=sa;Password=sql2022";
            //return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
        }
        
    }
}
