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

Requerimientos técnicos
* Deben utilizar viewmodels y las validaciones se deben realizar desde los mismos.
* Se debe usar Entity framework con code first para la persistencia de los datos.
* El proyecto tiene que ser visualmente entendible (Usar bootstrap).
* El proyecto debe usar la arquitectura ONION (Esta se debe aplicar correctamente
al 100%, en caso de algún error en la misma se considerará que esta incorrecta).
* Se deben utilizar repositorio y servicio genéricos.
* Se deben usar identity para el manejo de los usuarios.
* Se deben usar automapper para el mapeo de los viewmodels, entities y dtos.
* Se deben usar identity para el manejo de los usuarios y de la seguridad de api
con JWT.
* Se deben usar los patrones de diseño de CQRS y Mediator.
* Se deben documentar las api usando las facilidades que provee swagger.
* Todos los precios de las propiedades serán en peso dominicano.
* Todas las pantallas donde se listan propiedades deben tener los mismos filtros
descritos en la sección de home del documento.
* Si se intenta iniciar sesión con un usuario tipo desarrollador en el web app
debe decirle que no tiene permiso para usar la web app.
* Si se intenta iniciar sesión con un usuario tipo cliente o agente en el web api
26
debe decirle que no tiene permiso para usar el web api.

Esta es la pantalla inicial del sistema, en esta pantalla se deben listar todas las
propiedades creadas en el sistema listadas desde la más reciente a la más
antigua.
De las propiedades se debe mostrar la siguiente informaciones, Tipo de
propiedad(apartamento,casa, etc.), una imagen de la propiedad, el código de la
propiedad, el tipo de venta de esa propiedad (alquiler, venta , etc),
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/3d7f9705-2016-4016-89e0-eb245eaf42ad)
Login:
Al ingresar a la opción de inicio de sesión desde el menú principal de la app,
esta nos enviará a una pantalla con un formulario para poder hacer esta acción.
Aquí debe haber un formulario con los siguientes campos: correo o nombre de
usuario y un campo para la contraseña y un botón para iniciar sesión.
Las validaciones de este formulario que todos los campos son requeridos
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/5a889bb2-5bdd-497e-904c-f8baabaa02b3)
Administrador
Si el usuario que inicio sesión es del rol administrador el sistema lo debe
redireccionar a la pantalla inicial de un administrador se mostrará un menú con
las siguientes opciones:
● Home del administrador
● Listado de los agentes
● Mantenimiento de administradores
● Mantenimiento de desarrolladores
● Mantenimiento de tipo de propiedades
● Mantenimiento de tipo de ventas
● Mantenimiento de mejoras
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/e9b33233-eafa-4505-9ae7-ee66c8c6c850)
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/2e57bfc6-5cd8-4040-84f7-a2e2845d104a)
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/ddd1b5c7-0af2-43bc-aec3-f167df1b1e2a)

## Api
![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/fb9d478b-fd8f-4a2b-b3cb-3c1250a50df3)

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/84a7e462-ac5a-4e87-954a-27ad8407531b)

![image](https://github.com/AlgenisLopez03/RealEstateApp/assets/141606823/b8c7183b-dcea-473d-8b97-62b93752afb7)



