node -version
npm -version


### DOTNET

https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools

Para trabajar con NuGet, como consumidor o creador de paquetes, puede usar herramientas de interfaz de línea de comandos (CLI), así como características de NuGet en Visual Studio

[Instalar y usar un paquete (dotnet CLI)](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli) e [Instalar y usar un paquete (Visual Studio)](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio)

[dotnet.exe](https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools#dotnetexe-cli)	Herramienta CLI para las bibliotecas .NET Core y .NET Standard, y para cualquier proyecto de estilo SDK , como uno que tenga como destino .NET Framework. Se incluye con el SDK de .NET Core y proporciona características básicas de NuGet en todas las plataformas. (A partir de Visual Studio 2017, la CLI de dotnet se instala automáticamente con cualquier carga de trabajo relacionada con .NET Core).	[SDK de .NET Core](https://www.microsoft.com/net/download/)



Buen enlace para teoría
https://docs.microsoft.com/en-us/nuget/consume-packages/overview-and-workflow

Buen enlace para ejercicio y teoría de nugets con Net Core
https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli

https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package 

https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli

dotnet nuget locals all --list
cd root/.nuget/packages/newtonsoft.json/12.0.3

dotnet list package

https://www.youtube.com/playlist?list=PLdo4fOcmZ0oVLvfkFk8O9h6v2Dcdh2bh_

# Taller

## crear un proyecto net core y ejecutarlo

* mkdir Aplicacion
* cd Aplicacion
* dotnet new console
* dotnet run



## usar un paquete nuget en un proyecto sin añadirlo a la referencia y ver fallo, luego agregarlo y descargarlo


* abra el Program.csarchivo y agregue la siguiente línea en la parte superior del archivo: using Newtonsoft.Json;
* dotnet run fallo
* 
* dotnet add package Newtonsoft.Json --version 12.0.3 
* Una vez que se complete el comando, abra el archivo .csproj para ver la referencia agregada:
* dotnet run exito* 
* Agregue el siguiente código antes de la class Programlínea: 
public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DOB { get; set; }
}
* Reemplace la Mainfunción con lo siguiente:
static void Main(string[] args)
{
    Account account = new Account
    {
        Name = "John Doe",
        Email = "john@nuget.org",
        DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
    };

    string json = JsonConvert.SerializeObject(account, Formatting.Indented);
    Console.WriteLine(json);
}
dotnet run exito con json
* dotnet list package
* Displays the paths of all the local cache directories (http-cache directory, global-packages cache directory, and temporary cache directory): dotnet nuget locals all --list
* Displays the path for the local http-cache directory: dotnet nuget locals http-cache --list
* cd /root/.nuget/packages/newtonsoft.json/12.0.3
* Clears all files from all local cache directories (http-cache directory, global-packages cache directory, and temporary cache directory): dotnet nuget locals all --clear
* dotnet restore vuelve a descargar la librería y la guarda en caché Use the dotnet restore command, which restores packages listed in the project file (see PackageReference). With .NET Core 2.0 and later, restore is done automatically with dotnet build and dotnet run. As of NuGet 4.0, this runs the same code as nuget restore.

As with the other dotnet CLI commands, first open a command line and switch to the directory that contains your project file.

To restore a package using dotnet restore:

## Crear un nuget package desde dotnet cli
https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli
https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli

* dotnet new classlib
* agregar las propiedades al csproj
* dotnet pack
* \bin\Debug\AppLogger.1.0.0.nupkg
* Para que se ejecute automáticamente dotnet packcuando se ejecuta dotnet build, agregue la siguiente línea a su archivo de proyecto dentro de <PropertyGroup>:
<GeneratePackageOnBuild>true</GeneratePackageOnBuild>

* Add a nuget.config file to your project, in the same folder as your .csproj or .sln file 
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="katacoda" value="https://pkgs.dev.azure.com/capacitaciones-azure-devops/_packaging/katacoda/nuget/v3/index.json" />
  </packageSources>
</configuration>
* dotnet nuget push --source "katacoda" --api-key hnrllprtsrjn5mrnqlc7njn76xg6srncmzaenvozsapg273xkura bin/Debug

## usar un paquete nuget propio en un proyecto y usarlo (ya publicado previamente en el feed privado)
* dotnet add package EPM-AppLogger --version 1.0.0-CI-20201105-201534 fallo not found
* dotnet nuget list source
* touch nuget.config
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="katacoda" value="https://pkgs.dev.azure.com/capacitaciones-azure-devops/_packaging/katacoda/nuget/v3/index.json" />
  </packageSources>
  <packageSourceCredentials>
    <katacoda>
      <add key="Username" value="" />
      <add key="ClearTextPassword" value="%VSS_NUGET_EXTERNAL_FEED_ENDPOINTS%" />
    </katacoda>
</packageSourceCredentials>
</configuration>


* export VSS_NUGET_EXTERNAL_FEED_ENDPOINTS=hnrllprtsrjn5mrnqlc7njn76xg6srncmzaenvozsapg273xkura

https://github.com/microsoft/artifacts-credprovider#azure-artifacts-credential-provider

así debe quedar
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="EPM-AppLogger" Version="1.0.0-CI-20201105-201534" />
    <PackageReference Include="Newtonsoft.Json" Version="12.0.3" />
  </ItemGroup>

</Project>

* dotnet run exito porque la librería Newtonsoft está en caché en el computador
* dotnet nuget locals all --clear
* dotnet run falla
* agregar la fuente <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
dentro de la etiqueta <packageSources>


Debería quedar así:
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="katacoda" value="https://pkgs.dev.azure.com/capacitaciones-azure-devops/_packaging/katacoda/nuget/v3/index.json" />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
  </packageSources>
  <packageSourceCredentials>
    <katacoda>
      <add key="Username" value="%VSS_NUGET_EXTERNAL_FEED_ENDPOINTS%" />
      <add key="ClearTextPassword" value="%VSS_NUGET_EXTERNAL_FEED_ENDPOINTS%" />
    </katacoda>
</packageSourceCredentials>
</configuration>



## crear y publicar un paquete nuget https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli
## crear un nuevo proyecto y agregar y descargar el paquete publicado 




hnrllprtsrjn5mrnqlc7njn76xg6srncmzaenvozsapg273xkura



Agentes de compilación desatendidos
Canalizaciones de Azure DevOps
Use la tarea Autenticar NuGet antes de ejecutar los comandos NuGet, dotnet o MSBuild que necesitan autenticación.


https://github.com/microsoft/artifacts-credprovider#setup
Otros escenarios de compilación automatizados
Si está ejecutando el comando como parte de una compilación automatizada en un agente de compilación desatendido fuera de Azure DevOps Pipelines, puede proporcionar un token de acceso directamente mediante la VSS_NUGET_EXTERNAL_FEED_ENDPOINTS variable de entorno . Se recomienda el uso de tokens de acceso personal . Es posible que deba reiniciar el servicio del agente o la computadora antes de que las variables de entorno estén disponibles para el agente.


La primera vez que realiza una operación que requiere autenticación mediante dotnet, debe usar la --interactivemarca para permitirle dotnetsolicitar las credenciales o proporcionarlas a través de una variable de entorno.

Si está ejecutando de forma interactiva, navegue hasta el directorio de su proyecto y ejecute:

dotnet restore --interactivo
Una vez que haya adquirido con éxito un token, puede ejecutar comandos autenticados sin la --interactivemarca durante la vida útil del token que se guarda en la ubicación del caché del token de sesión .