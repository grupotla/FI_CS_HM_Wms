Namespace tools

Public Class BaseTools

    Public Shared Translate As Translator

End Class

Public Class Translator

    Public Shared Function [String](ByVal messageID As String, ByVal theCountry As String, ByVal theDoc As String) As String
        Dim wsTranslate As New wsCommonServices
        [String] = wsTranslate.Translate(messageID, theCountry, theDoc)
        wsTranslate.Dispose()
    End Function


    End Class

End Namespace