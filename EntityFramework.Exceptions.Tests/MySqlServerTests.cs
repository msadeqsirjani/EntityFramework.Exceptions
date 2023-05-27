using EntityFramework.Exceptions.MySQL;

namespace EntityFramework.Exceptions.Tests;

[Collection("MySQL Test Collection")]
public class MySQLServerTests : DatabaseTests, IClassFixture<MySQLDemoContextFixture>
{
    public MySQLServerTests(MySQLDemoContextFixture fixture) : base(fixture.Context)
    {

    }
}

public class MySQLDemoContextFixture : DemoContextFixture
{
    protected override DbContextOptionsBuilder<DemoContext> BuildOptions(DbContextOptionsBuilder<DemoContext> builder, IConfigurationRoot configuration)
    {
        return builder.UseMySQL(configuration.GetConnectionString("MySQL")).UseExceptionProcessor();
    }
}