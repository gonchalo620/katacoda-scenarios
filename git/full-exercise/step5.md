Este repositorio tiene 3 ramas principales: produccion, pruebas y desarrollo. Como te pudiste dar cuenta en el paso anterior, la rama de produccion es la rama por defecto. Estas 3 ramas tiene políticas, por lo que no se pueden enviar cambios directamente al repositorio remoto sobre estas ramas. Es por este motivo que se requiere que crees una nueva rama basada en la rama desarrollo, en la cual puedes hacer  y enviar modificaciones.

## Tarea

Primero que todo se debe ejecutar el siguiente comando para pasarse a la rama de desarrollo.

`git checkout desarrollo`{{execute}}

Ahora que estás ubicado en la rama de desarrollo, lo que sigue es crear una nueva rama a partir de esta.

`git branch feature/tu_nombre_sin_espacios`{{copy}}. Este comando crea la rama pero no se pasa a ella. Ejemplo git branch feature/jorge_alonso_cadavid_garcia esto se hace con el fin de que no hayan ramas con el mismo nombre en distintos participantes.

En el mundo real, en vez del nombre puedes nombrarlo con la identificación de la historia de usuario, nombre del sprint, nombre que identifica el cambio, etc, lo importante es que dentro del equipo haya un acuerdo del nombramiento de las ramas feature/*.

Para pasarte a la rama que acabas de crear ejecuta el comando `git checkout feature/tu_nombre_sin_espacios`{{copy}}

Para los pasos anteriores, también puedes ejecutar un comando que se comporta como un atajo de estos.
Para crear una nueva rama y saltar a ella en un solo paso, puedes utilizar el comando `git checkout -b feature/tu_nombre_sin_espacios`{{execute}} con la opción -b. Esto es un atajo para:
git branch feature/tu_nombre_sin_espacios
git checkout feature/tu_nombre_sin_espacios