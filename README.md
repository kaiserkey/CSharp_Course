### Distintos comandos para generar proyectos nuevos en ASP.NET

- dotnet new webapp -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET Core MVC).

- dotnet new mvc -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET Core MVC).

- dotnet new classlib -o <nombre-de-la-biblioteca> (Crea una biblioteca de clases .NET Core).

- dotnet new console -o <nombre-de-la-aplicación> (Crea una aplicación de consola .NET Core).

- dotnet new worker -o <nombre-de-la-aplicación> (Crea una aplicación de trabajador .NET Core).

- dotnet new razor -o <nombre-de-la-aplicación> (Crea una aplicación web ASP.NET .NET Core).


### Comandos para instalar paquetes e inicializar el proyecto

- dotnet add package <nombre-del-paquete> (Agrega un paquete NuGet a la aplicación).

- dotnet restore (Restaura los paquetes NuGet para la aplicación).

- dotnet build (Compila la aplicación).

- dotnet run (Ejecuta la aplicación).

- dotnet publish (Publica la aplicación).

- dotnet watch - Vigila los cambios realizados en los archivos del proyecto y ejecuta la compilación automáticamente.

-  dotnet nuget locals - Muestra la lista de los directorios de almacenamiento local de NuGet.


### Razor

Razor es un lenguaje de marcado y sintaxis que se usa para crear páginas web dinámicas en aplicaciones ASP.NET. Se utiliza para mejorar la experiencia de desarrollo al proporcionar una sintaxis concisa y fácil de entender, que es similar a la de un lenguaje de programación.

Razor está formado por un conjunto de caracteres especiales, conocidos como "marcadores", que se usan para indicar a Razor cómo renderizar el código. Estos marcadores se usan para escribir instrucciones en las páginas web. Algunos de los marcadores principales incluyen:

`@ `- Utilizado para indicar que se incluye código C# o Visual Basic

`@`: - Utilizado para insertar una cadena en la página

`@( )` - Utilizado para especificar instrucciones del lenguaje HTML

`@{ }` - Utilizado para especificar bloques de código C# o Visual Basic

`@foreach` - Utilizado para ejecutar un bucle a través de una colección de objetos

`@if` - Utilizado para especificar una condición

`@using` - Utilizado para importar un espacio de nombres

Además de estos marcadores, Razor también admite otros comandos como HTML, CSS y JavaScript, lo que permite a los desarrolladores crear páginas web complejas con sólo unas pocas líneas de código.
###Conexion con Mysql

1. Agregar el Paquete: `dotnet add package MySql.Data`

2. Crear una clase MySqlDatabase con el siguiente codigo en la carpeta de Models
```
   using System;
   using MySql.Data.MySqlClient;

   namespace Inmobiliaria.Models
   {
      public class MySqlDatabase : IDisposable
      {
         public MySqlConnection Connection;
         public string connectionString = "server=localhost;port=3306;database=databaseName;uid=userName;password=password"

         public MySqlDatabase(string connectionString)
         {
               Connection = new MySqlConnection(connectionString);
               this.Connection.Open();
         }

         public void Dispose()
         {
               Connection.Close();
         }
      }
   }
```
1. Luego en cada controlador agregar en el contructor la conexion a la base de datos y enviarla a cada metodo de los modelos que la usen

`using Inmobiliaria.Models;`
`private MySqlDatabase con { get; set; }`
`public InmuebleController() { con = new MySqlDatabase(); }`

###CODE GENERATOR
#####Instalar la libreria:
`dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.13`
#####Agregar la dependencia:
`dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`
#####Comandos mas usados:
1. `dotnet-aspnet-codegenerator controller -name "PropietariosController" -outDir "Controllers" -namespace "vsTest.Controllers" -f -actions`: 
   - controller: es el generador que se está utilizando.
   - name "PropietariosController": es el nombre que se le va a dar al controlador que se va a generar. En este caso, se va a generar un controlador con el nombre "PropietariosController".
   - outDir "Controllers": especifica el directorio donde se van a guardar los archivos del controlador generado. En este caso, los archivos se guardarán en el directorio "Controllers".
   - namespace "vsTest.Controllers": especifica el espacio de nombres del controlador generado. En este caso, el controlador se creará en el espacio de nombres "vsTest.Controllers".
   - f: indica que se sobrescriban los archivos existentes si ya existen en el directorio de salida.
   - actions: indica que se deben generar métodos de acción para las operaciones CRUD básicas (Create Read, Update, Delete).

