# UnityAR

## Creacion de aplicacion de Realidad Aumentada

* Lo primero será instalar el paquete de Vuforia Engine en nuestro proyecto y tras ello, crear la base de datos con nuestras fotos que actuaran como targets.
Una vez hecho esto debemos añadir a nuestra escena una cámara AR del paquete Vuforia y tantos Image Targets como imágenes queramos reconocer.

Yo he añadido cuatro ImageTargets diferentes, uno para cada tipo de dragón que aparecerá en nuestra aplicación de realidad aumentada.

![Captura](https://user-images.githubusercontent.com/72491269/206723983-13aa7484-bdaa-49df-bf9e-49250e44bbaa.PNG)

En esta imagen vemos como los cuatro dragones están en la misma posición y con una escala bastante pequeña, esto es asi porque una vez iniciada la escena, los scripts invisibilizan dichos dragones para solo visualizarlos cuando es reconocido su target específico y la escala es debido a la escala propia del propio target.

A continuación se muestran ejemplos de funcionamiento de la propia aplicación con todos los tipos de dragones añadidos:

* Dragon Azul
* Dragon Rojo
* Dragon Morado
* Dragon Verde
