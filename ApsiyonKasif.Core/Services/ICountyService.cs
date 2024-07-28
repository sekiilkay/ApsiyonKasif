﻿using ApsiyonKasif.Core.Entities;

namespace ApsiyonKasif.Core.Services
{
    public interface ICountyService : IGenericService<County>
    {
        Task<List<County>> GetCountiesByCityId(int cityId);
    }
}
