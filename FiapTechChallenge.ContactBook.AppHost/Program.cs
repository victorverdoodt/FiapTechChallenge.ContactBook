var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var postgresUsername = builder.AddParameter("pgusername");
var postgresPassword = builder.AddParameter("pgpassword", secret: true);

var database = builder.AddPostgres("database", null, null, 5432)
    .WithPgAdmin(null, "pgadmin");

var api = builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_Api>("api")
    .WithReference(database)
    .WithReference(cache);

//builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_WebApp>("webapp")
    //.WithReference(api);

builder.Build().Run();
