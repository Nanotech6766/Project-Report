@US05 @IAM @WebServices
Feature: Registro e inicio de sesión de cuidadores
  Como cuidador registrado en Foll
  Quiero registrarme e iniciar sesión mediante la API REST
  Para acceder a las aplicaciones Web y Mobile del Sprint 2

  Background:
    Given la API de IAM está disponible en "/api/iam/auth"

  @AcceptanceTest
  Scenario: Registro exitoso de un cuidador nuevo
    When envío una petición POST a "/api/iam/auth/register" con:
      | email              | password    | firstName | lastName |
      | cuidador@foll.test | Secure123!  | Ana       | Pérez    |
    Then la respuesta HTTP debe ser 200
    And el cuerpo de la respuesta debe contener el email "cuidador@foll.test"

  @AcceptanceTest
  Scenario: Inicio de sesión con credenciales válidas
    Given existe un cuidador con email "cuidador@foll.test" y contraseña "Secure123!"
    When envío una petición POST a "/api/iam/auth/login" con:
      | email              | password   |
      | cuidador@foll.test | Secure123! |
    Then la respuesta HTTP debe ser 200
    And la respuesta debe incluir un token JWT válido

  @AcceptanceTest
  Scenario: Rechazo de registro con email duplicado
    Given existe un cuidador con email "duplicado@foll.test"
    When envío una petición POST a "/api/iam/auth/register" con:
      | email               | password   | firstName | lastName |
      | duplicado@foll.test | Secure123! | Luis      | Gómez    |
    Then la respuesta HTTP debe ser 400
