# <center>Project Report</center>

<p align="center">
    <img src="https://upload.wikimedia.org/wikipedia/commons/f/fc/UPC_logo_transparente.png"></img><br>
    <strong>Universidad Peruana de Ciencias Aplicadas</strong><br>
    <strong>Facultad de Ingeniería</strong><br><br><br>
    <strong>Curso:</strong> 1ASI0572 - Desarrollo de Soluciones IOT<br>
    <strong>NRC:</strong> 6766<br><br>
    <strong>Nombre del Profesor: Marco Antonio Leon Baca</strong><br><br>
    <br><strong>"Informe del Trabajo Final"</strong>
</p>

</p>

<p align="center">
    <strong>Nombre del grupo: nanoTech</strong><br>
    <strong>Nombre del producto: Foll</strong>
</p>

<div style="text-align:center;">
    <h3>Integrantes:</h3>
    <table align="center">
        <tr>
            <th style="text-align:center;">Code</th>
            <th style="text-align:center;">Apellidos y Nombres</th>
        </tr>
        <tr>
            <td>u202315044</td>
            <td>Agreda Sobrino, Ariana Cecilia</td>
        </tr>
        <tr>
            <td>u202210259</td>
            <td>Belledonne Espinoza, Claudia Valeria</td>
        </tr>
        <tr>
            <td>u202313702</td>
            <td>Elera Rodríguez, Mauricio Daniel</td>
        </tr>
        <tr>
            <td>u202313773</td>
            <td>Saldaña Ayala, Fabiola del Rocío</td>
        </tr>
        <tr>
            <td>u20231a778</td>
            <td>Vilca Saboya, Diego Alejandro</td>
        </tr>
    </table>
</div>

<p align="center">
    <strong>Lima - Abril, 2026</strong>
</p>
<br>

---


<br>

<h1 align="center">Registro de versiones del Informe</h1>
</br>
<table>
            <tr>
                <th>Versión</th>
                <th>Fecha</th>
                <th>Autor</th>
                <th>Descripción de modificaciones</th>
            </tr>
<tr>
    <td>0</td>
    <td>08/04/2026</td>
    <td>Ariana Agreda</td>
    <td>Creación del reporte.</td>
</tr>
</table>

---


# Project Report Collaboration Insights
## TB1
 
---

 
# Contenido
 
