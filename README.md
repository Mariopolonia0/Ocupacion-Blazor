# Sistema de ocupacion en Blazor
~~~ 
pagina de registro de ocupacion
![1](https://user-images.githubusercontent.com/65502311/188183398-7d97927e-873f-4533-9a72-280c37c152ef.PNG)
~~~

~~~ 
pagina de lista de ocupacion
![2](https://user-images.githubusercontent.com/65502311/188183555-df51e077-9af2-4632-b696-1c777c252834.PNG)

~~~

## COMANDO PARA VISUAL STUDIO CODE Y BLAZOR:

* dotnet ef dbcontext list

* dotnet new blazorserver -f net6.0   **crear proyecto**

* dotnet watch run  **compilar proyecto**

* dotnet publish -c Release -o ./bin/Publish  **publicar solución**

* dotnet add package Microsoft.EntityFrameworkCore.tools  **agregar libreria Tools**


## PARA CONECTAR LA BASE DE DATOS

* dotnet tool install --global dotnet-ef 

* dotnet ef migrations add Inicial  

* dotnet ef update-database    
