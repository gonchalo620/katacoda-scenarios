Con la ayuda del editor superior, abra el archivo Program.cs y agregue la siguiente línea de código en la parte superior
`using Newtonsoft.Json;`{{copy}} 

**Nota:** no es necesario guardar, el editor guarda automáticamente cualquier cambio en los archivos.

Ahora ejecute la aplicación con el comando `dotnet run`{{execute}}. No te preocupes si falló, esto fue a propósito y sucede porque estamos intentando utilizar la dependencia Newtonsoft.Json pero aún no la hemos agregado formalmente al proyecto como una referencia.

Para agregar la dependencia, puede ejecutar el comando `dotnet add package Newtonsoft.Json --version 12.0.3`{{execute}}

Una vez se complete la ejecución del comando, abra el archivo Aplicacion.csproj donde podrá ver la referencia de Newtonsoft.Json agregada.

Ahora confirme que la aplicación está lista para ejecutarse correctamente.

`dotnet run`{{execute}}.


## Información adicional

La librería Newtonsoft.Json está publicada en el repositorio oficial de Nuget y sirve para serializar objetos a JSON y viceversa. La puedes encontrar en https://www.nuget.org/packages/Newtonsoft.Json/

