using ClassifiedAdvertising.Data;
using ClassifiedAdvertising.Data.Repositories;
using ClassifiedAdvertising.Data.Repositories.Implementations;
using ClassifiedAdvertising.Service.Services;
using ClassifiedAdvertising.Service.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace ClassifiedAdvertising.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                .AddJsonFormatters()
                .AddApiExplorer();

            services.AddSwaggerGen(options =>
                options.SwaggerDoc("v1", new Info { Title = "Classtified Advertising API", Version = "v1" }));

            services.AddDbContext<ClassifiedAdvertisingDbContext>(options =>
                {
                    options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
                }
            );

            // Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IAdvertisingRepository, AdvertisingRepository>();
            services.AddTransient<ITypeAdvertisingRepository, TypeAdvertisingRepository>();

            // Services
            services.AddTransient<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Classtified Advertising API v1"));

            app.UseMvc();
        }
    }
}
