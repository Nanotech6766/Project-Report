# language: es
Requisito: Vinculación Rápida de Cuidadores

  @US34 @HU_QR @Care @WebServices
  Característica: Vinculación rápida de cuidador mediante código QR
    Como cuidador registrado
    Quiero escanear el código QR del paciente
    Para vincularme a él rápidamente sin flujos complejos de invitación.

    @AcceptanceTest
    Escenario: Vinculación exitosa de cuidador a través de QR
      Dado un paciente "Juan Perez" registrado en el sistema con ID 1
      Y un cuidador registrado con ID 2 que no está vinculado al paciente
      Cuando se realiza una solicitud POST a "/api/patients/1/caregivers/qr" con el ID del cuidador
      Entonces el servidor debe responder con un código de estado 200 OK
      Y el cuidador debe quedar vinculado al paciente con el rol por defecto de cuidador.
