﻿using Domain.Entities;
using System;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        public Usuario ObterPorID(Guid id);
    }
}
