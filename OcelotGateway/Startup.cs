﻿using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace OcelotGateway;

public class Startup
{
    // public IConfiguration Configuration { get; }
    //
    // public Startup(IConfiguration configuration)
    // {
    //     Configuration = configuration;
    // }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddOcelot();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseOcelot();
    }
}