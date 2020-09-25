Este repositorio tiene 3 ramas principales: produccion, pruebas y desarrollo. Como te pudiste dar cuenta en el paso anterior, la rama de produccion es la rama por defecto. Estas 3 ramas tiene políticas, por lo que no se pueden hacer cambios directamente sobre estas ramas, hay que hacerlo por medio de un pull request.

Por ahora se requiere que crees una nueva rama basada en la rama desarrollo, en la cual debes hacer las modificaciones.

## Tarea

Primero que todo debemos ejecutar el siguiente comando para pasarse a la rama de desarrollo.

`git checkout desarrollo`

Ahora que estás ubicado en la rama de desarrollo, lo que sigue es crear una nueva rama a partir de esta.

`git branch feature/tu_nombre_sin_espacios`{{execute}}. Este comando crea la rama pero no se pasa a ella. Ejemplo git branch feature/jorge_alonso_cadavid_garcia esto se hace con el fin de que no hayan ramas con el mismo nombre en distintos participantes. En el mundo real, en vez del nombre puedes nombrarlo con la identificación de la historia de usuario, nombre del sprint, nombre que identifica el cambio, etc, lo importante es que dentro del equipo haya un acuerdo del nombramiento de las ramas feature/*.

Para pasarte a la rama que acabas de crear ejecuta el comando `git checkout feature/tu_nombre_sin_espacios`{{execute}}

Para crear una nueva rama y saltar a ella en un solo paso, puedes utilizar el comando `git checkout feature/tu_nombre_sin_espacios -b`{{execute}} con la opción -b. Esto es un atajo para:
git branch feature/tu_nombre_sin_espacios
git checkout feature/tu_nombre_sin_espacios