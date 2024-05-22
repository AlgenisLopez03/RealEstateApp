# RealEstateApp
Objetivo general
● Es una aplicación para el manejo de propiedades inmobiliarias,
utilizando asp net mvc 7.

Objetivo general : Este es el objetivo principal del proyecto o sistema. Podría ser algo como "Desarrollar una aplicación de gestión inmobiliaria integral".

Funcionalidades generales: Son las capacidades básicas que se esperan del sistema en su conjunto, como la capacidad de búsqueda, almacenamiento de datos, gestión de usuarios, etc.

Home: La página de inicio de la aplicación o el sistema. Es la primera página que ven los usuarios cuando acceden al sistema.

Agentes: Esta sección probablemente se refiere a las funcionalidades relacionadas con los agentes inmobiliarios que utilizan el sistema, como la gestión de sus perfiles, listado de propiedades, comunicación con clientes, etc.

Únete a la app: Esta funcionalidad se relaciona con el proceso mediante el cual los usuarios pueden registrarse o unirse a la aplicación.

Iniciar sesión (Login): La funcionalidad que permite a los usuarios registrados acceder al sistema ingresando sus credenciales.

Funcionalidades del cliente: Las capacidades específicas dirigidas a los usuarios finales o clientes que utilizan la aplicación, como buscar propiedades, ver detalles, programar visitas, etc.

Home del cliente: La página de inicio específica para los usuarios finales o clientes.
Home del agente : La página de inicio específica para los agentes inmobiliarios.

Mantenimiento de propiedades: Funcionalidades relacionadas con la gestión de propiedades, como agregar nuevas propiedades, editar detalles, eliminar propiedades, etc.
Listado de los agentes: Una funcionalidad que muestra un listado de todos los agentes inmobiliarios registrados en el sistema.

Mantenimiento de administradores: Funcionalidades relacionadas con la gestión de los administradores del sistema, como agregar nuevos administradores, cambiar permisos, etc.

Mantenimiento de desarrolladores: Probablemente se refiere a las funcionalidades relacionadas con la gestión de los desarrolladores del sistema.

Seguridad (17): Funcionalidades relacionadas con la seguridad del sistema, como la gestión de permisos de usuario, cifrado de datos, etc.

Funcionalidades del API (18): Capacidades relacionadas con la interfaz de programación de aplicaciones (API) que pueden utilizarse para integrar el sistema con otros sistemas o servicios externos.

<h2>Requerimientos técnicos</h2>
* Deben utilizar viewmodels y las validaciones se deben realizar desde los mismos.<br><br>
* Se debe usar Entity framework con code first para la persistencia de los datos.<br><br>
* El proyecto tiene que ser visualmente entendible (Usar bootstrap).<br><br>
* El proyecto debe usar la arquitectura ONION (Esta se debe aplicar correctamente<br><br>
al 100%, en caso de algún error en la misma se considerará que esta incorrecta).<br><br>
* Se deben utilizar repositorio y servicio genéricos.<br><br>
* Se deben usar identity para el manejo de los usuarios.<br><br>
* Se deben usar automapper para el mapeo de los viewmodels, entities y dtos.<br><br>
* Se deben usar identity para el manejo de los usuarios y de la seguridad de api<br><br>
con JWT.
* Se deben usar los patrones de diseño de CQRS y Mediator.<br><br>
* Se deben documentar las api usando las facilidades que provee swagger.<br><br>
* Todos los precios de las propiedades serán en peso dominicano.<br><br>
* Todas las pantallas donde se listan propiedades deben tener los mismos filtros
descritos en la sección de home del documento.<br><br>
* Si se intenta iniciar sesión con un usuario tipo desarrollador en el web app
debe decirle que no tiene permiso para usar la web app.<br><br>
* Si se intenta iniciar sesión con un usuario tipo cliente o agente en el web api
26
debe decirle que no tiene permiso para usar el web api.<br><br>

<h2>Home</h2>
Esta es la pantalla inicial del sistema, en esta pantalla se deben listar todas las
propiedades creadas en el sistema listadas desde la más reciente a la más
antigua.
De las propiedades se debe mostrar la siguiente informaciones, Tipo de
propiedad(apartamento,casa, etc.), una imagen de la propiedad, el código de la
propiedad, el tipo de venta de esa propiedad (alquiler, venta , etc),<br><br>

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/3d7f9705-2016-4016-89e0-eb245eaf42ad)
<h2>Login:</h2>
Al ingresar a la opción de inicio de sesión desde el menú principal de la app,
esta nos enviará a una pantalla con un formulario para poder hacer esta acción.
Aquí debe haber un formulario con los siguientes campos: correo o nombre de
usuario y un campo para la contraseña y un botón para iniciar sesión.
Las validaciones de este formulario que todos los campos son requeridos<br><br>

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/5a889bb2-5bdd-497e-904c-f8baabaa02b3)

<h2>Administrador</h2>
Si el usuario que inicio sesión es del rol administrador el sistema lo debe
redireccionar a la pantalla inicial de un administrador se mostrará un menú con
las siguientes opciones:
* Home del administrador
* Listado de los agentes
* Mantenimiento de administradores
* Mantenimiento de desarrolladores
* Mantenimiento de tipo de propiedades
* Mantenimiento de tipo de ventas
* Mantenimiento de mejoras<br><br>

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/e9b33233-eafa-4505-9ae7-ee66c8c6c850)
<br><br>
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/2e57bfc6-5cd8-4040-84f7-a2e2845d104a)
<h2>Home del cliente</h2>
Si el usuario que inicio sesión es del rol cliente el sistema lo debe redireccionar a la
pantalla de home de la app donde se listan todas las propiedades creadas en el
sistema.Lo que sí debe variar en este listado de propiedades del home es que el
usuario debe poder visualizar un botón en cada propiedad del listado con la que
pueda marcar o desmarcar esa propiedad como favorita.
<br><br>

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/ddd1b5c7-0af2-43bc-aec3-f167df1b1e2a)

<h2>Api</h2>

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/fb9d478b-fd8f-4a2b-b3cb-3c1250a50df3)

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/84a7e462-ac5a-4e87-954a-27ad8407531b)

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/b8c7183b-dcea-473d-8b97-62b93752afb7)



