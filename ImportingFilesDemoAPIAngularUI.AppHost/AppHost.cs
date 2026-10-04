var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ImportingFilesDemoAPIAngularUI_Server>("api")
	.WithExternalHttpEndpoints();

var ui = builder.AddJavaScriptApp("ui", "../importingfilesdemoapiangularui.client", "start")
	.WithHttpEndpoint(env: "PORT")
	.WithExternalHttpEndpoints();

builder.Build().Run();
