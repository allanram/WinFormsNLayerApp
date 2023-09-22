using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Negocio.Entidades.Comum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Validators
{

    public static partial class Validacoes
    {
        /// <summary>
        /// Valida as DataAnotattions de uma clase.
        /// <example>Exemplo:
        /// <code>
        ///   var errors = Validacao.getValidationerrors(obj);
        ///   foreach(var error in errors)
        ///   {
        ///      MessageBox.Show((errorMessage));
        ///   }
        /// 
        /// </code>
        /// </example>
        /// <param name="obj">é a classe instanciada</param>
        /// <returns>Lista de errors</returns>
        /// </summary>

        public static IEnumerable<ValidationResult> ValidarDataAnottations(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

    }
}
