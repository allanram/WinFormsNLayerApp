using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    // CLiente herda os dados de Pessoa
    public class Cliente: Pessoa
    {
        public DateTime Nascimento { get; set; }
    }
}
