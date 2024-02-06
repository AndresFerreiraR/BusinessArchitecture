# BusinessArchitecture

El curso ha sido cuidadosamente creado para que te diviertas con ejemplos prácticos de la vida real, 
con presentaciones cortas pero ilustrativas para explicar conceptos fundamentales de 
Arquitectura de Aplicaciones Empresariales con .NET 7.

ver Imagen1_RepresentacionArquitectura.png

Consideraciones Importantes:

El curso esta organizado de tal manera que cada clase se puede implementar de manera independiente sobre arquitecturas de 
aplicaciones nuevas o existentes.

Si bien es cierto el curso inicia con el Framework .NET Core 3.0 es totalmente compatible con las últimas versiones de .NET, 
evidencia de ello es que el curso se encuentra actualizado a la versión nativa de .NET 7.

El curso inicia con una Arquitectura Orientado al Dominio en Capas y va evolucionando hasta incorporar patrones, 
prácticas y principios de Arquitectura Limpia.



Happy Coding!


# Notas de Lanzamiento del Curso

Una de las mayores preocupaciones que tienen los estudiantes cuando comienzan 
un nuevo curso es saber si el curso se encuentra actualizado.

Vemos tantas empresas e instructores lanzar cursos y olvidarse de ellos. 
Esto conduce a cursos obsoletos sin actualizaciones tanto en contenido como en características.

Tenemos un enfoque completamente diferente. Lanzamos constantemente nuevos cursos, 
pero también mantenemos actualizados nuestros cursos existentes.

Aquí hay una cronología de las actualizaciones más importantes de nuestro curso 
Arquitectura de Aplicaciones Empresariales con .NET 7.



13 de enero de 2024 - Implementación de Patrones CQRS y Mediator.

Fundamentos e Implementación del Patrón CQRS en Aplicaciones ASP.NET Core 8.

Fundamentos e Implementación del Patrón Mediator en Aplicaciones ASP.NET Core 8.



25 de noviembre de 2023 - Upgrade a .NET 8.

Instalación de SDK y ASP.NET Core Runtime.

Upgrade de los Proyectos a .NET 8 (Capa de Dominio, Capa de Infraestructura, Capa de Aplicación y Capa de Presentación).



20 de octubre de 2023 - Actualización de la funcionalidad de API Versioning.

Eliminación del Paquete Microsoft.AspNetCore.Mvc.Versioning (Deprecado).

Instalación del Paquete Asp.Versioning.Mvc.ApiExplorer.



25 de septiembre de 2023 - Incorporación de la funcionalidad de envío de correos

Implementación del patrón Options.

Implementación de la funcionalidad de envío de correos utilizando la plataforma SendGrid.



02 de agosto de 2023 - Incorporación de nuevos componentes de Arquitectura

Integración de Web API con ReDoc.

Generación de Datos Fake utilizando Bogus.



19 de julio de 2023 - Incorporación de Comunicación entre microservicios basada en eventos

Implementación de Eventos en la Capa de Dominio.

Fundamentos e Instalación de RabbitMQ.

Implementación de la Capa de Infraestructura e Integración con RabbitMQ.

Implementación del Patrón Publisher-Subscriber.



14 de marzo de 2023 - Incorporación de Patrones, Prácticas y Principios de Clean Architecture

Fundamentos de Clean Architecture.

Organización de la solución e Inyección de dependencias.

Implementación de la Capa de Dominio.

Implementación de la Capa de Infraestructura y Persistencia de Datos.

Implementación de la Capa de Aplicación.

Implementación de la Capa de Servicios.



14 de noviembre de 2022 - Actualización de Versión de Framework y nuevos componentes de Arquitectura

Actualización de la Arquitectura a .NET 7.

Instalación, Configuración e Integración con Redis.

Implementación del Patrón Rate Limiting.



16 de agosto de 2022 - Nuevos componentes de Arquitectura

Implementación de Paginación.

Despliegue en Contenedores Docker.

Despliegue en Azure Web App.

Implementación de Logger y Dashboard con WatchDog.



05 de junio de 2022 - Patrones

Implementación del Patrón Health Check.

Implementación del Health Checks Personalizados.

Implementación del Patrón Repository.

Implementación del Patrón Unit of Work.



22 de noviembre de 2021 - Actualización de Versión de Framework y nuevos componentes de Arquitectura

Actualización de la Arquitectura a .NET 6.

Incorporación de autenticación con JWT.

Incorporación de control de versiones de una API.



12 de febrero de 2021 - Actualización de Versión de Framework y nuevos componentes de Arquitectura

Actualización de la Arquitectura a .NET 5.

Incorporación de la librería FluentValidation.

Construcción de pruebas unitarias.

Análisis de cobertura de código.



15 de noviembre 2020 - Actualización de Versión de Framework

Actualización de la Arquitectura a .NET Core 3.1.



17 de noviembre de 2019 - Actualizaciones de Versión de Framework

Actualización de la Arquitectura a .NET Core 3.

Actualización de Swagger a la especificación OpenAPI.



Los cursos de Arquitectura de Aplicaciones requieren actualizaciones constantes a lo largo del tiempo, y esa es exactamente la razón por la que continuamos actualizando 
nuestro curso de Arquitectura de Aplicaciones Empresariales con .NET 8.



## Modulo Fundamento Arquitectura de Aplicaciones

--> Definicion

• El diseño de la arquitectura de una aplicacion es el proceso por el cual se define una solución para los requisitos
técnicos y operacionales del mismo. Debe cumplir con requerimientos funcionales y no funcionales.

• La Arquitectura define qué componentes conforman la aplicacion, como se relacionan entre ellos y como mediante su interaccion
llevan a cabo una funcionalidad especifica, cumpliendo con los criterios de calidad como seguridad, disponibilidad, eficiencia, 
usabilidad, etc.

• Durante el diseño de la arquitectura se tratan los temas que pueden tener un impacto 
importante en el éxito o fracaso de la aplicacion.

