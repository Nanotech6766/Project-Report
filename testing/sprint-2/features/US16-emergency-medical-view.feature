@US16 @Care @EmergencyAnalytics @WebServices
Feature: Visualización de datos médicos durante una emergencia
  Como cuidador autenticado
  Quiero consultar tipo de sangre y alergias del paciente durante una alerta
  Para alimentar el dashboard de emergencia Web y Mobile

  Background:
    Given un cuidador autenticado con token JWT válido

  @AcceptanceTest
  Scenario: Consulta de perfil médico del paciente en emergencia
    Given existe un paciente con id 1 con bloodType "O+" y alergia "Penicilina"
    And el cuidador autenticado tiene acceso al paciente 1
    When envío una petición GET a "/api/care/patients/1"
    Then la respuesta HTTP debe ser 200
    And el cuerpo debe incluir bloodType "O+"
    And el cuerpo debe incluir medicalConditions con "Penicilina"

  @AcceptanceTest
  Scenario: Consulta de incidente activo con contexto del paciente
    Given existe un incidente activo para el paciente 1
    When envío una petición GET a "/api/emergency/incidents/active/patient/1"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe incluir patientId 1
