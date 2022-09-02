# Sistema de ocupacion en Blazor


## COMANDO PARA VISUAL STUDIO CODE Y BLAZOR:

* dotnet ef dbcontext list

* dotnet new blazorserver -f net6.0   **crear proyecto**

* dotnet watch run  **compilar proyecto

* dotnet publish -c Release -o ./bin/Publish  **publicar solución**

* dotnet add package Microsoft.EntityFrameworkCore.tools  **agregar libreria Tools**


## PARA CONECTAR LA BASE DE DATOS

* dotnet tool install --global dotnet-ef 

* dotnet ef migrations add Inicial  

* dotnet ef update-database    
