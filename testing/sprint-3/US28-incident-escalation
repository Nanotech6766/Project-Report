# language: es
Requisito: Monitoreo y Escalamiento de Incidentes

  @US28 @HU_Escalamiento @EmergencyAnalytics @WebServices
  Característica: Escalamiento de incidentes de emergencia
    Como sistema de monitoreo de salud
    Quiero transicionar el estado de un incidente a "Escalado" después de 3 minutos de inactividad o falta de confirmación
    Para notificar a los contactos de emergencia cuando el paciente principal no responde.

    @AcceptanceTest
    Escenario: Transición automática de incidente abierto a escalado por timeout
      Dado un paciente "Juan Perez" con un dispositivo activo
      Y un incidente de emergencia abierto registrado hace 3 minutos
      Cuando el background worker detecta el timeout del incidente
      Entonces el estado del incidente debe cambiar a "Escalado"
      Y se debe disparar la notificación de alerta de escalamiento a los contactos de emergencia mediante SMS.
