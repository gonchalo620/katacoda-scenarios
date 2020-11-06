Para iniciar se requiere instalar la última compilación de Azure CLI, para máquinas Linux, se debe correr el siguiente comando  `curl -sL https://aka.ms/InstallAzureCLIDeb | sudo bash` {{execute}}

Una vez instalada la CLI, deberá agregar la extensión de Azure DevOps, para esta tarea debe ejecutar el comando:  `az extension add --name azure-devops`

Una vez termine la instalción, pordrá verificar su versión ejecutando `az --version` {{execute}} y revisar las extensones instaladas y deberá encontrar el `item azure-devops`

Con la consola de comandos vaya a la ruta  `/root/taller/artefactos`. Ejecute el siguiente comando para hacerlo:



`cd /root/taller/artefactos`{{execute}}




Para verificar que esté ubicado en la ruta correcta ejecute `pwd`{{execute}}. Deberá ver en la salida de consola `/root/taller/artefactos`