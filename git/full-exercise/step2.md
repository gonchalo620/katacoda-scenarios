Los repositorios remotos le permiten compartir cambios desde o hacia su repositorio. Las ubicaciones remotas son generalmente un servidor de compilación, una máquina de miembros del equipo o una tienda centralizada como Github.com. Los repositorios remotos se clonan usando el comando `git clone <remote-url>` donde `<remote-url>` es la ubicación remota, generalmente una URL HTTPS o una conexión SSH, por ejemplo https://github.com/OcelotUproar/ocelite.git or git@github.com:/OcelotUproar/ocelite.git.  

## Tarea

Este entorno tiene una ubicación de repositorio remoto en https://capacitaciones-azure-devops@dev.azure.com/capacitaciones-azure-devops/Aprendiendo_Git/_git/Aprendiendo_Git. Usando `git clone`, clone el repositorio remoto.

`git clone https://capacitaciones-azure-devops@dev.azure.com/capacitaciones-azure-devops/Aprendiendo_Git/_git/Aprendiendo_Git`{{execute}}

## Tips

Cuando usa el comando `git clone`, se agregará automáticamente como un control remoto con el nombre de `origin` la ubicación desde la que está clonando.

Normalmente solo se clona una vez y luego por medio de comandos actualizamos el repositorio local con el repositorio remoto.