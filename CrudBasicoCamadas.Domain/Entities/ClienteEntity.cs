using CrudBasicoCamadas.Domain.Shared;
using Dapper.Contrib.Extensions;

namespace CrudBasicoCamadas.Domain.Entities
{
    [Table ("Cliente")]
    public class ClienteEntity : BaseEntity
    {
        public string Cpf { get; set; }

    }
}
