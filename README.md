# poorlamport-bet160
poorlamport-bet160 created by GitHub Classroom


Este proyecto simula gráficamente el algoritmo de los relojes lógicos de Lamport.
Dicho algoritmo se emplea para ordenar los eventos que ocurren en un sistema distribuido.

El algoritmo consiste en lo siguiente:
  •	Cada proceso del sistema tiene un contador que aumenta 1 cada vez que emite un mensaje.
  •	Si un proceso recibe un mensaje, compara el valor de su contador con el valor del contador del proceso que emitió el mensaje, para después tomar el máximo valor y sumarle 1.
  •	Al final cada evento de los procesos del sistema esta asociado a una marca del contador que determina el orden en el que sucedió.
  
Instrucciones para manejar el programa:
  • El usuario debe ingresar dos números entre 1 y 4 para indicar que procesos quiere que intervengan en el envió de mensajes.
  •	El proceso emisor es que emite el mensaje y el receptor el que lo recibe.
  •	Posteriormente debe dar clic en el botón enviar.
  •	La acción se verá reflejada en la tabla tanto del proceso emisor como del proceso receptor.
  •	En la tabla se podrá observar si el proceso envió o recibió un mensaje, así como el valor actual de su contador.

   
   

