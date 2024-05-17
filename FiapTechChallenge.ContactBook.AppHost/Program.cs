var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");
var database = builder.AddPostgres("database");

var api = builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_Api>("api")
    .WithReference(database)
    .WithReference(cache);

builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_WebApp>("webapp")
    .WithReference(api);

builder.Build().Run();