• Algunas preguntas a considerar

  •¿En qué entorno va ser desplegado nuestra aplicacion?
  •¿Cómo va a ser el despliegue de nuestra aplicacion en producción?
  •¿Cómo van a utilizar los usuarios nuestra aplicación?
  •¿Qué otros requisitos debe cumplir el sistema?(Seguridad, rendimiento, concurrencia configuracion, escalabilidad, interoperabilidad, etc)
  •¿Qué cambios en la arquitectura pueden impactar a la aplicación ahora o una vez desplegado?

Para diseñar la arquitecura de un sistema es importante tener en cuenta los intereses de los distintos stakeholders. Estos Stakeholders son usuarios 
del sistema, el propio sistema yu los objetivos del negocio.

Cada uno de ellos impone requisitos y restricciones que deben se considerados en el diseño de la arquitectura y qye pueden desencadenar agun conflicto
por lo que se debe alcanzar un compromiso entre los intereses de cada Stakeholders.

El objetivo final de la arquitectura es identificar los requisitos que producen un impacto en la estructura de la aplicacion y reducir los riesgos asociados
con la construccio. La arquitectura debe soportar los cambios futuros de la aplicacion, del hardware y de funcionalidad demandada por los clientes

• Mostrar la estructura del sistema pero ocular los detalles.
• Realizar todos los casos de uso.
• Satisfacer en la medida de lo posible los intereses de los stackejolders.
• Ocuparse de los requisitos fucnioanles y de calidad (no funcionales)
• Determinar eñ tipo de aplicacion a desarrollar.
• Determinar los estilos arquitecturales que se usaran y principales cuestiones transversales.

-> Proceso De diseño de arquitectura

1. Importancia del proceso de diseño de arquitectura
2. REquisitos previos
3. Etapas del proceso de diseño de la arquitectura.

1. Importancia

El proceso de diseño de la arquitectura juega un rol muy imporatante en el ciclo de vida de la aplicacion

La diferencia entre uin excelente proceso de diseño de arquitectura y uno deficiente puede supiner el exito o el 
facaso de nuestro proyecto.

Durante el proceso de diseño de la arquitectura se tratan y deciden temas importantes con la finalidad de cerear
un arquetipo o una plantilla basica de nuestra aplicacion

• Que tipo de aplicacion se va a construir. (web, RIA, escritorio, etc).
• Que estructura lógica va a tener la aplicacion (N-Capas, componentes, etc)
• Que estructura física va a tener la aplicacion (cliente/servidor, N-tier, etc)
• Que riesgos hay que afrontar y como hacerlo. (Seguridad, rendimiento, interoperabilidad, mantenibilidad, etc)
• Que tecnologías vamos a usar (WCF, WPF, Web Api, Dapper, Entity Framework, .Ner Core, JWT, etc)

2. Requisitos previos

Para realizar de manera eficiente todo el proceso de diseño partiremos de la informacion que ha generado el proceso
de captura de requisitos:

• Casos de uso o historias de usuario.
• Requisitos funcionales y no funcionales
• restricciones tecnológicas y de diseño en general.
• Entorno de despligue propuesto.

3. Etapas del proceso

el proceso de diseño de arquitectura es iterativo e incremental y consta de 5 etapas, este proceso se repite hasta completar
el desarrolla de la aplicacion (Imagen 2)

a. identificar los objetivos de la iteracion

  • En esta etapa es muy importante analizar las restricciones que tiene nuestra aplicacion en cuanto a tecnologías, topologías,
    de despliegue, uso del sistema, etc
  • Tambien es muy importante marcar cuales van a ser los objetivos de la arquitectura, tenemos que decidir si estamos construyendo
    un prototipo, realizando un diseño completo o probando posibles vías de desarrollo de la arquitectura
  • El tipo de documentacion a generar, así como el formato dependera de si nos dirigimos a otros arquetipos, a desarrolladores
    o a personas sin conocimientos tecnicos.
  • El objetivo de esta fase del proceso de diseño de la arquitectura es entender por completo el entorno que rodea nuestro sistema
  • Al termino de esta fase deberemos teber una lista de los objetivos de la iteracion, preferiblemente con planes para afrontarlos
    y metricas para determinar el tiepo esfuerzo que requerira completarlos.

b. Seleccionar los casos de uso importantes

Significa que desarrollaremos primero los casos de uso (funcionalidad) que más valor tengan para el cliente y mitigaremos en primer
lugar los riesgos mas importantes que afronte nuestra arquitectura (requisitos de calidad).

  • Lo importate que es el caso de uso dentro de la lógica de negocio.
  • El desarrollo del caso de uso implica in desarrollo importante de la arquitectura.
  • El desarrollo del caso de uso implica tratar algun requisito de calidad.
  • Lo que se adapte el caso de uso a los objetivos de la iteracion

c. Realizar un esquema de la aplicacion

Llegados a este punto, el promer paso es decidur que tipo de aplicacion vamos a desarrollar. El tipo de aplicacion que elegiremos dependerá
de las restricciones de despliegue, de conectividad, de lo compleja que sea la interfaz de usuario y de las restricciones de interoperabilidad
flexibilidad y tecnologías que imponga el cliente

  • Aplicaciones para dispositivos moviles
  • Aplicacioens de escritorio
  • Servicios
  • Aplicaciones web, SPA, etc

d. Identificar los principales riesgos

En esta etapa mitigamos los principales riesgos planes para solventarlos y planes de contigencia para el caso de que no puedan ser solventados

¿Cómo identificar los riesgos de la arquitectura? Con el entendimiento de los requisitos no funcionales.

"Los requisitos no funcionales son aquellas propiedades que deben tener nuestra aplicacion, como por ejemplo: Alta disponibilidad, flexibildiad,
interoperabilidad, mantenimiento, gestión operacional, rendimiento fiabilidad, reusabilidad, escalabilidad, seguridad, robustez, capacidada de testeo,
y experiencia de usuario

e. Crear arquitecturas candidatas

