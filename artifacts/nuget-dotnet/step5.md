Hasta el momento solo se han usado librerías Nuget que están publicadas en el repositorio oficial. Ahora procederá a utilizar una librería que está publicada en un feed de Artifacts en un proyecto privado de Azure DevOps.

En este momento, intentará agregar la dependencia **EPM-Saludo versión 1.0.0-CI-20201105-225845**, la cual está publicada en un feed de Artifacts privado https://dev.azure.com/capacitaciones-azure-devops

Ejecuta el siguiente comando para intentar agregar la dependencia `dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845`{{execute}}

Como se puede dar cuenta no fue posible encontrar la dependencia EPM-Saludo, el motivo es porque dotnet intenta buscar en el repositorio oficial de Nuget por defecto.

Ejecuta el siguiente comando para ver cuáles fuentes de repositorio Nuget están configurados `dotnet nuget list source`{{execute}} y confirmará lo dicho anteriormente.

Para configurar las fuentes de las dependencias de Nuget que se utilizarán en el proyecto, vamos a crear un archivo nuget.config en la misma ruta donde tenemos el .csproj.

`touch nuget.config`{{execute}}

Con la ayuda del editor, copia las siguientes líneas de código en el archivo nuget.config. Tenga cuidado de no dejar la primera línea vacía, a veces suele suceder.

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

Si analiza detenidamente, en el archivo nuget.config en la etiqueta ClearTextPassword debemos colocar el personal access token de Azure DevOps, que debería tener al menos permisos de lectura en el feed de Artifacts. Para no colocar el token directamente en el archivo, utilizaremos la variable de ambiente VSS_NUGET_EXTERNAL_FEED_ENDPOINTS.

Para crear la variable de ambiente con el valor del token ejecuta el siguiente comando:

Recuerda solicitar el token a los instructores.

`export VSS_NUGET_EXTERNAL_FEED_ENDPOINTS=<copia acá el token sin los signos de mayor y menor>`{{copy}}