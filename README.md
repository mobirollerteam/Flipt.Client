# Flipt.Client
This is auto-generated C# client of Flipt.


# Getting Started

## Setup

- Install NuGet `Flipt.Client` nuget package.


- Go to **Startup.cs** and make your configuration:

```csharp
services.AddFliptClient((sp, opts) =>
{
    opts.BaseUrl = "YOUR_FLIPT_BASE_URL";
});
```

## Usage

- Inject `IFliptAPIClient` into your object and use it.

```csharp
public class MyController : Controller
{
    private readonly IFliptAPIClient fliptClient;

    public MyController(IFliptAPIClient fliptClient)
    {
        this.fliptClient = fliptClient;
    }

    public async Task<IActionResult> MyAction()
    {
        var rule = await fliptClient.GetRuleAsync("MyFlag1", "1");

        // More code...

        return NoContent();
    }
}
```