using CrudBasicoCamadas.Domain.Entities;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Domain.Interfaces.IService
{
    public interface IFornecedorService
    {
        List<FornecedorEntity> GetAll();

        FornecedorEntity GetById(int id);

        bool DeleteById(FornecedorEntity fornecedorEntity);

        bool Insert(FornecedorEntity fornecedorEntity);

        bool Update(FornecedorEntity fornecedorEntity);

    }
}
