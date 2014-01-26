Imports System.Windows.Forms

Module Test

    Sub Main()
        '    Dim rfid = New Emulators.RfidReaderEmulator("id1", "com3,baud:4800")
        '    Dim rfidNewReadSensor As IEventSensor = rfid.Sensors(0)
        '  AddHandler rfidNewReadSensor.EventHappened, AddressOf NewRfidReadHandler

        '  Dim gate = New Emulators.ControlledGateEmulator("id2", "com4,baud:9600")
        '   Dim gateOpenStateSensor As IValueSensor = gate.Sensors(0)
        '   AddHandler gateOpenStateSensor.ValueChanged, AddressOf GateOpenStateChangedHandler
        '   Dim gateOpenActor As IImpulseActor = Nothing
        '   For Each actor In gate.Actors
        '    If actor.Name = "Open" Then gateOpenActor = actor
        '   Next
        '    gateOpenActor.Act()

        Application.Run()
    End Sub

    Sub NewRfidReadHandler(sender As Object, args() As String)
        Console.WriteLine("Rfid card read: " + args(0) + ", " + args(1))
    End Sub

    Sub GateOpenStateChangedHandler(sender As Object, value As String)
        Console.WriteLine("Gate open state changed: " + value)
    End Sub

End Module
