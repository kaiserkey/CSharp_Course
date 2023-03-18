comandos para generar proyecto dotnet con asp.net framework desde consola 

1. dotnet new webapp -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET Core MVC).

2. dotnet new mvc -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET Core MVC).

3. dotnet new classlib -o <nombre-de-la-biblioteca> (Crea una biblioteca de clases .NET Core).

4. dotnet new console -o <nombre-de-la-aplicación> (Crea una aplicación de consola .NET Core).

5. dotnet new worker -o <nombre-de-la-aplicación> (Crea una aplicación de trabajador .NET Core).

6. dotnet new razor -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET Core con


comandos para ejecutar la aplicacion web

1. dotnet add package <nombre-del-paquete> (Agrega un paquete NuGet a la aplicación).

2. dotnet restore (Restaura los paquetes NuGet para la aplicación).

3. dotnet build (Compila la aplicación).

4. dotnet run (Ejecuta la aplicación).

5. dotnet publish (Publica la aplicación).



comandos mas utilizados para trabajar en .net desde consola en visual studio code

1. dotnet new - Crea un nuevo proyecto .NET.
2. dotnet restore - Restaura los paquetes NuGet necesarios para compilar el proyecto.
3. dotnet build - Compila el proyecto.
4. dotnet run - Ejecuta el proyecto.
5. dotnet add package - Agrega un paquete NuGet al proyecto.
6. dotnet test - Ejecuta las pruebas de la solución.
7. dotnet publish - Prepara el proyecto para su publicación.
8. dotnet clean - Limpia los archivos generados durante la compilación.
9. dotnet watch - Vigila los cambios realizados en los archivos del proyecto y ejecuta la compilación automáticamente.
10. dotnet nuget locals - Muestra la lista de los directorios de almacenamiento local de NuGet.


sintaxis de razor en .net

Razor es un lenguaje de marcado y sintaxis que se usa para crear páginas web dinámicas en aplicaciones ASP.NET. Se utiliza para mejorar la experiencia de desarrollo al proporcionar una sintaxis concisa y fácil de entender, que es similar a la de un lenguaje de programación.

Razor está formado por un conjunto de caracteres especiales, conocidos como "marcadores", que se usan para indicar a Razor cómo renderizar el código. Estos marcadores se usan para escribir instrucciones en las páginas web. Algunos de los marcadores principales incluyen:

@ - Utilizado para indicar que se incluye código C# o Visual Basic

@: - Utilizado para insertar una cadena en la página

@( ) - Utilizado para especificar instrucciones del lenguaje HTML

@{ } - Utilizado para especificar bloques de código C# o Visual Basic

@foreach - Utilizado para ejecutar un bucle a través de una colección de objetos

@if - Utilizado para especificar una condición

@using - Utilizado para importar un espacio de nombres

Además de estos marcadores, Razor también admite otros comandos como HTML, CSS y JavaScript, lo que permite a los desarrolladores crear páginas web complejas con sólo unas pocas líneas de código.