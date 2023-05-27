﻿using EntityFramework.Exceptions.Oracle;

namespace EntityFramework.Exceptions.Tests;

public class OracleTests : DatabaseTests, IClassFixture<OracleTestContextFixture>
{
    public OracleTests(OracleTestContextFixture fixture) : base(fixture.Context)
    {
    }
}

public class OracleTestContextFixture : DemoContextFixture
{
    protected override DbContextOptionsBuilder<DemoContext> BuildOptions(DbContextOptionsBuilder<DemoContext> builder, IConfigurationRoot configuration)
    {
        var connectionString = Environment.GetEnvironmentVariable("Oracle");
        return builder.UseOracle(connectionString).UseExceptionProcessor();
    }
}