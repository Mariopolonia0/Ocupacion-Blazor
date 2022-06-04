# registro Ocupacion Blazor

COMANDO TERMINAR PARA VISUAL STUDIO CODE Y BLAZOR:

dotnet ef dbcontext list

dotnet new blazorserver -f net6.0  

-------------
dotnet watch run = COMPILAR PROYECTO BLAZOR

-------------
dotnet add package Microsoft.EntityFrameworkCore.tools 

--------PARA CONECTAR LA BASE DE DATOS
dotnet tool install --global dotnet-ef 
dotnet ef migrations add Inicial    
dotnet ef update-database    
