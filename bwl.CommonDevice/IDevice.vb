Public Interface IDevice
    Inherits IDeviceScheme

    ReadOnly Property DeviceID As String

    ReadOnly Property DeviceStorage As SettingsStorage
    ReadOnly Property DeviceLogger As Logger

End Interface
