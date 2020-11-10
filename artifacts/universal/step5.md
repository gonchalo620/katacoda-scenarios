El siguiente procedimiento a realizar es la descarga de los paquetes universales, para ello se deberá acondicionar la máquina virtual que tiene en esta ventana.

Instalar la última compilación de Azure CLI, para máquinas Linux, se debe correr el siguiente comando  `curl -sL https://aka.ms/InstallAzureCLIDeb | sudo bash`{{execute}}

Una vez instalada la CLI, deberá agregar la extensión de Azure DevOps, para esta tarea debe ejecutar el comando:  `az extension add --name azure-devops`{{execute}}

Una vez termine la instalción, pordrá verificar su versión ejecutando `az --version`{{execute}} y revisar las extensones instaladas, allí deberá encontrar el item `azure-devops` con su respectiva versión.

Es importante aclarar que esta configuración se debe de realizar por una sola vez
