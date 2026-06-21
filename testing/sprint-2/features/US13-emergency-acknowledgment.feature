@US13 @NotificationCommunication @WebServices
Feature: Confirmación de auxilio en alerta de emergencia
  Como cuidador autenticado
  Quiero confirmar que estoy en camino ante una alerta de caída
  Para sincronizar el estado con WebSockets y el botón "Estoy en camino"

  Background:
    Given un cuidador autenticado con token JWT válido

  @AcceptanceTest
  Scenario: Confirmación de notificación de caída
    Given existe una notificación de caída con id 20 dirigida al cuidador autenticado
    When envío una petición POST a "/api/notifications/20/acknowledge"
    Then la respuesta HTTP debe ser 200
    And la notificación 20 debe quedar en estado "Acknowledged"

  @AcceptanceTest
  Scenario: Resolución de incidente activo tras atención
    Given existe un incidente activo con id 15 para el paciente 1
    When envío una petición POST a "/api/emergency/incidents/15/resolve" con:
      | observation        |
      | Paciente asistido  |
    Then la respuesta HTTP debe ser 200
    And el incidente 15 debe quedar en estado "Resolved"

  @AcceptanceTest
  Scenario: Rechazo de confirmación de notificación ajena
    Given existe una notificación con id 99 dirigida a otro cuidador
    When envío una petición POST a "/api/notifications/99/acknowledge"
    Then la respuesta HTTP debe ser 400
