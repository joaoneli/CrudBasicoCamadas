using CrudBasicoCamadas.Domain.Shared;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace CrudBasicoCamadas.Domain.Entities
{
    [Table ("Cliente")]
    public class ClienteEntity : BaseEntity
    {
        [MaxLength(16, ErrorMessage = "O Cpf deve conter 16 caracteres."),MinLength(16, ErrorMessage = "O Cpf deve conter 16 caracteres.")]
        public string Cpf { get; set; }

    }
}
