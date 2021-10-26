

namespace WebApplication
{
    using System.Reflection;
    using Microsoft.OpenApi.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;

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
       

            services.AddControllers();

            services
                .AddMvcCore()
                .AddApiExplorer();

            services
                .AddSwaggerGen(options =>
                {
                    var groupName = "v1";
                    options.SwaggerDoc(groupName, new OpenApiInfo
                    {
                        Title = $"Web {groupName}",
                        Version = groupName,
                        Description = "Web API",
                        Contact = new OpenApiContact
                        {
                            Name = "Web Company",
                            Email = string.Empty,
                            Url = new Uri("https://Web.com/"),
                        }
                    });

                    
                });

            services
                .AddMagicAutoMapper()
                .AddAutoMapper(this.GetType().Assembly);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            app.UseSwagger();
            app.UseSwaggerUI(op =>
            {
                op.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
                op.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
             
                endpoints.MapControllers();
            });
        }
    }
}
