using CrudBasicoCamadas.Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace CrudBasicoCamadas.Domain.Interfaces.IRepository
{
    public interface IFornecedorRepository
    {
        List<FornecedorEntity> GetAll(IDbConnection connection);

        FornecedorEntity GetById(int id, IDbConnection connection);

        bool DeleteById(FornecedorEntity fornecedorEntity, IDbConnection connection);

        bool Insert(FornecedorEntity fornecedorEntity, IDbConnection connection);

        bool Update(FornecedorEntity fornecedorEntity, IDbConnection connection);
    }
}
