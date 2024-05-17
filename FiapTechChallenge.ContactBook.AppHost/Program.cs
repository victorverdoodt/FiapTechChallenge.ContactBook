var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FiapTechChallenge_ContactBook_Api>("fiaptechchallenge-contactbook-api");

builder.Build().Run();
