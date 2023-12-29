using rider;
using dbmanagerUtil;
// using System.Data.Generic;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/apii", () => {
    List<RiderLogin> lst = BDmanager.GetAlldetails();
    return lst;
});


app.Run();
