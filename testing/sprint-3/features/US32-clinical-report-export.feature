# language: es
Requisito: Exportación de Reporte Clínico en PDF

  @US32 @HU_PDF @Care @Frontend
  Característica: Exportación de reporte clínico en formato PDF
    Como médico o cuidador
    Quiero exportar el historial de caídas del paciente en un archivo PDF tabulado
    Para presentarlo en consultas clínicas.

    @AcceptanceTest
    Escenario: Descarga de reporte de caídas de paciente exitoso
      Dado el usuario se encuentra en la pantalla de "Reportes" del paciente "Juan Perez"
      Y el paciente tiene un historial de caídas registrado en el sistema
      Cuando el usuario hace clic en el botón de descarga del reporte PDF
      Entonces el sistema debe generar un documento PDF estructurado en el navegador
      Y el archivo PDF debe descargarse automáticamente con la información del paciente.
