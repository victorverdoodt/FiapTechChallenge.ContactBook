var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var database = builder.AddPostgres("database")
    .WithPgAdmin();

var rabbitMq = builder.AddRabbitMQ("RabbitMQConnection", port: 5672);

var api = builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_Api>("api")
    .WithReference(rabbitMq)
    .WithReference(database)
    .WithReference(cache)
    .WaitFor(database)
    .WithReplicas(2);

builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_WebApp>("webapp")
    .WithReference(rabbitMq)
    .WithReference(api)
    .WaitFor(api)
    .WithExternalHttpEndpoints();

builder.AddProject<Projects.FiapTechChallenge_ContactBook_Presentation_Consumer>("consumer")
    .WaitFor(rabbitMq);

builder.Build().Run();
