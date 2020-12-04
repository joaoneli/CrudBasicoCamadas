using CrudBasicoCamadas.Domain.Entities;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Domain.Interfaces.IService
{
    public interface IClienteService
    {
        List<ClienteEntity> GetAll();

        ClienteEntity GetById(int id);

        bool DeleteById(ClienteEntity clienteEntity);

        bool Insert(ClienteEntity clienteEntity);
        bool Update(ClienteEntity clienteEntity);
    }
}
