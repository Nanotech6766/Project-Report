@US08 @Care @WebServices
Feature: Gestión de contactos de emergencia secundarios
  Como cuidador autenticado
  Quiero agregar y eliminar contactos de emergencia del paciente
  Para completar el perfil desde las interfaces Web y Mobile

  Background:
    Given un cuidador autenticado con token JWT válido
    And existe un paciente con id 1 vinculado al cuidador autenticado

  @AcceptanceTest
  Scenario: Agregar contacto de emergencia secundario
    When envío una petición POST a "/api/care/patients/1/emergency-contacts" con:
      | fullName      | phoneNumber | relationship |
      | Carlos Quispe | 999888777   | Hijo         |
    Then la respuesta HTTP debe ser 201
    And el paciente 1 debe tener un contacto con teléfono "999888777"

  @AcceptanceTest
  Scenario: Eliminar contacto de emergencia existente
    Given el paciente 1 tiene un contacto de emergencia con id 10
    When envío una petición DELETE a "/api/care/patients/1/emergency-contacts/10"
    Then la respuesta HTTP debe ser 204
    And el paciente 1 no debe incluir el contacto 10
