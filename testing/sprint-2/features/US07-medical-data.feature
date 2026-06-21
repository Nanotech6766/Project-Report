@US07 @Care @WebServices
Feature: Actualización de datos médicos del paciente
  Como cuidador autenticado
  Quiero actualizar alergias, tipo de sangre y condiciones médicas
  Para mostrarlas en las interfaces Web y Mobile durante el monitoreo

  Background:
    Given un cuidador autenticado con token JWT válido
    And existe un paciente con id 1 vinculado al cuidador autenticado

  @AcceptanceTest
  Scenario: Actualización de tipo de sangre y alergias
    When envío una petición PUT a "/api/care/patients/1" con:
      | bloodType | medicalConditions.allergies |
      | O+        | Penicilina, Mariscos          |
    Then la respuesta HTTP debe ser 200
    And el paciente 1 debe tener bloodType "O+"
    And el paciente 1 debe incluir la alergia "Penicilina"

  @AcceptanceTest
  Scenario: Rechazo de actualización por paciente inexistente
    When envío una petición PUT a "/api/care/patients/99999" con:
      | bloodType |
      | A+        |
    Then la respuesta HTTP debe ser 404
