Ahora necesita iniciar sesion en Azure, para esto siga las siguientes indicaciones

Normalmente en nuestra máquina podemos utilizar el comando `az login` para autenticarnos en la CLI. En este ejercicio no utilizaremos la máquina local, se deberá usar el comando `az login --allow-no-subscription`{{execute}}. Este comando habilita la autenticación CLI sin necesidad de ingresar en la misma consola las credenciales.

En la terminal, el sistema le dará como respuesta un enlace para ingresar a la página https://microsoft.com/devicelogin con un token en mayúsculas con el que deberá loguearse.

Seleccionar la cuenta de Azure DevOps donde realizó los pasos anteriores. Para verificar el éxito de esta operación, en la terminal deberá de obtener un resultado similar a este

![inicio-exitoso](./assets/inicio-exitoso.png)