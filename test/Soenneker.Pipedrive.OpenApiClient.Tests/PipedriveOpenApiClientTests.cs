using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pipedrive.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PipedriveOpenApiClientTests : HostedUnitTest
{
    public PipedriveOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
