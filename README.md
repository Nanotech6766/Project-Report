# <center>Project Report</center>

<p align="center">
    <strong>Universidad Peruana de Ciencias Aplicadas</strong><br>
    <img src="https://upload.wikimedia.org/wikipedia/commons/f/fc/UPC_logo_transparente.png"></img><br>
    <strong>Ingeniería de Software - 2026-10</strong><br>
    <strong>Desarrollo de Soluciones IoT - 6766</strong><br>
    <strong>Profesor: Marco Antonio Leon Baca</strong><br>
    <br><strong>Informe del Trabajo Final</strong>
</p>

</p>

<p align="center">
    <strong>Startup: nanoTech</strong><br>
    <strong>Producto: Foll</strong>
</p>

<div style="text-align:center;">
    <h3>Team Members:</h3>
    <table align="center">
        <tr>
            <th style="text-align:center;">Member</th>
            <th style="text-align:center;">Code</th>
        </tr>
        <tr>
            <td>Ariana Cecilia Agreda Sobrino</td>
            <td>u202315044</td>
        </tr>
        <tr>
            <td>Claudia Valeria Belledonne Espinoza</td>
            <td>u202210259</td>
        </tr>
        <tr>
            <td>Mauricio Daniel Elera Rodríguez</td>
            <td>u202313702</td>
        </tr>
        <tr>
            <td>Saldaña Ayala, Fabiola del Rocío</td>
            <td>u202313773</td>
        </tr>
        <tr>
            <td>Vilca Saboya, Diego Alejandro</td>
            <td>u20231a778</td>
        </tr>
    </table>
</div>

<p align="center">
    <strong>Abril, 2026</strong>
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
 
