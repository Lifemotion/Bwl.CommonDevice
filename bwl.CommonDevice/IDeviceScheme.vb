Public Interface IDeviceScheme
    ReadOnly Property TypeID As String
    ReadOnly Property TypeName As String
	ReadOnly Property Sensors As IEnumerable(Of ISensor)
	ReadOnly Property Actors As IEnumerable(Of IActor)
End Interface
