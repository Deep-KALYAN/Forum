﻿using DAL.UOW;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    public static class DALExtension
    {
        public static void AddDALExtension(this IServiceCollection services)
        {
             services.AddScoped<IDBSession, DBSession>();
           
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
