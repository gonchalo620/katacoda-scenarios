Hasta el momento solo hemos usado librería Nuget que están publicadas en el repositorio oficial. Ahora utilizaremos una librería que está publicada en un feed de Artifacts en un proyecto privado de Azure DevOps.


* dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845
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
      <add key="Username" value="cualquiercosa" />
      <add key="ClearTextPassword" value="%VSS_NUGET_EXTERNAL_FEED_ENDPOINTS%" />
    </katacoda>
</packageSourceCredentials>
</configuration>


* export VSS_NUGET_EXTERNAL_FEED_ENDPOINTS=hnrllprtsrjn5mrnqlc7njn76xg6srncmzaenvozsapg273xkura
* dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845
* abra Program.cs y agregue al inicio using library.epm;
* Agregue estas líneas al final de la funcion static void Main
```var buzon = new Buzon();
    string saludo = buzon.Saludar();
    Console.WriteLine(saludo);
```
* dotnet run exito porque la librería Newtonsoft está en caché en el computador
* dotnet nuget locals all --clear
* dotnet run falla
* agregar la fuente <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
dentro de la etiqueta <packageSources>

