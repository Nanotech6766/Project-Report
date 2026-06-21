@US17 @EmergencyAnalytics @WebServices
Feature: Consulta del historial cronológico de caídas
  Como cuidador autenticado
  Quiero consultar el historial de incidentes de un paciente
  Para alimentar la lista cronológica de la interfaz Web y Mobile

  Background:
    Given un cuidador autenticado con token JWT válido
    And el cuidador autenticado tiene acceso al paciente 1

  @AcceptanceTest
  Scenario: Listado del historial de incidentes por paciente
    Given el paciente 1 tiene incidentes registrados en distintas fechas
    When envío una petición GET a "/api/emergency/incidents/history/patient/1"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe ser una lista ordenada cronológicamente

  @AcceptanceTest
  Scenario: Consulta de detalle de incidente histórico
    Given existe un incidente histórico con id 8 del paciente 1
    When envío una petición GET a "/api/emergency/incidents/8"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe incluir incidentId 8

  @AcceptanceTest
  Scenario: Rechazo de historial para paciente sin permisos
    Given el cuidador autenticado no tiene acceso al paciente 999
    When envío una petición GET a "/api/emergency/incidents/history/patient/999"
    Then la respuesta HTTP debe ser 400
