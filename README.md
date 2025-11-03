# RiniRollABall
Minijuego desarrollado en Unity 2019.4.9f1, con la intención de aprender el movimiento aplicando por fuerzas y el uso del Canvas en el entorno.

#Objetivos
Crear una pequeña experiencia donde una esfera es controlada aplicando fuerzas debe superar un sencillo laberinto, recolectando 5 objetos, utilizando:
rb.AddForce(vectorMovimiento * Velocidad); 
•	Para aplicar fuerzas a la esfera en base a los inputs de WASD.
other.gameObject.CompareTag("Coleccionable") == true){} 
•	Una vez detectada la colisión con los colliders, observar si se trata de un coleccionable con su tag.
other.gameObject.SetActive(false); 
•	Para deshabilitar los coleccionables desde la esfera una vez se detecta la colisión y dejar los coleccionables con menos responsabilidad.
Interfaz UI Canvas
•	Texto en pantalla para señalizar cantidad de coleccionables obtenidos y mostrar texto de Victoria.

#Scripts Principales
“Nivel1ControlParaPelota.cs”
•	El principal para la jugabilidad, colocado en el jugador, permite su movimiento característico.
•	Controla el conteo de puntos, tiene la mayor responsabilidad en el proyecto.
“Nivel1ControlCamara.cs”
•	El movimiento de cámara estilo isométrico que se obtiene al dejar una distancia determinada 
•	Permite que la cámara acompañe de esta forma a la esfera por más que está rueda o realice movimientos bruscos. 
•	Su desventaja es la necesidad de realizar un calculo manual desde el editor.
 
#Versión Jugable (Itch.io)
https://rhifumi.itch.io/minitest-rinirollaball
