namespace P2P_Data_Sharer.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("/hello")>]
type WeatherForecastController (logger : ILogger<WeatherForecastController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        "Hello, world!"
       
    [<HttpGet>]
    member _.Get(x) =
        $"Hello, world{x}"