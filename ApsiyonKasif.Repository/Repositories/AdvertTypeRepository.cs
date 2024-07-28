﻿using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Repository.Repositories
{
    public class AdvertTypeRepository : GenericRepository<AdvertType>, IAdvertTypeRepository
    {
        public AdvertTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
