var builder = DistributedApplication.CreateBuilder(args);

var ui = builder.AddProject<Projects.WasmStandalone>("ui");

builder.Build().Run();