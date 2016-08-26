POO: Métodos constructores y sobrecargas
Constructores, métodos C-Sharp, Enumerados, This, accesores de visibilidad
Prof. Octavio Villegas
Esta ejercitación está dividida en clases y cada clase tienen objetivos intermedios.
Nota: (la clase 1 y la clase 2) son la introducción a la IDE y el paralelismo entre la sintaxis del lenguaje “C” con C# (C-Sharp).
Clase 3
Ejercitación

Objetivo: comprender el funcionamiento de un constructor por defecto y this.
A	...inicialización del objeto
i.	Crear la clase publica Rueda, con un atributo de tipo  String llamado marca y el atributo de tipo int tamaño.
ii.	Crear un objeto en el MAIN , inspeccionar los atributos y verificar que el string está en null y el tamaño en 0.
B...Modificación de valores por defecto
i.	Crear un constructor por defecto sin código en su implementación.
ii.	Verificar ejecutando paso a paso que ingresa al constructor.
iii.	Modificar el atributo “This. Marca”  dentro del constructor por defecto con el texto “Sin Marca”.
iv.	Verificar ejecutando paso a paso que ingresa al constructor y que modifica el atributo.
V.	Crear 3 objetos RUEDA y ejecutar pasó a paso verificando el ingreso al constructor por defecto.
C...Relación de composición de clases
i.	Creamos la clase Auto, que posea un atributo string  fabricante y cuatro Ruedas con los siguientes nombres (ruedaDD, ruedaDI, ruedaTD, ruedaTI).
ii.	Crear el constructor por defecto y verificar que cada objeto rueda es inicializado en NULL.
iii.	Inicializar los objetos rueda en el constructor por defecto.
iv.	Verificar que cada objeto no esté en NULL.

Objetivo: comprender la funcionalidad y la sintaxis de un constructor estático.
D.	Constructor Estático
i.	Crear un constructor de clase  en AUTO.
ii.	Verificar que: 
1.	No puede tener modificar de visibilidad
2.	No se puede utilizar el THIS.
3.	Verificar, poniendo punto de quiebre, que es lo primero que se ejecuta, antes de utilizar cualquier miembro de instancia o de clase.
iii.	Crear un atributo estático llamado contador de objetos.
iv.	En el constructor por defecto inicializarlo en 0.
Objetivo: definición, casteo y utilización de enumerados.
E	...enumerados e instancias únicas en atributos estáticos
i.	Crear el enumerado eFabricante (Ford, Chevrolet y honda).
ii.	Verificar en el MAIN como se crear una variable de tipo eFabricante.
iii.	Verificar en el MAIN como se castea una variable de tipo eFabricante.
iv.	Cambiar el tipo de datos del atributo fabricante de la clase auto, de string a eFabricante.
v.	En el constructor  por defecto inicializar el valor del atributo fabricante.
vi.	Hacer que el fabricante se genere Random entre las tres opciones existentes.
vii.	Crear 5  objetos autos y verificar que se carguen los fabricantes de manera Random 
viii.	Crear un atributo estático de tipo Random.
ix.	Iniciar en objeto Random en el constructor estático.
x.	Verificar que las marcas estén ingresadas de manera Random.
 


Objetivo: utilización de atributos públicos y privados.
F.	...Atributos públicos y privados
i.	En la clase Auto creamos el atributo privado “kilometrosRecorridos”.
ii.	El atributo fabricante debe ser PRIVADO
iii.	Creamos los métodos que me permitan interactuar con el atributo por fuera de la clase:
1.	public void AgregarKilometros (int kilometros).
2.	public void VolverACero ().
3.	public int GetKms ().
iv.	Hacer el método: public void MostrarAuto () que muestre el fabricante del vehículo.
v.	Hacer  la clase CARRERA crear el método public void MostrarCarrera (), que muestre los datos de los autos de la carrera
1.	Ejercicio: hacer el método “PorTiempo” que recibe como parámetro  “minutos”  representado por un entero y que la cantidad de minutos son las iteraciones que vamos a realizar (while o for), y en cada iteración le agregaremos una cantidad de kilómetros Random a cada auto participante de la  carrera. Por último el método mostrara por pantalla quien es el ganador con los kilómetros que recorrió.


Objetivo: poder definir y reutilizar constructores, llamada a constructores ya existentes.
G	...Primeras sobrecargas de constructores
i.	En rueda creamos un nuevo constructor que reciba por parámetro un string “marca”.
ii.	Utilizarlo en el MAIN, verificar que al abrir el paréntesis se ve las dos formar de usarlo.
iii.	En rueda creamos un nuevo constructor que reciba por parámetro un int “tamaño”.
iv.	Utilizarlo en el MAIN, verificar que al abrir el paréntesis se ve las tres formar de usarlo.
v.	Agregarles los comentarios  a cada constructor con la tarea que realiza.
/// <summary>
/// Constructor por defecto que inicializa el atributo marca con 'sin marca'		
/// </summary>
H...Reutilización de código de constructores
i.	En rueda creamos un nuevo constructor que reciba por parámetro un string “marca” y un int tamaño.
ii.	Verificar que tanto en la sobrecarga que recibe un string y en la que recibe dos parámetros, el atributo marca es inicializado, pero en la que solo recibe int, el atributo marca está en NULL.
iii.	Utilizar el this para llamar desde el constructor que recibe un int al constructor por defecto para inicializar el atributo marca en “sin marca”.
iv.	Crear un constructor que reciba un INT tamaño y un String marca, que no tenga código en su implementación y que utilice el THIS para llamar al constructor antes realizado.
1.	Ejercicio: hacer las sobrecargas de los constructores de AUTO para que todas pasen por el constructor por defecto para que aumente el contador de objetos.
 

Objetivo: poder sobrecargar métodos.
I.	... Sobrecarga de métodos
i.	Crear la clase “tiempo” y la clase “kilómetro”, cada una con un único atributo de tipo INT llamado “cantidad”.
ii.	Cada uno  debe tener un único constructor que reciba por parámetro la cantidad.
iii.	Ahora en la clase carrera crear el método “CorrerCarrera” con dos sobrecargas, una que reciba kilómetros y una que reciba tiempo.
iv.	Agregamos a la clase auto el atributo privado “tiempoDemorado” donde acumularemos el tiempo demorado en recorrer los kilómetros.
v.	Agregamos al método “VolverACero”  las líneas para volver a cero  el “tiempoDemorado”.
vi.	Creamos el método “AgregarKilometros” que agrega el int que recibe por parámetros al tiempo demorado.
1.	Ejercicio: realizar la implementación  de cada sobrecarga del método “CorrerCarrera” e informar en cada caso quien es el ganador y el perdedor

		
