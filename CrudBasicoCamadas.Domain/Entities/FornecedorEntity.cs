using CrudBasicoCamadas.Domain.Shared;
using Dapper.Contrib.Extensions;

namespace CrudBasicoCamadas.Domain.Entities
{
    [Table("Fornecedor")]
    public class FornecedorEntity : BaseEntity
    {
        public string Cnpj { get; set; }
    }
}
