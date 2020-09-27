Puede ver qué archivos han cambiado entre su directorio de trabajo y lo que se ha enviado previamente al repositorio usando el comando `git status`.  

El resultado de este comando se denomina "estado del árbol de trabajo".



## Tarea

Use el comando `git status`{{execute}} para conocer el estado del repositorio.

Debió aparecerle el archivo que creó en el paso anterior como "untracked", significa que es un archivo nuevo que no esta seguido por git.
Para agregar el archivo a la zona de preparación, ejecuta el siguiente comando `git add archivos/tu_nombre_completo.html`

## Plus

Git "no rastrea" todos los archivos hasta que se indique lo contrario.
Puedes usar el comango `git add .` para agregar todos los archivos que estén listos para pasar a la zona de preparación.