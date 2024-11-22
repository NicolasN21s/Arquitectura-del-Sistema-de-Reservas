## Sistema de Reservas - Backend

<p>
  Importante a tener en cuenta:
</p>

###Descripción 
Esta es una aplicación backend para un sistema de reservas, desarrollada utilizando ASP.NET Core y Entity Framework Core. La aplicación permite gestionar reservas a través de una API RESTful.

###Requisitos
- .NET SDK 
- SQL Server (o cualquier otra base de datos SQL) 
- Visual Studio Code

Extensiones para Visual Studio Code:
C# for Visual Studio Code (powered by OmniSharp): Para soporte de C#.
NuGet Package Manager: Para gestionar paquetes NuGet.


### Configuración 
#### 1. Clona el Repositorio 
bash 
git clone <repository-url> cd BookingSystem

####2. Configura la Cadena de Conexión
Abre el archivo appsettings.json y asegúrate de que la cadena de conexión sea correcta.

####3. Añade las Migraciones y Actualiza la Base de Datos
Ejecuta los siguientes comandos en la terminal para añadir una nueva migración y actualizar la base de datos:
- dotnet ef migrations add InitialCreate 
- dotnet ef database update

####4 Ejecuta la Aplicación
- Para ejecutar la aplicación, usa el siguiente comando en la terminal:
dotnet run
La aplicación estará disponible en http://localhost:5000

###Documentación de la API
La API está documentada utilizando Swagger. Para acceder a la documentación interactiva, abre un navegador web y navega a http://localhost:5000/swagger.

####5 Explicación de Archivos Clave
Models/Booking.cs: Define el modelo de datos para las reservas.

Data/BookingContext.cs: Configura el contexto de datos usando Entity Framework Core.

Controllers/BookingsController.cs: Define los endpoints para CRUD de reservas.

Startup.cs: Configura los servicios y el pipeline de la aplicación.

Program.cs: Punto de entrada de la aplicación

####Información Adicional
Swagger: Swagger está configurado para proporcionar una interfaz web donde se puede explorar y probar la API.

Base de Datos Local: La aplicación utiliza una base de datos local para desarrollo. Para producción, asegúrate de actualizar la cadena de conexión en appsettings.json.
