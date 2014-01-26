Public Interface IValueSensor
    Inherits ISensor
    ReadOnly Property ValueType As String
    ReadOnly Property Value As String
    Event ValueChanged(sender As IValueSensor, value As String)
End Interface
