﻿using APICacheRedis.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Domain.Interfaces
{
    public interface IAgenciaService
    {
        Task<IEnumerable<Agencia>> GetAll();
    }
}
