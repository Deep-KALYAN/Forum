using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Domaine
{
    public static class DomainExtensions
    {
        public static void AddDomain(this IServiceCollection service)
        {
            service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
