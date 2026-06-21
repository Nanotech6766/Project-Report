@US18 @EmergencyAnalytics @WebServices
Feature: Marcado y filtrado de falsos positivos en el historial
  Como cuidador autenticado
  Quiero marcar incidentes como falsos positivos y consultar su estado
  Para habilitar los toggles de filtrado del historial en la interfaz

  Background:
    Given un cuidador autenticado con token JWT válido
    And el cuidador autenticado tiene acceso al paciente 1

  @AcceptanceTest
  Scenario: Marcado de incidente como falso positivo
    Given existe un incidente abierto con id 12 para el paciente 1
    When envío una petición POST a "/api/emergency/incidents/12/false-positive" con:
      | observation              |
      | Movimiento involuntario  |
    Then la respuesta HTTP debe ser 200
    And el incidente 12 debe quedar en estado "FalsePositive"

  @AcceptanceTest
  Scenario: Historial incluye incidentes resueltos y falsos positivos
    Given el paciente 1 tiene un incidente resuelto y uno marcado como falso positivo
    When envío una petición GET a "/api/emergency/incidents/history/patient/1"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe incluir al menos un incidente con status "Resolved"
    And la respuesta debe incluir al menos un incidente con status "FalsePositive"
