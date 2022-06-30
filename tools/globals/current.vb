Namespace tools.Globals

    Public Class current
        Private Shared iCountry As String

        Public Shared Property country() As String
            Get
                Return current.iCountry
            End Get
            Set(ByVal Value As String)
                If Value = "" Then
                    current.iCountry = "gt"
                Else
                    current.iCountry = Value
                End If

            End Set
        End Property
    End Class

End Namespace