Una vez realizadas las etapas anteriores, tendremos una arquitectura candidata que podremos evaluar. Si tenemos varias arquitecturas candidatas, realizaremos
la evaluacion de cada una de ellas e implementaremos la arquitectura mejor valorada, las cuales deberían responder:

  • ¿Que funcionalidad implementa?
  • ¿Que riesgos mitiga?
  • ¿Cumple las restricciones impuestas por el cliente?
  • ¿Que cuestiones deja en el aire?


--> Desacoplamiento entre componentes

 1. Desacoplamiento entre componentes

El desacoplamiento debería realizarse entre todos los objetos (con logica de ejecicion y dependencias) pertenecientes a las diferentes capas, pues existen
ciertas capas que se deben integrar a la aplicacion de una forma desacoplada (Imagen3).

En definitiva, desacoplar componentes es conseguir un "state od the art" del diseño interno de nuestra aplicacion: 

"tener preparada toda la estructura de la arquitectura de la aplicacion de forma desacoplada y en cualquier momento poder inyectar funcionalidad para cualquier
area o grupo de objetos, no tiene por que ser solo entre capas diferentes".

Las tecnicas de desacoplamiento están basadas en el principio de inversion de dependencias.

El proposito es conseguir disponer de capas de alto nivel que sean independientes de la implementacion y detalles concretos de las capas de mas bajo nivel, y por lo tanto
tambien, independientes de las tecnologías subyacentes.

  • las capas de alto nivel no deben depender de las capas de bajo nivel ambas capas deben depender de abstracciones (interfaces)
  • Las abstracciones no deben depender de los detalles. Son los detalles (implementacion) los que deben depender de las abstracciones (interfaces).

(imagen4) Diagrama de componentes

 2. Principales técnicas.

Las técnicas principales que se utilizan para habilitar el desacomplamiento entre capas, son:

  • Inversion de control (IoC)
  • Inyeccion de dependeicnas (DI)
  • Interfaces de servicios distribuidos (para consumo/acceso remoto a capas)

El uso correcto de estas tecnicas gracias al desacoplamiento que aportan, potencia los siguientes puntos:

  • posibilidad de sustitucion, en tiempo de ejecucion, de capas/modulos actuales por otros diferentes (como mismos interfaces y similar comportamiento),
    sin que impacte a la aplicacion.
  • Posibilidad de uso de stubs/moles y mocks en pruebas unitarias.

(Imagen5)

--> Inyeccion de dependencias e inversion de control

1. Patron de inversion de control

 Consiste en delegar a un componente o fiente externa, la funcion de seleccionar un tipo de implementacion concreta de las dependencias de nuestras clases.
 En definitiva este patron describe tecnicas para soportar una arquitectura tipo "plug-in" donde los objetos pueden buscar instancias de otros objetos
 que requieren y de los cuales dependen.
  
2. patron de inyeccion de dependencias

Es realmente un caso especial de IoC. Es un patron en el que se suplen objetos/dependencias a una clase en lugar de ser la propia clase quein 
cree los objetos/dependencias que necesita.

La forma mas potente de implementar este patron es mediante un "Contenedor DI". El contenedor DI inyecta a cada objeto las dependencias/objetos
necesarios segun las relaciones o registro plasmado bien por codigo o en ficheros xml de configuracion del "contenedor DI".

Tipicamente el "Contenedor DI" es proporcionado por un framework externo a la aplicacion (como unity, castleWindsor, Spring.Net, etc)
por lo cual en la aplicacion tambien se utilizara inversion de control al ser el contenedor (almacenado en una biblioteca) quien invoque 
el codigo de la aplicacion.

Las tecnicas de inyeccion de instancias de objetos son:

  • Inyeccion de interfaz, inyeccion de constructor.
  • Iyeccion de propiedad (setter) e inyeccion de llamada a método.

La opcion mas potente relativa al desacoplamiento es hacer uso de IoC y DI entre practicamente todos los objetos pertenecientes a las capas
de la arquitectura, esto nos permitira en cualquier momento inyectar simulaciones de comportamiento o diferentes ejecuciones reales
cambiandolo en tiempo de ejecicion y/o configuracion.

En definitiva, los contenedores IoC y la inyeccion de dependencias añaden flexibilidad y conllevan a tocar el menor codigo posible segun 
avanza el proyecto. Añaden compresion y mantenibilidad del proyecto.

con .NEt core tenemos inyeccion de dependencias nativo, ya que, basicamente este ha sido construido mediante interfaces (ejemplo inyeccion de dependencias Imagen6).

Vida util de las dependencias de los servicios en .Net Core

  • Tansaitorio (addTransient): Se crea una nueva instancia, cada vez que se crea un servicio o se solicita.
  • Ambito (addScoped): Se genera una nueva instancia para cada ambito. (Cada solicitud es un alcance). Dentro de ambito, el servicio es reutilizado.
  • Singleton (addSingleton): Se crea solo una vez y se usa en todas partes.

--> Capas Vs Niveles

 1. Canceptos de capas (layers) y niveles (tiers) (imagen7)

Es importante distiguir los conceptos de Capas (layers) y Niveles (tiers), pues es bastante comun que se confundan y o se denominen de forma incorrecta.

Las Capas se ocupan de la division lógica de componentes y funcionalidad, y no tienen en cuenta la localizacion fisica de componentes en diferentes 
servidores o en diferentes lenguajes.

Los Niveles se ocupan de la distribucion física de componentes y funcionalidad en servidores separados, teniendo en cuenta topología de redes y localizaciones
remotas.

Aunque tanto las capas como los Niveles usan conjuntos similares de nombres (presentacion, servicios, negocio y datos), es importante no confundirlos y recordar
que solo los niveles implica una separacion fisica.


Por ultimo, destacar que todas las aplicaciones con cierta complejidad, deberían implementar una arquitectura lógica de tipo N-Capas, pues proporciona una estructura
lógica correcta; sin embargo, no todas las aplicaciones tienen por qué implementarse en modo N-Tier, puesto que hoy aplicaciones que no requieren de una separacion física
de sus niveles.


