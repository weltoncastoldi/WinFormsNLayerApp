﻿using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;

namespace Database.Repositorios
{
    public class CargoRepository
    {

        public int Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StrConexao();
            var sqlConnection = new SqlConnection(stringConexao);

            sqlConnection.Open();

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

            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome", cargo.Nome);
            cmd.Parameters.AddWithValue("status", cargo.Status);

            sqlConnection.Close();
        }
    }
}
