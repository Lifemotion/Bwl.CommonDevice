Public Class ImpulseActor
    Implements IImpulseActor
    Protected _id As String
    Protected _name As String
    Protected _actDelegate As ImpulseActorActDelegate
    Public Delegate Sub ImpulseActorActDelegate(params() As String)

    Public Sub New(id As String, name As String, actDelegate As ImpulseActorActDelegate)
        _name = name
        _id = id
        _actDelegate = actDelegate
    End Sub
    Public ReadOnly Property Name As String Implements IActor.Name
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Type As String Implements IActor.Type
        Get
            Return MyClass.GetType.ToString
        End Get
    End Property

    Public Sub Act(ParamArray params() As String) Implements IImpulseActor.Act
        _actDelegate(params)
    End Sub

    Public ReadOnly Property ID As String Implements ISensorActorBase.ID
        Get
            Return _id
        End Get
    End Property
End Class
