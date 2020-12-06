using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BaseCrudCamadas.Repository.SqlServer
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public List<FornecedorEntity> GetAll(IDbConnection connection)
        {
            return connection.GetAll<FornecedorEntity>().ToList();
        }

        public FornecedorEntity GetById(int id,IDbConnection connection)
        {
            return connection.Get<FornecedorEntity>(id);
        }

        public bool DeleteById(FornecedorEntity fornecedorEntity, IDbConnection connection)
        {
            try
            {
                connection.Delete(fornecedorEntity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Insert(FornecedorEntity fornecedorEntity, IDbConnection connection)
        {
            try
            {
                connection.Insert(fornecedorEntity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Update(FornecedorEntity fornecedorEntity, IDbConnection connection)
        {
            try
            {
                connection.Update(fornecedorEntity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
