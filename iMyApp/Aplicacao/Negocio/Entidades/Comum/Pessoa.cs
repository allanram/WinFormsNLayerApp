using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades.Comum
{
    public class Pessoa : EntidadeBase
    {
       
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
