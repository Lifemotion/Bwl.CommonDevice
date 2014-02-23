Public MustInherit Class BaseDevice
	Implements IDevice
	Implements IDisposable

    Private _model As String = "ControlledGate"
    Private _name As String = "Controlled Gate"
	Private _actors As New List(Of IActor)
	Private _sensors As New List(Of ISensor)
    Private _id As String
    Private _storage As SettingsStorage
    Private _logger As Logger

    Public Sub New(model As String, name As String, id As String, actors As IActor(), sensors As ISensor(), storage As SettingsStorage, logger As Logger)
        _model = model
        _name = name
        _id = id
		_storage = storage
		_logger = logger

		If sensors IsNot Nothing Then
			For Each sensor In sensors
				AddSensor(sensor)
			Next
		End If

		If actors IsNot Nothing Then
			For Each actor In actors
				AddActor(actor)
			Next
		End If
    End Sub

	Protected Sub AddSensor(sensor As ISensor)
		_sensors.Add(sensor)
		If TypeOf (sensor) Is IEventSensor Then
			AddHandler CType(sensor, IEventSensor).EventHappened, AddressOf OnSensorEventHappened
		End If
		If TypeOf (sensor) Is IValueSensor Then
			AddHandler CType(sensor, IValueSensor).ValueChanged, AddressOf OnSensorValueChanged
		End If
	End Sub

	Protected Sub AddActor(actor As IActor)
		_actors.Add(actor)
	End Sub

	Public ReadOnly Property ModelID As String Implements IDevice.TypeID
		Get
			Return _model
		End Get
	End Property

	Public ReadOnly Property Actors As IEnumerable(Of IActor) Implements IDevice.Actors
		Get
			Return _actors
		End Get
	End Property

	Public ReadOnly Property Sensors As IEnumerable(Of ISensor) Implements IDevice.Sensors
		Get
			Return _sensors
		End Get
	End Property

	Public ReadOnly Property TypeName As String Implements IDevice.TypeName
		Get
			Return _name
		End Get
	End Property

	Public Event SensorValueChanged(sensor As IValueSensor, device As IDevice, value As String)
	Public Event SensorEventHappened(sensor As IEventSensor, device As IDevice, values As String())

	Private Sub OnSensorValueChanged(sender As IValueSensor, args As String)
		RaiseEvent SensorValueChanged(sender, Me, args)
	End Sub

	Private Sub OnSensorEventHappened(sender As IEventSensor, values() As String)
		RaiseEvent SensorEventHappened(sender, Me, values)
	End Sub

	Public ReadOnly Property DeviceID As String Implements IDevice.DeviceID
		Get
			Return _id
		End Get
	End Property

	Public ReadOnly Property DeviceLogger As Bwl.Framework.Logger Implements IDevice.DeviceLogger
		Get
			Return _logger
		End Get
	End Property

	Public ReadOnly Property DeviceStorage As Bwl.Framework.SettingsStorage Implements IDevice.DeviceStorage
		Get
			Return _storage
		End Get
	End Property

	Public Sub Dispose() Implements IDisposable.Dispose
		For Each sensor In Sensors
			If TypeOf (sensor) Is IEventSensor Then
				RemoveHandler CType(sensor, IEventSensor).EventHappened, AddressOf OnSensorEventHappened
			End If
			If TypeOf (sensor) Is IValueSensor Then
				RemoveHandler CType(sensor, IValueSensor).ValueChanged, AddressOf OnSensorValueChanged
			End If
		Next
	End Sub
End Class
