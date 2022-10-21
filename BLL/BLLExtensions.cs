using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BLL
{
    public static class BLLExtensions
    {
        public static void AddBLLExtension(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IForumService, ForumService>();
            services.AddTransient<ISecurityService, SecurityService>();
            services.AddDALExtension();
        }
    }
}
