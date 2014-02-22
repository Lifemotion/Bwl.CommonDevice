Public Interface IDeviceScheme
    ReadOnly Property TypeID As String
    ReadOnly Property TypeName As String
    ReadOnly Property Sensors As ISensor()
    ReadOnly Property Actors As IActor()
End Interface
