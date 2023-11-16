Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module.Win

    <DefaultClassOptions>
    Public Class Master
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        <Association("Master-Children")>
        Public ReadOnly Property Children As XPCollection(Of Child)
            Get
                Return GetCollection(Of Child)("Children")
            End Get
        End Property

        Private _name As String

        Public Property Name As String
            Get
                Return _name
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", _name, value)
            End Set
        End Property
    End Class
End Namespace
