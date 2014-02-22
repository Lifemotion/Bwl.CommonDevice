Public Interface IDeviceFactory
    Function CreateDevice(deviceID As String, emulator As Boolean) As IDevice
    ReadOnly Property TypeID() As String
    ReadOnly Property TypeName() As String
End Interface
