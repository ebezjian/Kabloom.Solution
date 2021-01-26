using KabloomLocationsApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace KabloomLocationsApi
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    

    // Register the Swagger generator, defining 1 or more Swagger documents
      services.AddSwaggerGen(c =>
        {
          c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
          c.SwaggerDoc("v2", new OpenApiInfo { Title = "My API", Version = "v2" });
        });

        services.AddApiVersioning(o =>
        {
          o.ReportApiVersions = true;
          o.AssumeDefaultVersionWhenUnspecified = true;
          o.DefaultApiVersion = new ApiVersion(1, 0);
        });
      }
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }
      
      app.UseCors(MyAllowSpecificOrigins);

      // app.UseHttpsRedirection();
      app.UseMvc();
      // Enable middleware to serve generated Swagger as a JSON endpoint.
      app.UseSwagger(c =>
      {
        c.SerializeAsV2 = true;
      });
      // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
      // specifying the Swagger JSON endpoint.
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
        c.RoutePrefix = string.Empty;
      });
    }
  }
}