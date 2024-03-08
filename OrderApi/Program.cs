using BusinessLogic.Validators;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add each and every validator one after another
//builder.Services.AddScoped<IValidator<CreateCustomerRequestValidator>, CreateCustomerRequestValidator>();
//Register all the validators in one go
builder.Services.AddValidatorsFromAssemblyContaining<CreateCustomerRequestValidator>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
