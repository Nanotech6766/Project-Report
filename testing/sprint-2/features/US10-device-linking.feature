@US10 @DeviceManagement @WebServices
Feature: Vinculación del cinturón IoT al paciente
  Como cuidador autenticado
  Quiero vincular un dispositivo IoT mediante su identificador
  Para habilitar el input de serial en Web y Mobile

  Background:
    Given un cuidador autenticado con token JWT válido
    And existe un paciente con id 1 vinculado al cuidador autenticado

  @AcceptanceTest
  Scenario: Vinculación exitosa de dispositivo al paciente
    Given existe un dispositivo IoT con id 1001 sin paciente asignado
    When envío una petición POST a "/api/devices/1001/link" con:
      | patientId |
      | 1         |
    Then la respuesta HTTP debe ser 200
    And el dispositivo 1001 debe estar asignado al paciente 1

  @AcceptanceTest
  Scenario: Consulta de dispositivo vinculado por paciente
    Given el paciente 1 tiene el dispositivo 1001 vinculado
    When envío una petición GET a "/api/devices/patient/1"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe incluir deviceId 1001

  @AcceptanceTest
  Scenario: Rechazo de vinculación por dispositivo inexistente
    When envío una petición POST a "/api/devices/99999/link" con:
      | patientId |
      | 1         |
    Then la respuesta HTTP debe ser 400
