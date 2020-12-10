using CrudBasicoCamadas.Domain.Shared;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace CrudBasicoCamadas.Domain.Entities
{
    [Table("Fornecedor")]
    public class FornecedorEntity : BaseEntity
    {
        [MaxLength(18, ErrorMessage = "O cnpj deve conter 18 caracteres."), MinLength(18, ErrorMessage = "O cnpj deve conter 18 caracteres.")]
        public string Cnpj { get; set; }
    }
}
