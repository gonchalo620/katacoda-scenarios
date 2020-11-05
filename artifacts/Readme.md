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



Taller

crear un proyecto net core y ejecutarlo
usar un paquete nuget en un proyecto y usarlo
usar un paquete nuget propio en un proyecto y usarlo (ya publicado previamente en el feed privado)
crear y publicar un paquete nuget https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli
crear un nuevo proyecto y agregar y descargar el paquete publicado 