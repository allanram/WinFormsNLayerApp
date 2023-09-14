﻿using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database.Repositorios
{
    public class CargoRepository
    {


        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
                 ([Nome]
                ,[Status]
                ,[CriadoEm]
                ,[CriadoPor]
                ,[AlteradoEm]
                ,[AlterdoPor])
                 VALUES
                (@Nome, 
                 @status,
                 @criadoEm, 
                 @criadoPor, 
                 @alteradoEm,
                 @alteradoPor)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                    connection.Close(); 
                }

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
        public bool Atualizar(Cargo cargo) 
        {
            try
            {
                var sql = @"";
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Deletar (Cargo cargo) 
        {
            try
            {
                var sql = @"";
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargo.Nome);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }   

        public DataTable ObterTodos(int cargoId)
        {
            SqlDataAdapter dataAdapter = null;  
            var dataTable = new DataTable();
            var sql = @"";                                                       
            try
            {
               
                using(var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cmd.CommandText,connection);
                    dataAdapter.Fill(dataTable);
                    return dataTable;

                }
            }
            catch (Exception)
            {

                throw;
            }       
           
        }
    }
}