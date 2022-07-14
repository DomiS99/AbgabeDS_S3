using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyCompany.MathProgram.Service;
using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram;

public class Program
{
    public static void Main (string[] args)
    {
        //Bauen des Builders
        var builder = WebApplication.CreateBuilder(args); //Builder wird definiert
        builder.Services.AddControllers(); //Zum erkennen der Controller
        builder.Services.AddEndpointsApiExplorer(); //Erkennt die Endpunkte der verwendeten Api
        builder.Services.AddSwaggerGen(); //Swagger initialisieren (für UI Testung)
        builder.Services.AddTransient<IMathService, MathService>(); // erstellt den MathService



        //--------------------------------------------------------------------------------------
        //Configurieren der Pipeline 
        //Builder muss die Pipeline durchlaufen

        var app = builder.Build(); //Builder wird erstellt
        app.MapControllers(); //Controller werden an Builder gemapped 
        app.UseSwagger(); //Swagger testumgebung wird erstellt
        app.UseSwaggerUI(); // Swagger UI wird initialisiert

        app.Run(); //Startet den Builder 
    }
}