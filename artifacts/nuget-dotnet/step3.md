Con la ayuda del editor superior, abra el archivo Program.cs y agregue la siguiente línea de código en la parte superior
`using Newtonsoft.Json;`{{copy}}. Nota: no es necesario guardar, el editor guarda automáticamente cualquier cambio en los archivos.

Ahora ejecute la aplicación con el comando `dotnet run`{{execute}}. No se preocupe si falló. Esto sucede porque estamos intentando utilizar la dependencia Newtonsoft.Json pero aún no la hemos agregado formalmente al proyecto.

Para agregar la dependencia puedes ejecutar el comando `dotnet add package Newtonsoft.Json --version 12.0.3`{{execute}}

Una vez se complete la ejecución del comando, abra el archivo Aplicacion.csproj donde podrá ver la referencia agregada.

Ahora confirme de que la aplicación está lista para ejecutarse correctamente.

`dotnet run`{{execute}}.


## Información adicional

La librería Newtonsoft.Json está publicada en el repositorio oficial de Nuget. Esta sirve para serializar objetos a json y viceversa. La puedes encontrar en https://www.nuget.org/packages/Newtonsoft.Json/

