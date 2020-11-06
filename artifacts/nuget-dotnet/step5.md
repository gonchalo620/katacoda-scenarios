Hasta el momento solo hemos usado librerías Nuget que están publicadas en el repositorio oficial. Ahora utilizaremos una librería que está publicada en un feed de Artifacts en un proyecto privado de Azure DevOps.

Vamos a intentar agregar la dependencia **EPM-Saludo versión 1.0.0-CI-20201105-225845**, la cual está publicada en un feed de Artifacts privado https://dev.azure.com/capacitaciones-azure-devops

Ejecuta el siguiente comando para intentar agregar la dependencia `dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845`{{execute}}

Como te pudiste dar cuenta no fue posible encontrar la dependencia EPM-Saludo, esto es porque por defecto dotnet intenta buscarla en el repositorio oficial de Nuget.

Ejecuta el siguiente comando para ver cuáles fuentes de repositorio Nuget están configurados `dotnet nuget list source`{{execute}} y te darás cuenta de lo dicho anteriormente.

Para configurar las fuentes de las dependencias de Nuget que se utilizarán en el proyecto, vamos a crear un archivo nuget.config en la misma ruta donde tenemos el .csproj.

`touch nuget.config`{{execute}}

Con la ayuda del editor copia la siguiente porción de código en el archivo nuget.config. Tenga cuidado en no dejar la primera línea vacía, a veces suele suceder.

```
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
```{{copy}}

Si te fijas, en el archivo nuget.config en la etiqueta ClearTextPassword debemos colocar el personal access token de Azure DevOps, que debería tener al menos permisos de lectura en el feed de Artifacts. Para no colocar el token directamente en el archivo, utilizaremos la variable de ambiente VSS_NUGET_EXTERNAL_FEED_ENDPOINTS.

Para crear la variable de ambiente con el valor del token ejecuta el siguiente comando:

`export VSS_NUGET_EXTERNAL_FEED_ENDPOINTS=hnrllprtsrjn5mrnqlc7njn76xg6srncmzaenvozsapg273xkura`{{execute}}