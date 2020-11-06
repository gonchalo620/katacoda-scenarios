Vuelve a la carpeta de la aplicación creada:

`cd /root/taller/Aplicacion`{{execute}}

Ya con la caché de las dependencias locales borrada, ejecuta nuevamente la aplicación para que observes el comportamiento. 
`dotnet run`{{execute}}

Falla porque en el archivo nuget.config solo agregamos la fuente del repositorio privado de Nuget, en el que la dependencia Newtonsoft.Json no existe. Debemos agregar la fuente oficial de Nuget para poder que las dependencias del repositorio oficial sean descargadas.

Abra el archivo nuget.config y agregue la siguiente sentencia `<add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />`{{copy}} dentro de la etiqueda <packageSources>

El orden de las fuentes influye en el orden en que se buscan las dependencias.

Ejecuta nuevamente la aplicación
`dotnet run`{{execute}}.


## Información adicional

La configuración de las fuentes se hizo de esta manera por la característica del ambiente de katacoda. Sin embargo no es la única forma, si utilizas Visual Studio también puedes hacerlo de manera sencilla y puedes autenticarte de manera visual.

Las tareas de Azure DevOps para este tema, tienen la forma de autenticarse fácilmente con la configuración de la tarea.


## Tips

Comando para listar paquetes del proyecto `dotnet list package`{{execute}}