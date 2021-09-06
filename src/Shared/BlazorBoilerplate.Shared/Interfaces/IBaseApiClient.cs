﻿using Breeze.Sharp;
using System;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Shared.Interfaces
{
    public interface IBaseApiClient
    {
        void AddEntity(IEntity entity);

        void RemoveEntity(IEntity entity);

        void ClearEntitiesCache();

        void CancelChanges();

        event EventHandler<EntityChangedEventArgs> EntityChanged;

        Task SaveChanges();

        Task<QueryResult<T>> GetItemsByFilter<T>(
            string from,
            string orderByDefaultField,
            string filter = null,
            string orderBy = null,
            string orderByDescending = null,
            int? take = null, int? skip = null);
    }
}
