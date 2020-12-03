using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BaseCrudCamadas.Repository.SqlServer
{
    public class ClienteRepository : IClienteRepository
    {


        public List<ClienteEntity> GetAll(IDbConnection connection)
        {
            return connection.GetAll<ClienteEntity>().ToList();
        }

        public ClienteEntity GetById(int id, IDbConnection connection)
        {
            return connection.Get<ClienteEntity>(id);
        }
    }
}
