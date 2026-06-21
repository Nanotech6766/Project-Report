@US19 @EmergencyAnalytics @WebServices
Feature: Datos de incidentes para estadísticas mensuales
  Como cuidador autenticado
  Quiero obtener el historial de caídas con fechas y estados
  Para que la interfaz Web pueda calcular el gráfico mensual con Chart.js

  Background:
    Given un cuidador autenticado con token JWT válido
    And el cuidador autenticado tiene acceso al paciente 1

  @AcceptanceTest
  Scenario: Historial retorna fechas necesarias para agregación mensual
    Given el paciente 1 tiene incidentes en mayo y junio de 2026
    When envío una petición GET a "/api/emergency/incidents/history/patient/1"
    Then la respuesta HTTP debe ser 200
    And cada incidente debe incluir openedAt
    And la respuesta debe permitir agrupar caídas por mes

  @AcceptanceTest
  Scenario: Historial vacío para paciente sin incidentes
    Given el paciente 2 no tiene incidentes registrados
    When envío una petición GET a "/api/emergency/incidents/history/patient/2"
    Then la respuesta HTTP debe ser 200
    And la respuesta debe ser una lista vacía
