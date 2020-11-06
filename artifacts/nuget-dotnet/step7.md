Vamos a limpiar las dependencias nuget descargadas en la máquina local.

Para listar los sitios donde pueden haber dependencias, ejecute el comando: 

`dotnet nuget locals all --list`{{execute}}

Dirígete a la carpeta `/root/.nuget/packages`para que confirmes que allí están almacenadas las dependencias que usamos en los pasos anteriores:
`cd /root/.nuget/packages`{{execute}}
`ls`{{execute}}

Para limpiar las dependencias descargadas, ejecuta el comando:
`dotnet nuget locals all --clear`{{execute}}

Vuelve a listar y debes ver la carpeta vacía:
`ls`{{execute}}