Public MustInherit Class BaseDevice
    Implements IDevice

    Private _model As String = "ControlledGate"
    Private _name As String = "Controlled Gate"
    Protected _actors As IActor()
    Protected _sensors As ISensor()
    Private _id As String
    Private _storage As SettingsStorage
    Private _logger As Logger

    Public Sub New(model As String, name As String, id As String, actors As IActor(), sensors As ISensor(), storage As SettingsStorage, logger As Logger)
        _model = model
        _name = name
        _id = id
        _actors = actors
        _sensors = sensors
        _storage = storage
        _logger = logger
    End Sub

    Public ReadOnly Property ModelID As String Implements IDevice.TypeID
        Get
            Return _model
        End Get
    End Property

    Public ReadOnly Property Actors As IActor() Implements IDevice.Actors
        Get
            Return _actors
        End Get
    End Property

    Public ReadOnly Property Sensors As ISensor() Implements IDevice.Sensors
        Get
            Return _sensors
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IDevice.TypeName
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property DeviceID As String Implements IDevice.DeviceID
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property DeviceLogger As bwl.Framework.Logger Implements IDevice.DeviceLogger
        Get
            Return _logger
        End Get
    End Property

    Public ReadOnly Property DeviceStorage As bwl.Framework.SettingsStorage Implements IDevice.DeviceStorage
        Get
            Return _storage
        End Get
    End Property
End Class
