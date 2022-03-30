using GDLibrary.Api.Data;
using GDLibrary.Api.Domain.Queries;
using GDLibrary.Api.Domain.Services.DeleteARequest;
using GDLibrary.Api.Domain.Services.FindRequest;
using GDLibrary.Api.Domain.Services.ListRequests;
using GDLibrary.Api.Domain.Services.RequestABook;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BooksContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ContactsContext")));

builder.Services.AddScoped<RequestABookHandler>();
builder.Services.AddScoped<IGetBookByTitle, GetBookByTitle>();
builder.Services.AddScoped<IGetActiveRequestsByTitle, GetActiveRequestsByTitle>();
builder.Services.AddScoped<IAddRequest, AddRequest>();
builder.Services.AddScoped<DeleteRequestHandler>();
builder.Services.AddScoped<IGetActiveRequestByBookId, GetActiveRequestByBookId>();
builder.Services.AddScoped<IUpdateRequest, UpdateRequest>();
builder.Services.AddScoped<ListRequestsHandler>();
builder.Services.AddScoped<IListActiveRequests, ListActiveRequests>();
builder.Services.AddScoped<FindRequestHandler>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }