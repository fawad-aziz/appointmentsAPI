﻿using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AppointmentsAPI.Business.Data.Contracts
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Database Database { get; }
    }
}
