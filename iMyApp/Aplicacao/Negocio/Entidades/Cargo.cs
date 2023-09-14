using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public  class Cargo : EntidadeBase
    {
        public string  Nome{ get; set; }
        public bool Status { get; set; }
       
        public Cargo(string nome,bool status) 
        { 
          Nome = nome;
          Status = status;
          CriadoPor = "Allan";
          CriadoEm = DateTime.Now;
          
          AlteradoEm = DateTime.Now;
          AlteradoPor = "Allan";
        }
    }
}
