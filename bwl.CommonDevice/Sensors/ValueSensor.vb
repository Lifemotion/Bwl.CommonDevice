Public Class ValueSensor(Of T)
    Implements IValueSensor

    Protected _name As String
    Protected _value As T
    Protected _id As String
    Public Sub New(id As String, name As String)
        _name = name
        _id = id
    End Sub

    Public ReadOnly Property Name As String Implements ISensor.Name
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Type As String Implements ISensor.Type
        Get
            Return MyClass.GetType.ToString
        End Get
    End Property

    Public ReadOnly Property Value As String Implements IValueSensor.Value
        Get
            Return _value.ToString
        End Get
    End Property

    Public ReadOnly Property ValueType As String Implements IValueSensor.ValueType
        Get
            Return _value.GetType.ToString
        End Get
    End Property

    Public Event ValueChanged(sender As IValueSensor, value As String) Implements IValueSensor.ValueChanged
    'TODO: костыль и криво
    Public Sub ChangeValue(newValue As T)
        _value = newValue
        RaiseEvent ValueChanged(Me, _value.ToString)
    End Sub

    Public ReadOnly Property ID As String Implements ISensorActorBase.ID
        Get
            Return _id
        End Get
    End Property
End Class
