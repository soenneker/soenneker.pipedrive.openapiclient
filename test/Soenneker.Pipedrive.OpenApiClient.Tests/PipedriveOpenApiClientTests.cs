using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Pipedrive.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PipedriveOpenApiClientTests : FixturedUnitTest
{
    public PipedriveOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
