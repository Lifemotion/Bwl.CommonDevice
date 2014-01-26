Public Interface IEventSensor
    Inherits ISensor
    Event EventHappened(sender As IEventSensor, args() As String)
End Interface
