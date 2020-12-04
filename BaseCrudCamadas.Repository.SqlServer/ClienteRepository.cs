
using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using Dapper.Contrib.Extensions;
using System;
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

        public bool DeleteById(ClienteEntity clienteEntity, IDbConnection connection)
        {
            try
            {
                connection.Delete(clienteEntity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
     

        }
    }
}
