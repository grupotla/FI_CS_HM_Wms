Namespace tools.Globals

    Public Class development

        Public Shared ReadOnly Property DebugMode() As Boolean
            Get
                If ConfigurationSettings.AppSettings("running_mode") = "debug" Then

                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

    End Class


End Namespace