--> Capas

  1. Consideraciones iniciales

  • Localizar los cambios en una parte especifica de la solucion minimiza el impacto en otras partes, reduce el trabajo requerido en arreglar defectos, facilita
    el mantenimiento de la aplicacion y mejora la flexibilidad general de la aplicacion.

  • La separacion de responsabilidades entre componentes (por ejemplo, separar la interface de usario de la logica de negocio, y la lógica de negocio de acecso a datos)
    Aumementa la flexibilidad, la mantenibilidad y la escalabilidad.
  
  • Ciertos componentes deben ser reutilizables entre diferentes moduilos de una aplicacion o incluso difetenres aplicaciones.

  • Equipos diferentes deben poder trabajar en partes de la solucion con minimas dependencias, para ello, deben desarrollar contra interfaces bien definidas.

  • Los componentes individuales deben ser cohesivos.

  • Los componentes no relacionados directamente deben estar debilmente acoplados.

  • Los diferentes componentes de una solucion deben poder ser desplegados de una forma independiente, e incluso mantenidos y actualizados en diferentes momentos.

  • Para asegurar estabilidad y calidad, cada capa debe contener sus propias pruebas unitarias.

  2. Definicion de Capas

Las Capas son agrupaciones horizontales lógicas de componentes de software que forman la aplicacion

Nos ayudan a diferenciar entre los diferentes tipos de tareas a se realizadas por los componentes, ofreciendo un duseño que maximiza la reutilizacion y especialmente la 
mantenibilidad.

En definitiva se trata de aplicar el principio de "Separacion de responsabilidades" (SoC - separation of concerns principle) dentro de una arquitecura. (ver imagen4)

Al dividir una aplicacion en capas separadas que desempeñan diferentes roles y funcionalidades, nos ayuda a mejorar el mantenimiento del codigo; nos permite tambien
diferentes tipos de despliegue y sobre todo nos proporciona una clara delimitacion y situacion de dónde debe estar cada tipo de componente funcional e incluso cada tipo de 
tecnología (imagen8)

  3. Consideraciones relativas a pruebas

Una aplicacion basado en una arquitectura N-Capas mejora considerablemente la capacidad de implementar pruebas de una forma apropiada

  • Debido a que cada capa interactua con otras capas solo mediante interfaces bien definidos, es facil añadir implementaciones alternativas a cada capa (mock y stubs)
    Esto permite realizar pruebas unitarias de una capa incluso cuando las capas de las que depende no estan finalizadas o, incluso porque se quiera poder ejecutar
    mucho mas rápido un conjunto muy grande de pruebas unitarias.

  • Es mas facil realizar pruebas sobre componentes individuales porque las dependencias entre ellos estan limitadas de forma que los compoenentes de capas de alto nivel
    solo pueden interactual con los niveles inferiores. Esto ayuda a aislar componentes indivuduales para poder probarlos adecuadamente y nos facilita el poder cambiar unos 
    componentes de capas inferiores por otros diferentes con un impacto muy pequeñoen la aplicacion (siempre y cuando cumplan los mismo interfaces) (imagen9)

  4. Beneficios del uso de Capas

  • El mantenimiento en una solicion sera mucho mas facil porque las funciones están localizadas. Ademas las capas deben estar debilmente acopladas entre ellas y con alta
    cohesion internamente, lo cual posibilita variar de una forma sencilla diferentes implementaciones de capas.

  • Otras soluciones deberia poder reutilizar funcionalidad expuesta por las diferentes capas, especialmente si se han diseñado para ello.

  • Los desarrollos distribuidos son mucho mas sencillos de implementar si el trabajo se ha distribuido en diferentes capas lógicas.

--> Principios base de diseño a Seguir

  1. Principios de diseño SOLID (imagen10)

    • Principio de unica responsabilidad (imagen11)

      Una clase debe tener una única responsabilidad o característica. Dicho de otra manera, una clase dene de tener una unica razon por la que esta justificando cambios
      sobre su codigo fuente, una cpmseciemcoa de este p´rincipio es que de forma general las clases deberian tener pocas dependencias con otras clases/tipos.

    • Principio Abierto Cerrado (imagen12)

      Una clase dene estar abierta para extencion y cerrada para la modificacion. Es decir, el comportamiento de una clase dene poder ser extendido sin necesidad
      de realizar modificaciones sobre el codigo de la misma.

    • Principio de sustitucion de Liskov (imagen12)

      Los subtipos deben poder ser sustituibles por sus tipos base (interfaz o clase base). Este hecho se deriva de que el comportamiento de un programa que trabaja
      con abstracciones (interfaces o clases base) no deben cambiar porque se sustituya una implementacion concreta por otra: los programas deben hacer referencia a las 
      abstracciones y no a las implementaciones.

    • Principio Segregacion de interfaces (imagen13)

      Las implementaciones de las interfaces en las clases no deben estar obligadas a implementar metodos que no se usan. Es decir, las interfaces de clases denen ser especificos
      dependiendo de quien los consume y por lo tanto, tienen que estar granularizados / segregados en diferentes interfaces no debiendo crear nunca grandes interfaces.

    • Prinipio Inversion de dependencias (Imagen14)

      Las anstracciones no deben depender de los detalles - Los detalles deben depender de las abstracciones. Las dependencias directas entre clase deben ser reemplazadas por 
      abstracciones (interfaces) para permitir diseños top-down din requerir primero el diseño de los niveles inferiores

  2. Otros principios clave de diseño


    • El diseño de componentes debe ser altamente cohesivo: No sobrecargar los componentes añadiendo funcionalidad mezclada o no relacionada. Por ejemplo, evitar mezclar
      lógica de acceso a datos con lógica de negocio perteneciente al modelo del dominio

    • Mantener el codigo transversal anstraido de la lógica especifica de la aplicacion: El código transversal se refiere a código de aspectos horizontales, como
      la seguridad, festion de operaciones, logging, instrumentalizacion, etc.

    • Separacion de preocupaciones/responsabilidades: dividir la aplicacion en distintas partes minimizando las funcionalidades superpuestas entre dichas partes.
      El factor fundamental es minimizar los puntos de integracion para conseguir una alta cohesion y un bajo acoplamiento.

    • No Repetirse (DRY): Se debe especigicar "La intencion" en un unico sitio en el sistema. Por ejemplo en terminos de diseño una aplicacion, una funcionalidad especifica
      debe implementar en un unico componente; esta mismo funcionalidad no debe estar implementada en otros componentes.

