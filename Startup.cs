using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using prof_sofware.Models;
using prof_sofware.Services;


namespace prof_sofware
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

            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserTypeService, UserTypeService>();
            services.AddScoped<IGenusService, GenusService>();
            services.AddScoped<ISpeciesService, SpeciesService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IHospitalService, HospitalService>();
            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IEmergencyService, EmergencyService>();
            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IPostService, PostService>();
             services.AddScoped<IFrienService,FriendService>();
           


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "This is Petscope Apı Doc",
                    Version = "v1",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Email = "cem.paydas@gmail.com",


                    }

                });
            });




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();


            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Petscope API Doc");
            });




        }
    }
}
