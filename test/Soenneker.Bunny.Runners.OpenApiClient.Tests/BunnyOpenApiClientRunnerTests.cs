using Soenneker.Tests.HostedUnit;

namespace Soenneker.Bunny.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class BunnyOpenApiClientRunnerTests : HostedUnitTest
{
    public BunnyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
