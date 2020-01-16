namespace POC.Function

open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module HttpTrigger =
    [<FunctionName("HttpTrigger")>]
    let Run([<HttpTrigger(AuthorizationLevel.Function, "get", Route = null)>] req: HttpRequest , log: ILogger) =
        log.LogInformation "F# HTTP trigger function processed a request."
        let name = req.Query.["name"]
        HelloWorld.HelloWorld name

