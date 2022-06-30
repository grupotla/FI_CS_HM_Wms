Public Class _default
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'VISITOR REMOTE_ADDR

        'If Request.ServerVariables("SERVER_NAME") = "10.10.1.32" Then
        Response.Redirect("login/login.aspx")
        'Else
        'Response.Redirect("http://10.10.1.10:81/login/login.aspx") 'cambiado 2017-06-05 para produccion nada mas
        'End If

    End Sub

End Class
