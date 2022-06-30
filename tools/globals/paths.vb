Namespace tools.Globals

    Public Class paths

        Public Shared Function GetLanguageFileName(ByVal server As System.Web.HttpServerUtility) As String
            If development.DebugMode Then
                Return server.MapPath("//WMS_AIMAR/Include/XMLMultilingual/") + "MultilingualText.xml"
            Else
                Return server.MapPath("//Include/XMLMultilingual/") + "MultilingualText.xml"
            End If
        End Function

        Public Shared Function GetDBConnectionsFileName(ByVal server As System.Web.HttpServerUtility) As String
            If development.DebugMode Then
                Return server.MapPath("//WMS_AIMAR/Include/XMLConnection/") + "Cnn.debug.xml"
            Else
                Return server.MapPath("//Include/XMLConnection/") + "Cnn.release.xml"
            End If
        End Function

        Public Shared Function GetImagesPath(ByVal server As System.Web.HttpServerUtility) As String
            If development.DebugMode Then
                Return server.MapPath("//WMS_AIMAR/Include/XMLURL/") + "ServerURL.debug.xml"
            Else
                Return server.MapPath("//Include/XMLURL/") + "ServerURL.release.xml"
            End If
        End Function

        Public Shared Function GetServerPath() As String
            If development.DebugMode Then
                Return "//WMS_AIMAR/"
            Else
                Return "//"
            End If
        End Function

    End Class

End Namespace