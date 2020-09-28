Indicaciones Trabajo futuro


Si ya terminaste el trabajo en la rama feature/* que estabas trabajando puedes eliminar la rama local y remota con el siguiente comando: 

Antes de eliminar una rama asegúrate de que has subido todos los cambios y también debes situarte en una rama distinta para poder eliminarla.

Para pasarse a una rama distinta `git checkout rama_que_quires_pasarte`

Eliminar la rama local: `git branch -d rama_que_quires_eliminar`
Eliminar la rama Remota: `git push origin --delete feature/nombre_de_rama` también la puedes eliminar desde la interfaz del repositorio remoto (Azure DevOps, GitHub)


## Nuevos desarrollos

Suponga que tienes un nuevo desarrollo lo que debes hacer es pasarte a la rama de desarrollo, hacer un pull para actualizar la rama local con la rama remota (descargar los últimos cambios), como se hizo en el paso anterior, luego de esto es repetir los pasos desde el punto 5.

Ya con esto tienes el conocimiento necesario para trabajar colaborativamente con git ¡Felicitaciones¡ .


## Nota 

Si quieres descargar localmente una rama que ha subido otro compañero al repositorio remoto, puedes ejecutar el siguiente comando:

`git fetch`{{execute}} esto actualizará las referencias a las ramas remotas en tu repositorio local.
Lista las ramas remotas con `git branch -a` para asegurarte de que si hayan actualizado las referencias.

Para crear una rama a partir de la rama remota ejecuta el comando `git checkout -b nombre_rama_local origin/nombre_rama_remota`