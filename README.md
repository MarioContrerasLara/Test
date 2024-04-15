# Test
Hay dos archivos el pograma (Program.cs) y el Test (Test1.cs).

##Programa
Usamos la librería Mail para que sea más sencillo y no tener que utilizar expresiones regulares.
En el mail creamos en forma de lista la variable emails que es dónde se almacenaran los emails válidos introducidos por consola.
email lee la entrada de teclado.
Mientras no se introduzca quit el programa sigue.
En el caso en el que el email sea válido se comprueba si email está en emails. Si el email no es válido se pregunta de nuevo paraque el usuario vuelva a introducir texto.
El boleano IsValidMail comprueba en un try catch mediante la librería mail si el valoir de la variable email tiene formato de email.

##Tests
Son cuatro test.
Los dos primeros son test unitarios. Añadimos un nuevo proyecto MSTest. A la aplicación le añadimos la referencia al proyecto.
El primero le da valor a la variable email un email válido. En Act crea un boleano result con la que se llama a la función IsValidMail pasándole como parámetro el email. Se le hace un assert de si es verdadero el resultado.
El segundo sigue el mismo procedimento que el anterior, está vez pasándole un email incorrecto.
Para los otros dos test usamos el mismo fichero. Pero primero instalamos el nuget de moq.
El primero comprueba si ya se a validado antes el correo. Guarda en email el correo. Crea una variable mockEmailList al que se le pasa la interfaz.
Siguiendo la estructura de moq se comprueba si contiene el email.
El apartyado de act es el mismo que el de los otros dos pero esta vez se añade otro boleano para verificar si se ha validado o no.
En assert se comprueba si se es válido y si ya se ha validado.
Para EmailNotValidated es lo mismo pasándole el mismo email pero comprobado si es falso en assert el boleano de si se ha validado antes.
