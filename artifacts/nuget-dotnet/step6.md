En el paso anterior, se realizaron las configuraciones necesarias para poder utilizar dependencias de un repositorio privado de Nuget.

Ahora intenta agregar la dependencia.

`dotnet add package EPM-Saludo --version 1.0.0-CI-20201105-225845`{{execute}}

Abra el archivo .csproj y verificar si se ha agregado la referencia de EPM-Saludo.

Abra el archivo Program.cs y agregue al inicio `using library;`{{copy}} con esto ya podríamos hacer uso de la dependencia **EPM-Saludo** dentro de nuestra aplicación.

Agregue estas líneas al final de la funcion static void Main, después de la línea Console.WriteLine(json);

```
var buzon = new Buzon();
string saludo = buzon.Saludar();
Console.WriteLine(saludo);
```{{copy}}

Ahora ejecuta nuevamente la aplicación
`dotnet run`{{execute}} 

Aunque no se ha agregado la fuente oficial de Nuget en el archivo nuget.config, la ejecución es exitosa. Esto debido que la librería de Newtonsoft.Json está almacenada localmente por la descarga que hicimos de esta, en los pasos anteriores.

En el paso posterior vamos a limpiar las dependencias de Nuget de la máquina local.