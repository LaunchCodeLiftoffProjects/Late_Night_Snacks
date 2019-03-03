using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Late_Night_Snacks.Helpers;
using Late_Night_Snacks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Late_Night_Snacks
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MenuItemsDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseInMemoryDatabase("CustomDB"));

        

            //services.AddIdentity<ApplicationUser, IdentityRole>()
                //.AddRoleManager<ApplicationRoleManager>();

            // Add application services.
            

            services.AddMvc();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //SECOND DB 
            //services.AddDbContext<OrdersContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("OrdersContext")));
        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MenuItemsDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            DBSeeder.SeedDB(context);


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }

   /* public static class RoleHelper
    {
        private static async Task EnsureRoleCreated(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
        public static async Task EnsureRolesCreated(this RoleManager<IdentityRole> roleManager)
        {
            //add roles that should be in database, here
            await EnsureRoleCreated(roleManager, "Member");
            await EnsureRoleCreated(roleManager, "Anonymous");
            await EnsureRoleCreated(roleManager, "Admin");
        }
        
    }*/
}
