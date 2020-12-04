using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using CrudBasicoCamadas.Domain.Interfaces.IUnityOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudBasicoCamadas.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnityOfWork _unityOfWork;

        public ClienteService(IClienteRepository clienteRepository, IUnityOfWork unityOfWork)
        {
            _clienteRepository = clienteRepository;
            _unityOfWork = unityOfWork;
        }

        public List<ClienteEntity> GetAll()
        {
            return _clienteRepository.GetAll(_unityOfWork.GetConnection());
        }

        public ClienteEntity GetById(int id)
        {
            return _clienteRepository.GetById(id, _unityOfWork.GetConnection());
        }
        public bool DeleteById(ClienteEntity clienteEntity)
        {
            return _clienteRepository.DeleteById(clienteEntity, _unityOfWork.GetConnection());
        }

        public bool Insert(ClienteEntity clienteEntity)
        {
            return _clienteRepository.Insert(clienteEntity, _unityOfWork.GetConnection());
        }

        public bool Update(ClienteEntity clienteEntity)
        {
            return _clienteRepository.Update(clienteEntity, _unityOfWork.GetConnection());
        }
    }
}
