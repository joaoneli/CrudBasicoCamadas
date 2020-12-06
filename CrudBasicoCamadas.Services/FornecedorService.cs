using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using CrudBasicoCamadas.Domain.Interfaces.IUnityOfWork;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IUnityOfWork _unityOfWork;

        public FornecedorService(IFornecedorRepository fornecedorRepository, IUnityOfWork unityOfWork)
        {
            _fornecedorRepository = fornecedorRepository;
            _unityOfWork = unityOfWork;
        }

        public List<FornecedorEntity> GetAll()
        {
            return _fornecedorRepository.GetAll(_unityOfWork.GetConnection());
        }

        public FornecedorEntity GetById(int id)
        {
            return _fornecedorRepository.GetById(id, _unityOfWork.GetConnection());
        }
        public bool DeleteById(FornecedorEntity fornecedorEntity)
        {
            return _fornecedorRepository.DeleteById(fornecedorEntity, _unityOfWork.GetConnection());
        }
        public bool Insert(FornecedorEntity fornecedorEntity)
        {
            return _fornecedorRepository.Insert(fornecedorEntity, _unityOfWork.GetConnection());
        }
        public bool Update(FornecedorEntity fornecedorEntity)
        {
            return _fornecedorRepository.Update(fornecedorEntity, _unityOfWork.GetConnection());
        }
    }
}

