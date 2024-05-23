var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var database = builder.AddPostgres("database")
    .WithPgAdmin();

var api = builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_Api>("api")
    .WithReference(database)
    .WithReference(cache);

builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_WebApp>("webapp")
    .WithReference(api)
    .WithExternalHttpEndpoints();

builder.Build().Run();
