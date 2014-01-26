Public Interface IDeviceModel
    ReadOnly Property ModelID As String
    ReadOnly Property Name As String
    ReadOnly Property Sensors As ISensor()
    ReadOnly Property Actors As IActor()
End Interface
