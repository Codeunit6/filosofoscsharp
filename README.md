# Filosofos sinodales

## Datos personales 
NOMBRE:Fernando Brayan Mejía Gómez 

Grupo: 2722IS

## Copiar repositorio :space_invader:

Recuerda copiar el codigo del proyecto con:
```
git clone
```
### Contribucion al proyecto :globe_with_meridians:
A traves de la contribuicon puedes aplicar codigos con  	:hammer_and_wrench: `gitbash` como lo son:

```
git status
git add .
git commit -m "mesaje"
git push
```
## Problematica :pushpin:
![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/mesafilo.jpg "filosofos")

Cinco filósofos se sientan alrededor de una mesa y pasan su vida cenando y pensando. Cada filósofo tiene un plato de fideos y un tenedor a la izquierda de su plato. Para comer los fideos son necesarios dos tenedores y cada filósofo sólo puede tomar los que están a su izquierda y derecha. Si cualquier filósofo toma un tenedor y el otro está ocupado, se quedará esperando, con el tenedor en la mano, hasta que pueda tomar el otro tenedor, para luego empezar a comer. 
Si dos filósofos adyacentes intentan tomar el mismo tenedor a una vez, se produce una condición de carrera: ambos compiten por tomar el mismo tenedor, y uno de ellos se queda sin comer. 

Si todos los filósofos toman el tenedor que está a su derecha al mismo tiempo, entonces todos se quedarán esperando eternamente, porque alguien debe liberar el tenedor que les falta. Nadie lo hará porque todos se encuentran en la misma situación (esperando que alguno deje sus tenedores). Entonces los filósofos se morirán de hambre. Este bloqueo mutuo se denomina interbloqueo o deadlock. 

El problema consiste en encontrar un algoritmo que permita que los filósofos nunca se mueran de hambre. 

## Diseño :notebook_with_decorative_cover:
![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/dise%C3%B1o.jpg "filosofos")

Para el diseño del programa se hizo en un forms de C# el cual contiene una mesa redonda con una imagen PNG, la cual contiene dentro de ella 5 palillos en formato PNG donde cada filosofo (en este caso es un personaje de una caricatura) podrá tomar sus palillos respectivo. En el centro de la mesa tiene un botón que permitirá inicializar la comida de los filósofos dentro de este contiene los hilos que se ejecutaran en nuestro programa. También hace falta recalcar que las imágenes de los filósofos comiendo se encuentran en el mismo lugar con los respectivos nombres “bobsponja#numerolugar” y “bobtoronja#numerodelugar” donde bobsponja es el filósofo en su estado normal no comiendo y bobtoronja es el estado donde se ve comiendo, a través de la propiedad de visibilidad se fueron intercalando la comida de estos.

### Propiedades :lock_with_ink_pen:

Aquí las propiedades del forms en general, donde se especifico el fondo que contendría el panel forms.

![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/propiedades1.jpg "filosofos")

![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/propiedades2.jpg "filosofos")

![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/propiedades3.jpg "filosofos")

## Informacion del proyecto :computer:

Dentro del programa se hizo de dos maneras diferentes mediante 5 funciones diferentes donde se ejecuta cada uno de los filósofos según su respectivo lugar para comer y hacer su respectivo resultado, y la otra manera es de mandar parámetros a una función para su ejecución.

Primeramente, es necesario declarar variables publicas las cuales son de tipo int y bool, las cuales desarrollan las siguientes funciones

- [x] Bool  	:open_file_folder:
- [x] Int :bar_chart:

```
public bool palillo1 = true, palillo2 = true, palillo3 = true, palillo4 = true, palillo5 = true;
public static int filosofo = 5;
public int palillos = filosofo; 
```

Para la función que recibirá nuestro botón escribiremos los hilos que recibirán para la ejecución del programa en la cual reciben parámetros para la función, este parámetro es de tipo entero, ya que especificara el número del filosofo para poder acceder al proceso que se llevara a cabo, esto con el fin de evitar la corrupción de datos y evitar también un posible deadlock.

