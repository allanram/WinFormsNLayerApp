using Dapper;
using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    internal class CargoRepository : ICargoRepository
    {
        public bool Atualizar(Cargo cargo)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"UPDATE [dbo].[Cargo]
                                SET
                                    [Nome] = @nome,
                                    [Status] = @status,
                                    [AlteradoEm] = @alteradoEm,
                                    [AlteradoPor] = @alteradoPor
                                WHERE
                                    [Id] = @id";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", cargo.Nome);
                    parametros.Add("@status", cargo.Status);
                    parametros.Add("@alteradoEm", DateTime.Now);
                    parametros.Add("@alteradoPor", cargo.AlteradoPor);
                    parametros.Add("@id", cargo.Id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(int cargoId)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"DELETE FROM Cargo WHERE Id = @id";

                    var parametros = new DynamicParameters();
                    parametros.Add("@Id",Id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Incluir(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> OterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