--> Principales Estilos de arquitectura

  1. Definicion de estilo de arquitectura

    Un esttilo de arquitectura es una familia de arquitecturas que comparten determinadas caracteristicas.

    Por ejemplo, de n niveles es un estilo de arquitectura comun. Ultimamente, las arquitecturas de microservicios se han empezado a hacer mas populares.

    Los estilos de arquitectura no requieren el uso de tecnologias concretas, pero algunas tecnologías son adecuadas para ciertas arquitecturas. Por ejemplo, los contenedores
    son una opcion natural para los microservicios.

  2. Principales estilos de arquitectura

    • N - Niveles: Es una arquitectura tradicional para aplicaciones empresariales. Las dependencias se administran mediante la division de la aplicacion,  en capas que realizan 
      funciones logicas como presentaciones, lógicas de negocios y acceso a datos. Una capa solo puede llamar a las capas que se encuetnran por debajo de ella.

    • Web-Cola-Trabajo(Imagen17): En este estilo. La aplicación tiene un front-end web que controla las solicitudes http y un trabajo de back-end que realiza las tareas de uso intensivo 
      de la cpu u operaciones de larga duración. El front-end se comunica con el trabajo a través de una cola de mensajes asíncronos. 
      La arquitectura web cola trabajo es adecuada para dominios relativamente sencillos con algunas tareas que se consumen muchos recursos.

    • Microservicios (imagen18): Una aplicación de microservicios se compone de muchos servicios pequeños e independientes. Cada servicio implementa una sola función empresarial. 
      Los servicios están acoplados de forma flexible y se comunican a través de contratos de API. 
      Una arquitectura de microservicios es más compleja a la hora de compilar y administrar.

    • CQRS (imagen19): El estilo CQRS (segregación de responsabilidad de consultas y comandos) separar las operaciones de lectura y escritura en modelos independientes. 
      Esto permite aislar las partes del sistema que actualizan los datos de las partes que leen los datos.
      Se debería tenerlo en cuenta para dominios colaborativos en los que muchos usuarios acceden a los mismos datos.

    • Arquitectura basada en eventos (imagen20): Usa un modelo de publicación-suscripción (pub-sub), en el que los productores publican eventos y los consumidores se suscriben a ellos. 
      Los productores son independientes de los consumidores y estos a su vez son independientes entre sí. Se debería tenerlo en cuenta para aplicaciones que consumen y procesan un gran 
      volumen de datos con una latencia muy baja.

## Arquitectura N-Capas cib Irientacion al dominio ##

--> Definicion de arquitectura con otientacion al dominio

  1. Definicion de una arquitectura otientada al dominio (DDD).

  Una arquitectura DDD esta compusta por 3 niveles principalmente (imagen21), los cuales son: 
  
    • application layer: Capa donde se realizan la transformacion de objetos a traves de DTO's control de excepciones, las transacciones, etc.
    • Dominio: capa donde se encuentra la lógica de negocio.
    • Infraestructura: Capa donde se realiza loggin persistencia contra una base de datos, interaccion con otros servicios, archivos, etc.

  Que el objetivo de esta arquitectura macro es proporcionar una base consolidada para un tipo concreto de aplicaciones. Aplicaciones empresariales complejas. 
  Este tipo de aplicaciones se caracterizan por tener una vida relativamente larga y un volumen de cambios evolutivos considerable.

  Por lo tanto, en estas aplicaciones es muy importante todo lo relativo al mantenimiento de la aplicación, la facilidad de actualización o la sustitución de 
  tecnologías y frameworks/ORMs por otras versiones más modernas o incluso por otras diferentes, etc. 
  El objetivo es que todo esto se pueda realizar con el menor impacto posible sobre el resto de la aplicación.

  Ejemplo: en las aplicaciones complejas, el comportamiento de las reglas de negocio (lógica del dominio) está sujeto a muchos cambios y es muy importante 
  poder modificar, construir y realizar pruebas sobre dichas capas de lógica del dominio de una forma fácil e independiente.
  Debido a esto, un objetivo importante es tener el mínimo acoplamiento entre el modelo del dominio (lógica y reglas de negocio) y el resto de capas del sistema 
  (capa de persistencia, capa de aplicación, capa de infraestructura de persistencia de datos, etc.).


  2. Diseño de un Microservicio orientado a un DDD

    El diseño guiado por el dominio (DDD) propone un modelo basado en la realidad de negocio con relación a sus casos de uso. 

    En el contexto de la creación de aplicaciones, DDD hace referencia a los problemas como dominios. Describe áreas de problemas independientes como contextos 
    delimitados (cada contexto delimitado está correlacionado con un microservicio) y resalta un lenguaje común para hablar de dichos problemas.

    También sugiere muchos patrones y conceptos técnicos, pero lo importante no son los patrones en sí, sino organizar el código para que esté en línea con los problemas 
    de negocio y utilizar los mismos términos empresariales (lenguaje ubicuo).

    La clave está en donde situar los límites al diseñar y definir un microservicio. Los patrones de DDD le ayudan a comprender la complejidad del dominio.
    Si dos microservicios necesitan colaborar mucho entre sí, probablemente sean el mismo microservicio.

  3. Niveles en los Microservicios DDD (Imagen22)

    • Nivel De aplicacion: 

      Define los trabajos que se supone que el software debe hacer y dirige los objetos de dominio expresivo para que resuelvan problemas.

      Este nivel debe mantenerse estrecho. No contiene reglas de negocio ni conocimientos. Sino que sólo coordina tareas y delega trabajo a colaboraciones 
      de objetos de dominio en el siguiente nivel.


    • Nivel del modelo del dominio:

      Responsable de representar conceptos del negocio, información sobre la situación del negocio y reglas de negocio. El estado que refleja la situación empresarial 
      está controlado y se usa aquí, aunque los detalles técnicos de su almacenaje se delegan a la infraestructura. Este nivel es el núcleo del software empresarial.

    • Nivel de infraestructura: 

      El nivel de infraestructura es la forma en la que los datos que inicialmente se conservan en las entidades de dominio (en la memoria) se guardan en base de datos o 
      en otro almacén permanente.

