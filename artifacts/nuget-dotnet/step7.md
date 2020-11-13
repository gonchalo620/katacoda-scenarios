Ahora se procederá a limpiar las dependencias Nuget descargadas en la máquina local.

Para listar los sitios donde pueden haber dependencias almacendas localmente, ejecute el siguiente comando: 

`dotnet nuget locals all --list`{{execute}}

Dirijase a la carpeta `/root/.nuget/packages`para que confirmes que allí están almacenadas las dependencias que usamos en los pasos anteriores:
`cd /root/.nuget/packages`{{execute}}

Lista las carpetas con el comando `ls`{{execute}}

Para limpiar las dependencias descargadas, ejecuta el comando:
`dotnet nuget locals all --clear`{{execute}}

Vuelve a listar y aparecerá la carpeta vacía:
`ls`{{execute}}