2. `dotnet-aspnet-codegenerator view Index List -outDir "Views/Propietarios" -udl --model vsTest.Models.Propietario -f`:
   - Index: el nombre de la acción del controlador para la que se está generando la vista.
   List: el nombre del archivo de diseño a utilizar para la vista generada.
   **Tipos de vistas**: **Empty, Create, Edit, Delete, Details, List**
   - outDir "Views/Propietarios": especifica el directorio de salida para los archivos generados, que en este caso es Views/Propietarios.
   - udl: especifica que la vista debe utilizar los datos no tipados (untyped) IQueryable en lugar de los modelos tipados (typed) IEnumerable o List.
   - -model vsTest.Models.Propietario: especifica el modelo para el cual se está generando la vista. En este caso, la vista se generará para la entidad Propietario definida en la clase vsTest.Models.Propietario.
   - f: especifica que se sobrescriban los archivos de vista existentes sin preguntar.

3. `dotnet aspnet-codegenerator identity --relativeFolderPath CarpetaDelCodigo`: este comando se utiliza para generar código de inicio de sesión, registro y gestión de usuarios utilizando el marco de autenticación y autorización Identity de ASP.NET Core. Reemplaza "CarpetaDelCodigo" por la ruta relativa de la carpeta donde se ubicará el código generado.

4. `dotnet aspnet-codegenerator area --name NombreDelArea`: este comando se utiliza para generar un área de la aplicación, que permite organizar el código en secciones lógicas. Reemplaza "NombreDelArea" por el nombre que desees darle al área.

5. `dotnet aspnet-codegenerator razorpage --name NombreDeLaPagina -m Modelo --relativeFolderPath CarpetaDeLaPagina -dc ContextoDeDatos`: este comando se utiliza para generar una página Razor con el modelo de datos y las acciones necesarias. Reemplaza "NombreDeLaPagina" por el nombre que desees darle a la página, "Modelo" por el nombre de la clase del modelo, "CarpetaDeLaPagina" por la ruta relativa de la carpeta donde se ubicará la página y "ContextoDeDatos" por el nombre del contexto de datos.

6. `dotnet aspnet-codegenerator api -name NombreDelControlador -m Modelo -dc ContextoDeDatos --relativeFolderPath CarpetaDelControlador`: este comando se utiliza para generar un controlador de API con acciones CRUD básicas para el modelo especificado. Reemplaza "NombreDelControlador" por el nombre que desees darle al controlador, "Modelo" por el nombre de la clase del modelo, "ContextoDeDatos" por el nombre del contexto de datos y "CarpetaDelControlador" por la ruta relativa de la carpeta donde se ubicará el controlador.

### Usar el ORM de Entity Framework Core

El comando `dotnet tool install --global dotnet-ef` instala la herramienta de Entity Framework en el sistema globalmente, lo que permite que se utilice en cualquier proyecto de .NET en el sistema.

Este comando instala la última versión estable de la herramienta de Entity Framework Core en el sistema. Para instalar una versión específica, puedes agregar el argumento --version seguido del número de versión.

Es importante tener en cuenta que este comando requiere que tengas instalado el SDK de .NET Core en tu sistema. Si no tienes el SDK instalado, puedes descargarlo desde el sitio web oficial de .NET Core.

Después de instalar la herramienta de Entity Framework, puedes utilizar el comando dotnet ef para ejecutar varios comandos, como crear migraciones, actualizar la base de datos y generar modelos a partir de una base de datos existente.

Para configurar e instalar EntityFrameworkCore con MySQL en .NET, puedes ejecutar los siguientes comandos en la terminal:

1. Instalar el paquete de NuGet "Pomelo.EntityFrameworkCore.MySql":
`dotnet add package Pomelo.EntityFrameworkCore.MySql`
1. Instalar el paquete de NuGet "Microsoft.EntityFrameworkCore.Tools":
`dotnet add package Microsoft.EntityFrameworkCore.Tools`
1. Instalar el paquete de NuGet "Microsoft.EntityFrameworkCore.Design":
`dotnet add package Microsoft.EntityFrameworkCore.Design`
1. Instalar el paquete de NuGet "Microsoft.EntityFrameworkCore":
   ` dotnet add package Microsoft.EntityFrameworkCore `

Una vez instalados los paquetes necesarios, puedes utilizar el comando "dotnet ef dbcontext scaffold" para generar automáticamente los modelos y el contexto de base de datos a partir de una base de datos MySQL existente:

`dotnet ef dbcontext scaffold "server=localhost;port=3306;database=mydatabase;uid=myuser;password=mypassword;" Pomelo.EntityFrameworkCore.MySql --output-dir Models`

