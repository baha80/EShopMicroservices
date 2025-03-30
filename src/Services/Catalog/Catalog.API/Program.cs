var builder = WebApplication.CreateBuilder(args);

//add services to the container before building the app

var app = builder.Build(); // build the app

// Configure the HTTP request pipeline.


app.Run();