```
Thread hbobsponja = new Thread(new ThreadStart(() => parametros(1)));
hbobsponja.Start();
Thread hbobsponja2 = new Thread(new ThreadStart(() => parametros(2)));
hbobsponja2.Start();
Thread hbobsponja3 = new Thread(new ThreadStart(() => parametros(3)));
hbobsponja3.Start();
Thread hbobsponja4 = new Thread(new ThreadStart(() => parametros(4)));
hbobsponja4.Start();
Thread hbobsponja5 = new Thread(new ThreadStart(() => parametros(5)));
hbobsponja5.Start();
```

Para la función que recibe los parámetros y se ejecuta en los hilos principales, donde recibe el número del filósofo que recupero del parámetro en el hilo, este hará el cálculo del palillo izquierdo tanto como el derecho, el palillo derecho será igual al número del filósofo y el palillo izquierdo será igual al número de filosofo más uno ya que se aumenta el número del palillo, esto solamente aplica para el 1,2,3 y 4, para el 5 se condiciona a 1. Ya que no existe un palillo 6.

```
//Palillos inicializacion
            int Pizq = filosofo +1;
            int Pd = filosofo;
            //si es filosofo 5 se modifica palillo izquierdo para 1 
            if (filosofo == 5)
            {
                Pizq = 1;
            }
            //inicializar semaforo
            sem.WaitOne();
            if(Pizq == 1 && Pd == 2)
            {
                //ocupar palillos
                palillo1 = false;
                palillo2 = false;
                //modificar imagenes
                Invoke((Delegate)new Action(() => {
                    //visibilidad de las imagenes
                    bobsponja1.Visible = false;
                    bobtoronja1.Visible = true;
                    //visibilidad de los palillos
                    palo1.Visible = false;
                    palo2.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            //en otro caso modificar visibilidad de bob sponja
            Invoke((Delegate)new Action(() => {
                //visibilidad del avatar
                bobsponja1.Visible = true;
                bobtoronja1.Visible = false;
                //visibilidad de los palos
                palo1.Visible = true;
                palo2.Visible = true;
            }));
            //soltar palillos
            palillo2 = true;
            palillo3 = true;
        }
```

## Pruebas :pushpin:
Para las pruebas del programa es necesario ver como se inicializa el programa, este empieza lanzando la ventana del form donde se encuentran nuestros 5 filósofos y los 5 palillos, estos podrán empezar a comer una vez se haya dado al botón de estoy listo, y empieza la ejecución de los hilos puestos en este

En la ejecución del programa se ve como cambia el aspecto de los filósofos cuando estos están comiendo, así como también como desaparecen los utensilios que están ocupando para comer, esto haciendo que solo puedan comer 2 filósofos de los 5 para que no exista un problema dentro de los recursos del programa.

![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/prueba1.jpg "filosofos")

![filosofos](https://github.com/Codeunit6/filosofoscsharp/blob/main/imagenes/prueba2.jpg "filosofos")

## Contacto

Si hay alguna dificultad o necesitas alguna ayuda con el proyecto por favor contactame aqui:
- :telephone_receiver:  5540124899

- :envelope:  fernando.brayan.m.g@gmail.com

## Recuerda dar las gracias :blue_heart:

Este proyecto puedes ocuparlo siempre y cuando:
- Da la gracias de manera publica :heartpulse:
- No lo ocupes con fines maliciosos :lock_with_ink_pen:
- Me invites un cafe :coffee:

Este ultimo no es obligatorio.

## Recuerda seguirme en YOUTUBE

![Codeunit06](https://github.com/Codeunit6/Codeunit6/blob/main/anbu.jpg "Codeunit06")

spek14programacion :link: `<link>` : <https://www.youtube.com/channel/UCwPxnD_fdRJggn5ZILh1PRg>

📌 Tengo un canal en youtube donde pudes ver mis tutoriales. 📌

- Puedes ver tutoriales orientados al backend
- Tengo tutoriales de conceptos
- Sigueme si gustas 

## Recuerda darme un follow :black_nib:

En mi perfil podras encontrar cosas interesantes: 

[GitHub](https://github.com/Codeunit6 "GitHub")

:link: `<link>` : <https://github.com/Codeunit6>