--> Diseñar un arquetipo orientacion al dominio con .Net Core

  1. Diseñar arquetipo orientado al dominio (DDD)

    Se va a ir detallando cada capa.

    • Capa de infraestructura de datos

      • Data (conexion a la base de datos)
      • Interface (definicion de los metodos CRUD)
      • Repository (implementacion de las interfaces, metodos CRUD)

    • Capa de dominio

      • Entity (Entidades de negocio, Limites de contexto (microservicio))
      • Interface (definicion de los metodos de negocio)
      • Core (implementacion de las interfaces, Logica de negocio)

    • Capa de Aplicacion

      • DTO (Objetos de transferencia de datos).
      • Interfaces (definicion de los metodos de aplicacion)
      • Main (Implementacion de las interfaces y gestion de cuestiones técnicas, gestión de excepciones, manejo de transacciones, Transformacion de objetos).

    • Capa de servicio

      • Web API (Servicios HTTP Restful, CORS, Inyeccion de dependencias, Seguridad JSON Web Token, Swagger (Especificacion OpenAPI)).

    • Capa Transversal

      • Common (clases base, interfaces y funciones comunes).
      • Mapper (mapeo de objetos (DTO / Entidades y viceversa)).
      • Loggin (Trazabilidad, Stack Trace).

  2. Vista general del arquetipo (estructura e interrelaciones) (imagen4)
  .
  3. Definir tegnología a utilizar en cada nivel del arquetipo (Imagen23).

    Se usaran librerias como:

      • NETStandard.Library
      • Micro ORM Dapper
      • Microsoft.Extensions.Configuration
      • System.Data.sqlClient
      • AutoMapper
      • Microsoft.AspNetCore.App
      • Microsoft.NetCore.App
      • AutoMapper.Extension.Microsoft.DependencyInjection
      • SwashBuckle.AspNetCore (Swagger)
      • System.IdentityModel.Tokens.JWT (JWT)

## Configuración del entono de desarrollo ##

--> Configuracion entono de desarrollo

  1. Configuracion del entorno.

    • Para el siguiente desarrollo usaremos como base de datos Microsoft Sql server (MSql Server), para poder ejecutar un entorno local de Sql Server se debe instalar
      "SQL Server Express" se puede descargar desde la siguiente opcion: https://www.microsoft.com/en-us/sql-server/sql-server-downloads (imagen24)
      Para instalar Sql server express seguir el siguiente tutorial: https://www.youtube.com/watch?v=oYHmKFiNOYs 
    
    • Instlar un entorno de desarrollo para conectarse a la base de datos y administrarla, para ello podemos instalar SSMS (Sql Server Management Studio) o usar Azure data studio
      link para descarga de SSMS (Sql Server Management Studio): https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 (imagen25)
      instalacion de sql server management studio https://www.youtube.com/watch?v=_fFz-_O2yvI.

      link para descarga azure data studio https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall link instalaccion: https://www.youtube.com/watch?v=_-xiFxCENN4 

    • para el desarrollo del proyeto se utilizara IDE Visual studio 2017 o superior y/o Visutal studio code.

      Descarga Visual Studio 2017 o superior link: https://visualstudio.microsoft.com/es/ (segun version y arquitectura de la maquina). (imagen26)
      Link para instalacion https://www.youtube.com/watch?v=0Bylp5rPnWg 

      Descarga visual studio code link: https://visualstudio.microsoft.com/es/ (segun version y arquitectura de la maquina). (imagen27)
      Link para instalacion https://www.youtube.com/watch?v=X_Z7d04x9-E

    • Versones de .Net y .Net core link de descarga: https://dotnet.microsoft.com/en-us/download/dotnet (el proyecto empezara con una version .Net Core 2.1 e ira incrementando hasta 
      estar en la ultima version).

## Capa de infraestructura de persistencia a datos ##

  A partir de aqui se subira el codigo de cada clase al repitorio, quedara como un neuvo commit en la rama develop.

  1. Se debe ejecutar el script instnwnd.sql contenido en la carpeta Scripts dentro de la base de datos.

  2. Se debe crear el proyecto.

## Capa de dominio ##

Ver los pull realizados al reposiotiro en la rama de develop

## Capa de Alicacion ##

Ver los pull realizados al reposiotiro en la rama de develop

## Capa de Servicio ##

