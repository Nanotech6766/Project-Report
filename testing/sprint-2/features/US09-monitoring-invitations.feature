@US09 @Care @WebServices
Feature: Gestión de solicitudes de permiso de monitoreo
  Como cuidador principal u invitado
  Quiero listar, aceptar y rechazar invitaciones de monitoreo
  Para habilitar la vista de solicitudes del Sprint 2

  Background:
    Given la API de invitaciones está disponible en "/api/care/invitations"

  @AcceptanceTest
  Scenario: Consulta de invitaciones recibidas
    Given un cuidador autenticado con token JWT válido
    When envío una petición GET a "/api/care/invitations/received"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe ser una lista de invitaciones

  @AcceptanceTest
  Scenario: Aceptación de invitación por el cuidador principal
    Given un cuidador principal autenticado con token JWT válido
    And existe una invitación pendiente con id 5 para su paciente
    When envío una petición POST a "/api/care/invitations/5/accept"
    Then la respuesta HTTP debe ser 200
    And la invitación 5 debe quedar en estado "Accepted"

  @AcceptanceTest
  Scenario: Rechazo de invitación por el cuidador principal
    Given un cuidador principal autenticado con token JWT válido
    And existe una invitación pendiente con id 6 para su paciente
    When envío una petición POST a "/api/care/invitations/6/reject"
    Then la respuesta HTTP debe ser 200
    And la invitación 6 debe quedar en estado "Rejected"
