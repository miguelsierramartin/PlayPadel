# PlayPadel

Trabajo Fin de Grado, ETSISI - UPM 2020/2021

<h4>Título del proyecto</h4> 
Prácticas DevOps para la Automatización de la Integración y Despliegue Continuos en la Nube de Aplicaciones basadas en Microservicios .Net. Caso Práctico: PlayPadel

<h4>Resumen</h4> 
Se requiere hacer uso de una metodología DevOps, apoyada por una herramienta, como es Azure DevOps, que cubre las necesidades de este paradigma. Para llevar a cabo esto, se han creado plantillas de pipelines genéricas encargadas de diseñar la infraestructura de la aplicación. Así como pipelines de integración continua (CI) y despliegue continuo (CD) para cada uno de los microservicios, enfocados a la automatización en la construcción, prueba y despliegue de cada uno de los proyectos independientes, en un entorno de Staging (o pre-producción) en la nube de Azure, para posteriormente acabar pasando al entorno final de producción. A su vez, se utiliza la herramienta SonarCloud, lo que permite el análisis estático de código y por tanto, facilita la mejora en la calidad de este.

Por último, en el caso de estudio práctico se aborda la elaboración de PlayPadel, una aplicación web de un club de pádel, dedicada a gestionar tanto las reservas de pistas como una tienda online. Esta aplicación va a disponer de alojamiento en el portal de Azure, donde su disposición va a estar basada en una arquitectura de microservicios. Por lo tanto, para la implementación de estos microservicios, mediante el framework .NET Core, se hace uso del IDE Visual Studio, encargado de ser el entorno de desarrollo del código; y de Github para alojar las versiones del código fuente de cada uno de los microservicios de la aplicación.

<h4>Arquitectura</h4>

![Arquitecura PlayPadel microservicios](https://user-images.githubusercontent.com/60613241/124792209-1869e100-df4d-11eb-8139-a28ed824e407.png)


<h4>Microservicios</h4>
Los microservicios que se crean son:

•	Identity.Api: Es el microservicio encargado de gestionar todo lo relacionado con los usuarios que están registrados en la aplicación. A su vez, va a ser responsable de generar el token de acceso a nuestras distintas APIs.

•	Catalog.Api: Es el microservicio responsable de gestionar todo lo que a productos de la tienda se refiere, tanto la información detallada de cada producto como un registro del stock disponible de cada uno.
•	Order.Api: Es el microservicio encargado de tramitar las órdenes de compra, por ello necesita mantener una relación directa con los demás microservicios para asociar a los clientes con los productos que han sido comprados por cada uno.

•	Customer.Api: Microservicio encargado de manejar todo lo relacionado con los clientes que han sido registrados en la aplicación, la información de cada uno de ellos como los productos que pueden tener asociados a ellos en una orden de compra.

•	Alquiler.Api: Es el microservicio que más se aleja de la línea continuista del resto, está encargado de gestionar el alquiler/reservas de las pistas de padel, por lo que se ha desarrollado de manera un poco más independiente al resto de microservicios.

•	Proxy.Layer: Es la capa encargada de comunicar los microservicios entre sí, a través de consultas HTTP a los microservicios que requieran de esa comunicación.

•	Api.Gateways: Estos módulos van a permitir encapsular las consultas requeridas a nuestros microservicios. De esta manera, los microservicios no se ven expuestos al acceso por los clientes ni a la comunicación con los mismos y pueden permanecer de carácter privado.

•	Web.Client: Es un proyecto web desarrollado como un razor page, centrado en facilitar la programación de escenarios en páginas.
•	Authentication.Web.Client: Al contar con un proyecto web con la implementación de un formulario de acceso (log-in), vamos a tener un servicio de autenticación encargado de consumir y comunicarse con un único microservicio (Identity). El objetivo va a ser solicitar el token de acceso a la aplicación a ese microservicio y pasarle esa información al proyecto web del cliente, actúa como una pasarela de comunicación. 


<h3>PIPELINES CI MICROSERVICIOS</h3>

| Pipeline | Status | Pipeline | Status |
| ------------- | ------------- | ------------- | ------------- |
| WebClient.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Clients.WebClient.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=16&branchName=master) | WebAuthentication.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Clients.Authentication.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=15&branchName=master)
| ApiGatewayTienda.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/ApiGateway.WebClientTienda.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=17&branchName=master) | ApiGatewayReservas.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/ApiGateway.WebClientReservas.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=18&branchName=master)
| Catalog.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Catalog.Api.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=9&branchName=master) | Customer.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Customer.Api.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=10&branchName=master)
| Identity.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Identity.Api.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=11&branchName=master) | Order.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Order.Api.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=12&branchName=master) 
| Alquiler.Build | [![Build Status](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_apis/build/status/Alquiler.Api.Build?branchName=master)](https://dev.azure.com/miguelsierramartin1599/PlayPadel/_build/latest?definitionId=14&branchName=master)