En este ejemplo, "mydatabase" es el nombre de la base de datos MySQL que deseas generar, y "myuser" y "mypassword" son las credenciales necesarias para acceder a la base de datos. El comando generará los archivos de modelo en el directorio "Models" de tu proyecto.

### Conexion a la base de datos
Luego de haber instalado las dependencias para el funcionamiento de la base de datos sera necesario configurar la conexion a la base de datos.

En la clase principal de Program.cs importar los paquetes using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; using project_name.Models;

1. Utilizar el siguiente codigo para realizar la conexion a la base de datos
   `builder.Services.AddDbContext<YoutubeContext>(
      options => options.UseMySql(
         configuration.GetConnectionString("DefaultConnection"),
         ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"])
      )
   );`

2. Configurar la cadena de conexion en appsettings.json
   `"AllowedHosts": "*",
   "ConnectionStrings": {
   "DefaultConnection": "server=localhost;port=3306;database=mydatabase;uid=myuser;password=mypassword;"
   }`

3. En la clase DBContext, borramos la cadena de conexión especificada en el método OnConfiguring. Debe quedar el método vacío.
   `protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {}`

#### Comandos mas usados para EntityFrameworkCore

- `dotnet ef migrations add <migration-name>`: Este comando crea una nueva migración con el nombre especificado en la base de datos. Las migraciones se utilizan para mantener la integridad de la base de datos a medida que se modifican los modelos. Cada migración representa un conjunto de cambios que se aplicarán a la base de datos.

- `dotnet ef database update`: Este comando aplica todas las migraciones pendientes a la base de datos. Las migraciones se aplican en el orden en que se crearon.

- `dotnet ef dbcontext scaffold <connection-string> <provider>`: Este comando crea automáticamente un contexto de base de datos y clases de entidad basados en una base de datos existente. El parámetro connection-string es una cadena de conexión a la base de datos y provider especifica el proveedor de base de datos que se utilizará.

- `dotnet ef dbcontext info`: Este comando muestra información sobre el contexto de la base de datos, incluyendo el proveedor de base de datos, la cadena de conexión y la lista de entidades que están definidas en el contexto.

- `dotnet ef dbcontext list`: Este comando muestra una lista de los contextos de la base de datos que se han creado en el proyecto.

- `dotnet ef dbcontext scaffold`: Este comando crea automáticamente un contexto de base de datos y clases de entidad basados en una base de datos existente, pero a diferencia del comando anterior, se utiliza para bases de datos de Oracle, PostgreSQL, SQLite, SQL Server, MySQL, etc.

En resumen, estos comandos son muy útiles para trabajar con Entity Framework Core en .NET y para manejar la creación y actualización de la base de datos y sus migraciones, así como para generar clases de entidad a partir de una base de datos existente.

### Tipos de metodos en controladores

En ASP.NET MVC, los controladores pueden tener diferentes métodos según las acciones que deben realizar. Algunos de los métodos más comunes que puede tener un controlador de ASP.NET MVC son:

- **IActionResult**: es una interfaz que representa un tipo de resultado de acción en ASP.NET MVC. Se utiliza para encapsular diferentes tipos de resultados de acción que se pueden devolver desde una acción del controlador.

- **ActionResult**: es un tipo de retorno de acción que representa un resultado de acción genérico. Puede devolver cualquier tipo de resultado, como una vista, un archivo, un JSON, etc.

- **ViewResult**: representa una vista que se va a renderizar como resultado de una acción del controlador.

- **PartialViewResult**: representa una vista parcial que se va a renderizar como resultado de una acción del controlador.

- **FileResult**: representa un archivo que se va a descargar como resultado de una acción del controlador.

- **JsonResult**: representa un objeto JSON que se va a enviar como resultado de una acción del controlador.

- **RedirectResult**: redirige a otra URL como resultado de una acción del controlador.

- **RedirectToRouteResult**: redirige a otra ruta como resultado de una acción del controlador.

- **HttpStatusCodeResult**: representa un código de estado HTTP como resultado de una acción del controlador.

- **ContentResult**: devuelve una cadena de texto sin formato como resultado de una acción del controlador.

- **EmptyResult**: representa una respuesta vacía como resultado de una acción del controlador.

- **ViewComponentResult**: representa una vista de componente que se va a renderizar como resultado de una acción del controlador.

- **StatusCodeResult**: representa un código de estado HTTP personalizado que se va a enviar como resultado de una acción del controlador.

- **ObjectResult**: representa cualquier objeto que se va a enviar como resultado de una acción del controlador.

- **`Task<IActionResult>`**: es un método asincrónico que devuelve un objeto IActionResult.

