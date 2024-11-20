using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LineConcept.Models;
using System.Data.SqlClient;
using Dapper;

namespace LineConcept.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        // var connectionString = "Server=localhost,1441;Database=FurnitureDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
        // var connection = new SqlConnection(connectionString);

        // var queryAppSetting = "select * from AppSettings";
        // var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();



        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
