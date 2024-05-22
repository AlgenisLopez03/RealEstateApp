# RealEstateApp
Objetivo general
● Es una aplicación para el manejo de propiedades inmobiliarias,
utilizando asp net mvc 7.
Funcionalidades generales
Objetivo general	3
Funcionalidades generales	3
Home	3
Agentes	5
Únete a la app	6
Iniciar sesión (Login)	6
Funcionalidades del cliente	7
Home del cliente	7
Funcionalidades del Agente	7
Home del agente	7
Mantenimiento de propiedades	8
Mi perfil	10
Funcionalidades del Administrador	10
Home del administrador	10
Listado de los agentes	11
Mantenimiento de administradores	11
Mantenimiento de desarrolladores	12
Mantenimiento de tipo de propiedades	13
Mantenimiento de tipo de ventas	14
Mantenimiento de mejoras	16
Seguridad	17
Funcionalidades del Api	18
Funcionalidades generales	18
Login y Seguridad	18
Controlador de propiedades	19
Controlador de agentes	20
Mant. de tipo de propiedades	21
Mant. de tipo de ventas	23
Mant. de mejoras	24
Requerimientos técnicos	26

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
