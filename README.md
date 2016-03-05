PROYECTO PARA CURSO DE DESARROLLO VISUAL STUDIO .NET 2015 WEB DEVELOPER C#

1.	TITULO DEL PROYECTO		:	SISTEMA WEB TIENDA VIRTUAL

2.	DESCRIPCIÓN
El presente proyecto está orientado a realizar los aspectos básicos que comprende el proceso de ventas tanto por parte del usuario como por la parte de la administración en un entorno Web.
3.	ALCANCE  DEL PROYECTO
EL proyecto comprende el desarrollo de un sistema web básico.
El sistema implementado seguirá el patrón de diseño MVC.
El sistema a desarrollarse comprenderá 2 entornos el de Usuario y el Administrador.
El código fuente seguirá buenas prácticas y patrones de código limpio.
La base de datos tendrá una estructura básica para temas funcionales de la herramienta a elaborar.
La versión de base de datos a utilizar será Sql 2008.
El software para elaborar el código fuente será Visual Studio 2013.
El sistema deberá descargarse de un repositorio.
El sistema deberá compilarse y ejecutar scripts que estén en el proyecto.
La herramienta deberá ejecutarse en cualquier PC que cumpla con los requerimientos básicos para acceder a un entorno web.

3.1.	INTERFAZ CLIENTE
El usuario cliente podrá ingresar a la página web y crearse un login para posteriormente concretar las compras que desea realizar.
El usuario ingresará a la página web y consultar los productos que desea comprar con su respectivo detalle.
El usuario contará con un “carrito de compras” para poder agregar al mismo los productos que desee comprar, en caso de que sea más de uno.
De desistir de comprar un ítem seleccionado podrá desagregarlo del “carrito de compras”.
Para concretar el proceso de compra el usuario el sistema solicitará  ingresar con su login y su password, el cuál de no contar con uno, el sistema le permitirá crearlo. Si usuario ya se logueó al inicio sistema ya no solicitará login.
El registro de usuario requerirá de ingreso de datos básicos.
El usuario podrá consultar sus compras realizadas en un historial de compras.
El usuario recibirá un mail a su bandeja de entrada correspondiente como confirmación de compra.
Al momento de concretar la compra se generará automáticamente una orden de compra con su id correspondiente que el usuario administrador podrá revisar en su sesión.
El usuario hará el pago de sus compras con la opción tarjeta de crédito o débito.

3.2.	INTERFAZ ADMINISTRADOR

El usuario administrador podrá hacer el mantenimiento respectivo de los productos, categorías y subcategorías (agregar, eliminar, actualizar) de la tienda virtual.

El sistema permitirá consultar las órdenes de compra generadas por el usuario cliente a través de un filtrado básico (por fecha, por producto, por categoría, sub-categoría).

El sistema  alertará al administrador vía correo electrónica  al momento de haberse registrado una nueva orden de compra.

El sistema elaborará un consolidado diario de las órdenes de comprar generadas.

Las órdenes de compra contarán con un estado:” Recepcionado”, “En Proceso”, “Entregado”, “Anulado”.

El administrador podrá anular una orden de compra ya sea por solicitud del cliente o por criterios definidos por el administrador, siempre y cuando el pedido aún se encuentre en proceso.

4.	LIMITACIONES  DEL PROYECTO

Se simulará que el pago sea con tarjeta de crédito o débito,  no se validará con banco. Sólo se ingresa por temas funcionales.

El sistema no realizará un cuadre de caja diario, sólo elaborará el consolidado diario de las compras como tema informativo.

La compra no requerirá emitir Factura, sólo generará la orden de compra correspondiente y enviará por correo la confirmación de la compra. Simulará una boleta.

