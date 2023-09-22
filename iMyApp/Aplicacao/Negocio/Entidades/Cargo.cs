using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public  class Cargo : EntidadeBase
    {
        [Required(ErrorMessage = "Nome é Obrigatório"),]
        [StringLength(50)]
        [MinLength(5,ErrorMessage ="Nome muito curto" )]  
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