- [Project Report](#project-report)
- [Project Report Collaboration Insights](#project-report-collaboration-insights)
  - [TB1](#tb1)
- [Contenido](#contenido)
- [Student Outcome](#student-outcome)
- [Capítulo I: Introducción](#capítulo-i-introducción)
  - [1.1. Startup Profile](#11-startup-profile)
    - [1.1.1. Descripción de la Startup](#111-descripción-de-la-startup)
    - [1.1.2. Perfiles de integrantes del equipo](#112-perfiles-de-integrantes-del-equipo)
  - [1.2. Solution Profile](#12-solution-profile)
    - [1.2.1. Antecedentes y problemática](#121-antecedentes-y-problemática)
    - [1.2.2. Lean UX Process](#122-lean-ux-process)
      - [1.2.2.1. Lean UX Problem Statements](#1221-lean-ux-problem-statements)
      - [1.2.2.2. Lean UX Assumptions](#1222-lean-ux-assumptions)
      - [1.2.2.3. Lean UX Hypothesis Statements](#1223-lean-ux-hypothesis-statements)
      - [1.2.2.4. Lean UX Canvas](#1224-lean-ux-canvas)
  - [1.3. Segmentos objetivo](#13-segmentos-objetivo)
    - [Segmento: Adultos Mayores](#segmento-adultos-mayores)
    - [Segmento: Cuidadores de adultos mayores, familiares y personal de salud](#segmento-cuidadores-de-adultos-mayores-familiares-y-personal-de-salud)
- [Capítulo II: Requirements Elicitation \& Analysis](#capítulo-ii-requirements-elicitation--analysis)
  - [2.1. Competidores](#21-competidores)
    - [2.1.1. Análisis competitivo](#211-análisis-competitivo)
    - [2.1.2. Estrategias y tácticas frente a competidores](#212-estrategias-y-tácticas-frente-a-competidores)
  - [2.2. Entrevistas](#22-entrevistas)
    - [2.2.1. Diseño de entrevistas](#221-diseño-de-entrevistas)
    - [2.2.2. Registro de entrevistas](#222-registro-de-entrevistas)
    - [2.2.3. Análisis de entrevistas](#223-análisis-de-entrevistas)
  - [2.3. Needfinding](#23-needfinding)
    - [2.3.1. User Personas](#231-user-personas)
    - [2.3.2. User Task Matrix](#232-user-task-matrix)
    - [2.3.3. User Journey Mapping](#233-user-journey-mapping)
    - [2.3.4. Empathy Mapping](#234-empathy-mapping)
  - [2.4. Big Picture EventStorming](#24-big-picture-eventstorming)
  - [2.5. Ubiquitous Language](#25-ubiquitous-language)
- [Capítulo III: Requirements Specification](#capítulo-iii-requirements-specification)
  - [3.1. User Stories](#31-user-stories)
    - [Epic Stories](#epic-stories)
  - [3.2. Impact Mapping](#32-impact-mapping)
  - [3.3. Product Backlog](#33-product-backlog)
- [Capítulo IV: Solution Software Design](#capítulo-iv-solution-software-design)
  - [4.1. Strategic-Level Domain-Driven Design](#41-strategic-level-domain-driven-design)
    - [4.1.1. Design-Level EventStorming](#411-design-level-eventstorming)
      - [4.1.1.1. Candidate Context Discovery](#4111-candidate-context-discovery)
      - [4.1.1.2. Domain Message Flows Modeling](#4112-domain-message-flows-modeling)
      - [4.1.1.3. Bounded Context Canvases](#4113-bounded-context-canvases)
    - [4.1.2. Context Mapping](#412-context-mapping)
    - [4.1.3. Software Architecture](#413-software-architecture)
      - [4.1.3.1. Software Architecture System Landscape Diagram](#4131-software-architecture-system-landscape-diagram)
      - [4.1.3.2. Software Architecture Context Level Diagrams](#4132-software-architecture-context-level-diagrams)
      - [4.1.3.3. Software Architecture Container Level Diagrams](#4133-software-architecture-container-level-diagrams)
      - [4.1.3.4. Software Architecture Deployment Diagrams](#4134-software-architecture-deployment-diagrams)
  - [4.2. Tactical-Level Domain-Driven Design](#42-tactical-level-domain-driven-design)
    - [4.2.1. Bounded Context: IAM](#421-bounded-context-iam)
      - [4.2.1.1. Domain Layer](#4211-domain-layer)
      - [4.2.1.2. Interface Layer](#4212-interface-layer)
      - [4.2.1.3. Application Layer](#4213-application-layer)
      - [4.2.1.4. Infrastructure Layer](#4214-infrastructure-layer)
      - [4.2.1.5. Bounded Context Software Architecture Component Level Diagrams](#4215-bounded-context-software-architecture-component-level-diagrams)
      - [4.2.1.6. Bounded Context Software Architecture Code Level Diagrams](#4216-bounded-context-software-architecture-code-level-diagrams)
        - [4.2.1.6.1. Bounded Context Domain Layer Class Diagrams](#42161-bounded-context-domain-layer-class-diagrams)
        - [4.2.1.6.2. Bounded Context Database Design Diagram](#42162-bounded-context-database-design-diagram)

- [Conclusiones](#Conclusiones)
- [Bibliografía](#Bibliografía)
- [Anexos](#Anexos)
 
---
 
# Student Outcome
 <table border="1" style="border-collapse: collapse; width: 100%; font-family: sans-serif; font-size: 14px;">
    <thead>
        <tr style="background-color: #f2f2f2; text-align: left;">
            <th style="padding: 10px; width: 25%;">Criterio específico</th>
            <th style="padding: 10px; width: 50%;">Acciones realizadas</th>
            <th style="padding: 10px; width: 25%;">Conclusiones</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style="padding: 10px;"><strong>Trabaja en equipo para proporcionar liderazgo en forma conjunta</strong></td>
            <td style="padding: 10px;">
                <p><strong>Ariana Agreda</strong><br> <strong>TB1:</strong><br>
                Durante el desarrollo del proyecto, asumí el liderazgo en la definición y validación del problema. Al encargarme del Lean UX Process y el Needfinding (elaborando los User Personas, Empathy Mapping y Journey Mapping), tomé la iniciativa de guiar al equipo en la comprensión profunda del usuario. Esto permitió sentar bases sólidas para el Startup y Solution Profile, orientando las decisiones del equipo hacia una solución con verdadero valor.</p>
                <p><strong>Fabiola Saldaña</strong><br> <strong>TB1:</strong><br>
                Lideré el modelado estratégico del dominio al dirigir las dinámicas de Big Picture y Design-Level EventStorming. A través del descubrimiento de Candidate Contexts y el modelado de flujos, tomé la responsabilidad de unificar la visión de negocio con el diseño técnico, guiando a mis compañeros en la toma de decisiones conjuntas sobre la arquitectura del sistema.</p>
                <p><strong>Claudia Belledonne</strong><br> <strong>TB1:</strong><br>
                Asumí el liderazgo técnico en el diseño de la Arquitectura de Software utilizando el modelo C4 (Landscape, Context, Container, Deployment). Además, dirigí el análisis competitivo y el diseño de entrevistas. Mi liderazgo se enfocó en proveer directrices arquitectónicas claras, asegurando que las propuestas de desarrollo fueran escalables y competitivas.</p>
                <p><strong>Mauricio Elera</strong><br> <strong>TB1:</strong><br>
                Lideré la implementación del Tactical-Level Domain-Driven Design. Mi responsabilidad principal fue traducir los requerimientos estratégicos a nivel de código y diseño de base de datos. Orienté al equipo técnico definiendo la estructuración en capas (Domain, Application, Infrastructure) y elaborando los diagramas de clases, garantizando estándares técnicos de alta calidad.</p>
                <p><strong>Diego Vilca</strong><br> <strong>TB1:</strong><br>
                Actué como líder en la gestión del producto y especificación de requerimientos. Al estructurar el Product Backlog, redactar las User Stories y elaborar el Impact Mapping y Context Mapping, proporcioné al equipo una dirección clara sobre el alcance del proyecto, asegurando que las prioridades de desarrollo estuvieran correctamente alineadas.</p>
            </td>
            <td style="padding: 10px; vertical-align: top;"> <strong>TB1:</strong><br>
                Como equipo, demostramos un liderazgo distribuido y complementario donde cada integrante asumió el control de su área de especialidad. Esta autonomía coordinada permitió que las decisiones estratégicas de UX, gestión de producto y arquitectura técnica se integraran orgánicamente. El liderazgo conjunto evidenció una madurez profesional que garantizó la viabilidad y robustez del diseño del proyecto.
            </td>
        </tr>
                <tr>
            <td style="padding: 10px;"><strong>Crea un entorno colaborativo e inclusivo, establece metas, planifica tareas y cumple objetivos.</strong></td>
            <td style="padding: 10px;">
                <p><strong>Ariana Agreda</strong><br> <strong>TB1:</strong><br>
                Para fomentar la colaboración, socialicé activamente los hallazgos del Lean UX Process con todo el equipo. Planifiqué las metas de validación estructurando los Problem y Hypothesis Statements, asegurándome de que todos los miembros comprendieran los antecedentes y la problemática, manteniendo un entorno donde las ideas de todos enriquecieran el diseño de la solución.</p>
                <p><strong>Fabiola Saldaña</strong><br> <strong>TB1:</strong><br>
                Garantice un entorno inclusivo al facilitar los talleres de EventStorming, promoviendo la participación equitativa de todos los integrantes. Planifiqué estas dinámicas para poder definir los segmentos objetivos y los Bounded Context Canvases de manera consensuada, logrando cumplir con el hito de alineación entre negocio y tecnología.</p>
                <p><strong>Claudia Belledonne</strong><br> <strong>TB1:</strong><br>
                Trabajé de la mano con el equipo para analizar las entrevistas de forma conjunta. Al diseñar los diagramas de arquitectura, planifiqué reuniones de retroalimentación para asegurar que los modelos C4 integraran los requerimientos de todos, cumpliendo con el objetivo de entregar una arquitectura coherente y bien documentada.</p>
                <p><strong>Mauricio Elera</strong><br> <strong>TB1:</strong><br>
                Apoyé activamente la recopilación de información mediante el registro detallado de entrevistas, asegurando que todo el equipo tuviera acceso transparente a los datos. En la planificación de mis tareas de Tactical DDD, coordiné constantemente con arquitectura para cumplir los objetivos de diseño de software en los tiempos establecidos, ajustando componentes de manera iterativa.</p>
                <p><strong>Diego Vilca</strong><br> <strong>TB1:</strong><br>
                Impulsé la colaboración creando el Ubiquitous Language, lo que estandarizó nuestra comunicación interna y evitó ambigüedades. Planifiqué las iteraciones organizando las tareas en el Product Backlog, estableciendo metas claras de cumplimiento para cada integrante, lo que fue clave para presentar los entregables a tiempo.</p>
            </td>
            <td style="padding: 10px; vertical-align: top;"> <strong>TB1:</strong><br>
                Logramos consolidar un entorno de trabajo altamente estructurado e inclusivo. La creación de un Lenguaje Ubicuo común, la comunicación constante de los hallazgos de UX y la rigurosa planificación mediante el Product Backlog y diagramas técnicos, nos permitieron cumplir con todos los objetivos e hitos del proyecto de manera eficiente, cohesionada y sin retrasos.
            </td>
        </tr>
    </tbody>
</table>
 
---
 
# Capítulo I: Introducción
 
## 1.1. Startup Profile
 
### 1.1.1. Descripción de la Startup

Somos un equipo de estudiantes de Ingeniería de Software de la UPC, unidos por la convicción de que la tecnología sólo tiene sentido cuando se pone al servicio de la humanidad. Nos define una profunda pasión por la innovación y un compromiso genuino con el bienestar social. Nuestra startup nace con el propósito de utilizar las herramientas digitales no sólo para optimizar procesos, sino para transformar realidades y proteger lo que más importa: la vida y la tranquilidad de las familias.

Nuestra visión se centra en darle una voz y seguridad a quienes muchas veces quedan olvidados por el ritmo acelerado de la modernidad. Buscamos romper la barrera de la soledad y la vulnerabilidad, transformando la tecnología en un acompañante silencioso pero vigilante. Creemos firmemente que la innovación debe ser inclusiva y empática, permitiendo que las personas de la tercera edad mantengan su independencia mientras sus seres queridos recuperan la paz mental.

Misión
Desarrollar soluciones tecnológicas accesibles y humanas que garanticen una respuesta inmediata ante emergencias geriátricas, priorizando siempre la dignidad y la autonomía de los adultos mayores.

Visión
Consolidarnos como la plataforma de cuidado preventivo más confiable de la región, siendo reconocidos por nuestra capacidad de conectar a las personas a través de la innovación y el compromiso social.

 
### 1.1.2. Perfiles de integrantes del equipo


<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/ariana.png"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>Ariana Agreda - u202315044</strong></p>
          <p align="justify">
            Mi nombre es Ariana Agreda, tengo 19 años y soy estudiante del 7mo ciclo de Ingeniería de Software en la UPC. Me considero una persona creativa, responsable y comprometida con cada tarea. Por ello, estoy dispuesta a dedicar un gran esfuerzo y apoyo para que logremos los mejores resultados para el proyecto.
          </p>
    </td>
  </tr>
</table>

<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/claudia.png"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>Claudia Belledonne - u202210259</strong></p>
          <p align="justify">
            Mi nombre es Claudia Belledonne, tengo 21 años y me encuentro en mi cuarto año de Ingeniería de Software en la UPC.
            En general, soy alguien creativa, responsable, dedicada y manejo bien el hacer muchas tareas a la vez.
            Para este trabajo, me comprometo a brindar mi máximo esfuerzo y dedicación.
          </p>
    </td>
  </tr>
</table>

<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/mauricio.png"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>Mauricio Elera - u202313702</strong></p>
          <p align="justify">
            Mi nombre es Mauricio Elera, tengo 19 años y soy estudiante del 7mo ciclo de Ingeniería de Software en la UPC. Me considero una persona proactiva, organizada y con muchas ganas de aprender. Estoy comprometido con el trabajo en equipo y dispuesto a aportar todo lo necesario para que nuestro proyecto sea exitoso.
          </p>
    </td>
  </tr>
</table>

<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/diego.png"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>Diego Vilca - u20231a778</strong></p>
          <p align="justify">
             Estudio la carrera de Ingeniería de Software, tengo 20 años y actualmente me encuentro cursando el 7mo ciclo de dicha carrera. Tengo conocimientos en C++, C#, Python, Java, HTML, CSS, JavaScript y Vue. Me considero una persona con responsabilidad, optimismo y honestidad, cualidades que considero fundamentales para una colaboración efectiva en equipo y un buen desarrollo en este proyecto.
          </p>
    </td>
  </tr>
</table>
<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/fabiola.png"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>Fabiola Saldaña - u202313773</strong></p>
          <p align="justify">
             Mi nombre es Fabiola Saldaña, tengo 20 años y actualmente curso el 7mo ciclo de la carrera de Ingeniería de Software. En lo personal busco aprender constantemente y me considero alguien responsable, proactiva y dedicada con mis trabajos. Es por ello que me comprometo apoyar al equipo con mis habilidades y conocimientos para alcanzar los mejores resultados.
          </p>
    </td>
  </tr>
</table>
 
## 1.2. Solution Profile
 
### 1.2.1. Antecedentes y problemática

<table>
    <tr>
      <td rowspan="2"><strong>What</strong></td>
      <td>¿Cuál es el problema?</td>
      <td>El problema central es la alta vulnerabilidad y pérdida de autonomía en adultos mayores debido a problemas de movilidad y fragilidad física. Al quedar bajo el cuidado de otros, se genera una dependencia crítica; sin embargo, el riesgo real se inicia cuando los cuidadores (familiares o enfermeros) no pueden estar físicamente presentes. En esos momentos, cualquier accidente se convierte en una crisis que nadie puede detectar a tiempo.
</td>
    </tr>
    <tr>
      <td>¿Cuál es la relación con la persona en cuestión?</td>
      <td>La relación es de dependencia y urgencia médica. Ante una caída, el cuerpo de un adulto mayor sufre daños graves (como fracturas de cadera o traumatismos) que requieren transporte inmediato a un centro clínico. El dilema es que, si no hay nadie al lado, el tiempo de respuesta es nulo, lo que agrava drásticamente el pronóstico de salud. Foll entra como ese "vigilante virtual" que conecta al paciente con su red de apoyo cuando la presencia física falla.</td>
    </tr>
    <tr>
      <td rowspan="2"><strong>When</strong></td>
      <td>¿Cuándo sucede el problema?</td>
      <td>El problema es latente y totalmente impredecible; puede ocurrir en cualquier momento del día o la noche, sin importar cuántas medidas de prevención se tomen. El factor crítico es que, una vez ocurre el accidente, el margen para actuar y salvar la movilidad del paciente es sumamente corto.</td>
    </tr>
    <tr>
      <td>¿Cuándo utiliza el cliente el producto?</td>
      <td>El ecosistema se activa de forma simultánea: el dispositivo IoT monitorea 24/7 de manera pasiva, pero el cliente (cuidador familiar o personal de enfermería) interactúa intensamente con la solución en el segundo exacto en que ocurre la caída y se dispara la notificación de alerta, permitiendo una reacción inmediata.</td>
    </tr>
    <tr>
      <td rowspan="2"><strong>Where</strong></td>
      <td>¿Dónde está el cliente cuando utiliza el producto?</td>
      <td>Gracias a la conectividad en la nube, el responsable del adulto mayor puede estar en cualquier parte del mundo (en el trabajo, viajando o en su propio hogar) y aun así tener el control total para actuar, ya sea despachando una ambulancia, contactando a un vecino o acudiendo él mismo al lugar del incidente. Solo requiere acceso a internet.</td>
    </tr>
    <tr>
      <td>¿A dónde se dirige?</td>
      <td>La solución se dirige hacia la implementación de un modelo de rescate práctico y ágil. El objetivo es eliminar la sobrecarga de información innecesaria y procesos lentos, para que el flujo desde la detección hasta el auxilio médico sea lo más directo y efectivo posible.</td>
    </tr>
    <tr>
      <td rowspan="3"><strong>Who</strong></td>
      <td>¿Quiénes están involucrados?</td>
      <td>El ecosistema involucra a dos actores principales: los adultos mayores, quienes son los usuarios que portan el dispositivo físico; y los cuidadores (familiares o profesionales), quienes gestionan las alertas mediante la aplicación.</td>
    </tr>
    <tr>
      <td>¿A quiénes les sucede el problema?</td>
      <td>Principalmente a los adultos mayores que enfrentan el riesgo físico de caer, pero también a sus cuidadores, quienes sufren un desgaste emocional y psicológico debido a la preocupación constante y el miedo de que un accidente ocurra mientras ellos no están presentes.</td>
    </tr>
    <tr>
      <td>¿Quién lo utiliza?</td>
      <td>La solución es un ecosistema compartido: los mayores usan el hardware (discreto y cómodo), los apoderados gestionan las alertas de uno o varios pacientes desde el móvil con la aplicación o desde la computadora con la plataforma web.</td>
    </tr>
    <tr>
      <td><strong>Why</strong></td>
      <td>¿Cuál es la causa del problema?</td>
      <td>La causa raíz es la falta de presencia constante de los cuidadores. Debido a compromisos laborales, sociales o familiares, es imposible estar físicamente al cuidado del adulto mayor el 100% del tiempo. Esto genera una inquietud constante sobre la seguridad del ser querido y la necesidad de una herramienta que actúe inmediatamente cuando el factor humano no está disponible.</td>
    </tr>
    <tr>
      <td rowspan="4"><strong>How</strong></td>
      <td>¿En qué condiciones nuestros clientes usan el producto?</td>
      <td>Se utiliza en entornos que exigen alta confiabilidad y rapidez, como hogares privados o centros geriátricos. El producto está diseñado para ser accesible, adaptable a diferentes perfiles de pacientes y, sobre todo, para brindar una comodidad que no interfiera con la vida diaria del usuario.</td>
    </tr>
    <tr>
      <td>¿Cómo nos conocieron nuestros compradores?</td>
      <td>Principalmente mediante las recomendaciones de otros familiares o amigos que pasaron por situaciones similares. También a través de canales de difusión entre residencias geriátricas.</td>
    </tr>
    <tr>
      <td>¿Cómo prefieren nuestros consumidores acceder a nuestro producto?</td>
      <td>Para flexibilidad de los cuidadores se implementa la versión app móvil, ya que proporciona una flexibilidad e inmediatez al tener el dispositivo a la mano; y también una plataforma web, en caso estos estén constantemente en labores de oficina.</td>
    </tr>
    <tr>
      <td>¿Qué llevó a la persona a esa situación?</td>
      <td>La necesidad imperativa de garantizar la seguridad de sus seres queridos sin sacrificar su propia vida laboral o personal, buscando eliminar la ansiedad de "qué pasará si no estoy ahí" mediante una supervisión tecnológica inteligente.</td>
    </tr>
<tr>
  <td><strong>How Much</strong></td>
  <td>¿Qué tanto afecta el problema y cuánto cuesta no actuar?</td>
  <td>
    En el Perú, las caídas representan una de las principales causas de morbilidad en adultos mayores. Según el Ministerio de Salud, estos eventos son más frecuentes en personas mayores de 70 años y pueden ocasionar fracturas, hospitalizaciones y pérdida de autonomía (Minsa, 2026). Estudios realizados en Lima indican que aproximadamente 1 de cada 3 adultos mayores atendidos en servicios de salud ha sufrido al menos una caída en el último año, con consecuencias físicas, emocionales y funcionales significativas (Castillo Paulino, 2024). El costo de atención por una caída con fractura en hospitales de nivel III puede superar los S/ 8,000 - S/ 20,000, considerando hospitalización, cirugía, medicamentos y rehabilitación, lo que genera una carga económica importante para familias y aseguradoras (SUSALUD, 2024). La evidencia nacional coincide con el principio de la “Hora Dorada”: una atención rápida reduce complicaciones, mortalidad y secuelas. En adultos mayores peruanos, el riesgo de mortalidad post‑trauma es considerablemente mayor que en adultos jóvenes, especialmente en lesiones de cadera y cráneo (Castillo Paulino, 2024). En este contexto, soluciones como Foll permiten reducir tiempos de respuesta, evitar complicaciones y disminuir los costos asociados a hospitalización prolongada y rehabilitación tardía.
  </td>
</tr>

</tr>

</table>
 
### 1.2.2. Lean UX Process
 
#### 1.2.2.1. Lean UX Problem Statements

Nuestro servicio ofrece una plataforma digital integral para el cuidado a distancia de adultos mayores, permitiendo que sus cuidadores principales estén alerta ante accidentes que puedan ocurrir con sus familiares o pacientes, permitiéndoles actuar con la mayor prontitud posible.

Hemos observado que un factor crítico en el cuidado geriátrico es la necesidad de una presencia física constante. Sin embargo, esta supervisión 24/7 no es una realidad para muchas personas que, a pesar de querer cuidar a sus seres queridos, deben atender responsabilidades laborales, reuniones, viajes o simplemente no pueden estar presentes el 100% del tiempo. Esta falta de monitoreo continuo causa que, ante una caída accidental, el tiempo de auxilio sea demasiado prolongado, derivando en complicaciones médicas graves o fatalidades evitables.

¿Cómo podríamos mejorar la detección y comunicación de incidentes para que los familiares y cuidadores responsables puedan actuar de inmediato, basándonos en la métrica de reducción del tiempo de respuesta ante emergencias y la disminución de falsas alarmas mediante el uso de inteligencia artificial?

 
#### 1.2.2.2. Lean UX Assumptions

**User Assumptions:**

**¿Quién es mi usuario?**
Nuestros usuarios se dividen en dos perfiles: el adulto mayor que porta el dispositivo IoT, y el cuidador (familiar o personal de enfermería) que requiere tranquilidad y alertas inmediatas para una gestión eficiente de emergencias.

**¿Dónde encaja nuestro producto en su trabajo o vida?**
Se integra de forma orgánica en la rutina del adulto mayor como un accesorio diario; en la vida del cuidador como una herramienta de supervisión remota vía smartphone o web.

**¿Qué problemas tiene nuestro producto que resolver?**
Principalmente la ausencia de supervisión 24/7, el temor al desamparo tras un accidente doméstico y la carencia de registros de movilidad precisos para diagnósticos preventivos.

**¿Cuándo y cómo es usado nuestro producto?**
Se utiliza de manera pasiva y constante mediante el monitoreo del dispositivo. Se activa críticamente ante un patrón de impacto o caída, disparando alertas automáticas a la App y Web.

**¿Qué características son importantes?**
La precisión del algoritmo de IA, la inmediatez de las notificaciones push, la autonomía de la batería y una interfaz clara que muestre información de emergencia (alergias, tipo de sangre, contactos) del paciente.

**¿Cómo debe verse nuestro producto y cómo debe comportarse?**
El hardware debe ser discreto, ergonómico y no estigmatizante. Las plataformas deben ser intuitivas, priorizando la urgencia y los pasos a seguir tras la alerta. 

**Business Assumptions:**

- Creemos que nuestros clientes necesitan una forma de monitorear a sus familiares sin invadir su privacidad y con la garantía de que serán alertados solo ante emergencias reales.
- Estas necesidades se pueden resolver mediante un dispositivo IoT con IA integrada y un ecosistema multiplataforma (Móvil/Web).
- Nuestros clientes primarios son familias con adultos mayores a cargo y centros de salud o residencias geriátricas.
- El valor fundamental que el cliente busca es la tranquilidad mental y la seguridad de un auxilio oportuno.


#### 1.2.2.3. Lean UX Hypothesis Statements

- **Creemos que** implementar un modelo de Inteligencia Artificial que filtre movimientos cotidianos logrará reducir las falsas alarmas. **Sabremos que tenemos éxito cuando** observemos una reducción del 80% en las notificaciones erróneas durante las pruebas de uso diario en entornos domésticos.
- **Creemos que** enviar alertas en tiempo real con geolocalización a los cuidadores (familiares o enfermeros) permitirá agilizar el auxilio médico. **Sabremos que tenemos éxito cuando** el tiempo promedio entre la detección de la caída y la confirmación de ayuda disminuya a menos de 20 minutos.
- **Creemos que** proporcionar un historial detallado de incidentes en la plataforma web permitirá a los cuidadores (familiares o enfermeros) monitorear el deterioro físico del adulto mayor. **Sabremos que tenemos éxito cuando** el 70% de los usuarios reporten que la información les permitió informar de manera precisa al médico tratante sobre patrones de riesgo durante las consultas de control.
- **Creemos que** ofrecer una interfaz intuitiva mejorará la adopción por parte de personas con poca experiencia tecnológica. **Sabremos que hemos tenido éxito cuando** al menos el 90% de los usuarios nuevos logren enviar la confirmación de ayuda en menos de 15 minutos desde que reciben la notificación de alerta.

#### 1.2.2.4. Lean UX Canvas

<table border="1" style="width: 100%">
 
  <tbody>
    <tr>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">Business Problem</strong><br>
          <ul><li>
        Las familias y centros de salud enfrentan dificultades para monitorear a adultos mayores 24/7. La falta de supervisión física constante genera una respuesta tardía ante caídas accidentales, lo que deriva en complicaciones graves o fallecimientos. Se requiere una solución que reduzca el tiempo de auxilio sin depender de la presencia humana permanente.
          </li></ul>
      </td>
      <td rowspan="3" valign="top" style="padding: 10px; border: 1px solid #ccc;">
        <strong style="color: #2c3e50;">Solutions</strong>
        <ul>
            <li><strong>Dispositivo IoT:</strong> Sensor discreto con acelerómetro y giroscopio.</li>
            <li><strong>Algoritmo:</strong> Análisis de patrones de movimiento para filtrar caídas reales de falsas alarmas.</li>
            <li><strong>App Móvil y Plataforma Web:</strong> Gestión de alertas en tiempo real con geolocalización, y visualización de historial de incidentes.</li>
        </ul>
      </td>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">Business Outcomes</strong>
        <ul>
            <li>Reducción del 80% en notificaciones de falsas alarmas.</li>
            <li>Disminución del tiempo de respuesta médica a menos de 20 minutos.</li>
            <li>Alcance de una tasa de adopción del 90% en usuarios nuevos.</li>
        </ul>
      </td>
    </tr>
    <tr></tr>
    <tr>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">User & Customers</strong>
        <ul>
            <li><strong>Adulto Mayor:</strong> Usuario final que busca independencia y seguridad.</li>
            <li><strong>Cuidadores (Familiares o Profesionales):</strong> Clientes que buscan tranquilidad y una herramienta eficiente para la gestión de emergencias y el seguimiento de la salud del adulto mayor.</li>
        </ul>
      </td>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">User Outcomes & Benefits</strong>
        <ul>
            <li>Eliminación de la ansiedad del cuidador al no estar presente.</li>
            <li>Acceso inmediato a información de emergencia (alergias, tipo de sangre).</li>
            <li>Detección temprana de deterioro físico mediante patrones de movilidad.</li>
            <li>Mayor autonomía para el adulto mayor en su hogar.</li>
        </ul>
      </td>
    </tr>
    <tr>
      <td rowspan="3" valign="top" style="padding: 10px; border: 1px solid #ccc;">
        <strong style="color: #2c3e50;">¿Qué es lo más importante que debemos aprender primero?</strong>
        <ul>
            <li>Comprender la precisión del algoritmo de IA al distinguir caídas críticas de actividades cotidianas (como sentarse bruscamente) en entornos reales.</li>
          <li>Evaluar el nivel de ergonomía y comodidad del dispositivo wearable para garantizar su uso prolongado sin causar rechazo en el adulto mayor.</li>
          <li>Analizar la disposición de los familiares a adoptar un modelo de suscripción mensual a cambio de seguridad y monitoreo en la nube.</li>
          <li>Investigar qué factores de usabilidad en la app móvil facilitan una reacción rápida del cuidador ante una notificación de emergencia.</li>
        </ul>
      </td>
    </tr>
    <tr>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">Hypotheses</strong><br>
          <ul>
          <li> Creemos que al automatizar la detección de caídas con IoT e IA, los familiares podrán reducir los tiempos de respuesta ante emergencias y mejorar la seguridad del adulto mayor.</li>
<li>Creemos que los cuidadores valorarán tener una única plataforma para consultar el historial de incidentes y visualizar patrones de riesgo para informar al médico tratante.</li>
<li> Creemos que al ofrecer un producto con hardware ergonómico e interfaz simple, incluso los usuarios con poca familiaridad tecnológica podrán adoptarlo rápidamente.</li>
<li> Creemos que el envío de alertas con geolocalización permitirá a los responsables actuar de manera más eficiente y necesaria ante un accidente.</li>
        </ul>
      </td>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">¿Cuál es la menor cantidad de trabajo para validar? </strong>
        <ul>
<li> Desarrollo de un prototipo con sensor básico conectado a Firebase.</li>
<li>App mínima que dispare una notificación push al detectar un impacto fuerte.</li>
<li>Simulaciones de caída controladas con 5 usuarios para validar la precisión inicial.</li>
<li>Landing page para medir el interés de compra de familiares.</li>
        </ul>
      </td>
    </tr>
    <tr></tr>
  </tbody>
</table>

 
## 1.3. Segmentos objetivo

### Segmento: Adultos Mayores

**Descripción del segmento:**
Personas de la tercera edad que residen de forma independiente o con supervisión parcial en entornos urbanos. Se caracterizan por valorar profundamente su autonomía y privacidad. Debido a procesos naturales de envejecimiento, presentan una mayor fragilidad física y riesgos de movilidad, lo que los hace vulnerables ante accidentes domésticos sin compañía.

**Características demográficas:**
- Edad: 65 a 85 años  
- Ubicación: Principalmente zonas urbanas  
- Nivel socioeconómico: Medio y medio-bajo  
- Nivel educativo: Variable (predominantemente educación básica o secundaria)
- Nivel tecnológico: Bajo a Medio (familiarizados con el uso básico de smartphones para comunicación por voz y WhatsApp).

**Características relevantes:**
- Conservan movilidad y autonomía en actividades diarias  
- Uso limitado o básico de tecnología  
- Preferencia por soluciones simples y no invasivas  
- Alta valoración de su independencia  

**Sustento estadístico:**
- Según el Ministerio de Salud (MINSA, 2026), las caídas más frecuentes en perssonas en mayores de 70 años en Lima.
- Según la Unidad Geriátrica de la Clínica Alemana (Clínica Alemana, 2018), el riesgo de caídas aumenta progresivamente con la edad. Se estima que alrededor del 30% de las personas mayores de 65 años experimenta al menos una caída al año, cifra que se incrementa hasta un 50% en aquellos que superan los 80 años.

### Segmento: Cuidadores de adultos mayores, familiares y personal de salud

**Descripción del segmento:**
Personas encargadas de la supervisión y bienestar del adulto mayor. Este segmento es híbrido: incluye a familiares directos (hijos o nietos) con responsabilidades laborales que les impiden estar presentes 24/7, y a cuidadores formales (enfermeros o técnicos en salud) que necesitan optimizar su labor de monitoreo.

**Características demográficas:**
- Edad: 20 a 60 años  
- Ubicación: Zonas urbanas  
- Nivel socioeconómico: Medio y medio-alto  
- Nivel educativo: Secundaria completa o superior
- Nivel tecnológico: Medio a Alto (usuarios intensivos de aplicaciones móviles y plataformas web para gestión de tareas y comunicación).

**Características relevantes:**
- Uso frecuente de smartphones y aplicaciones digitales  
- Responsabilidad emocional y/o económica sobre el adulto mayor  
- Limitaciones de tiempo debido a trabajo u otras responsabilidades  

**Sustento estadístico:**
- De acuerdo con SUSALUD (2024), el costo promedio de atención por una fractura de cadera derivada de una caída en Lima puede oscilar entre los S/ 8,000 y S/ 20,000, generando una carga económica crítica para las familias.
- Estudios de carga emocional indican que el 85% de los cuidadores familiares en entornos urbanos experimentan niveles altos de ansiedad debido a la sobrecargar de cuidar de varios adultos mayores a la vez (Cruz Méndez et al., 2025). 


 
# Capítulo II: Requirements Elicitation & Analysis
 
## 2.1. Competidores
En esta sección se identifican y describen los principales competidores (directos e indirectos) que ofrecen soluciones para la detección de caídas y monitoreo de adultos mayores. El mercado actual se divide entre dispositivos médicos tradicionales y tecnología de consumo masivo adaptada a la salud.

* **Competidor 1: Apple Watch (Competidor Indirecto)**
    El Apple Watch es un smartwatch de consumo masivo de la empresa Apple que incluye una función nativa de detección de caídas mediante sus acelerómetros y giroscopios integrados. Si detecta un impacto fuerte seguido de inmovilidad, emite alertas y puede contactar automáticamente a los servicios de emergencia (911) y a los contactos definidos. Su principal ventaja es que elimina por completo el estigma de "dispositivo para ancianos" por su diseño estético, pero presenta barreras de entrada por su alto costo inicial, la necesidad de estar integrado al ecosistema Apple y una autonomía de batería limitada (generalmente un día), lo que lo vuelve inviable para el monitoreo nocturno o continuo sin interrupciones.

* **Competidor 2: Philips Lifeline (Competidor Directo)**
    Es uno de los sistemas de alerta médica más tradicionales y reconocidos a nivel mundial. Su principal dispositivo es un colgante equipado con la tecnología AutoAlert, la cual detecta caídas y se comunica directamente con un centro de respuesta operado por humanos las 24 horas del día. Aunque goza de alta validación clínica y fiabilidad, su modelo de negocio se basa en suscripciones mensuales elevadas y su diseño de "botón de pánico" o colgante suele generar rechazo en adultos mayores independientes, quienes lo perciben como un elemento estigmatizante.

* **Competidor 3: Medical Guardian (Competidor Directo)**
    Empresa enfocada exclusivamente en el desarrollo de dispositivos wearables (relojes y colgantes, como el MGMini) para el cuidado y monitoreo de adultos mayores. Sus equipos cuentan con detección de caídas, GPS y botones de emergencia, conectándose de manera independiente a redes celulares sin requerir que el usuario posea un smartphone. Si bien es una solución integral y altamente funcional, sus costos de adquisición y tarifas de monitoreo mensual están diseñados principalmente para el mercado norteamericano, resultando poco accesibles para el mercado latinoamericano.
 
### 2.1.1. Análisis competitivo

<table border="1" style="width: 100%; font-size: 11px; table-layout: fixed; word-wrap: break-word; border-collapse: collapse;">
  <thead>
    <tr>
      <th colspan="6" style="padding: 5px; background-color: #f2f2f2;"><b>Competitive Analysis Landscape</b></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td colspan="2" align="center" style="padding: 5px;">¿Por qué llevar a cabo este análisis?</td>
      <td colspan="4" align="center" style="padding: 5px;">El objetivo de este análisis es evaluar cómo Foll se posiciona frente a soluciones comerciales y médicas de detección de caídas, identificando oportunidades para destacar mediante nuestra IA en el edge, ergonomía y control de falsas alarmas.</td>
    </tr>
    <tr>
      <td colspan="2" rowspan="2" valign="top" style="padding: 5px; width: 20%; background-color: #f9f9f9;"><b>Startup y Competidores</b></td>
      <td valign="top" align="center" style="padding: 5px; width: 20%; background-color: #f9f9f9;"><b>nanoTech</b></td>
      <td valign="top" align="center" style="padding: 5px; width: 20%; background-color: #f9f9f9;"><b>Apple Watch</b></td>
      <td valign="top" align="center" style="padding: 5px; width: 20%; background-color: #f9f9f9;"><b>Philips Lifeline</b></td>
      <td valign="top" align="center" style="padding: 5px; width: 20%; background-color: #f9f9f9;"><b>Medical Guardian</b></td>
    </tr>
    <tr>
      <td valign="top" align="center" style="padding: 5px;"><img src="img/competitors/nanotech-logo.png" alt="nanoTech Logo" height="60" /></td>
      <td valign="top" align="center" style="padding: 5px;"><img src="img/competitors/applewatch-logo.png" alt="Apple Watch Logo" height="60" /></td>
      <td valign="top" align="center" style="padding: 5px;"><img src="img/competitors/philips-lifeline-logo.jpg" alt="Philips Lifeline Logo" height="60" /></td>
      <td valign="top" align="center" style="padding: 5px;"><img src="img/competitors/medical-guardian-logo.png" alt="Medical Guardian Logo" height="60" /></td>
    </tr>
    <tr>
      <td rowspan="2" valign="top" style="padding: 5px; width: 8%;"><b>Perfil</b></td>
      <td valign="top" style="padding: 5px; width: 12%;">Overview</td>
      <td valign="top" style="padding: 5px;">Ecosistema IoT compuesto por un cinturón discreto con sensores de movimiento y Edge AI para la detección precisa de caídas en adultos mayores, conectado a una app móvil y web para cuidadores.</td>
      <td valign="top" style="padding: 5px;">Smartwatch de consumo masivo con funciones integradas de salud, que incluye algoritmo nativo de detección de caídas y llamadas automáticas de emergencia (SOS).</td>
      <td valign="top" style="padding: 5px;">Sistema clásico de alerta médica (tipo colgante) equipado con tecnología AutoAlert, respaldado por un centro de respuesta humano disponible 24/7.</td>
      <td valign="top" style="padding: 5px;">Dispositivos portátiles (relojes y botones) diseñados específicamente para el adulto mayor, enfocados en monitoreo GPS y alertas directas a redes de cuidado.</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Ventaja competitiva ¿Qué valor ofrece a los clientes?</td>
      <td valign="top" style="padding: 5px;">Reduce falsas alarmas gracias a su IA que aprende en servidor local (Edge), formato de cinturón cómodo, e incluye un switch físico inmediato para cancelar alertas erróneas.</td>
      <td valign="top" style="padding: 5px;">Dispositivo estéticamente deseable y no estigmatizante. Cuenta con un ecosistema robusto de monitoreo de salud integral.</td>
      <td valign="top" style="padding: 5px;">Confianza de marca médica establecida e integración directa con un Call Center humano para despachar ambulancias de inmediato.</td>
      <td valign="top" style="padding: 5px;">Batería de larga duración, conectividad independiente (sin smartphone) y diseño extremadamente simplificado para el usuario.</td>
    </tr>
    <tr>
      <td rowspan="2" valign="top" style="padding: 5px;"><b>Perfil de Marketing</b></td>
      <td valign="top" style="padding: 5px;">Mercado objetivo</td>
      <td valign="top" style="padding: 5px;">Adultos mayores en riesgo de caída y sus cuidadores que buscan una solución precisa, asequible y con gestión directa de emergencias.</td>
      <td valign="top" style="padding: 5px;">Público general y adultos mayores con afinidad tecnológica, o cuyos familiares los integran al ecosistema Apple.</td>
      <td valign="top" style="padding: 5px;">Adultos mayores frágiles, con alto riesgo de complicaciones, que viven solos y necesitan asistencia profesional garantizada.</td>
      <td valign="top" style="padding: 5px;">Adultos mayores activos o en casa, cuyos hijos/cuidadores necesitan tranquilidad a través del rastreo de ubicación.</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Estrategias de marketing</td>
      <td valign="top" style="padding: 5px;">Marketing digital apelando a la tranquilidad de familiares, y alianzas B2B con centros geriátricos locales.</td>
      <td valign="top" style="padding: 5px;">Marketing de consumo masivo, posicionamiento como artículo de estilo de vida y conectividad familiar ininterrumpida.</td>
      <td valign="top" style="padding: 5px;">Alianzas institucionales con hospitales y publicidad en canales tradicionales (TV, radio).</td>
      <td valign="top" style="padding: 5px;">SEO, marketing digital dirigido a cuidadores y alianzas con organizaciones de envejecimiento activo.</td>
    </tr>
    <tr>
      <td rowspan="3" valign="top" style="padding: 5px;"><b>Perfil de Producto</b></td>
      <td valign="top" style="padding: 5px;">Productos & Servicios</td>
      <td valign="top" style="padding: 5px;">Hardware (Cinturón IoT y switch), Edge Gateway (IA), App Móvil y Plataforma Web (historial).</td>
      <td valign="top" style="padding: 5px;">Apple Watch (hardware), App de Salud y conectividad con servicios de emergencia (911).</td>
      <td valign="top" style="padding: 5px;">Colgante con detección AutoAlert, Comunicador Base y Aplicación Cares para red familiar.</td>
      <td valign="top" style="padding: 5px;">MGMini (Smartwatch o colgante), Portal Web MyGuardian y centro de monitoreo propio.</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Precios & Costos</td>
      <td valign="top" style="padding: 5px;">Hardware accesible (sensores + switch) + suscripción mensual económica para plataforma web/app.</td>
      <td valign="top" style="padding: 5px;">Costo inicial elevado ($250-$400+ USD). Sin cuota mensual, pero requiere iPhone.</td>
      <td valign="top" style="padding: 5px;">Costo de activación y suscripción mensual elevada (aprox. $50 USD/mes).</td>
      <td valign="top" style="padding: 5px;">Dispositivo inicial ($150 USD aprox.) más suscripción mensual de monitoreo ($40-$50 USD).</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Canales de distribución (Web y/o Móvil) </td>
      <td valign="top" style="padding: 5px;">E-commerce (Web), descarga de App gratuita y convenios directos con residencias.</td>
      <td valign="top" style="padding: 5px;">Retailers masivos, operadoras móviles y tiendas oficiales Apple.</td>
      <td valign="top" style="padding: 5px;">Venta web, agentes telefónicos y distribuidores de suministros médicos.</td>
      <td valign="top" style="padding: 5px;">E-commerce y canales telefónicos orientados a consultoría familiar.</td>
    </tr>
    <tr>
      <td rowspan="4" valign="top" style="padding: 5px;"><b>Análisis SWOT</b></td>
      <td valign="top" style="padding: 5px;">Fortalezas</td>
      <td valign="top" style="padding: 5px;">IA local (Edge) que filtra falsos positivos. Hardware discreto. Switch físico da control para evitar pánico.</td>
      <td valign="top" style="padding: 5px;">Marca prestigiosa. Hardware de alta calidad. Libre del estigma de "dispositivo médico".</td>
      <td valign="top" style="padding: 5px;">Fiabilidad médica comprobada. Algoritmo AutoAlert estudiado. Respuesta humana 24/7.</td>
      <td valign="top" style="padding: 5px;">Ecosistema 100% para la usabilidad del adulto mayor. Independencia total de otros smart devices.</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Debilidades</td>
      <td valign="top" style="padding: 5px;">Marca nueva sin validación clínica inicial. Requiere educar sobre el uso del Edge Gateway.</td>
      <td valign="top" style="padding: 5px;">Batería dura 1 día. Curva de aprendizaje tecnológica alta para el adulto mayor.</td>
      <td valign="top" style="padding: 5px;">Diseño en forma de botón/colgante genera estigma. Costo recurrente alto.</td>
      <td valign="top" style="padding: 5px;">Tarifas mensuales elevadas. Menor reconocimiento de marca fuera de Norteamérica.</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Oportunidades</td>
      <td valign="top" style="padding: 5px;">Mercado desatendido en Latam. Alta introducción de smartphones en cuidadores buscando opciones económicas.</td>
      <td valign="top" style="padding: 5px;">Mayor alfabetización digital en nuevas generaciones. Funciones de salud preventivas.</td>
      <td valign="top" style="padding: 5px;">Integración con sistemas de salud pública o seguros privados para subsidios.</td>
      <td valign="top" style="padding: 5px;">Expansión a mercados latinoamericanos y alianzas con domótica (Smart Home).</td>
    </tr>
    <tr>
      <td valign="top" style="padding: 5px;">Amenazas</td>
      <td valign="top" style="padding: 5px;">Reducción de precios en Smartwatches genéricos. Resistencia inicial a usar un cinturón adicional.</td>
      <td valign="top" style="padding: 5px;">Wearables chinos de bajo costo (Xiaomi, Amazfit) incluyendo detección de caídas.</td>
      <td valign="top" style="padding: 5px;">Canibalización por dispositivos más invisibles (Smart Rings, ropa inteligente).</td>
      <td valign="top" style="padding: 5px;">Quejas de usuarios por la retención en los modelos de suscripción.</td>
    </tr>
  </tbody>
</table>

### 2.1.2. Estrategias y tácticas frente a competidores

Para asegurar la viabilidad y introducción de **Foll** en el mercado, se han definido las siguientes estrategias y tácticas preliminares, diseñadas para contrarrestar las fortalezas de la competencia y capitalizar sus debilidades, considerando nuestro contexto tecnológico de Edge AI e IoT:

**Estrategias para afrontar las fortalezas de la competencia:**
* **Frente a la alta precisión médica (Philips Lifeline):** Se aprovechará el procesamiento local (Edge Gateway) para que la Inteligencia Artificial de Foll aprenda de los patrones de movimiento específicos de cada usuario en su propio hogar. Esta táctica permite igualar e incluso superar la precisión de los algoritmos estáticos de la competencia, al adaptar el sistema a la biomecánica única del paciente.
* **Frente a la estética y deseabilidad (Apple Watch):** En lugar de competir creando una pantalla costosa, la estrategia será la **invisibilidad del hardware**. Foll se diseñará como un cinturón o accesorio imperceptible bajo la ropa, evitando la resistencia psicológica del usuario y el estigma social de llevar un "botón de auxilio" visible.

**Tácticas para aprovechar las debilidades de la competencia:**
* **Contra las falsas alarmas y la pérdida de control:** Dispositivos como el Apple Watch pueden asustar al usuario al iniciar conteos regresivos ruidosos para llamar al 911. La táctica de Foll es la inclusión de un **switch físico e intuitivo** en el cinturón que permite al adulto mayor cancelar inmediatamente una alerta falsa (por ejemplo, al sentarse bruscamente), empoderándolo y evitando el estrés innecesario a sus cuidadores.
* **Contra los altos costos y modelos de retención:** Ante las elevadas suscripciones de Philips y Medical Guardian, Foll implementará una táctica de penetración de mercado con hardware de bajo costo (sensores básicos de acelerometría pero lo suficientemente buenos como para que la IA se alimente de datos más precisos) y un modelo de suscripción mensual altamente asequible enfocado en el uso de la plataforma en la nube y la app, democratizando el acceso a esta tecnología para familias de ingresos medios.
* **Contra la baja autonomía de batería:** Al no requerir pantallas táctiles a color ni conexión LTE constante en el wearable (ya que el procesamiento fuerte se delega al Edge Gateway en la casa), Foll garantizará una duración de batería de varios días, asegurando la protección durante las madrugadas, momento crítico donde los smartwatches suelen estar cargándose.

**Abordaje de Oportunidades y Amenazas:**
* **Oportunidad (Alta penetración móvil en cuidadores):** Se focalizarán las campañas de marketing hacia los hijos o familiares responsables (cuidadores), destacando la app móvil de Foll como una herramienta que les devuelve la "tranquilidad y libertad" durante sus jornadas laborales, capitalizando su familiaridad con la gestión de servicios vía smartphone.
* **Amenaza (Wearables genéricos de bajo costo):** Para evitar ser desplazados por pulseras inteligentes chinas que incorporen detección de caídas genérica, la táctica defensiva será centrar la propuesta de valor en el **historial clínico y los patrones de riesgo** que la IA de Foll ofrece en la plataforma web, proporcionando datos invaluables para los médicos geriatras, algo que una pulsera deportiva no entrega.
 
## 2.2. Entrevistas
 
### 2.2.1. Diseño de entrevistas

<strong>Segmento objetivo 1: Adultos mayores</strong><br>
- ¿Alguna vez ha tenido un tropiezo o una caída estando solo en casa o fuera de ella? Si la respuesta es sí: ¿Qué ocurrió exactamente y qué fue lo más difícil de ese momento?
- ¿Hay actividades que evita realizar cuando está solo por miedo a resbalar o caer?
- En caso de ocurrirle un accidente como caerse, ¿Tiene forma de contactarse con sus familiares o pedir ayuda?
- Si tuviera que usar un sensor pequeño todos los días por su seguridad, ¿en qué parte del cuerpo le resultaría más cómodo y fácil de olvidar que lo lleva puesto?
- Entre las siguientes opciones, ¿cuál prefiere?: ¿En el cinturón o la cintura, como un collar, como una pulsera, o fijado a la pierna?
- ¿Hay algún tipo de accesorio que definitivamente rechazaría usar porque le resulta incómodo para dormir, para sentarse, o para alguna otra actividad?
- ¿Se sentiría cómodo usando este dispositivo sabiendo que no lo está grabando ni vigilando, sino que procesa sus movimientos de forma privada y solo avisa a su familia o persona responsable si ocurre una emergencia real? 
<br><br>

<strong>Segmento objetivo 2 : Cuidadores de adultos mayores</strong><br>

- ¿Cuál es su relación con el adulto mayor y cuántas horas al día suele pasar esta persona sin supervisión presencial?
- ¿Alguna vez han vivido la situación angustiante en la que su familiar sufre una caída estando solo y nadie se entera de inmediato?
- Si la respuesta es sí: ¿Cuánto tiempo pasó hasta que se dieron cuenta o recibieron ayuda, y cómo impactó ese evento en la confianza de ambos al estar solos en casa?
- Sabiendo que este dispositivo detecta caídas automáticamente y alerta en tiempo real, ¿por qué medio preferiría recibir esa notificación para reaccionar lo más rápido posible (por ejemplo, un SMS inmediato, una llamada automática o una notificación en una aplicación)?
- A diferencia de los "botones de pánico" tradicionales, este sistema actúa solo sin que el adulto mayor deba hacer nada si se encuentra aturdido. ¿Qué tanto valor (del 1 al 10) le ve a esta automatización para su tranquilidad mental diaria?
- El monitoreo constante puede generar preocupación por la privacidad. ¿Le da tranquilidad saber que el dispositivo procesa los datos localmente, evitando enviar información personal a través de redes inseguras?
- En un futuro, ¿estaría dispuesto a permitir que los datos de movimiento se usen de forma completamente anónima para entrenar y mejorar la precisión de la inteligencia artificial del dispositivo?

<br>
 
### 2.2.2. Registro de entrevistas

<strong> Segmento objetivo 1: Adultos mayores</strong><br>

<strong>Entrevista #1</strong><br>
- Nombre completo: Domingo Valverde
- Edad: 84 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Bajo
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQCxJcHRe5V5R5pyQP0Q4l6cAXdU6jpPalqP63w-N8kiN9o?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=T5Cjbn
- Inicio: 0:00 s
- Fin: 4:23 s
<img width="500"  alt="image" src="img/entrevistas/entrevista1.png" />

<br><br>

<strong>Entrevista #2</strong><br>
- Nombre completo: Juan Valverde
- Edad: 62 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Bajo/Medio
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQCxJcHRe5V5R5pyQP0Q4l6cAXdU6jpPalqP63w-N8kiN9o?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=T5Cjbn
- Inicio: 4:24 s
- Fin: 8:08 s
<img width="500"  alt="image" src="img/entrevistas/entrevista2.png" />

<br><br>

<strong>Entrevista #3</strong><br>
- Nombre completo: Máximo Torres
- Edad: 87 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Bajo
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQCxJcHRe5V5R5pyQP0Q4l6cAXdU6jpPalqP63w-N8kiN9o?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=T5Cjbn
- Inicio: 8:09 s
- Fin: 15:28 s
<img width="500"  alt="image" src="img/entrevistas/entrevista3.png" />

<br><br>		



<strong>Segmento objetivo 2: Cuidadores de adultos mayores, familiares y personal de salud</strong><br>
<strong>Entrevista #1</strong><br>
- Nombre completo: Gabriel Zabala
- Edad: 27 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Medio/Alto
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQC5upcUmFlkR4SKz8NWKpaoAbT-efi8SR0IvHU82kzFRiI?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=dOgBBV
- Inicio: 0:00 s
- Fin: 2:54 s
<img width="500"  alt="image" src="img/entrevistas/entrevista4.png" />

<br><br>


<strong>Entrevista #2</strong><br>
- Nombre completo: Santiago Baldeón
- Edad: 19 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Medio/Alto
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQC5upcUmFlkR4SKz8NWKpaoAbT-efi8SR0IvHU82kzFRiI?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=dOgBBV
- Inicio: 2:54 s
- Fin: 5:53 s
<img width="500"  alt="image" src="img/entrevistas/entrevista5.png" />

<br><br>

<strong>Entrevista #3</strong><br>
- Nombre completo: Sergio Iglesias
- Edad: 20 años
- Relación con el adulto mayor: Familiar
- Ubicación: Lima Metropolitana
- Nivel tecnológico: Medio/Alto
- Enlace del video: https://upcedupe-my.sharepoint.com/:v:/g/personal/u202315044_upc_edu_pe/IQC5upcUmFlkR4SKz8NWKpaoAbT-efi8SR0IvHU82kzFRiI?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=dOgBBV
- Inicio: 5:53 s
- Fin: 9:10 s
<img width="500"  alt="image" src="img/entrevistas/entrevista6.png" />


 
### 2.2.3. Análisis de entrevistas

<strong>Segmento objetivo 1: Adultos mayores</strong><br>
- <strong>Contexto y perfil</strong><br>
Los tres entrevistados tienen entre 62 y 87 años y viven en condiciones de relativa independencia, aunque con momentos de soledad en casa o en la calle. Ninguno reportó una caída grave dentro del hogar, pero sí experiencias de tropiezos en exterior, y en un caso un accidente de moto con pérdida de conocimiento. Esto es relevante: el riesgo percibido no siempre coincide con el riesgo real, y los adultos mayores tienden a minimizar su vulnerabilidad. <br>
- <strong>Conciencia del riesgo: presente pero subestimada</strong><br>
Los tres reconocen cierto nivel de riesgo, aunque lo expresan con matices. Uno de ellos evita actividades físicas cuando está solo por miedo a caerse. Otro es más confiado en su condición física pese a sus 87 años. El tercero, con 62 años, admite que algunas tareas no pueden hacerse solo. En todos los casos existe una tensión entre el deseo de independencia y la conciencia de que algo podría pasar sin que nadie se enterase. Este es el punto emocional más importante del segmento: no es el miedo a caerse, sino el miedo a quedarse solo sin poder pedir ayuda.<br>
- <strong>Capacidad de pedir ayuda: el verdadero problema</strong><br>
Cuando se les preguntó si podrían contactar a alguien en caso de accidente, las respuestas revelaron una limitación real: el celular no siempre está al alcance de la mano. Uno mencionó explícitamente que "a veces no lo tiene a mano". Otro dependió de una desconocida en la calle para levantarse, y de vecinos para avisar a su familia. Esto valida directamente que un sistema pasivo, que no requiere que el adulto mayor haga nada, es más adecuado que cualquier botón o llamada manual.<br>
- <strong>Forma del dispositivo: pulsera como clara preferencia</strong><br>
Los tres señalaron la muñeca como la zona más cómoda para llevar el sensor, asociándolo naturalmente con un reloj o pulsera. El cinturón/cintura fue mencionado como segunda opción. El collar fue rechazado de forma unánime por incomodidad, especialmente para dormir. Este dato es directo y accionable para el diseño físico del dispositivo.<br>
<strong>Privacidad: sin barreras</strong><br>
Al igual que en el segmento de cuidadores, la privacidad no genera rechazo. Los tres aceptaron bien el concepto de un dispositivo que procesa datos localmente y solo alerta en emergencias reales. Uno de ellos incluso lo vinculó con valores comunitarios: la tecnología como extensión de la red de apoyo entre vecinos y familia.<br>
- <strong>Receptividad general: alta, pero con perfil de usuario que necesita simplicidad</strong><br>
La propuesta fue bien recibida por los tres. No hubo objeciones al concepto. Sin embargo, este segmento tiene menor familiaridad tecnológica, lo que implica que el onboarding y la configuración del dispositivo deben ser manejados por el cuidador o familiar, no por el adulto mayor. El adulto mayor solo necesita ponérselo, nada más.

<br><br>

<strong>Segmento objetivo 2: Cuidadores de adultos mayores, familiares y personal de salud:</strong><br>
- <strong>Contexto y perfil del segmento</strong><br>
Los tres entrevistados son jóvenes adultos (19–27 años) que cuidan a adultos mayores de la familia, principalmente abuelos. El tiempo que pasa el adulto mayor sin supervisión varía bastante: desde 2 horas hasta 6–8 horas diarias, lo que refleja distintos niveles de exposición al riesgo y distintas urgencias en cada hogar.<br>
- <strong>Problema validado: la caída como evento crítico no detectado</strong><br>
Los tres casos confirmaron haber vivido una situación angustiante relacionada con caídas. En todos los casos el patrón fue el mismo: la caída ocurrió estando el adulto mayor solo, y el cuidador se enteró tarde, ya sea al volver a casa o por intervención de un tercero. Los tiempos sin atención variaron entre 10 minutos y 6 horas. Este punto es clave: no es el miedo abstracto a una caída lo que motiva al segmento, sino la experiencia directa de haberla vivido y no haber podido actuar a tiempo.<br>
Un hallazgo importante es que los adultos mayores tienden a no reportar la caída por su cuenta, ya sea por orgullo, miedo a preocupar o, en casos como el del abuelo con Alzheimer, por incapacidad cognitiva. Esto refuerza directamente la propuesta de valor de un sistema automático que no dependa de la acción del adulto mayor.<br>
- <strong>Recepción del producto: alta valoración de la automatización</strong><br>
La característica más valorada fue que el sistema actúa solo, sin que el adulto mayor tenga que hacer nada. Los tres entrevistados reconocieron explícitamente que esto lo diferencia de un botón de pánico tradicional, que pierde utilidad precisamente en los escenarios más graves (caída con pérdida de conciencia, adulto mayor con demencia). Uno de los entrevistados llegó a señalar que los botones de pánico "no tienen sentido cuando hay una caída en la que ya no se puede interactuar", lo que valida directamente el core del producto.<br>
- <strong>Canal de notificación preferido</strong><br>
Hay consenso en que el canal preferido es la llamada telefónica o la notificación push, no los SMS. La razón es práctica: los jóvenes tienen el celular silenciado con frecuencia, y una llamada vibra de forma prolongada. Las notificaciones push también se consideran efectivas por su visibilidad inmediata. El SMS queda descartado como canal principal.<br>
- <strong>Privacidad y datos: barrera baja en este segmento</strong><br>
La preocupación por privacidad fue mínima en los tres casos. Todos indicaron que les parece bien que el dispositivo procese datos localmente, y también mostraron disposición a compartir datos de movimiento de forma anónima para mejorar el modelo. Esto simplifica decisiones de diseño y abre la puerta a estrategias de mejora continua del modelo de detección.<br>
- <strong>Feedback de producto: falsos positivos como punto de fricción</strong><br>
Un entrevistado señaló algo valioso: la necesidad de un mecanismo para descartar falsas alarmas, por ejemplo cuando el adulto mayor hace un movimiento brusco que no es una caída. Sugirió algo como un botón de "no pasa nada" en el dispositivo o en la app. Esto es un insight de UX relevante que debería considerarse en el diseño de la experiencia de alerta.


## 2.3. Needfinding
 
### 2.3.1. User Personas

A continuación, se presentará los 2 user persona de acuerdo al segmento objetivo encontrado:

<strong>Segmento #1 - Adultos mayores:</strong><br>
<img src="img/needfinding/userpersona1.png" width=800px>
<br><br>
<strong>Segmento #2 - Cuidadores de Adultos mayores:</strong><br>
<img src="img/needfinding/userpersona2.png" width=800px><br>
 
### 2.3.2. User Task Matrix

Para el análisis de las actividades críticas en el cuidado del adulto mayor, se han identificado tres segmentos clave: el Adulto Mayor, quien busca preservar su integridad física; y el Familiar Cuidador, responsable de la supervisión y respuesta inmediata.
A continuación, se presenta la matriz que evalúa la frecuencia e importancia de las tareas necesarias para cumplir estos objetivos de salud:
<br>

<table>
    <tr>
        <td>Task</td>
        <td>Segmento 1<br>Adulto Mayor</td>
        <td>Segmento 2<br>Cuidador</td>        
    </tr>
    <tr>
        <td></td>
        <td>Frecuencia / Importancia</td>
        <td>Frecuencia / Importancia</td>        
    </tr>
    <tr>
        <td>Mantener la integridad física durante los desplazamientos cotidianos</td>
        <td>Alta / Alta</td>
        <td>Alta / Alta</td>        
    </tr>
    <tr>
        <td>Verificar el estado de bienestar y seguridad personal</td>
        <td>Alta / Media</td>
        <td>Alta / Alta</td>        
    </tr>
    <tr>
        <td>Reaccionar ante caídas accidentales o impactos físicos críticos</td>
        <td>Baja / Alta</td>
        <td>Baja / Alta</td>        
    </tr>
    <tr>
        <td>Coordinar el protocolo de auxilio y traslado a centros médicos</td>
        <td>Baja / Alta</td>
        <td>Baja / Alta</td>        
    </tr>
    <tr>
        <td>Comunicar incidentes de pérdida de equilibrio o mareos leves</td>
        <td>Media / Alta</td>
        <td>Media / Alta</td>        
    </tr>
    <tr>
        <td>Documentar el historial de incidentes físicos para consultas médicas</td>
        <td>Media / Media</td>
        <td>Media / Alta</td>        
    </tr>
    <tr>
        <td>Identificar y mitigar riesgos de caídas en el entorno doméstico</td>
        <td>Baja / Media</td>
        <td>Media / Media</td>        
    </tr>
    <tr>
        <td>Gestionar la carga emocional y tranquilidad del entorno familiar</td>
        <td>Alta / Alta</td>
        <td>Alta / Alta</td>        
    </tr>
</table>

<strong>Tareas críticas:</strong> La integridad física y la tranquilidad emocional son las tareas más frecuentes y vitales para ambos segmentos, ya que garantizan autonomía para el mayor y paz mental para el cuidador.
<br><br>
<strong>Coincidencias:</strong> Ambos coinciden en la importancia alta de las tareas de emergencia (reacción y traslado); aunque su frecuencia es baja, su ejecución oportuna es fundamental para salvar vidas.
<br><br>
<strong>Diferencias:</strong> El registro de historial y la verificación de bienestar presentan la mayor brecha. El cuidador les asigna importancia alta por su rol de supervisión, mientras que el adulto mayor les otorga un nivel medio para evitar ser percibido como una carga o perder su independencia.

### 2.3.3. User Journey Mapping

A continuación, se presentan los User Journey Maps creados para cada perfil de usuario definido en nuestros dos segmentos objetivo. Estos mapas permiten visualizar la experiencia actual y los puntos críticos de dolor, fundamentando así el diseño de nuestro prototipo.

<strong>Segmento #1 - Adultos mayores:</strong><br>
<img src="img/needfinding/journey1.png" width=800px>
<br><br>
<strong>Segmento #2 - Cuidadores de Adultos mayores:</strong><br>
<img src="img/needfinding/journey2.png" width=800px><br>
 
### 2.3.4. Empathy Mapping

A continuación, se mostrarán los Empathy Mapping creados para cada perfil de usuario identificado en nuestros dos segmentos objetivo. Estos mapas nos ayudarán a comprender mejor a nuestros clientes y, así, optimizar la aplicación.

<strong>Segmento #1 - Adultos mayores:</strong><br>
<img src="img/needfinding/empathymap1.png" width=800px>
<br><br>
<strong>Segmento #2 - Cuidadores de Adultos mayores:</strong><br>
<img src="img/needfinding/empathymap2.png" width=800px><br>
 
## 2.4. Big Picture EventStorming
Para entender y plantear la lógica del proyecto, en grupo nos juntamos para definir las principales funcionalidades y flujos que tendría Foll. A continuación se mostrarán los pasos realizados para el Big Picture Eventstorming el cual es un primer acercamiento a nuestra solución. 

Url del Miro: <a href="https://miro.com/app/board/uXjVHfOJLLk=/?share_link_id=603482509922">https://miro.com/app/board/uXjVHfOJLLk=/?share_link_id=603482509922</a> 

<br>

<img src="img/eventstorming/big-picture/0.png" alt="Big Picture Event Storming" width="700"/>

**Eventos principales**
<img src="img/eventstorming/big-picture/1.png" alt="Big Picture Event Storming" width="700"/>

**Eventos en orden cronológico**
<img src="img/eventstorming/big-picture/2.1.png" alt="Big Picture Event Storming" width="700"/>
<img src="img/eventstorming/big-picture/2.2.png" alt="Big Picture Event Storming" width="700"/>

**Eventos con actores y sistemas externos**
<img src="img/eventstorming/big-picture/3.1.png" alt="Big Picture Event Storming" width="700"/>
<img src="img/eventstorming/big-picture/3.2.png" alt="Big Picture Event Storming" width="700"/>

## 2.5. Ubiquitous Language
 
A continuación, se presenta el lenguaje ubicuo que permite establecer un lenguaje común entre todos los miembros del equipo de desarollo y expertos de dominio. De esta manera, se reducen las malinterpretaciones y se mejora la comunicación entre todos los involucrados en el proyecto de software, asegurando que el software desarrollado sea realmente útil y relevante para el negocio.

* **Elderly Patient / Adulto Mayor:** La persona que lleva puesto el cinturón inteligente y a la que estamos protegiendo.
* **Caregiver / Cuidador:** El enfermero, médico o familiar que usa la aplicación para vigilar al adulto mayor y recibir sus alertas.
* **Medical Profile / Perfil Médico:** La ficha técnica con los datos de salud importantes del paciente (tipo de sangre, alergias, etc.).
* **Emergency Contacts / Contactos de Emergencia:** La lista de personas externas a las que el sistema llamará si el personal del asilo no responde rápido.
* **Pairing / Vinculación:** El paso donde le decimos al sistema: "Este cinturón físico específico le pertenece a este abuelito en particular".

* **Movement Data / Datos de Movimiento:** Los números exactos de fuerza e inclinación que el cinturón está sintiendo a cada segundo.
* **Possible Fall Event / Evento de Posible Caída:** Cuando el sistema siente un golpe fuerte, pero todavía estamos esperando para confirmar si fue una caída real o si solo se sentó de golpe.
* **Edge Processing / Procesamiento Local:** La "magia matemática" que ocurre directamente en las computadoras del asilo para decidir rapidísimo si hubo una caída, sin tener que esperar a que el internet responda.
* **False Positive / Falso Positivo:** Una falsa alarma. Ocurre cuando el cinturón detecta un golpe, pero el abuelito presiona el botón para decir "estoy bien".

* **Confirmed Fall / Caída Confirmada:** Una emergencia real. Es cuando el cinturón detectó una caída y nadie canceló la alarma a tiempo.
* **Verification Timer / Temporizador de Verificación:** Los segundos de "gracia" o cuenta regresiva que le damos al paciente para apagar la alarma antes de asustar a los enfermeros.
* **Help on the Way / Ayuda en Camino:** El mensaje que aparece cuando un enfermero ve la alerta en su celular y presiona "Yo me encargo de ir a revisarlo".
* **Fall History / Historial de Caídas:** El diario digital donde se guardan todos los tropiezos o caídas de un paciente para que el doctor los estudie después.

* **GPS Location / Ubicación GPS:** El punto exacto en el mapa donde se encuentra el adulto mayor al momento de la emergencia.
* **Preferred Medical Center / Centro Médico Preferido:** El hospital o clínica a donde se debe llevar al paciente si la caída es grave.
* **Ambulance Requested / Ambulancia Solicitada:** Cuando el sistema o el cuidador piden ayuda externa porque la emergencia es muy grave.

* **Smart Belt / Cinturón Inteligente:** El aparato completo que se pone el paciente en la cintura.
* **Biomechanical Sensor / Sensor Biomecánico [Sensor]:** El chip interno que "siente" hacia dónde se mueve o si se cae el paciente.
* **Local Audio Alarm / Alarma Local Sonora [Actuador]:** La bocina del cinturón que hace un ruido fuerte para avisar a los que están cerca que el abuelito se cayó.
* **Confirmation Motor / Motor de Confirmación [Actuador]:** La pieza que hace vibrar el cinturón para preguntarle al paciente: "¿Te caíste?.
---
 
# Capítulo III: Requirements Specification
 
## 3.1. User Stories


En esta sección, se detalla los requisitos funcionales del ecosistema "Foll" estructurados en Epics y User Stories. Las historias de usuario (incluyendo Technical Stories y Landing Page Stories) cuentan con criterios de aceptación redactados bajo el formato BDD (Behavior-Driven Development) usando la sintaxis Gherkin (Given-When-Then).

### Epic Stories
* **EPIC01:** **Como** equipo comercial de Foll, **quiero** informar y captar nuevos clientes mediante una Landing Page, **para** generar conversiones y suscripciones al ecosistema.
* **EPIC02:** **Como** usuario del ecosistema, **quiero** gestionar identidades, perfiles médicos y emparejamiento de hardware, **para** establecer una red de cuidado segura y personalizada.
* **EPIC03:** **Como** equipo de desarrollo, **quiero** capturar y procesar los datos físicos mediante Edge Computing, **para** detectar caídas con precisión en tiempo real sin saturar la red.
* **EPIC04:** **Como** cuidador responsable, **quiero** recibir y gestionar alertas críticas de caídas, **para** coordinar un auxilio rápido y efectivo para el adulto mayor.
* **EPIC05:** **Como** cuidador, **quiero** consultar el historial y estadísticas de incidentes pasados, **para** analizar la evolución de la salud del paciente junto a su médico.


| Epic / Story ID | Título | Descripción | Criterios de Aceptación | Relacionado con |
| :--- | :--- | :--- | :--- | :--- |
| US01 | Visualización de propuesta de valor | **Como** visitante de la landing page,<br>**quiero** visualizar una explicación sobre cómo la IA detecta caídas,<br>**para** comprender el beneficio principal del producto. | **Scenario 1:** Acceso a beneficios.<br>**Given** que el visitante accede al sitio web estático,<br>**When** el visitante navega a la sección de beneficios,<br>**Then** el sistema presenta el texto informativo sobre la tecnología de detección.<br><br>**Scenario 2:** Adaptabilidad móvil.<br>**Given** que el visitante ingresa desde un móvil,<br>**When** el sistema carga la información,<br>**Then** el sistema ajusta la distribución del contenido al tamaño de la pantalla. | EPIC01 |
| US02 | Visualización de planes | **Como** visitante de la landing page,<br>**quiero** revisar los costos de adquisición y suscripción,<br>**para** evaluar la viabilidad de implementar la solución en mi familia. | **Scenario 1:** Consulta de precios.<br>**Given** que el visitante se encuentra en la sección de planes,<br>**When** el sistema despliega la información comercial,<br>**Then** el sistema detalla al menos un plan básico.<br><br>**Scenario 2:** Redirección comercial.<br>**Given** que el visitante revisa un plan,<br>**When** el visitante selecciona adquirirlo,<br>**Then** el sistema redirige al formulario de contacto. | EPIC01 |
| US03 | Testimonios de confiabilidad | **Como** visitante de la landing page,<br>**quiero** leer testimonios de otras familias,<br>**para** validar la eficacia del dispositivo en la vida real. | **Scenario 1:** Visualización de reseñas.<br>**Given** que el visitante llega a la sección de comunidad,<br>**When** el sistema carga la página,<br>**Then** el sistema muestra al menos tres reseñas validadas.<br><br>**Scenario 2:** Rotación de testimonios.<br>**Given** que la sección contiene múltiples elementos,<br>**When** transcurren 5 segundos sin interacción,<br>**Then** el sistema rota la reseña mostrada automáticamente. | EPIC01 |
| US04 | Contacto comercial | **Como** visitante de la landing page,<br>**quiero** enviar mis datos a través de un formulario,<br>**para** que un asesor se comunique conmigo y resolver mis dudas. | **Scenario 1:** Envío exitoso.<br>**Given** que el visitante completa el formulario con correo válido,<br>**When** el visitante envía la solicitud,<br>**Then** el sistema registra el prospecto y muestra un mensaje de confirmación.<br><br>**Scenario 2:** Validación de formato.<br>**Given** que el visitante ingresa un correo sin formato "@",<br>**When** el visitante intenta enviar el formulario,<br>**Then** el sistema bloquea el envío y solicita corregir el formato. | EPIC01 |
| US05 | Creación de cuenta cuidador | **Como** cuidador,<br>**quiero** crear una cuenta en el sistema,<br>**para** acceder al ecosistema de monitoreo de Foll. | **Scenario 1:** Registro exitoso.<br>**Given** que el cuidador proporciona un correo y contraseña seguros,<br>**When** el cuidador envía la solicitud,<br>**Then** el sistema crea la cuenta y envía un correo de verificación.<br><br>**Scenario 2:** Correo duplicado.<br>**Given** que el correo ya existe en la base de datos,<br>**When** el cuidador envía la solicitud,<br>**Then** el sistema rechaza la creación y notifica el error. | EPIC02 |
| US06 | Creación de perfil de paciente | **Como** cuidador,<br>**quiero** registrar un perfil para el adulto mayor a mi cargo,<br>**para** gestionar su información médica. | **Scenario 1:** Creación de perfil.<br>**Given** que el cuidador ingresa el nombre y edad del paciente,<br>**When** el cuidador confirma el registro,<br>**Then** el sistema genera el perfil y lo asocia a su cuenta.<br><br>**Scenario 2:** Validación de datos obligatorios.<br>**Given** que el cuidador omite la edad,<br>**When** el cuidador intenta guardar,<br>**Then** el sistema bloquea la acción y solicita el dato. | EPIC02 |
| US07 | Actualización de datos médicos | **Como** cuidador,<br>**quiero** editar el tipo de sangre y las alergias del adulto mayor,<br>**para** mantener su historial clínico actualizado ante cualquier emergencia. | **Scenario 1:** Edición exitosa.<br>**Given** que el cuidador modifica el campo de alergias,<br>**When** el cuidador guarda los cambios,<br>**Then** el sistema actualiza la información en la base de datos.<br><br>**Scenario 2:** Cancelación de edición.<br>**Given** que el cuidador modifica los datos,<br>**When** el cuidador selecciona cancelar,<br>**Then** el sistema descarta los cambios y mantiene la información original. | EPIC02 |
| US08 | Adición de contactos secundarios | **Como** cuidador,<br>**quiero** guardar contactos telefónicos de otros familiares,<br>**para** asegurar el auxilio en caso yo esté ausente. | **Scenario 1:** Adición exitosa.<br>**Given** que el cuidador ingresa un número telefónico válido,<br>**When** el cuidador guarda el contacto,<br>**Then** el sistema añade el número a la lista de llamadas automáticas.<br><br>**Scenario 2:** Límite de contactos.<br>**Given** que el perfil posee el máximo de 5 contactos,<br>**When** el cuidador intenta agregar uno nuevo,<br>**Then** el sistema deniega la acción. | EPIC02 |
| US09 | Permiso de monitoreo | **Como** adulto mayor,<br>**quiero** aceptar la solicitud de vinculación de un cuidador,<br>**para** otorgar permiso de que reciba mis alertas. | **Scenario 1:** Aceptación de solicitud.<br>**Given** que el adulto mayor posee una invitación pendiente,<br>**When** el adulto mayor confirma la autorización,<br>**Then** el sistema vincula ambas cuentas.<br><br>**Scenario 2:** Rechazo de solicitud.<br>**Given** que el adulto mayor recibe una invitación,<br>**When** el adulto mayor la rechaza,<br>**Then** el sistema elimina la solicitud. | EPIC02 |
| US10 | Vinculación del cinturón | **Como** adulto mayor,<br>**quiero** registrar el código serial del cinturón en mi cuenta,<br>**para** que el sistema asocie el hardware conmigo. | **Scenario 1:** Emparejamiento exitoso.<br>**Given** que el adulto mayor ingresa un serial válido,<br>**When** el adulto mayor solicita la vinculación,<br>**Then** el sistema asocia el hardware a su perfil.<br><br>**Scenario 2:** Dispositivo en uso.<br>**Given** que el serial pertenece a otro paciente,<br>**When** el adulto mayor intenta vincularlo,<br>**Then** el sistema rechaza la operación. | EPIC02 |
| US21 | Generación de QR de perfil | **Como** usuario registrado del ecosistema,<br>**quiero** seleccionar el perfil de un adulto mayor y mostrar un código QR,<br>**para** permitir que otros cuidadores se vinculen rápidamente de forma presencial. | **Scenario 1:** Visualización del QR.<br>**Given** que el usuario selecciona un adulto mayor de su lista,<br>**When** el usuario selecciona la opción "Mostrar QR",<br>**Then** el sistema renderiza en pantalla un código QR único asociado a ese perfil.<br><br>**Scenario 2:** Cierre de vista QR.<br>**Given** que el código QR está en pantalla,<br>**When** el usuario selecciona la acción de cerrar o regresar,<br>**Then** el sistema oculta el QR y vuelve a la vista de detalles. | EPIC02 |
| US22 | Vinculación de paciente vía QR | **Como** cuidador,<br>**quiero** utilizar la opción de "agregar adulto mayor" para escanear un código QR,<br>**para** vincular rápidamente a un paciente que ya se encuentra registrado en el sistema. | **Scenario 1:** Escaneo exitoso.<br>**Given** que el cuidador abre el escáner desde la opción "Agregar adulto mayor",<br>**When** la cámara lee un código QR válido del sistema,<br>**Then** el sistema vincula al adulto mayor a su lista de monitoreo.<br><br>**Scenario 2:** Código inválido.<br>**Given** que el cuidador escanea un QR ajeno al ecosistema,<br>**When** el sistema procesa la lectura,<br>**Then** el sistema muestra un mensaje de error y permite reintentar. | EPIC02 |
| TS01 | Captura y envío de telemetría | **Como** Developer,<br>**quiero** desarrollar el firmware del cinturón IoT,<br>**para** que lea los datos del sensor y los transmita al Edge Gateway. | **Scenario 1:** Transmisión estable.<br>**Given** que el dispositivo tiene conexión local,<br>**When** el sensor captura movimiento,<br>**Then** el firmware envía el paquete al servidor Edge.<br><br>**Scenario 2:** Almacenamiento temporal.<br>**Given** que el dispositivo pierde conexión,<br>**When** el sensor captura datos,<br>**Then** el firmware almacena la lectura en memoria interna. | EPIC03 |
| TS02 | Detección Edge AI | **Como** Developer,<br>**quiero** implementar el algoritmo matemático/IA en el servidor Edge,<br>**para** determinar si los datos corresponden a una caída real. | **Scenario 1:** Detección positiva.<br>**Given** que el Edge recibe datos que superan el umbral de impacto,<br>**When** el algoritmo evalúa la magnitud,<br>**Then** el sistema clasifica el evento como "Posible Caída" y activa el actuador local.<br><br>**Scenario 2:** Filtrado de ruido.<br>**Given** que el Edge recibe fluctuaciones por caminata,<br>**When** el algoritmo evalúa los datos,<br>**Then** el sistema ignora el evento. | EPIC03 |
| TS03 | Endpoint de persistencia | **Como** Developer,<br>**quiero** exponer un endpoint RESTful seguro en la nube,<br>**para** guardar los incidentes confirmados por el Edge. | **Scenario 1:** Persistencia exitosa (HTTP 201).<br>**Given** que el endpoint recibe un payload válido,<br>**When** el sistema procesa la petición,<br>**Then** el sistema guarda el registro y retorna HTTP 201.<br><br>**Scenario 2:** Falla de seguridad (HTTP 401).<br>**Given** que el request carece del token de autorización,<br>**When** el sistema evalúa la petición,<br>**Then** el sistema retorna HTTP 401 Unauthorized. | EPIC03 |
| TS04 | Monitoreo de batería | **Como** Developer,<br>**quiero** desarrollar un servicio que evalúe el nivel de voltaje enviado por el hardware,<br>**para** alertar sobre niveles críticos de energía. | **Scenario 1:** Detección de nivel crítico.<br>**Given** que el servicio recibe un valor de voltaje inferior al 15%,<br>**When** el sistema actualiza el estado,<br>**Then** el sistema dispara un evento de "Batería Baja" hacia los cuidadores vinculados.<br><br>**Scenario 2:** Restablecimiento de carga.<br>**Given** que el cinturón es conectado a la corriente y supera el 20% de batería,<br>**When** el servicio recibe la actualización de voltaje,<br>**Then** el sistema limpia la alerta de "Batería Baja" en la aplicación de los cuidadores. | EPIC03 |
| TS05 | Pre-procesamiento de movimiento (Sistema Embebido) | **Como** Developer,<br>**quiero** capturar y evaluar los patrones de movimiento directamente en el sistema embebido,<br>**para** procesar los datos de los sensores y empaquetarlos limpiamente antes de enviarlos a la capa Edge. | **Scenario 1:** Evaluación y empaquetado.<br>**Given** que los sensores generan datos de movimiento en bruto,<br>**When** el microcontrolador (sistema embebido) evalúa el patrón,<br>**Then** el sistema filtra y empaqueta los datos procesados.<br><br>**Scenario 2:** Transmisión a capa Edge.<br>**Given** que los datos han sido procesados localmente,<br>**When** el ciclo de evaluación termina,<br>**Then** el sistema embebido envía la carga útil optimizada a la capa Edge. | EPIC03 |
| US11 | Protocolo de verificación de alerta local | **Como** adulto mayor,<br>**quiero** que el cinturón active una alarma sonora tras detectar una caída y me permita presionar un botón,<br>**para** cancelar el falso positivo antes de que se alerte a mis cuidadores. | **Scenario 1:** Cancelación de falsa alarma.<br>**Given** que el dispositivo detecta un impacto y activa la alarma sonora por 10 segundos,<br>**When** el usuario presiona el botón físico dentro de ese tiempo,<br>**Then** el sistema desactiva la alarma, registra un falso positivo y no notifica.<br><br>**Scenario 2:** Confirmación y notificación.<br>**Given** que el dispositivo activa la alarma sonora,<br>**When** transcurren 10 segundos sin que el botón sea presionado,<br>**Then** el sistema escala el evento confirmando la caída y avisa a los cuidadores. | EPIC04 |
| US12 | Recepción de alerta remota | **Como** cuidador,<br>**quiero** recibir una notificación en tiempo real con la ubicación GPS,<br>**para** reaccionar de inmediato ante la caída. | **Scenario 1:** Emisión Push.<br>**Given** que ocurre una "Caída Confirmada",<br>**When** el sistema procesa la emergencia,<br>**Then** el sistema envía una notificación Push con coordenadas al cuidador.<br><br>**Scenario 2:** Dispositivo offline.<br>**Given** que el envío Push falla por falta de internet del cuidador,<br>**When** el sistema agota intentos,<br>**Then** el sistema envía la alerta vía SMS. | EPIC04 |
| US13 | Confirmación de auxilio | **Como** cuidador,<br>**quiero** informar en la app que estoy en camino a la emergencia,<br>**para** coordinar esfuerzos con el resto de familiares. | **Scenario 1:** Aceptación de incidente.<br>**Given** que existe una alerta activa,<br>**When** el cuidador selecciona la acción de asistir,<br>**Then** el sistema cambia el estado a "Ayuda en camino".<br><br>**Scenario 2:** Bloqueo de duplicidad.<br>**Given** que un cuidador asume el control,<br>**When** el sistema actualiza el estado,<br>**Then** el sistema oculta la opción de asistir a los demás cuidadores. | EPIC04 |
| US14 | Escalamiento telefónico | **Como** adulto mayor,<br>**quiero** que llamen automáticamente a mis contactos secundarios,<br>**para** que me auxilien si mi cuidador no responde. | **Scenario 1:** Cuidador inactivo.<br>**Given** que una alerta permanece sin respuesta por 3 minutos,<br>**When** el sistema detecta la inactividad,<br>**Then** el sistema inicia una llamada automatizada a los contactos secundarios.<br><br>**Scenario 2:** Lista de contactos vacía.<br>**Given** que la alerta requiere escalamiento pero el perfil no tiene contactos secundarios registrados,<br>**When** el sistema intenta realizar las llamadas automatizadas,<br>**Then** el sistema salta este paso y procede directamente al siguiente nivel de emergencia. | EPIC04 |
| US15 | Solicitud de ambulancia | **Como** adulto mayor,<br>**quiero** que el sistema solicite una ambulancia si nadie contesta,<br>**para** asegurar mi integridad. | **Scenario 1:** Red agotada.<br>**Given** que cuidadores y contactos secundarios no responden,<br>**When** el sistema agota los protocolos,<br>**Then** el sistema emite una solicitud electrónica al centro médico registrado.<br><br>**Scenario 2:** Confirmación de despacho.<br>**Given** que el sistema emitió la solicitud electrónica al centro médico,<br>**When** el centro confirma la recepción del caso,<br>**Then** el sistema actualiza el estado de la alerta a "Ambulancia en camino". | EPIC04 |
| US16 | Visualización médica en emergencia | **Como** paramédico o cuidador,<br>**quiero** ver las alergias y tipo de sangre directamente en la pantalla de la alerta,<br>**para** aplicar el tratamiento médico correcto de inmediato. | **Scenario 1:** Acceso a datos.<br>**Given** que la alerta crítica está abierta en la pantalla,<br>**When** el cuidador despliega los detalles clínicos,<br>**Then** el sistema muestra la información vital del perfil.<br><br>**Scenario 2:** Ausencia de datos médicos.<br>**Given** que el perfil no tiene alergias ni tipo de sangre registrados,<br>**When** el cuidador despliega los detalles clínicos,<br>**Then** el sistema indica "No hay información médica registrada". | EPIC04 |
| US17 | Consulta de historial | **Como** cuidador,<br>**quiero** consultar una lista de las caídas pasadas,<br>**para** identificar frecuencias de riesgo. | **Scenario 1:** Lista cronológica.<br>**Given** que el cuidador accede a la sección de reportes,<br>**When** el sistema carga la información,<br>**Then** el sistema presenta los eventos ordenados por fecha.<br><br>**Scenario 2:** Detalles del evento.<br>**Given** que el cuidador visualiza la lista,<br>**When** selecciona un incidente,<br>**Then** el sistema muestra la hora y ubicación exacta del suceso. | EPIC05 |
| US18 | Filtro de falsos positivos | **Como** cuidador,<br>**quiero** filtrar las alertas canceladas por el paciente,<br>**para** evaluar si está sufriendo de mareos o inestabilidad leves. | **Scenario 1:** Aplicación de filtro.<br>**Given** que el cuidador visualiza el historial,<br>**When** aplica el filtro "Falsos Positivos",<br>**Then** el sistema excluye las caídas reales y muestra solo las alertas canceladas.<br><br>**Scenario 2:** Limpieza de filtro.<br>**Given** que el filtro "Falsos Positivos" está activo,<br>**When** el cuidador selecciona la opción de borrar filtros,<br>**Then** el sistema restablece la vista mostrando nuevamente todo el historial. | EPIC05 |
| US19 | Visualización de estadísticas | **Como** cuidador,<br>**quiero** ver un gráfico mensual de incidentes,<br>**para** comprender la tendencia de la salud del adulto mayor. | **Scenario 1:** Gráfico de barras.<br>**Given** que el cuidador entra a la sección de analíticas,<br>**When** el sistema procesa los datos del mes,<br>**Then** el sistema renderiza un gráfico con el conteo de caídas por semana.<br><br>**Scenario 2:** Mes sin incidentes.<br>**Given** que no se registraron caídas en el mes seleccionado,<br>**When** el sistema procesa los datos,<br>**Then** el sistema muestra un mensaje indicando "Cero incidentes este mes" en lugar del gráfico. | EPIC05 |
| US20 | Exportación de reporte clínico | **Como** cuidador,<br>**quiero** descargar el historial de caídas en formato PDF,<br>**para** enviárselo directamente al médico tratante antes de la cita. | **Scenario 1:** Generación de PDF.<br>**Given** que el cuidador visualiza el reporte de un mes específico,<br>**When** selecciona la opción de exportar,<br>**Then** el sistema compila la información y descarga un documento PDF estructurado.<br><br>**Scenario 2:** Exportación sin datos.<br>**Given** que el historial del mes seleccionado está vacío,<br>**When** el cuidador intenta exportar el reporte,<br>**Then** el sistema genera un PDF indicando que no hubo registros de incidencias en el periodo. | EPIC05 |

## 3.2. Impact Mapping
 
 En esta sección, se ha llevado a cabo la creación del Impact Mapping, partiendo de las metas comerciales establecidas para los user personas. Se han identificado los impactos deseados, los entregables necesarios y se han relacionado con las historias de usuario correspondientes.


 <img alt="Impact Mapping" src="img/impact-mapping/impact-mapping.png" />

## 3.3. Product Backlog

En esta sección se presenta el Product Backlog del proyecto, el cual contiene una lista priorizada de todas las funcionalidades para el desarrollo del Ecosistema de Foll

La priorización se ha realizado considerando el valor que cada ítem aporta al negocio, la complejidad técnica y la dependencia entre tareas. Este backlog servirá como guía para el equipo de desarrollo durante las diferentes fases del proyecto, asegurando que se enfoquen en entregar el mayor valor posible en cada iteración.

| # Orden | User Story Id | Título | Descripción | Story Points (1 / 2 / 3 / 5 / 8) |
| :--- | :--- | :--- | :--- | :--- |
| 1 | US01 | Visualización de propuesta de valor | Como visitante de la landing page, quiero visualizar una explicación sobre cómo la IA detecta caídas, para comprender el beneficio principal del producto. | 2 |
| 2 | US02 | Visualización de planes | Como visitante de la landing page, quiero revisar los costos de adquisición y suscripción, para evaluar la viabilidad de implementar la solución en mi familia. | 2 |
| 3 | US03 | Testimonios de confiabilidad | Como visitante de la landing page, quiero leer testimonios de otras familias, para validar la eficacia del dispositivo en la vida real. | 3 |
| 4 | US04 | Contacto comercial | Como visitante de la landing page, quiero enviar mis datos a través de un formulario, para que un asesor se comunique conmigo y resolver mis dudas. | 3 |
| 5 | US05 | Creación de cuenta cuidador | Como cuidador, quiero crear una cuenta en el sistema, para acceder al ecosistema de monitoreo de Foll. | 3 |
| 6 | US06 | Creación de perfil de paciente | Como cuidador, quiero registrar un perfil para el adulto mayor a mi cargo, para gestionar su información médica. | 3 |
| 7 | US09 | Permiso de monitoreo | Como adulto mayor, quiero aceptar la solicitud de vinculación de un cuidador, para otorgar permiso de que reciba mis alertas. | 2 |
| 8 | US10 | Vinculación del cinturón | Como adulto mayor, quiero registrar el código serial del cinturón en mi cuenta, para que el sistema asocie el hardware conmigo. | 5 |
| 9 | US21 | Generación de QR de perfil | Como usuario registrado del ecosistema, quiero seleccionar el perfil de un adulto mayor y mostrar un código QR, para permitir que otros cuidadores se vinculen rápidamente de forma presencial. | 3 |
| 10 | US22 | Vinculación de paciente vía QR | Como cuidador, quiero utilizar la opción de "agregar adulto mayor" para escanear un código QR, para vincular rápidamente a un paciente que ya se encuentra registrado en el sistema. | 5 |
| 11 | TS01 | Captura y envío de telemetría | Como Developer, quiero desarrollar el firmware del cinturón IoT, para que lea los datos del sensor y los transmita al Edge Gateway. | 8 |
| 12 | TS05 | Pre-procesamiento de movimiento (Sistema Embebido) | Como Developer, quiero capturar y evaluar los patrones de movimiento directamente en el sistema embebido, para procesar los datos de los sensores y empaquetarlos limpiamente antes de enviarlos a la capa Edge. | 8 |
| 13 | TS02 | Detección Edge AI | Como Developer, quiero implementar el algoritmo matemático/IA en el servidor Edge, para determinar si los datos corresponden a una caída real. | 8 |
| 14 | TS03 | Endpoint de persistencia | Como Developer, quiero exponer un endpoint RESTful seguro en la nube, para guardar los incidentes confirmados por el Edge. | 5 |
| 15 | US12 | Recepción de alerta remota | Como cuidador, quiero recibir una notificación en tiempo real con la ubicación GPS, para reaccionar de inmediato ante la caída. | 5 |
| 16 | US11 | Protocolo de verificación de alerta local | Como adulto mayor, quiero que el cinturón active una alarma sonora tras detectar una caída y me permita presionar un botón, para cancelar el falso positivo antes de que se alerte a mis cuidadores. | 5 |
| 17 | US13 | Confirmación de auxilio | Como cuidador, quiero informar en la app que estoy en camino a la emergencia, para coordinar esfuerzos con el resto de familiares. | 3 |
| 18 | US16 | Visualización médica en emergencia | Como paramédico o cuidador, quiero ver las alergias y tipo de sangre directamente en la pantalla de la alerta, para aplicar el tratamiento médico correcto de inmediato. | 2 |
| 19 | TS04 | Monitoreo de batería | Como Developer, quiero desarrollar un servicio que evalúe el nivel de voltaje enviado por el hardware, para alertar sobre niveles críticos de energía. | 3 |
| 20 | US08 | Adición de contactos secundarios | Como cuidador, quiero guardar contactos telefónicos de otros familiares, para asegurar el auxilio en caso yo esté ausente. | 2 |
| 21 | US14 | Escalamiento telefónico | Como adulto mayor, quiero que llamen automáticamente a mis contactos secundarios, para que me auxilien si mi cuidador no responde. | 8 |
| 22 | US15 | Solicitud de ambulancia | Como adulto mayor, quiero que el sistema solicite una ambulancia si nadie contesta, para asegurar mi integridad. | 5 |
| 23 | US07 | Actualización de datos médicos | Como cuidador, quiero editar el tipo de sangre y las alergias del adulto mayor, para mantener su historial clínico actualizado ante cualquier emergencia. | 2 |
| 24 | US17 | Consulta de historial | Como cuidador, quiero consultar una lista de las caídas pasadas, para identificar frecuencias de riesgo. | 3 |
| 25 | US18 | Filtro de falsos positivos | Como cuidador, quiero filtrar las alertas canceladas por el paciente, para evaluar si está sufriendo de mareos o inestabilidad leves. | 2 |
| 26 | US19 | Visualización de estadísticas | Como cuidador, quiero ver un gráfico mensual de incidentes, para comprender la tendencia de la salud del adulto mayor. | 5 |
| 27 | US20 | Exportación de reporte clínico | Como cuidador, quiero descargar el historial de caídas en formato PDF, para enviárselo directamente al médico tratante antes de la cita. | 5 |

A continuación se muestra el enlace al tablero de Trello donde se gestiona el Product Backlog, junto con una captura de pantalla representativa:

https://trello.com/b/0wcO99Dl/foll-product-backlog

<img alt="Product Backlog Trello" src="img/product-backlog/foll-product-backlog.png" width="900"/>
 
---
 
# Capítulo IV: Solution Software Design
 
## 4.1. Strategic-Level Domain-Driven Design

En esta sección se desarrolla la parte estratégica de Domain-Driven Design. El propósito fundamental es traducir la complejidad del entorno de hardware IoT y la gestión de emergencias en límites arquitectónicos claros que reflejen el verdadero valor del negocio: la salvaguarda de la vida y la respuesta oportuna. Para lograr esta alineación, se detalla el proceso de descubrimiento y modelado de Bounded Contexts a partir del Design-Level EventStorming, la orquestación de sus interacciones mediante Context Mapping, y la consolidación de estas decisiones en una arquitectura de software integral y escalable documentada bajo el estándar C4.
 
### 4.1.1. Design-Level EventStorming

En esta sección de Design-Level EventStorming planteamos una versión revisada y mejorada del modelado general del dominio. El propósito es llegar al mayor nivel de detalle posible, explicando la secuencia de eventos de Foll en componentes de software para así tener un mayor entendimiento de las funcionalidades y flujos que tendrá el proyecto. 

<img src="img/eventstorming/0.png" alt="Event Storming" width="700"/>

**Paso 1：Exploración desestructurada**
<img src="img/eventstorming/1.png" alt="Event Storming" width="700"/>

**Paso 2：Línea de tiempo**
<img src="img/eventstorming/2.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/2.2.png" alt="Event Storming" width="700"/>

**Paso 3：Puntos de dolor**
<img src="img/eventstorming/3.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/3.2.png" alt="Event Storming" width="700"/>

**Paso 4：Puntos clave**
<img src="img/eventstorming/4.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/4.2.png" alt="Event Storming" width="700"/>

**Paso 5：Comandos**

<img src="img/eventstorming/5.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/5.2.png" alt="Event Storming" width="700"/>

**Paso 6：Políticas**

<img src="img/eventstorming/6.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/6.2.png" alt="Event Storming" width="700"/>

**Paso 7：Modelos de lectura**

<img src="img/eventstorming/7.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/7.2.png" alt="Event Storming" width="700"/>

**Paso 8：Sistemas externos**

<img src="img/eventstorming/8.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/8.2.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/8.3.png" alt="Event Storming" width="700"/>

**Paso 9：Agregados**

<img src="img/eventstorming/9.1.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/9.2.png" alt="Event Storming" width="700"/>
<img src="img/eventstorming/9.3.png" alt="Event Storming" width="700"/>

**Paso 10：Bounded Contexts**<br>
En este último paso, se sintetizaron los flujos principales para determinar los bounded contexts con los que desarrollaríamos Foll.

<img src="img/eventstorming/10.png" alt="Event Storming" width="700"/> <br>

**IAM context** <br>
En este bounded context se trabaja la lógica de la autenticación, creación de cuentas, permisos para monitorear a los adultos mayores y la vinculación con el dispositivo iot. 
 <br>
<img src="img/eventstorming/10-iam.png" alt="Event Storming" width="700"/>

**Emergency management context**<br>
En Emergency management se centra en la respuesta del aplicativo y web cuando se detecta una caída para asegurar la seguridad del adulto mayor afectado.
<img src="img/eventstorming/10-emergency.png" alt="Event Storming" width="700"/>

**Embedded systems context**<br>
En él se concentra la lógica para que el dispositivo iot pueda interpretar la información que recibe de los sensores, de manera que detetcte la caída y esa alerta sea enviada al resto del aplicativo Foll.<br>
<img src="img/eventstorming/10-embedded.png" alt="Event Storming" width="700"/>

**Edge context**<br>
En este bounded context se recibe la data procesada para activar el protocolo de verificación y que sirva de puente con el bounded context de emergency management. <br>
<img src="img/eventstorming/10-edge.png" alt="Event Storming" width="700"/>

**Notifications context**<br>
Se controla la lógica de envío de mensajes, llamadas y alertas en caso se detecte una caída.<br>
<img src="img/eventstorming/10-notifications.png" alt="Event Storming" width="700"/>

#### 4.1.1.1. Candidate Context Discovery

En esta sección se presenta el proceso seguido por el equipo para el descubrimiento y clasificación de bounded contexts candidatos a partir del Event Storming de Diseño realizado previamente. El objetivo fue identificar los límites naturales del dominio del sistema de monitoreo y detección de caídas, determinar cuáles son las partes core del negocio y cuáles cumplen roles de apoyo o genéricos, con el fin de priorizar los esfuerzos de diseño y arquitectura en aquellos elementos que aportan el mayor valor estratégico.

**Preparación de la sesión:**

La sesión de Candidate Context Discovery se desarrolló tomando como insumo principal el taller de Event Storming. Para esta dinámica se utilizaron:

- La línea de tiempo de eventos del dominio.
- Los clusters iniciales de eventos generados a partir de los flujos de hardware (Embedded/Edge) y software (App/Cloud).
- Los eventos clave (pivotal events) que marcaban cambios de estado críticos, como "Evento de posible caída detectado" o "Alerta de emergencia emitida".

El equipo documentó la evolución de la categorización mediante representaciones visuales del tablero de trabajo.

**Técnica aplicada: *Start-with-Value***

Para este proyecto se aplicó la técnica *Start-with-Value*, cuyo principio consiste en priorizar aquellas partes del dominio que representan el mayor valor para el negocio y el usuario final (en este caso, la preservación de la salud y la atención rápida de emergencias). Esta técnica permitió separar con claridad qué bounded contexts debían ser considerados como Core, y cuáles como Supporting o Generic.

El proceso se organizó en tres pasos principales:

1. **Identificación de valor estratégico:** El equipo analizó qué componentes del sistema IoT y de la plataforma generan el valor directo. Se determinó que el valor reside en la precisión de la detección en tiempo real y la eficacia del protocolo de respuesta médica, más no en la simple gestión de cuentas.

   ![Identificación de valor estratégico](./img/candidate-context-discovery/candidate-context-discovery-step1.png)

2. **Agrupación de eventos en torno al valor:** Se revisaron los clusters de eventos, destacando los flujos de hardware (captura de sensores y edge computing) y los protocolos de emergencia como los de mayor impacto vital.

   ![Agrupación de eventos en torno al valor](./img/candidate-context-discovery/candidate-context-discovery-step2.png)

3. **Clasificación Core, Supporting, Generic:** Los contextos se categorizaron según su aporte al propósito principal del sistema y el nivel de complejidad algorítmica y de negocio.

   ![Clasificación Core, Supporting, Generic](./img/candidate-context-discovery/candidate-context-discovery-step3.jpg)

**Candidate Contexts identificados**

El análisis permitió identificar los siguientes bounded contexts candidatos:

| Candidate Context | Eventos Clave Asociados | Clasificación | Descripción | Justificación |
| :--- | :--- | :--- | :--- | :--- |
| **IAM** | Cuidador autenticado, Cuenta adulto mayor creada, Adulto mayor vinculado mediante código QR, Dispositivos vinculado a usuario. | Generic | Gestión de identidades, perfiles médicos básicos, emparejamiento de dispositivos y control de accesos. | Es necesario para que el sistema opere y asigne roles, pero no es el diferenciador; existen soluciones estándar de identidad que pueden cubrirlo. |
| **Embedded System** | Datos de movimiento capturados por el sistema embebido, Datos de sensores enviados a la capa Edge, Botón de cancelación presionado. | Supporting | Adquisición de datos brutos en tiempo real mediante hardware IoT y filtrado inicial de usuario. | Es fundamental para alimentar el sistema (IoT), pero su lógica es de recolección de datos, apoyando directamente al motor de análisis principal. |
| **Edge** | Patrón de movimiento analizado, Evento de posible caída detectado, Alerta sonora activada, Caída confirmada. | Core | Procesamiento local avanzado e inferencia de patrones de movimiento para la detección autónoma de caídas. | Es el corazón tecnológico del sistema. Procesar en el Edge reduce la latencia, no depende de la nube constante y representa la innovación diferencial del negocio. |
| **Notifications** | Notificación enviada a la aplicación, Alerta de llamada iniciada, Intento de contacto fallido, Cuidador notificado responde a la alerta. | Supporting | Enrutamiento de alertas, gestión de reintentos y confirmaciones de recepción multicanal. | Soporta el flujo de comunicación crítica asegurando la entrega de mensajes, apoyándose en integraciones de terceros (SMS, Push, Llamadas). |
| **Emergency** | Alerta de emergencia emitida, Ubicación de GPS obtenida, Ninguno de los cuidadores responde tras varios intentos, Ambulancia solicitada. | Core | Orquestación del protocolo crítico de salvaguarda, escalamiento de no-respuesta y gestión de historial de incidencias. | Representa el valor final e irrenunciable para el usuario: coordinar el rescate médico de forma autónoma cuando cada segundo cuenta. |

**Clasificación estratégica**

Como parte del análisis *Start-with-Value*, se representó gráficamente la clasificación de los bounded contexts en una matriz de dos ejes:

- **Business Differentiation (eje X):** Grado en que el contexto aporta valor estratégico, innovación o diferenciación en el mercado de la salud y el cuidado de adultos mayores.
- **Model Complexity (eje Y):** Nivel de complejidad algorítmica (ej. análisis de patrones) y de reglas de negocio requerido para implementar y mantener el contexto.

En esta matriz de clasificación de bounded contexts, se distribuyeron los contextos en los tres tipos:

- **Core:** Edge, Emergency.
- **Supporting:** Embedded System, Notifications.
- **Generic:** IAM.

![Matriz de clasificación de bounded contexts](./img/candidate-context-discovery/candidate-context-discovery-strategic-classification.png)

**Resultados**

Se definieron cinco bounded contexts candidatos en total, estructurados de la siguiente manera:

- **2 Core** (Edge, Emergency), enfocados en la detección inteligente y la salvaguarda de la vida.
- **2 Supporting** (Embedded System, Notifications), encargados de la recolección de datos y el enrutamiento de avisos.
- **1 Generic** (IAM), para la gestión de acceso e identidades.

![Candidate Contexts finales](./img/candidate-context-discovery/candidate-context-discovery-results.png)

La aplicación de la técnica *Start-with-Value* permitió asegurar que la atención principal del diseño táctico y las decisiones arquitectónicas (como DDD y Clean Architecture) se concentren en los contextos de Edge y Emergency, dado que allí reside la propuesta de valor crítica y diferenciadora de la solución.

El resto de contextos serán modelados en las siguientes secciones mediante Bounded Context Canvas y Domain Message Flows, garantizando consistencia y claridad en la comunicación entre los microservicios y los componentes embebidos.
 
#### 4.1.1.2. Domain Message Flows Modeling
 
#### 4.1.1.3. Bounded Context Canvases
 
### 4.1.2. Context Mapping
 
### 4.1.3. Software Architecture
 
#### 4.1.3.1. Software Architecture System Landscape Diagram

<img width="4750" height="1150" alt="Landscape-dark (1)" src="https://github.com/user-attachments/assets/0c05f4d9-3378-49cd-80b1-1f54bf072354" />

<br>

#### 4.1.3.2. Software Architecture Context Level Diagrams

<img width="3170" height="1150" alt="SystemContext-dark (1)" src="https://github.com/user-attachments/assets/c52bfdca-c4a6-4095-bc44-996d92365fe1" />

<br>
 
#### 4.1.3.3. Software Architecture Container Level Diagrams

<img width="7070" height="2288" alt="ContainerView-dark" src="https://github.com/user-attachments/assets/1a7d2e45-5c28-4dfc-a15f-f1156dea5fd7" />

<br>
 
#### 4.1.3.4. Software Architecture Deployment Diagrams

<img width="3820" height="1608" alt="DeploymentView-dark" src="https://github.com/user-attachments/assets/17cb30a4-65e2-4e0c-a527-1b3d00c3a357" />

<br>
 
## 4.2. Tactical-Level Domain-Driven Design
 
### 4.2.1. Bounded Context: IAM

---

#### 4.2.1.1. Domain Layer

Esta capa representa el nucleo del BC IAM. Gestiona la identidad, autenticacion, autorizacion y vinculacion entre usuarios y dispositivos, aplicando reglas de negocio sin depender de frameworks externos.

##### Entities

###### `User`
**Proposito:** Representa a cualquier persona registrada en el sistema. Puede ser un Adulto Mayor o un Cuidador. Es la entidad central del BC IAM y raiz de su agregado.

| Atributo | Tipo | Scope | Descripcion |
|---|---|---|---|
| `id` | `UserId` | private | Identificador unico del usuario |
| `email` | `Email` | private | Correo electronico, unico en el sistema |
| `passwordHash` | `PasswordHash` | private | Hash de la contrasena del usuario |
| `role` | `Role` | private | Rol asignado: `ELDERLY_USER` o `CAREGIVER` |
| `fullName` | `string` | private | Nombre completo del usuario |
| `phoneNumber` | `string` | private | Numero de telefono para notificaciones de emergencia |
| `isActive` | `boolean` | private | Indica si la cuenta esta habilitada |
| `createdAt` | `DateTime` | private | Fecha de creacion de la cuenta |

| Metodo | Retorno | Scope | Descripcion |
|---|---|---|---|
| `activate()` | `void` | public | Habilita la cuenta del usuario |
| `deactivate()` | `void` | public | Deshabilita la cuenta sin eliminarla |
| `changePassword(newHash: PasswordHash)` | `void` | public | Actualiza el hash de contrasena validando reglas de negocio |
| `hasRole(role: Role)` | `boolean` | public | Verifica si el usuario tiene un rol especifico |

###### `Device`
**Proposito:** Representa un dispositivo ESP32 registrado en el sistema. Un dispositivo debe estar vinculado a exactamente un Adulto Mayor para operar.

| Atributo | Tipo | Scope | Descripcion |
|---|---|---|---|
| `id` | `DeviceId` | private | Identificador unico del dispositivo |
| `macAddress` | `string` | private | Direccion MAC del ESP32, inmutable tras registro |
| `alias` | `string` | private | Nombre legible asignado por el usuario (ej. "Pulsera de papa") |
| `ownerId` | `UserId` | private | ID del Adulto Mayor al que esta vinculado |
| `status` | `DeviceStatus` | private | Estado: `ACTIVE`, `INACTIVE`, `UNBOUND` |
| `registeredAt` | `DateTime` | private | Fecha de vinculacion al sistema |
| `lastSeenAt` | `DateTime` | private | Ultimo heartbeat recibido desde el dispositivo |

| Metodo | Retorno | Scope | Descripcion |
|---|---|---|---|
| `bind(ownerId: UserId)` | `void` | public | Vincula el dispositivo a un Adulto Mayor |
| `unbind()` | `void` | public | Desvincula el dispositivo, poniendolo en estado `UNBOUND` |
| `activate()` | `void` | public | Cambia el estado a `ACTIVE` |
| `deactivate()` | `void` | public | Cambia el estado a `INACTIVE` |
| `updateLastSeen(timestamp: DateTime)` | `void` | public | Actualiza el timestamp del ultimo heartbeat |
| `isBound()` | `boolean` | public | Retorna true si el dispositivo tiene un dueno asignado |

###### `CareRelationship`
**Proposito:** Representa el vinculo entre un Adulto Mayor y su Cuidador. Controla quien tiene permiso de monitorear a quien y gestionar sus alertas.

| Atributo | Tipo | Scope | Descripcion |
|---|---|---|---|
| `id` | `RelationshipId` | private | Identificador unico de la relacion |
| `elderlyUserId` | `UserId` | private | ID del Adulto Mayor |
| `caregiverId` | `UserId` | private | ID del Cuidador |
| `status` | `RelationshipStatus` | private | Estado: `PENDING`, `ACTIVE`, `REVOKED` |
| `invitationToken` | `string` | private | Token unico para aceptar la invitacion |
| `createdAt` | `DateTime` | private | Fecha de creacion de la invitacion |
| `acceptedAt` | `DateTime` | private | Fecha en que el Cuidador acepto |

| Metodo | Retorno | Scope | Descripcion |
|---|---|---|---|
| `accept()` | `void` | public | El Cuidador acepta la relacion, cambia estado a `ACTIVE` |
| `revoke()` | `void` | public | Cualquiera de las partes revoca la relacion |
| `isPending()` | `boolean` | public | Verifica si la relacion aun no fue aceptada |
| `isActive()` | `boolean` | public | Verifica si la relacion esta vigente |

##### Value Objects

###### `UserId`
**Proposito:** Encapsula el identificador unico de un usuario. Garantiza que el ID nunca sea nulo ni vacio.

| Atributo | Tipo | Descripcion |
|---|---|---|
| `value` | `UUID` | Valor del identificador |

###### `DeviceId`
**Proposito:** Encapsula el identificador unico de un dispositivo.

| Atributo | Tipo | Descripcion |
|---|---|---|
| `value` | `UUID` | Valor del identificador |

###### `Email`
**Proposito:** Encapsula y valida la direccion de correo electronico. Garantiza formato valido en construccion.

| Atributo | Tipo | Descripcion |
|---|---|---|
| `value` | `string` | Direccion de email validada |

| Metodo | Descripcion |
|---|---|
| `validate(raw: string)` | Lanza excepcion de dominio si el formato es invalido |

###### `PasswordHash`
**Proposito:** Encapsula el hash de contrasena. Nunca almacena ni expone el texto plano.

| Atributo | Tipo | Descripcion |
|---|---|---|
| `value` | `string` | Hash bcrypt de la contrasena |

###### `Role`
**Proposito:** Enumeracion que define los roles posibles dentro del sistema.

| Valor | Descripcion |
|---|---|
| `ELDERLY_USER` | Adulto Mayor que porta el dispositivo |
| `CAREGIVER` | Persona encargada de monitorear y recibir alertas |

###### `DeviceStatus`
**Proposito:** Enumeracion que describe el estado operativo de un dispositivo.

| Valor | Descripcion |
|---|---|
| `ACTIVE` | Dispositivo vinculado y operando |
| `INACTIVE` | Dispositivo vinculado pero apagado o sin senal |
| `UNBOUND` | Dispositivo sin dueno asignado |

###### `RelationshipStatus`
**Proposito:** Enumeracion que describe el estado del vinculo Adulto-Cuidador.

| Valor | Descripcion |
|---|---|
| `PENDING` | Invitacion enviada, aun no aceptada |
| `ACTIVE` | Vinculo confirmado y activo |
| `REVOKED` | Vinculo revocado por alguna de las partes |

##### Aggregates

###### `UserAggregate`
**Root:** `User`  
**Proposito:** Agrupa a `User` con su `Device` vinculado y sus `CareRelationship` activas. Garantiza que todas las modificaciones al usuario y sus relaciones pasen por la raiz, manteniendo consistencia.

###### `DeviceAggregate`
**Root:** `Device`  
**Proposito:** Gestiona el ciclo de vida del dispositivo de forma independiente. La vinculacion y desvinculacion siempre ocurren a traves de este agregado.

##### Domain Services

###### `AuthenticationDomainService`
**Proposito:** Contiene la logica de autenticacion que no pertenece naturalmente a ninguna entidad individual. Verifica credenciales y delega la emision de tokens a infraestructura.

| Metodo | Retorno | Descripcion |
|---|---|---|
| `validateCredentials(email: Email, rawPassword: string, user: User)` | `boolean` | Verifica que la contrasena ingresada coincida con el hash almacenado |

###### `DeviceBindingDomainService`
**Proposito:** Encapsula las reglas de negocio para vincular y desvincular dispositivos. Garantiza que un dispositivo no sea vinculado a mas de un usuario simultaneamente.

| Metodo | Retorno | Descripcion |
|---|---|---|
| `canBind(device: Device, user: User)` | `boolean` | Valida que el dispositivo este en estado `UNBOUND` y el usuario sea `ELDERLY_USER` |
| `canUnbind(device: Device, requesterId: UserId)` | `boolean` | Valida que quien solicita la desvinculacion sea el dueno o un administrador |

##### Repository Interfaces

###### `IUserRepository`
**Proposito:** Abstraccion del repositorio de usuarios. Definida en dominio, implementada en infraestructura.

| Metodo | Retorno | Descripcion |
|---|---|---|
| `findById(id: UserId)` | `User \| null` | Busca un usuario por su ID |
| `findByEmail(email: Email)` | `User \| null` | Busca un usuario por su email |
| `save(user: User)` | `void` | Persiste un usuario nuevo o actualizado |
| `delete(id: UserId)` | `void` | Elimina un usuario del sistema |

###### `IDeviceRepository`
**Proposito:** Abstraccion del repositorio de dispositivos.

| Metodo | Retorno | Descripcion |
|---|---|---|
| `findById(id: DeviceId)` | `Device \| null` | Busca un dispositivo por su ID |
| `findByMacAddress(mac: string)` | `Device \| null` | Busca un dispositivo por su MAC address |
| `findByOwnerId(ownerId: UserId)` | `Device \| null` | Retorna el dispositivo vinculado a un Adulto Mayor |
| `save(device: Device)` | `void` | Persiste un dispositivo nuevo o actualizado |

###### `ICareRelationshipRepository`
**Proposito:** Abstraccion del repositorio de vinculos Adulto-Cuidador.

| Metodo | Retorno | Descripcion |
|---|---|---|
| `findByElderlyUserId(id: UserId)` | `CareRelationship \| null` | Retorna la relacion activa del Adulto Mayor |
| `findByCaregiverId(id: UserId)` | `CareRelationship[]` | Retorna todas las relaciones de un Cuidador |
| `findByInvitationToken(token: string)` | `CareRelationship \| null` | Busca una relacion por token de invitacion |
| `save(relationship: CareRelationship)` | `void` | Persiste una relacion nueva o actualizada |

---

#### 4.2.1.2. Interface Layer

Esta capa expone las capacidades del BC IAM al mundo exterior mediante endpoints HTTP REST. Los controllers reciben las solicitudes, delegan inmediatamente a la Application Layer y retornan la respuesta formateada. No contienen logica de negocio.

##### `AuthController`
**Proposito:** Gestiona los endpoints de autenticacion: registro, login y logout.

| Metodo HTTP | Endpoint | Handler delegado | Descripcion |
|---|---|---|---|
| `POST` | `/api/v1/auth/register` | `RegisterUserCommandHandler` | Registra un nuevo usuario (Adulto Mayor o Cuidador) |
| `POST` | `/api/v1/auth/login` | `LoginCommandHandler` | Autentica credenciales y retorna JWT + refresh token |
| `POST` | `/api/v1/auth/refresh` | `RefreshTokenCommandHandler` | Renueva el JWT usando el refresh token |
| `POST` | `/api/v1/auth/logout` | `LogoutCommandHandler` | Invalida el refresh token del usuario |

##### `UserController`
**Proposito:** Expone operaciones sobre el perfil del usuario autenticado.

| Metodo HTTP | Endpoint | Handler delegado | Descripcion |
|---|---|---|---|
| `GET` | `/api/v1/users/me` | `GetCurrentUserQueryHandler` | Retorna el perfil del usuario autenticado |
| `PUT` | `/api/v1/users/me` | `UpdateUserProfileCommandHandler` | Actualiza nombre o telefono del usuario |
| `PUT` | `/api/v1/users/me/password` | `ChangePasswordCommandHandler` | Cambia la contrasena del usuario autenticado |
| `DELETE` | `/api/v1/users/me` | `DeactivateUserCommandHandler` | Desactiva la cuenta del usuario |

##### `DeviceController`
**Proposito:** Gestiona el registro y vinculacion de dispositivos ESP32.

| Metodo HTTP | Endpoint | Handler delegado | Descripcion |
|---|---|---|---|
| `POST` | `/api/v1/devices` | `RegisterDeviceCommandHandler` | Registra un nuevo ESP32 en el sistema |
| `POST` | `/api/v1/devices/{deviceId}/bind` | `BindDeviceCommandHandler` | Vincula el dispositivo al Adulto Mayor autenticado |
| `DELETE` | `/api/v1/devices/{deviceId}/bind` | `UnbindDeviceCommandHandler` | Desvincula el dispositivo de su dueno actual |
| `GET` | `/api/v1/devices/me` | `GetMyDeviceQueryHandler` | Retorna el dispositivo vinculado al usuario autenticado |
| `PATCH` | `/api/v1/devices/{deviceId}/status` | `UpdateDeviceStatusCommandHandler` | Actualiza el estado del dispositivo (heartbeat edge) |

##### `CareRelationshipController`
**Proposito:** Gestiona el flujo de invitacion y vinculacion entre Adulto Mayor y Cuidador.

| Metodo HTTP | Endpoint | Handler delegado | Descripcion |
|---|---|---|---|
| `POST` | `/api/v1/care-relationships/invite` | `InviteCaregiverCommandHandler` | El Adulto Mayor invita a un Cuidador por email |
| `POST` | `/api/v1/care-relationships/accept` | `AcceptInvitationCommandHandler` | El Cuidador acepta la invitacion usando el token |
| `DELETE` | `/api/v1/care-relationships/{id}` | `RevokeCareRelationshipCommandHandler` | Cualquiera de las partes revoca el vinculo |
| `GET` | `/api/v1/care-relationships/me` | `GetMyCareRelationshipQueryHandler` | Retorna la relacion activa del usuario autenticado |

---

#### 4.2.1.3. Application Layer

Esta capa orquesta los flujos de negocio del BC IAM. Los Command Handlers ejecutan operaciones de escritura y los Query Handlers resuelven lecturas. Ninguno contiene logica de dominio: la delegan a las entidades y domain services correspondientes.

##### Command Handlers

###### `RegisterUserCommandHandler`
**Proposito:** Orquesta el registro de un nuevo usuario en el sistema.

**Command:** `RegisterUserCommand { fullName, email, rawPassword, role, phoneNumber }`

**Flujo:**
1. Verifica que no exista un usuario con el mismo email via `IUserRepository`.
2. Crea el `PasswordHash` usando `IPasswordHashingService`.
3. Construye la entidad `User` con los value objects correspondientes.
4. Persiste via `IUserRepository`.
5. Publica evento `UserRegisteredEvent`.

###### `LoginCommandHandler`
**Proposito:** Valida credenciales y emite tokens de sesion.

**Command:** `LoginCommand { email, rawPassword }`

**Flujo:**
1. Busca el usuario por email via `IUserRepository`.
2. Delega validacion de credenciales a `AuthenticationDomainService`.
3. Si es valido, solicita JWT y refresh token a `ITokenService`.
4. Retorna `LoginResult { accessToken, refreshToken, expiresIn }`.

###### `RefreshTokenCommandHandler`
**Proposito:** Renueva el JWT de un usuario con sesion activa.

**Command:** `RefreshTokenCommand { refreshToken }`

**Flujo:**
1. Valida el refresh token via `ITokenService`.
2. Extrae el `UserId` del token.
3. Verifica que el usuario este activo via `IUserRepository`.
4. Emite un nuevo JWT y retorna.

###### `LogoutCommandHandler`
**Proposito:** Invalida el refresh token activo del usuario.

**Command:** `LogoutCommand { refreshToken }`

**Flujo:**
1. Valida el refresh token via `ITokenService`.
2. Llama a `ITokenService.revoke(refreshToken)` para anadirlo a la blacklist.

###### `BindDeviceCommandHandler`
**Proposito:** Vincula un ESP32 registrado a un Adulto Mayor.

**Command:** `BindDeviceCommand { deviceId, requesterId }`

**Flujo:**
1. Recupera el `Device` via `IDeviceRepository`.
2. Recupera el `User` via `IUserRepository`.
3. Verifica elegibilidad con `DeviceBindingDomainService.canBind()`.
4. Ejecuta `device.bind(ownerId)`.
5. Persiste via `IDeviceRepository`.
6. Publica evento `DeviceBoundEvent`.

###### `UnbindDeviceCommandHandler`
**Proposito:** Desvincula un dispositivo de su Adulto Mayor actual.

**Command:** `UnbindDeviceCommand { deviceId, requesterId }`

**Flujo:**
1. Recupera el `Device` via `IDeviceRepository`.
2. Valida autorizacion con `DeviceBindingDomainService.canUnbind()`.
3. Ejecuta `device.unbind()`.
4. Persiste via `IDeviceRepository`.

###### `InviteCaregiverCommandHandler`
**Proposito:** El Adulto Mayor genera una invitacion para un Cuidador.

**Command:** `InviteCaregiverCommand { elderlyUserId, caregiverEmail }`

**Flujo:**
1. Verifica que el Cuidador exista y tenga rol `CAREGIVER` via `IUserRepository`.
2. Verifica que no exista ya una relacion activa via `ICareRelationshipRepository`.
3. Genera un `invitationToken` unico.
4. Crea y persiste la `CareRelationship` en estado `PENDING`.
5. Publica evento `CaregiverInvitedEvent` para que `Notifications` envie el email de invitacion.

###### `AcceptInvitationCommandHandler`
**Proposito:** El Cuidador acepta la invitacion y activa el vinculo.

**Command:** `AcceptInvitationCommand { invitationToken, caregiverId }`

**Flujo:**
1. Busca la relacion por `invitationToken` via `ICareRelationshipRepository`.
2. Verifica que la relacion este en estado `PENDING`.
3. Verifica que el `caregiverId` coincida.
4. Ejecuta `relationship.accept()`.
5. Persiste via `ICareRelationshipRepository`.

###### `RevokeCareRelationshipCommandHandler`
**Proposito:** Revoca el vinculo entre Adulto Mayor y Cuidador.

**Command:** `RevokeCareRelationshipCommand { relationshipId, requesterId }`

**Flujo:**
1. Recupera la relacion via `ICareRelationshipRepository`.
2. Valida que `requesterId` sea una de las dos partes.
3. Ejecuta `relationship.revoke()`.
4. Persiste via `ICareRelationshipRepository`.

##### Event Handlers

###### `UserRegisteredEventHandler`
**Proposito:** Reacciona al evento `UserRegisteredEvent`. Puede delegar al BC `Notifications` el envio de un email de bienvenida.

**Evento:** `UserRegisteredEvent { userId, email, role }`

###### `DeviceBoundEventHandler`
**Proposito:** Reacciona al evento `DeviceBoundEvent`. Actualiza el estado del dispositivo y puede notificar al Cuidador vinculado que hay un dispositivo activo.

**Evento:** `DeviceBoundEvent { deviceId, ownerId }`

---

#### 4.2.1.4. Infrastructure Layer

Esta capa provee las implementaciones concretas de las interfaces definidas en el Domain Layer y gestiona la comunicacion con sistemas externos como la base de datos relacional y los servicios de tokens.

##### Repository Implementations

###### `UserRepositoryImpl`
**Proposito:** Implementacion concreta de `IUserRepository`. Accede a la base de datos relacional MySQL para persistir y recuperar usuarios.  
**Tecnologia:** .NET + Entity Framework Core + MySQL (`Pomelo.EntityFrameworkCore.MySql`)

| Metodo | Descripcion de implementacion |
|---|---|
| `findById(id)` | `DbContext.Users.FirstOrDefaultAsync(u => u.Id == id)` con indice primario sobre `user_id` |
| `findByEmail(email)` | `DbContext.Users.FirstOrDefaultAsync(u => u.Email == email)` con indice unico sobre columna `email` |
| `save(user)` | `DbContext.Users.Update(user)` + `SaveChangesAsync()`, EF Core resuelve insert vs update automaticamente |
| `delete(id)` | Soft delete: `UPDATE users SET is_active = 0 WHERE user_id = ?`, nunca eliminacion fisica |

###### `DeviceRepositoryImpl`
**Proposito:** Implementacion concreta de `IDeviceRepository`. Gestiona la persistencia de dispositivos ESP32 garantizando integridad referencial con la tabla de usuarios.  
**Tecnologia:** .NET + Entity Framework Core + MySQL

| Metodo | Descripcion de implementacion |
|---|---|
| `findById(id)` | `DbContext.Devices.FirstOrDefaultAsync(d => d.Id == id)` |
| `findByMacAddress(mac)` | Query sobre columna `mac_address` con indice unico; garantiza unicidad a nivel de base de datos |
| `findByOwnerId(ownerId)` | `DbContext.Devices.FirstOrDefaultAsync(d => d.OwnerId == ownerId && d.Status == ACTIVE)` |
| `save(device)` | `DbContext.Devices.Update(device)` + `SaveChangesAsync()`. La FK `owner_id -> users.user_id` garantiza que no exista un dispositivo sin dueno valido |

###### `CareRelationshipRepositoryImpl`
**Proposito:** Implementacion concreta de `ICareRelationshipRepository`. La naturaleza relacional de este vinculo (Adulto Mayor <-> Cuidador) se beneficia directamente de las constraints de MySQL.  
**Tecnologia:** .NET + Entity Framework Core + MySQL

| Metodo | Descripcion de implementacion |
|---|---|
| `findByElderlyUserId(id)` | Query filtrando `elderly_user_id = ?` y `status = 'ACTIVE'` con FK validada contra tabla `users` |
| `findByCaregiverId(id)` | Query filtrando `caregiver_id = ?`, retorna todos los estados; JOIN implicito validado por FK |
| `findByInvitationToken(token)` | Query sobre columna `invitation_token` con indice unico |
| `save(relationship)` | `DbContext.CareRelationships.Update(rel)` + `SaveChangesAsync()`. Ambas FKs (`elderly_user_id`, `caregiver_id`) son validadas por MySQL antes de persistir |

##### External Service Implementations

###### `JwtTokenServiceImpl`
**Proposito:** Implementacion concreta de `ITokenService`. Emite, valida y revoca JWT dentro del ecosistema .NET.  
**Tecnologia:** .NET + `System.IdentityModel.Tokens.Jwt` + `Microsoft.AspNetCore.Authentication.JwtBearer`

| Metodo | Descripcion |
|---|---|
| `generate(userId, role)` | Crea un `JwtSecurityToken` con claims `sub`, `role` y `exp`; firmado con clave simetrica HS256 configurable via `appsettings.json` |
| `validate(token)` | Usa `JwtSecurityTokenHandler.ValidateToken()` con `TokenValidationParameters` definidos en startup; lanza `SecurityTokenException` si invalido |
| `revoke(refreshToken)` | Persiste el token revocado en tabla `token_blacklist` en MySQL con columna `expires_at` para limpieza automatica por job |
| `refresh(refreshToken)` | Valida el refresh token contra `token_blacklist`, extrae claims y emite nuevo access token |

###### `BcryptPasswordHashingServiceImpl`
**Proposito:** Implementacion concreta de `IPasswordHashingService`. Hashea y verifica contrasenas de forma segura.  
**Tecnologia:** .NET + `BCrypt.Net-Next` (NuGet)

| Metodo | Descripcion |
|---|---|
| `hash(rawPassword)` | `BCrypt.HashPassword(rawPassword, workFactor: 12)` genera hash con salt aleatorio embebido |
| `verify(rawPassword, hash)` | `BCrypt.Verify(rawPassword, hash)` compara en tiempo constante, retorna booleano |

###### `InvitationEmailServiceImpl`
**Proposito:** Envia el correo de invitacion al Cuidador cuando el Adulto Mayor lo invita al sistema.  
**Tecnologia:** .NET + `SendGrid` (NuGet SDK)

| Metodo | Descripcion |
|---|---|
| `sendInvitation(caregiverEmail, invitationToken, elderlyName)` | Construye un `SendGridMessage` con template HTML, embebe el link de aceptacion con el token y lo despacha via `SendGridClient.SendEmailAsync()` |

##### Database Configuration

###### `IamDbContext`
**Proposito:** Clase que extiende `DbContext` de Entity Framework Core. Configura los mappings entre las entidades del dominio y las tablas MySQL del BC IAM, define constraints, indices y relaciones a nivel de ORM.  
**Tecnologia:** Entity Framework Core 8 + `Pomelo.EntityFrameworkCore.MySql`

**Tablas gestionadas:**

| Tabla | Entidad mapeada | Constraint destacada |
|---|---|---|
| `users` | `User` | PK `user_id`, indice unico `email` |
| `devices` | `Device` | PK `device_id`, indice unico `mac_address`, FK `owner_id -> users.user_id` |
| `care_relationships` | `CareRelationship` | PK `relationship_id`, FK `elderly_user_id -> users.user_id`, FK `caregiver_id -> users.user_id`, indice unico `invitation_token` |
| `token_blacklist` | *(tabla de infraestructura)* | PK `token_id`, indice sobre `expires_at` para limpieza periodica |
 
#### 4.2.1.5. Bounded Context Software Architecture Component Level Diagrams

![IAM - Component Level Diagram](./img/tactical-ddd/iam/component.svg)

Este diagrama de componentes (C4 Nivel 3) ilustra la arquitectura interna y el flujo de ejecucion del contenedor `IAM Service`. Muestra como el Bounded Context esta descompuesto de forma coherente con los principios de Arquitectura Limpia (`Interface`, `Application`, `Domain` e `Infrastructure`). El diagrama traza el recorrido de las peticiones desde clientes externos (App Movil y Web) hacia los controladores REST, delegando la orquestacion en los command handlers (CQRS), interactuando con las reglas de negocio en agregados de dominio y finalizando con la persistencia en MySQL mediante implementaciones concretas de repositorios.
 
#### 4.2.1.6. Bounded Context Software Architecture Code Level Diagrams
 
##### 4.2.1.6.1. Bounded Context Domain Layer Class Diagrams

![IAM - Domain Layer Class Diagram](./img/tactical-ddd/iam/class.svg)

Este diagrama de clases UML ilustra el modelo conceptual y estructural del dominio IAM. Presenta a `User` y `Device` como raices de sus respectivos agregados, detallando atributos encapsulados (Value Objects), metodos y enumeraciones que materializan las reglas de negocio. Ademas, expone las relaciones de cardinalidad con `CareRelationship`, las interfaces de repositorio que definen contratos de persistencia y los domain services encargados de logica transversal (como autenticacion y vinculacion), manteniendo el nucleo del sistema agnostico a cualquier tecnologia de infraestructura.
 
##### 4.2.1.6.2. Bounded Context Database Design Diagram

![IAM - Database Design Diagram](./img/tactical-ddd/iam/db.svg)

Este diagrama Entidad-Relacion (ERD) representa el esquema fisico de base de datos relacional (MySQL) para el Bounded Context IAM. Detalla las tablas principales (`USERS`, `DEVICES` y `CARE_RELATIONSHIPS`), sus columnas y tipos de datos. El diagrama destaca llaves primarias (PK), llaves foraneas (FK) y restricciones de unicidad (UK) que garantizan integridad referencial, reflejando como se almacena la relacion entre usuarios, sus dispositivos hardware asignados y sus vinculos de cuidado.
 

# Conclusiones

1. La validación del problema confirmó que la mayor vulnerabilidad no es la caída en sí, sino el aislamiento posterior; Foll soluciona esto mediante un sistema pasivo que alerta automáticamente sin depender de que el adulto mayor, quien suele estar aturdido o sin el celular a la mano, realice acción alguna.

2. El procesamiento local mediante Edge AI representa el mayor diferencial técnico del proyecto, ya que permite que el algoritmo aprenda de los patrones biomecánicos específicos de cada usuario en su hogar, reduciendo drásticamente las falsas alarmas en comparación con algoritmos estáticos.

3. El diseño del hardware como un cinturón imperceptible bajo la ropa es fundamental para la adopción del producto, ya que elimina el estigma social de "dispositivo médico" y la resistencia psicológica del usuario independiente, a diferencia de los colgantes o botones de pánico tradicionales.

4. La aplicación de Domain-Driven Design permitió alinear la arquitectura de software con el valor del negocio, identificando los contextos de Edge y Emergency como el núcleo estratégico del sistema, asegurando que el desarrollo se concentre en la precisión de la detección y la rapidez de respuesta.

5. El valor fundamental del ecosistema para el segmento de cuidadores es el alivio de la carga emocional y la ansiedad; la plataforma les devuelve la tranquilidad de saber que serán notificados con ubicación exacta e información médica solo cuando ocurra una emergencia real.

6. Foll logra democratizar el acceso a la tecnología de cuidado preventivo en el contexto latinoamericano, ofreciendo una alternativa de bajo costo en hardware y suscripción frente a competidores internacionales cuyos precios y modelos de retención resultan inaccesibles para la mayoría de familias locales.

7. La investigación de campo demostró una alta disposición de los usuarios a compartir datos de movimiento de forma anónima y procesarlos localmente, lo que valida la viabilidad de un modelo de mejora continua donde la inteligencia artificial del dispositivo se vuelve más precisa con el uso diario.

<br>

# Bibliografía
- Castillo Paulino, L. C. (2024). Capacidad funcional y riesgo de caídas en pacientes adultos mayores Essalud, Lima 2024 [Tesis de licenciatura, Universidad Wiener]. Repositorio Uwiener. https://repositorio.uwiener.edu.pe/entities/publication/3f46152a-5dd7-4a2d-af0f-8471d59edaa9

- Minsa. (2026, marzo 9). Minsa brinda recomendaciones para prevenir caídas en adultos mayores. Ministerio de Salud del Perú. https://www.gob.pe/institucion/minsa/noticias/1362772-minsa-brinda-recomendaciones-para-prevenir-caidas-en-adultos-mayores

- Superintendencia Nacional de Salud. (2023). Boletín Estadístico 2023. SUSALUD – Gobierno del Perú. https://www.gob.pe/institucion/susalud/informes-publicaciones/4595872-boletin-estadistico-2023


# Anexos
