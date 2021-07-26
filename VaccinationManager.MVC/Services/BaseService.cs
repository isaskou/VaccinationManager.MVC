﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationManager.DAL;

namespace VaccinationManager.MVC.Services
{
    public class BaseService
    {
        protected readonly DataContext _dc;

        public BaseService(DataContext dc)
        {
            if (dc is null) throw new ArgumentException("DataContext must be not null");
            _dc = dc;
        }
    }
}
