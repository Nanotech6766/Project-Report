@US06 @Care @WebServices
Feature: Creación y consulta de perfil de paciente
  Como cuidador autenticado
  Quiero crear y consultar el perfil de un adulto mayor
  Para gestionarlo desde las interfaces Web y Mobile

  Background:
    Given un cuidador autenticado con token JWT válido

  @AcceptanceTest
  Scenario: Creación de paciente con datos básicos
    When envío una petición POST a "/api/care/patients" con:
      | dni       | firstName | lastName | birthDate  | relationshipTypeId |
      | 12345678  | Rosa      | Quispe   | 1945-03-12 | 1                  |
    Then la respuesta HTTP debe ser 201
    And el paciente creado debe tener DNI "12345678"

  @AcceptanceTest
  Scenario: Consulta de paciente por identificador
    Given existe un paciente con id 1 vinculado al cuidador autenticado
    When envío una petición GET a "/api/care/patients/1"
    Then la respuesta HTTP debe ser 200
    And el cuerpo debe incluir firstName y lastName del paciente

  @AcceptanceTest
  Scenario: Listado de pacientes por cuidador
    Given el cuidador autenticado tiene pacientes asignados
    When envío una petición GET a "/api/care/patients/by-caregiver/{userId}"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe ser una lista no vacía
