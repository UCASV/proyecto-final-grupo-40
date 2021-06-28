# proyecto-final-grupo-40
proyecto-final-grupo-40 created by GitHub Classroom

Aspectos técnicos

El software utilizado para este programa fue, Rider de JetBrains es un IDE.NET, En este
programa se realizó mediante .NET Core en su versión número 5, en un formato de Windows
Forms Apps

Sistema Operativo

Windows 10
MySQL.Notifier 1.1.7
JetBrains Rider 2021.1.2
Paquetes Externos
Microsoft.EntityFrameworkCore 5.0.6
Microsoft.EntityFreameworkCore.Design 5.0.6
Instalación

Base de Datos

En primer lugar, accede al sitio https://www.mysql.com/,Una vez dentro pincha sobre el botón
Downloads del menú superior, en la página de descargas haz scroll y pincha sobre el enlace
MySQL Community (GPL) Downloads, ahora verás un listado con todas las opciones de
descargas existentes, en este punto debes pinchar sobre MySQL Installer for Windows, en la
siguiente página te encontrarás dos enlaces de descarga que aparentemente parecen el
mismo, pero uno tiene un peso de unos 2,4 MB mientras que el otro pesa 436 MB.
Luego te saldrán dos instaladores el primero es un instalador que necesitará conexión a
Internet para poder completar el proceso, mientras que el segundo ya incluye todo lo
necesario para instalar la base de datos sin necesidad de conexión.

Para evitar complicaciones durante la instalación pincha sobre el botón Download del
instalador que pesa unos 400 MB, al final de la nueva página que aparecerá pulsa sobre “No
thanks, just start my download”. De este modo te evitarás tener que crear una cuenta en la
web de Oracle si no la tienes, en ese momento empezará la descarga de un archivo con
extensión .msi que será el que tendrás que utilizar para realizar todo el proceso de instalación
de la base de datos en tu ordenador con Windows 10.

Instalar MySQL en Windows 10

Una vez que la descarga se haya completado, haz doble click sobre el archivo recién
descargado para lanzar el proceso de instalación. Es necesario que lo hagas desde un usuario
con permisos de administrador y que aceptes los permisos que te pedirá el administrador de
cuentas.
Aceptar licencia de uso

Segundos después de aceptar este permiso, se abrirá el instalador de MySQL y en la primera
pantalla te mostrará la licencia de uso que deberás aceptar marcando la casilla
correspondiente y después pulsar sobre Next.
Ahora el instalador te preguntará qué tipo de instalación quieres realizar. La elección
dependerá del uso que vayas a hacer del software y también de la experiencia que tengas. Si
vas a crear tus propias bases de datos desde cero, necesitarás utilizar herramientas de
desarrollo y plugins para ciertas aplicaciones, por lo que la opción Developer Default o Full son
las idóneas. En cambio, si únicamente vas a cargar bases de datos ya creadas, puedes optar
por elegir Server only para que únicamente se instale el servidor y puedas cargar tus bases de
datos.

Rider

Al ser un IDE de JetBrains, nos dirigiremos a su página web o mediante este enlace
https://www.jetbrains.com/es-es/rider/download/#section=windows El cual al instalarse
podrá añadir los lenguajes y herramientas a utilizar mediante este IDE.
Este IDE requiere de licencia para ser utilizado
Licencia Esta se puede comprar, o en el caso de ser estudiantes. como lo somos nosotros,
podemos solicitar una licencia educativa que proporcione Jetbrains mediante este enlace
https://www.jetbrains.com/shop/eform/students en el cual te verás los pasos a seguir, ya
cuando la tengas, podrás ingresar con tu usuario de la licencia en el IDE para obtener más
beneficios y herramientas.
Esta licencia dura un año, pero se puede ir renovando
Patrones de diseño utilizados
Model View Controller:
Se implementa como la arquitectura principal del software haciendo las separaciones entre el
modelo, la vista (interfaces gráficas y entornos donde interactúa el usuario final) y el, cada una
de estas partes está especificada en su respectiva carpeta con los archivos que componen
dicho patrón de diseño. Se utiliza principalmente para separar responsabilidades en los objetos
del proyecto, propiciando así código más fácil de depurar e igualmente poder delegar el
desarrollo de la función entre varios programasdores teniendo en cuenta la menor cantidad de
conflictos. Así mismo el patrón mvc ayuda a la reutilización de código y un mejor manejo de los
datos en la aplicación.

Cadena de responsabilidad:

Se implementa creando una interfaz que sirva como base de funcionalidad en todos los nodos
de la cadena, de ahí se hereda una clase abstracta que a través de polimorfismo permite el
encadenamiento y uso de muchos handlers en la cadena independientemente de su tipo, una
vez planteado esto se implementan handlers concretos que llevan a cabo una tarea en
específico de la cadena antes de continuar con la ejecución de los demás. El principal motivo
de implementación este es que facilita mucho el desarrollo de distintos validadores de los
datos obtenidos en el programa, además de establecer un orden de ejecución y segmentar las
funciones de validación, ayudando considerablemente el proceso de depuración,

Proxy:

Se implementa en las clases terminadas en proxy, creando una interfaz intermedia con el
objeto a utilizar a través de herencia y composición dentro de esta nueva clase proxy; sirve
para extender la función de dos clases en específico: Login y Cita. El principal motivo para
utilizar este es añadir lógica extra a las clases de login y citas permitir que estas se enfoquen
más en tareas específicas y el proxy se encargue de algunas validaciones, consultas y registros,
permitiendo un mejor manejo de los datos antes de enviarlos a otros formularios, guardarlos
en la base de datos, etc.

Members:

1.Nelson Gustavo Miranda Cruz.

2.Denis Armando Mancia Rivas.

3.Carlos Mario Rivera Henriquez.

4.Kevin Osvaldo Mejia Molina.
