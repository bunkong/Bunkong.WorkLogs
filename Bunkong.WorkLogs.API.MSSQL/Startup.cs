using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bunkong.WorkLogs.Database.Infrastructure;
using Bunkong.WorkLogs.Database.MSSQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Bunkong.WorkLogs.API.MSSQL
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
            services.AddMvc();

            services.AddMvc().AddJsonOptions(options =>
            {

                // 输出保持属性定义的大小写原样(Pascal：UpperCamelCase)，不设置则 默认是 小驼峰  lowerCamelCase
                options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Bunkong WorkLogs API Which Database is MSSQL", Version = "v1" });
            });

            services.AddDbContext<Bunkong.WorkLogs.Database.MSSQL.IDMSSQLDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MSSQL")));

            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.AddSingleton<IDbConnectionFactory, SqlConnectionFactory>(serviceProvider =>
            {
                var connectionString = Configuration["ConnectionStrings:MSSQL"];
                return new SqlConnectionFactory(connectionString);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bunkong WorkLogs API Which Database is MSSQL. V1");

                //To serve the Swagger UI at the app's root (http://localhost:<port>/), set the RoutePrefix property to an empty string:
                c.RoutePrefix = string.Empty;
            });

            //设置跨域 : 必须位于mvc 之前
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowAnyOrigin(); //允许任何域
                //builder.WithOrigins("http://localhost:8080");
            });

            app.UseMvc();
        }
    }
}