- [Student Outcome](#student-outcome)
- [Project Report Collaboration Insights](#project-report-collaboration-insights)
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
- [Capítulo II: Requirements Elicitation & Analysis](#capítulo-ii-requirements-elicitation--analysis)
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
    - [4.2.X. Bounded Context: \<Bounded Context Name\>](#42x-bounded-context-bounded-context-name)
      - [4.2.X.1. Domain Layer](#42x1-domain-layer)
      - [4.2.X.2. Interface Layer](#42x2-interface-layer)
      - [4.2.X.3. Application Layer](#42x3-application-layer)
      - [4.2.X.4. Infrastructure Layer](#42x4-infrastructure-layer)
      - [4.2.X.5. Bounded Context Software Architecture Component Level Diagrams](#42x5-bounded-context-software-architecture-component-level-diagrams)
      - [4.2.X.6. Bounded Context Software Architecture Code Level Diagrams](#42x6-bounded-context-software-architecture-code-level-diagrams)
        - [4.2.X.6.1. Bounded Context Domain Layer Class Diagrams](#42x61-bounded-context-domain-layer-class-diagrams)
        - [4.2.X.6.2. Bounded Context Database Design Diagram](#42x62-bounded-context-database-design-diagram)
 
---
 
# Student Outcome
 
 
---
 
# Capítulo I: Introducción
 
## 1.1. Startup Profile
 
### 1.1.1. Descripción de la Startup
 
### 1.1.2. Perfiles de integrantes del equipo
 
## 1.2. Solution Profile
 
### 1.2.1. Antecedentes y problemática

<table>
    <tr>
      <td rowspan="2"><strong>What</strong></td>
      <td>¿Cuál es el problema?</td>
      <td>El problema central es la alta vulnerabilidad y pérdida de autonomía en adultos mayores debido a problemas de movilidad y fragilidad física. Al quedar bajo el cuidado de otros, se genera una dependencia crítica; sin embargo, el riesgo real se inicia cuando los cuidadores (familiares o médicos) no pueden estar físicamente presentes. En esos momentos, cualquier accidente se convierte en una crisis que nadie puede detectar a tiempo.</td>
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
      <td>El ecosistema se activa de forma simultanea: el dispositivo IoT monitorea 24/7 de manera pasiva, pero el cliente (familiar o médico) interactúa intensamente con la solución en el segundo exacto en que ocurre la caída y se dispara la notificación de alerta, permitiendo una reacción inmediata.</td>
    </tr>
    <tr>
      <td rowspan="2"><strong>Where</strong></td>
      <td>¿Dónde está el cliente cuando utiliza el producto?</td>
      <td>Gracias a la conectividad en la nube, el responsable del adulto mayor puede estar en cualquier parte del mundo (en el trabajo, viajando o en su propio hogar) y aun así tener el control total para actuar, ya sea despachando una ambulancia, contactando a un vecino o acudiendo él mismo al lugar del incidente.</td>
    </tr>
    <tr>
      <td>¿A dónde se dirige?</td>
      <td>La solución se dirige hacia la implementación de un modelo de rescate práctico y ágil. El objetivo es eliminar la sobrecarga de información innecesaria y procesos lentos, para que el flujo desde la detección hasta el auxilio médico sea lo más directo y efectivo posible.</td>
    </tr>
    <tr>
      <td rowspan="3"><strong>Who</strong></td>
      <td>¿Quiénes están involucrados?</td>
      <td>El ecosistema involucra a tres actores principales: los adultos mayores (usuarios del dispositivo físico), los apoderados o familiares responsables (receptores de alertas en la app) y el personal médico especializado (usuarios de la plataforma web para gestión clínica y seguimiento).</td>
    </tr>
    <tr>
      <td>¿A quiénes les sucede el problema?</td>
      <td>Principalmente a los adultos mayores que enfrentan el riesgo físico de caer, pero también a sus cuidadores, quienes sufren un desgaste emocional y psicológico debido a la preocupación constante y el miedo de que un accidente ocurra mientras ellos no están presentes.</td>
    </tr>
    <tr>
      <td>¿Quién lo utiliza?</td>
      <td>La solución es un ecosistema compartido: los mayores usan el hardware (discreto y cómodo), los apoderados gestionan las alertas de uno o varios pacientes desde el móvil, y los médicos utilizan la plataforma web para llevar el historial detallado de incidentes y detectar patrones de riesgo.</td>
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
      <td>Principalmente mediante las recomendaciones de otros familiares o amigos que pasaron por situaciones similares. También a través de canales profesionales, como personal médico y clínicas que confían en Foll como una herramienta de soporte preventivo.</td>
    </tr>
    <tr>
      <td>¿Cómo prefieren nuestros consumidores acceder a nuestro producto?</td>
      <td>Los cuidadores prefieren la inmediatez de la app móvil, ya que es el dispositivo que siempre tienen a la mano. En contraste, el personal médico prefiere la plataforma web, que les ofrece una visión más amplia y profesional para gestionar grandes volúmenes de registros y expedientes clínicos de manera organizada.</td>
    </tr>
    <tr>
      <td>¿Qué llevó a la persona a esa situación?</td>
      <td>La necesidad imperativa de garantizar la seguridad de sus seres queridos sin sacrificar su propia vida laboral o personal, buscando eliminar la ansiedad de "qué pasará si no estoy ahí" mediante una supervisión tecnológica inteligente.</td>
    </tr>
<tr>
  <td><strong>How Much</strong></td>
  <td>¿Qué tanto afecta el problema y cuánto cuesta no actuar?</td>
  <td>
    En el Perú, las caídas representan una de las principales causas de morbilidad en adultos mayores. 
    Según el Ministerio de Salud, estos eventos son más frecuentes en personas mayores de 70 años y pueden ocasionar fracturas, hospitalizaciones y pérdida de autonomía (Minsa, 2026).
    Estudios realizados en Lima indican que aproximadamente <strong>1 de cada 3</strong> adultos mayores atendidos en servicios de salud ha sufrido al menos una caída en el último año, con consecuencias físicas, emocionales y funcionales significativas (Castillo Paulino, 2024).
    El costo de atención por una caída con fractura en hospitales de nivel III puede superar los 
    <strong>S/ 8,000 – S/ 20,000</strong>, considerando hospitalización, cirugía, medicamentos y rehabilitación, lo que genera una carga económica importante para familias y aseguradoras (SUSALUD, 2024).
    La evidencia nacional coincide con el principio de la <strong>“Hora Dorada”</strong>: una atención rápida reduce complicaciones, mortalidad y secuelas. En adultos mayores peruanos, el riesgo de mortalidad post‑trauma es considerablemente mayor que en adultos jóvenes, especialmente en lesiones de cadera y cráneo (Castillo Paulino, 2024).
    En este contexto, soluciones como <strong>Foll</strong> permiten reducir tiempos de respuesta, evitar complicaciones y disminuir los costos asociados a hospitalización prolongada y rehabilitación tardía.
  </td>
</tr>

</tr>

</table>
 
### 1.2.2. Lean UX Process
 
#### 1.2.2.1. Lean UX Problem Statements

Nuestro servicio ofrece una plataforma digital integral para el cuidado a distancia de adultos mayores, permitiendo que sus cuidadores principales o el personal médico encargado estén alerta ante accidentes que puedan ocurrir con sus familiares o pacientes, permitiéndoles actuar con la mayor prontitud posible.

Hemos observado que un factor crítico en el cuidado geriátrico es la necesidad de una presencia física constante. Sin embargo, esta supervisión 24/7 no es una realidad para muchas personas que, a pesar de querer cuidar a sus seres queridos, deben atender responsabilidades laborales, reuniones, viajes o simplemente no pueden estar presentes el 100% del tiempo. Esta falta de monitoreo continuo causa que, ante una caída accidental, el tiempo de auxilio sea demasiado prolongado, derivando en complicaciones médicas graves o fatalidades evitables.

¿Cómo podríamos mejorar la detección y comunicación de incidentes para que los familiares y médicos puedan actuar de inmediato, basándonos en la métrica de reducción del tiempo de respuesta ante emergencias y la disminución de falsas alarmas mediante el uso de inteligencia artificial?
 
#### 1.2.2.2. Lean UX Assumptions

**User Assumptions:**

**¿Quién es mi usuario?**
Nuestros usuarios se dividen en tres perfiles: el adulto mayor que porta el dispositivo IoT, el cuidador familiar que requiere tranquilidad y alertas inmediatas, y el personal médico que gestiona el historial de varios pacientes.

**¿Dónde encaja nuestro producto en su trabajo o vida?**
Se integra de forma orgánica en la rutina del adulto mayor como un accesorio diario; en la vida del cuidador como una herramienta de supervisión remota vía smartphone; y en el flujo del médico como un tablero de control para seguimiento preventivo.

**¿Qué problemas tiene nuestro producto que resolver?**
Principalmente la ausencia de supervisión 24/7, el temor al desamparo tras un accidente doméstico y la carencia de registros de movilidad precisos para diagnósticos preventivos.

**¿Cuándo y cómo es usado nuestro producto?**
Se utiliza de manera pasiva y constante mediante el monitoreo del dispositivo. Se activa críticamente ante un patrón de impacto o caída, disparando alertas automáticas a la App y registrando el evento en la plataforma Web.

**¿Qué características son importantes?**
La precisión del algoritmo de IA, la inmediatez de las notificaciones push, la autonomía de la batería y una interfaz clara que muestre información de emergencia (alergias, tipo de sangre, contactos) del paciente.

**¿Cómo debe verse nuestro producto y cómo debe comportarse?**
El hardware debe ser discreto, ergonómico y no estigmatizante. La App debe ser intuitiva, priorizando la urgencia y los pasos a seguir tras la alerta. La Web debe ser profesional, limpia y enfocada en la visualización de datos clínicos.

**Business Assumptions:**

- Creemos que nuestros clientes necesitan una forma de monitorear a sus familiares sin invadir su privacidad y con la garantía de que serán alertados solo ante emergencias reales.
- Estas necesidades se pueden resolver mediante un dispositivo IoT con IA integrada y un ecosistema multiplataforma (Móvil/Web).
- Nuestros clientes primarios son familias con adultos mayores a cargo y centros de salud o residencias geriátricas.
- El valor fundamental que el cliente busca es la tranquilidad mental y la seguridad de un auxilio oportuno.

#### 1.2.2.3. Lean UX Hypothesis Statements

- **Creemos que** implementar un modelo de Inteligencia Artificial que filtre movimientos cotidianos logrará reducir las falsas alarmas. **Sabremos que tenemos éxito cuando** observemos una reducción del 80% en las notificaciones erróneas durante las pruebas de uso diario en entornos domésticos.
- **Creemos que** enviar alertas en tiempo real con geolocalización a los apoderados permitirá agilizar el auxilio médico. **Sabremos que tenemos éxito cuando** el tiempo promedio entre la detección de la caída y la confirmación de ayuda disminuya a menos de 20 minutos.
- **Creemos que** proporcionar un panel web con el historial de incidentes a los médicos logrará identificar patrones de deterioro físico. **Sabremos que tenemos éxito cuando** al menos el 70% de los especialistas consultados utilicen los reportes de Foll para ajustar o recomendar nuevos tratamientos preventivos.
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
            <li><strong>App Móvil:</strong> Gestión de alertas en tiempo real y geolocalización para apoderados.</li>
            <li><strong>Plataforma Web:</strong> Panel de control para médicos con historial clínico y patrones de riesgo.</li>
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
            <li><strong>Apoderado/Familiar:</strong> Cliente que busca tranquilidad y respuesta inmediata.</li>
            <li><strong>Personal Médico:</strong> Usuario profesional que requiere datos precisos para prevención.</li>
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
          <ul><li>Creemos que al automatizar la detección de caídas con IoT e IA, los familiares podrán reducir los tiempos de respuesta ante emergencias y mejorar la seguridad del adulto mayor.</li>
          <li>Creemos que los médicos y cuidadores valorarán tener una única plataforma para consultar el historial de incidentes y visualizar patrones de riesgo preventivo.</li>
          <li>Creemos que al ofrecer un producto con hardware ergonómico e interfaz simple, incluso los usuarios con poca familiaridad tecnológica podrán adoptarlo rápidamente.</li>
          <li>Creemos que el envío de alertas con geolocalización permitirá a los responsables actuar de manera más eficiente y necesaria ante un accidente.</li>
        </ul>
      </td>
      <td rowspan="2" valign="top" style="padding: 10px; border: 1px solid #ccc; background-color: #f9f9f9;">
        <strong style="color: #2c3e50;">¿Cuál es la menor cantidad de trabajo para validar? </strong>
        <ul>
            <li>Desarrollo de un prototipo con sensor básico conectado a Firebase.</li>
            <li>App mínima que dispare una notificación push al detectar un impacto fuerte.</li>
            <li>Simulaciones de caída controladas con 5 usuarios para validar precisión inicial.</li>
            <li>Landing page para medir el interés de compra de familiares.</li>
        </ul>
      </td>
    </tr>
    <tr></tr>
  </tbody>
</table>

 
## 1.3. Segmentos objetivo
 
---
 
# Capítulo II: Requirements Elicitation & Analysis
 
## 2.1. Competidores
 
### 2.1.1. Análisis competitivo
 
### 2.1.2. Estrategias y tácticas frente a competidores
 
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
 
