var app=WebApplication.CreateBuilder(args).Build(); app.MapGet("/",()=>"Hello from MyApp testing test"); app.Run();
