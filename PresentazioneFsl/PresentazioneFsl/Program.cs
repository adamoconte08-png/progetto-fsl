var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Permette al server di cercare automaticamente index.html nella cartella wwwroot
app.UseDefaultFiles();

// 2. Abilita l'uso dei file statici (HTML, CSS, immagini)
app.UseStaticFiles();

app.Run();