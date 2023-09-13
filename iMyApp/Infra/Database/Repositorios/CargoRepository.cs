using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database.Repositorios
{
    public class CargoRepository
    {
       

        public int Inserir(Cargo cargo)
        {
            var stringConexao = SqlServer.StrConexao();
            var sqlConnection = new SqlConnection();
            sqlConnection.Open();
           var sql =  
