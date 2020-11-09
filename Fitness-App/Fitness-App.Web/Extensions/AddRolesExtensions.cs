using Fitness_App.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness_App.Web.Extensions
{
    public class AddRolesExtensions
    {
        private readonly IApplicationBuilder app;
        private readonly Fitness_AppDbContext context;

        public AddRolesExtensions(IApplicationBuilder app, Fitness_AppDbContext context)
        {
            this.app = app;
            this.context = context;
        }

        private async void SeedRoles()
        {
            if (this.context.Roles.Any())
            {
                return;
            }

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var roleManger = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                if (!roleManger.RoleExistsAsync("Admin").Result)
                {
                    await roleManger.CreateAsync(new IdentityRole("Admin"));
                }

                if (!roleManger.RoleExistsAsync("User").Result)
                {
                    await roleManger.CreateAsync(new IdentityRole("User"));
                }
            }
        }

        public async Task CreateRoles()
        {
            Task.Run(SeedRoles).Wait();
        }
    }
}
