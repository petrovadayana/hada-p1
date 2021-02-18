# HADA:
## Práctica 1a
### Dayana Petrova Tashukova
#### Pregunta 1: ¿Qué crees que significa la opción -n en el comando revert?

```console
git revert -n SHA-1
```
La opcion **-n** en el comando significa que no se haga un commit de forma automática tras la realizacion de ***revert***

#### Pregunta 2: ¿Qué cambios se han producido al ejecutar el comando reset?
Elimina por completo lo que esta en el stash, y si añadimos al final del comando el SHA-1, se eliminan todos los commits hechos hasta ese SHA-1 introducido, regresando a él.
#### Pregunta 3: ¿Qué diferencias observas entre revert y reset?
**Git reverse** revierte el proyecto al estado de un commit generando un nuevo commit que revierte los cambios realizados. De esta manera las modificaciones no son eliminadas del historial y pueden ser accedidas en el futuro. Los cambios locales que no han sido guardados son sobrescritos.
Por otra parte, **Git reset** se utiliza para mover el proyecto a un commit anterior eliminando todos los posteriores de el historial de commits.
#### Pregunta 4: ¿Qué diferencias observas entre merge y rebase?
La diferencia principal entre **merge** y **rebase** es que en el primero, la rama pemanece de forma paralela a master tras su mezcla, posiblemente quedando muerta en el tiempo. En cambio, en **rebase** , dicha rama es recortada y concatenada a la rama destino, quedando el proyecto mucho mas limpio, ordenado y estructurado.


