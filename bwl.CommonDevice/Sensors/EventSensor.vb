Public Class EventSensor
    Implements IEventSensor

    Protected _id As String
    Protected _name As String

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

    'TODO: костыль и криво
    Public Sub RaiseNewEvent(args() As String)
        RaiseEvent EventHappened(Me, args)
    End Sub

	Public Event EventHappened(sender As IEventSensor, args() As String) Implements IEventSensor.EventHappened

    Public ReadOnly Property ID As String Implements ISensorActorBase.ID
        Get
            Return _id
        End Get
    End Property
End Class
