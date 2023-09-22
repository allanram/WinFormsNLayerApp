using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades.Validator
{
    public class Funcionarios : Endereco
    {
        public string Nome { get; set; }
       
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Rg{ get; set; }

        public DateTime DataAdimissao { get; set; }
        public string Cic { get; set; }
        public string Nascionalidade { get; set; }
        public bool Sexo { get; set; }


        public Funcionarios(string nome, DateTime dataNascimento, string telefone, DateTime dataAdimissao, string cic, string nascionalidade, bool sexo,string rg)
        {
            Nome = nome;
          
            DataNascimento = dataNascimento;
            Telefone = telefone;
            DataAdimissao = dataAdimissao;
            Cic = cic;
            Nascionalidade = nascionalidade;
            Sexo = sexo;
            Rg = rg;

        }


    }
}
