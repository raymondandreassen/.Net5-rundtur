using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using System.Linq;
using Serilog;
using Demo4.Server.Service;
using Microsoft.EntityFrameworkCore;
using MatBlazor;
using Seq.Extensions.Logging;
using Microsoft.Extensions.Logging;
using Demo4.Server.Service.Helpers;

namespace Demo4.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddSeq();
            });

            string[] orgins = new string[] { "http://localhost:5000", "https://localhost:5001", "http://localhost:55507", "https://localhost:44343" };
            services.AddCors(opt => opt.AddPolicy("CorsPolicy", c =>
            {
                // c.AllowAnyOrigin()
                c.WithOrigins(orgins)
                 .AllowAnyHeader()
                 .AllowCredentials()
                 .AllowAnyMethod();
            }));

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlDbContext")));

            // Kun for demo
            var myServer_config = new Service.Helpers.MyServerConfig();
            Configuration.Bind("MyServer", myServer_config);
            services.AddSingleton(myServer_config);

            services.AddScoped<MyServer>();
            //    .UseConfig(myServer_config));  // <--- Kun for å vise at man kan

            // Også mulig
            //services.AddScoped<MyServer>();
            //    .UseConfig(myServer_config));  


            // Swagger
            services.AddSwaggerGen();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<IDbInitializer, DbInitializer>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();

                // DB seeder, hvis jeg enda IsDevelopment()...
                //var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
                //using (var scope = scopeFactory.CreateScope())
                //{
                //    var dbInitializer = scope.ServiceProvider.GetService<Service.Helpers.IDbInitializer>();
                //    dbInitializer.Initialize();
                //    dbInitializer.SeedData();lk
                //}
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "dotnet Demo");
            });

            //app.UseSerilogRequestLogging();    

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
