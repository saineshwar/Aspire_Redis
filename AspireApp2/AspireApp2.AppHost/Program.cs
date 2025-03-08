var builder = DistributedApplication.CreateBuilder(args);

// Added Redis resource
var cache = builder.AddRedis("cache")
    .WithRedisInsight() // Added Redis Insight
    .WithRedisCommander() // Added Redis Commander Ui to Manage keys and values
    .WithDataVolume()// Adds a named volume for the data folder to a Redis container resource and enables Redis persistence.
    //.WithDataBindMount(
    //    source: @"C:\RedisData\Data",
    //    isReadOnly: false)
    .WithPersistence(
        interval: TimeSpan.FromMinutes(5),
        keysChangedThreshold: 100);

var apiService = builder.AddProject<Projects.AspireApp2_ApiService>("apiservice")
    .WithReference(cache);

builder.AddProject<Projects.AspireApp2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
