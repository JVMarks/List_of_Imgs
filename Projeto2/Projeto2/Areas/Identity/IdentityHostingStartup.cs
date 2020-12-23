using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projeto2.Areas.Identity.Data;
using Projeto2.Data;

[assembly: HostingStartup(typeof(Projeto2.Areas.Identity.IdentityHostingStartup))]
namespace Projeto2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;//
                    options.Password.RequireLowercase = false;//Aceitar tamanhos diferentes 
                    options.Password.RequireUppercase = false;//Aceitar tamanhos diferentes 

                    options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";//aceitar qualquer das opcoes 
                    //options.User.RequireUniqueEmail = false;
                })
                    .AddEntityFrameworkStores<AuthDbContext>();
            });
        }
    }
}