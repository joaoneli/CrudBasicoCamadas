using System;
using System.Data;

namespace CrudBasicoCamadas.Domain.Interfaces.IUnityOfWork
{
    public interface IUnityOfWork : IDisposable
    {
        void BeginTransaction();
        bool Commit();
        bool Rollback();
        IDbConnection GetConnection();
        IDbTransaction GetTransaction();
    }
}
