﻿using CrudBasicoCamadas.Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace CrudBasicoCamadas.Domain.Interfaces.IRepository
{
    public interface IClienteRepository
    {
        List<ClienteEntity> GetAll(IDbConnection connection);
        ClienteEntity GetById(int id, IDbConnection connection);
    }
}