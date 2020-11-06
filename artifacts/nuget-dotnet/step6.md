En el paso anterior se realizaron las configuraciones necesarias para poder utilizar dependencias de un repositorio privado de Nuget.

Ahora intenta agregar la dependencia.

`dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845`{{execute}}

Abra el archivo .csproj y verificar si se ha agregado la referencia de EPM-Saludo.


Abra el archivo Program.cs y agregue al inicio `using library;`{{copy}} con esto ya podríamos hacer uso de la dependencia EPM-Saludo dentro de nuestra aplicación.

Agregue estas líneas al final de la funcion static void Main
```var buzon = new Buzon();
    string saludo = buzon.Saludar();
    Console.WriteLine(saludo);
```{{copy}}

Ahora ejecuta la aplicación
`dotnet run`{{execute}} 

Aunque no hemos agregado la fuente oficial de Nuget, la ejecución es exitosa. Esto debido a que la librería de Newtonsoft.Json está almacenada localmente por la descarga que hicimos de esta en los pasos anteriores.

* `dotnet list package`{{execute}}
* `dotnet nuget locals all --list`{{execute}}
* Displays the path for the local http-cache directory: `dotnet nuget locals http-cache --list`{{execute}}
* `cd /root/.nuget/packages`{{execute}}
* `ls`{{execute}}

* `dotnet nuget locals all --clear`{{execute}}
* `dotnet run`{{execute}} falla
* agregar la fuente <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
dentro de la etiqueta <packageSources>


## Información adicional

La configuración de las fuentes se hizo de esta manera por la característica del ambiente de katacoda. Sin embargo no es la única forma, si utilizas Visual Studio también puedes hacerlo de manera sencilla y puedes autenticarte de manera visual.

Las tareas de Azure DevOps para este tema, tienen la forma de autenticarse fácilmente con la configuración de la tarea.
