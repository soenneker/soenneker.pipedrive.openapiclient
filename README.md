[![](https://img.shields.io/nuget/v/soenneker.pipedrive.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.pipedrive.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.pipedrive.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.pipedrive.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.pipedrive.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.pipedrive.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.pipedrive.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.pipedrive.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Pipedrive.OpenApiClient

Generated request builders and models for Pipedrive API v2, including activities, deals, leads, organizations, people, pipelines, products, projects, stages, tasks, and users.

## Installation

```bash
dotnet add package Soenneker.Pipedrive.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Pipedrive.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.pipedrive.com/api/v2"
};

var client = new PipedriveOpenApiClient(adapter);
var deals = await client.Deals.GetAsync(
    cancellationToken: cancellationToken);
```

The example uses a Pipedrive OAuth access token. If you use a personal API token, add it as the `api_token` query parameter required by Pipedrive rather than sending it as a bearer token.