Ver los pull realizados al reposiotiro en la rama de develop

  • Swagger y OpenApi => 

      • ¿Que es IpenAPI?

        La especificacion de Open API es un formado de descripcion para REST. Un archivo OpenAPI permite describir una API de manera complera incluyendo la informacion del endpoint
        incluyendo parametros de entrada y salida para cada endpoint y permite conocer los metodos de autenticacion de la API a consumir, por ultimo permite conocer la informacion
        del contacto, licencia, terminos de uso.

      • ¿Que es Swagger?

        Es un conjunto de herramientas de codigo abierto creadas al rededor de la especificacion OpenAPI que ayuda a diseñar, construir, documentar y consumir un API Rest

  • CORS => 

    • Contexto => 
      • La seguridad el navegador impide que una pagina web realice solicitudes a un dominio diferente. Esta restriccion se llama politica del mismo origen.
      • La politica del mismo origen impide que un sutio malicioso lea datos confidenciales de otro sitio.
      • En muchos casos es posible que sea necesario permitir que otros sitios realicen solicitudes del origen cruzado a su aplicacion (Ejemplo: cuando se exponen API's).

    • CORS
      • Es un estandar W3C que permite a un servidor flexibilizar la politica del mismo origen.
      • Permite que un servidor habilite explicitamente algunas solicitudes de origen cruzado mientras rechaza otras.
      • Es mas seguro y mas flexible que las tecnicas anteriores como JSONP.
      • No es una caracteristica de seguridad, CORS flexibiliza la seguridad. Una API no es mas segura al permitir CORS.

  • JWT (JASON WEB TOKEN)

    • Que es un Token? : Es una cadena alfanumerica con caracteres aparentemente aleatorios, como el siguiente: eyJhBGSJDHKksjdhfiuwerjnUKSHDkaaskdfKAJSHdjksdfkasjfnKJASHfkjasdfwweflaskcnadfas
      o como el siguiente 123456

      Estas cadenas de texto, aparentemente no tienen un significado, sin embargo tiene un significado real para el servidor o institucion que lo emitió y ademas pueden entender y así validar al usuario 
      que intenta acceder a la informacion. Un token pude tener datos adicionales.

    • Que son los JSON Web tokens (JWT)
      Podemos decir que los JWT son un tipo de token el cual engloba una estructura, la cual puede ser desencriptada por el sevidor y de esta forma, autenticarnos como usuario en la aplicacion.

        • Estructura de un JWT (3 secciones separadas por un punto)
          iugIGIhlkjhiuGIkhliuHIUGluiHlkhlIHl.yUKJBSIiuiausiuHuihIHsuibiNkjIUhihsbiUHIh.iuihiNIUhiUGbgTYfBkJtFugikguiyfgBJgiUGi
          
          Header (primera parte): Contiene el tipo de token y el algoritmo de encriptamiento.
          Payload (segunda parte): Contiene los datos que identifican al usuario (Id,Nombre,etc)
          Firma (tercera parte): Es la firma digital, la cual se genera con las secciones anteriores y sirve para validar que el contenido no haya sido alterado. (header y payload en base64 y despues encriptado)
      
        • Como se usan JWT

          • Los JWT se utilizan para autenticar a los usuarios, para ello, el usuario requiere de un login tradicional como es el usuario y password.
          • Una vez, que el sistema de backend valida que el usuario y la contraseña  son correctas, este retornara un token al usuario.
          • El Token lo debera guardar el cliente, pues de aqui en adelante todas las peticiones que realice al servidor, deberá llevar el token.
          • El token por lo general es almacenado en cookies o en el localstorage del navegador, y cuando se requiere enviar un request al sevidor, se recupere y se envua como header.

        • Ciclo de vida de un token

          • El usaurio requiere una autenticacion tradicional con el servidor, es decir, usuario y password.
          • El servidor valida que los datos introducidos sean correctos y generara un token.
          • El servidor enviara el token al usuario y este lo tendra que almacenar de cualquier forma.
          • una vez con el token el usuario realiza una peticion al servidor, enviando en el header el token.
          • El servidor validara que el token sea correcto, desencriptandolo mediante la mmisma llave que utilizo para encriptarlo.
          • Si el token es correcto, entonces el servidor retornara los datos solicitados.

  ## Actualizacion A .NET Core 3.0 ##

  Ver actualizacion en el repo.

  ## Metricas de calidad de codigo ##

    1. Metricas de codigo

      • Las metricas de codigo son un conjunto de metricas de software que brindan a los desarrolladores una mejor comprension del codigo  que estan desarrollando.
      • Al Aprovahcar las metricas de codigo los desarrolladores puden comprender que clases y/o metodos deben refactorizar o realizas pruebas mas a fondo.
      • Los equipos de desarrollo pueden identificar riesgos potenciales, comprender el estado actual de un proyecto y realizar y realizar un seguimiento del proceso durante el desarrolo de software

        • Visual Studio a partir de la version 2019 calcula las metricas de codigo
          • Maintainability index (indice de mantenibilidad).
              Calcula un valor de indice entre 0 a 100, lo cual representa  la relativa facilidad de mantener el codigo. Un valor alto significa uma mejor mantenibilidad del codigo.
                0-9 ROJO
                10-19 AMARILLO
                20-100 VERDE

          • Ciclomatic complexity (Complejidad ciclomatica).

            Mide la complejidad estructural del código. Se obtiene calculando el numero de diferentes rutas de codigo en el flujo del programa. Un programa que tiene un flujo de control complejo requiere mas
            pruebas para logar una buena cobertura de codigo y es menos mantenible.

          • Depth of inheritance (profundidad de herencia).

            Indica la cantidad de frases diferentes que se heredan entre si, hasta la clase base. La profundidad de herencia es similar al acoplamiento de clases en que un cambio en una clase base puede afectar
            a cualquiera de sus calses heredadas. Cuanto mayor sea este numero, mayor sera la herencia y mayor sera la posibilidad de que las modificaciones de la clase base produzcan un cambio radical.

          • Class coupling (Acoplamiento de clases).

            Mide el acoplamiento a clases unicas a traves de parámetros, variables locales, tipos de retorno, llamadas a metodos, etc.
          
            Un buen diseño de software dicta que los tipos y metodos deben tener una alta cohesion y un bajo acoplamiento. El alto acomplamiento indica un diseño que es dificil de reutilizar y mantener debido 
            a sus muchas interdependencias con otros tipos.

          • Line of code (Lineas de codigo).

            Indica el numero exacto de lineas de codigo fuente que están presentes en su archivo fuente, incluso las lineas en blanco, estas metricas estan disponibles a partid de visual studio 2019

## DOCKER ##

  Docker es una plataforma de software que le permite crear, probar e implementar aplicaciones rápidamente. Docker empaqueta software en unidades estandarizadas llamadas contenedores que incluyen todo lo necesario para que el software se ejecute, incluidas bibliotecas, herramientas de sistema, código y tiempo de ejecución. Con Docker, puede implementar y ajustar la escala de aplicaciones rápidamente en cualquier entorno con la certeza de saber que su código se ejecutará.

  Docker le proporciona una manera estándar de ejecutar su código. Docker es un sistema operativo para contenedores. De manera similar a cómo una máquina virtual virtualiza (elimina la necesidad de administrar directamente) el hardware del servidor, los contenedores virtualizan el sistema operativo de un servidor.

  Docker fue creado por desarrolladores y para desarrolladores. Brinda estabilidad al entorno: un contenedor en la máquina de desarrollo funcionará exactamente igual en el escenario, la producción o cualquier otro entorno. Esto elimina el problema de varias versiones de programas en diferentes entornos

    • Algunos comandos

      • Docker version => nos permite conocer la version de docker instalada y el motor (engine) sobre el cual esta corriendo.
      • Docker image ls => nos permite listar las imagenes dispobibles en el equipo.
      • Docker image build -t <nombreImagen:version> -f <directorioDockerFile> <DirectorioDeLaSolucion>
          Ejemplo "docker image build -t pacagroup.ecommerce:1.0.0 -f .\Pacagroup.Ecommerce.Services.WebApi\Dockerfile ."
          Se crea una imagen llamada pacagroup.ecommerce:1.0.0 ejecutando el docker file en la ruta .\Pacagroup.Ecommerce.Services.WebApi\Dockerfile y se especifica el directorio de la solucion, se coloca . al estar en la raiz del directorio
      • Docker image rm -f <IdImagen> => nos permite borrar una imagen por Id

      Creacion del contenedor docker a partir de una imagen.

        • docker container ls => Este comando nos permite listar los contenedores.
        • docker container run --name <NombreDelContenedor> -d -p <puerto>:<Puerto> <IdDeLaImagen> => nos permite crear un contenedro
          asignarle un nombre con --nambe, con -d idicamos que el contenedor se ejeucte en segundo plano con la opcion -p establecemos
          los puertos en el contenedor primer puerto para acceder al contenedor desde docker host y el segundo puerto es el interno del contenedor seguido con el id de la imagen ejemplo

          docker container run --name pacagroup.econmmerce -d -p 8050:80 3f754ad0bdf6

        • docker container logs <IdContenedor> => nos permite ver los logs de la aplicacion que esta corriendo sobre este contenedor.

## Actualizacion .Net Core 3.1 ##

Ver repositorio

• Metodos de extension:

  Son metodos adicionales que permiten inyectar metodos adicionales sin modificar, derivar o recompilar la clase, estructura o interfaz original. Con la extensino ganamos mantenibilidad en el codigo y segmentar 
  funcionalidades en diversas clases que cumplan responsabilidades especificas siguiendo el orden de los principios solid.

## Actualizacion a .Net 5 ##

ver repositorio

## Creacion de reglas de validacion con FluentValidation ##

  Ver repositoio


## Pruebas Unitarias ##

  1. Definicion de las pruebas unitarias.

    Las pruebas unitarias consiste en probar ciertas funciones o areas de nuestro codigo de forma aislada del resto. De esta forma se comprueba que ante una serue de entradas el resilado obtenido es el que se espera

    Las pruebas unitarias deben ser automarizadas de forma que segun se va programando se va construyendo una bateria de pruebas que en un futuro nos aseguran que el codigo sigue funcionando tras modificaciones, refactorizaciones, mantenimiento, etc.

    Se denominan pruebas unitarias porque descomponen las funciones de la aplicacion en comportamientos comprobables discretos que se pueden probar como unidades individuales

  2. Caracteristicas de las pruebas unitarias.

    • Deben ser automatizables
    • Deben tener control sobre todo el codigo que se esta probando.
    • se pueden ejecutar en cualquier orden (no debe depender de que se haya ejecutado otro test previamente).
    • Se ejecuta en memoria (no requiere de disco duro, base de datos o servicios web).
    • Devuelve siempre el mismo resultado.
    • Se ejecuta rapidamente.
    • Testea una unica funcionalidad.
    • Es facil de leer y mantener
    • puedes confiar en él (cuando ves un resultado no te hace falta depurar el codigo para asegurarse).

  3. Requisitos de las clases de pruebas unitarias.

     Los requisitos minimos para una calse de prueba en visaul studio .NET

      • Atributo [TestClass]: Obligatirio en cualquier clase que mantenga metodos de pruena unitarios.
      • El atributo [TestMethod]: Indica que un determinado metodo es una prueba unitaria.

  4. Estructura de las pruebas unitarias.

    Usualmente se usa el patron AAA (Arrange, Act, Assert).

      • Arrange => donde se inicializan los objetos necesarios para la ejecucion del codigo
      • Act => donde se ejecuta el metodo que se va a probar y se obtiene el resultado.
      • Asset => Donde se comprueban que el resultado obtenido es el esperado.

  5. Nombre de los metodos de las pruebas unitarias.

  El nombre de la prueba unitaria debe representar lo que hace realmente la prueba, sin tener que revisar la prueba en si 

  Se recomienda usar el formado: [Metodo]-[Escenario]-[ResultadoEsperado]
  Ejemplo ProcesarRetiro_CuandoMotoEsMayorAlSaldo_SaldoInsuficiente

  6. Recomendaciones.

    • Al crear una clase de prueba, el nombre debe serguir el formato [NombreClase]Test: BanckTest, AccoutTest, etc
    • Los metodos de prueba no deberían tener parametros.
    • Los metodos de prueba deben ser de tipo void.
    • Finalmente se debe tener en cuenta que una prueba unitaria solo debe probar una funcionalidad especifica, si tu prueba se complica por los distintos flujos que se tienen que probar, quiere decir, que el metodo bajo prueba no sigue el principio de responsabilidad unica,