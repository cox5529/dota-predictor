using DotaPredictor.API.Filters;
using DotaPredictor.DataBuilder.Extensions;
using DotaPredictor.DataBuilder.Interfaces;
using DotaPredictor.DataBuilder.Settings;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDotaDataPredictor();
builder.Services.AddControllers(options => options.Filters.Add<ApiExceptionFilter>());
builder.Services.Configure<HeroSettings>(o => builder.Configuration.GetSection("Hero").Bind(o));

builder.Services.AddSwaggerGen(
    options =>
    {
        options.SwaggerDoc(
            "v1",
            new OpenApiInfo
            {
                Version = "v1",
                Title = "DotaPredictor.API",
                Description = "Dota Predictor API"
            });
    });

var app = builder.Build();
var predictor = app.Services.GetRequiredService<IPredictorService>();
//predictor.BuildModel("data.csv");
//predictor.SaveModel("model.zip");
predictor.LoadModel("model.zip");

app.UseRouting();
app.UseCors(o => o.AllowAnyOrigin().AllowAnyMethod().Build());
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DotaPredictor.API v1"));

app.Run();
