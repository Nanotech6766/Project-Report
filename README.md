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
    - [4.2.1. Bounded Context: \<Bounded Context Name\>](#421-bounded-context-bounded-context-name)
      - [4.2.1.1. Domain Layer](#4211-domain-layer)
      - [4.2.1.2. Interface Layer](#4212-interface-layer)
      - [4.2.1.3. Application Layer](#4213-application-layer)
      - [4.2.1.4. Infrastructure Layer](#4214-infrastructure-layer)
      - [4.2.1.5. Bounded Context Software Architecture Component Level Diagrams](#4215-bounded-context-software-architecture-component-level-diagrams)
      - [4.2.1.6. Bounded Context Software Architecture Code Level Diagrams](#4216-bounded-context-software-architecture-code-level-diagrams)
        - [4.2.1.6.1. Bounded Context Domain Layer Class Diagrams](#42161-bounded-context-domain-layer-class-diagrams)
        - [4.2.1.6.2. Bounded Context Database Design Diagram](#42162-bounded-context-database-design-diagram)
 
---
 
# Student Outcome
 
 
---
 
# Capítulo I: Introducción
 
## 1.1. Startup Profile
 
### 1.1.1. Descripción de la Startup
 
### 1.1.2. Perfiles de integrantes del equipo

<table align="center" border="1" cellspacing="0" cellpadding="8" style="width: 90%; border-collapse: collapse;">
  <tr>
    <td style="width: 150px; text-align: center;">
      <img src="img/profile-photos/"  width="520"></img>
    </td>
      <td>
          <p align="center"><strong>NOMBRE - CODE ALUMNO</strong></p>
          <p align="justify">
            DESCRIPCION
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
 
### 2.2.2. Registro de entrevistas
 
### 2.2.3. Análisis de entrevistas
 
## 2.3. Needfinding
 
### 2.3.1. User Personas
 
### 2.3.2. User Task Matrix
 
### 2.3.3. User Journey Mapping
 
### 2.3.4. Empathy Mapping
 
## 2.4. Big Picture EventStorming
 
## 2.5. Ubiquitous Language
 
---
 
# Capítulo III: Requirements Specification
 
## 3.1. User Stories
 
## 3.2. Impact Mapping
 
## 3.3. Product Backlog
 
---
 
# Capítulo IV: Solution Software Design
 
## 4.1. Strategic-Level Domain-Driven Design
 
### 4.1.1. Design-Level EventStorming
 
#### 4.1.1.1. Candidate Context Discovery
 
#### 4.1.1.2. Domain Message Flows Modeling
 
#### 4.1.1.3. Bounded Context Canvases
 
### 4.1.2. Context Mapping
 
### 4.1.3. Software Architecture
 
#### 4.1.3.1. Software Architecture System Landscape Diagram
 
#### 4.1.3.2. Software Architecture Context Level Diagrams
 
#### 4.1.3.3. Software Architecture Container Level Diagrams
 
#### 4.1.3.4. Software Architecture Deployment Diagrams
 
## 4.2. Tactical-Level Domain-Driven Design
 
### 4.2.1. Bounded Context: \<Bounded Context Name\>
 
#### 4.2.1.1. Domain Layer
 
#### 4.2.1.2. Interface Layer
 
#### 4.2.1.3. Application Layer
 
#### 4.2.1.4. Infrastructure Layer
 
#### 4.2.1.5. Bounded Context Software Architecture Component Level Diagrams
 
#### 4.2.1.6. Bounded Context Software Architecture Code Level Diagrams
 
##### 4.2.1.6.1. Bounded Context Domain Layer Class Diagrams
 
##### 4.2.1.6.2. Bounded Context Database Design Diagram
 
