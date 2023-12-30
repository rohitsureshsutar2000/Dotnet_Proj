using rider;
using dbmanagerUtil;
// using System.Data.Generic;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/alldata", () => {
    List<RiderStatus> lst = BDmanager.GetAlldetails();
    return lst;
});
app.MapGet("/valid", () => {
    return BDmanager.GetAlldetails();
    
});


app.Run();
