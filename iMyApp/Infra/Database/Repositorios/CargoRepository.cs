using Dapper;
using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using Negocio.Repository;

namespace Database.Repositorios
{
    public class CargoRepository : ICargoRepository
    {
        public bool Atualizar(Cargo cargo)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Cargo]
                            ([Nome]
                            ,[Status]
                            ,[CriadoEm]
                            ,[CriadoPor]
                            ,[AlteradoEm]
                            ,[AlteradoPor])
                        VALUES
                            (@nome, 
                            @status, 
                            @criadoEm, 
                            @criadoPor, 
                            @alteradoEm, 
                            @alteradoPor)";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", cargo.Nome);
                    parametros.Add("@status", cargo.Status);
                    parametros.Add("@criadoEm", cargo.CriadoEm);
                    parametros.Add("@criadoPor", cargo.CriadoPor);
                    parametros.Add("@alteradoEm", cargo.AlteradoEm);
                    parametros.Add("@alteradoPor", cargo.AlteradoPor);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Deletar(int cargoId)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Cargo ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
