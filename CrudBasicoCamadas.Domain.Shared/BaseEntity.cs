
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace CrudBasicoCamadas.Domain.Shared
{
    public class BaseEntity
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(255)]
        public string Endereco { get; set; }

        [MaxLength(10)]
        public string Telefone { get; set; }
    }
}
