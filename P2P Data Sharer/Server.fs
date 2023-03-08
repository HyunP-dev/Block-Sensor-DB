namespace P2P_Data_Sharer

open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.HttpsPolicy
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open P2P_Data_Sharer.Controllers


module Server =
    let Run _ = do
        let builder = WebApplication.CreateBuilder()

        builder.Services.AddControllers() |> ignore
        let app = builder.Build() 

        // app.UseHttpsRedirection() |> ignore

        // app.UseAuthorization() |> ignore
        app.MapControllers() |> ignore

        app.RunAsync() |> ignore

        0