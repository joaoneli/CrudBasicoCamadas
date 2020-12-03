
using Dapper.Contrib.Extensions;

namespace CrudBasicoCamadas.Domain.Shared
{
    public class BaseEntity
    {
        [ExplicitKey]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }
    }
}
