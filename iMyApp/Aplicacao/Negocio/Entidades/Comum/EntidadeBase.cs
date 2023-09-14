using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades.Comum
{
    public abstract class EntidadeBase
    {
        public int Id { get; }
        public DateTime CriadoEm { get; internal set; }
        public string CriadoPor { get; internal set;}
        public DateTime AlteradoEm { get; internal set;}
        public string AlteradoPor { get; internal set; }
        
    }
}
