﻿namespace EntityFramework.Exceptions.Tests;

public abstract class DemoContextFixture : IDisposable
{
    internal DemoContext Context { get; }

    protected DemoContextFixture()
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

        var configuration = new ConfigurationBuilder().AddJsonFile($"appsettings.{environment}.json", optional: true).Build();
            
        var builder = BuildOptions(new DbContextOptionsBuilder<DemoContext>(), configuration);

        Context = new DemoContext(builder.Options);
        Context.Database.EnsureCreated();
    }

    protected abstract DbContextOptionsBuilder<DemoContext> BuildOptions(DbContextOptionsBuilder<DemoContext> builder, IConfigurationRoot configuration);

    public void Dispose()
    {
        Context.Database.EnsureDeleted();
    }
}