using CrudBasicoCamadas.Domain.Interfaces.IUnityOfWork;
using System.Data;
using System.Data.SqlClient;

namespace BaseCrudCamadas.Repository.SqlServer.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        public IDbTransaction Transaction { get; set; }
        public IDbConnection Connection { get; set; }
        public UnityOfWork(string config)
        {
            Connection = new SqlConnection(config);
            Connection.Open();
        }
        public void BeginTransaction()
        {
            Transaction = Connection.BeginTransaction();
        }

        public bool Commit()
        {
            if (Transaction == null)
                return false;

            try
            {
                Transaction.Commit();
                return true;
            }
            catch
            {
                Transaction.Rollback();
                return false;
            }
            finally
            {
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void Dispose()
        {
            if (Transaction != null)
            {
                Transaction.Dispose();
                Transaction = null;
            }
            if (Connection == null)
                return;
            Connection.Dispose();
            Connection = null;
        }

        public IDbConnection GetConnection()
        {
            return Connection;
        }

        public IDbTransaction GetTransaction()
        {
            return Transaction;
        }

        public bool Rollback()
        {
            try
            {
                if (Transaction == null)
                    return false;
                Transaction.Rollback();
                Transaction = null;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
