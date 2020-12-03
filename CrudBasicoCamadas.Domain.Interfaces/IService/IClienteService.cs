﻿using CrudBasicoCamadas.Domain.Entities;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Domain.Interfaces.IService
{
    public interface IClienteService
    {
        List<ClienteEntity> GetAll();

        ClienteEntity GetById(int id);
    }
}
