Regrese a la carpeta de la aplicación creada:

`cd /root/taller/Aplicacion`{{execute}}

Ya con la caché de las dependencias locales borrada, ejecute nuevamente la aplicación para observar el comportamiento. 
`dotnet run`{{execute}}

La ejecución falla porque en el archivo nuget.config solo se agregó la fuente del repositorio privado de Nuget, en el que la dependencia Newtonsoft.Json no existe. Se debe agregar la fuente oficial de Nuget para poder que las dependencias del repositorio oficial sean descargadas.

Ahora, abra el archivo nuget.config y agregue la siguiente sentencia `<add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />`{{copy}} luego de la etiqueta `<clear />`

**Nota:** El orden de las fuentes influye en el orden en que se buscan las dependencias.

Ejecuta nuevamente la aplicación
`dotnet run`{{execute}}.

Cuando se ejecuta dotnet run, por debajo se incia también el comando dotnet restore, que se encarga de descargar las dependencias necesarias.


## Información adicional

La configuración de las fuentes se realizó de esta forma por la característica del ambiente de katacoda. Sin embargo, no es la única forma si se utiliza Visual Studio también puede hacerlo de manera sencilla y autenticarse de manera visual.

En los pipelines de Azure DevOps,  existe una tarea que hace el trabajo de autenticarse en los repositorios nuget en caso de ser necesario.


## Tips

Comando para listar paquetes del proyecto `dotnet list package`{{execute}}