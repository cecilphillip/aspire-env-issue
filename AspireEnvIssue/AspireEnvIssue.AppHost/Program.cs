var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireEnvIssue_ApiService>("apiservice")
    .WithEnvironment("OTEL_EXPORTER_OTLP_ENDPOINT", "http://localhost:4318");

builder.AddProject<Projects.AspireEnvIssue_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();