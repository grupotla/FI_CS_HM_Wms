Public Class ProductsAgeMetTitle
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

    Public Sub FillGroupsCombo()
        Dim rsData As ADODB.Recordset
        Dim xServ As New wsCommonServices
        Dim sSQL As String

        sSQL = "SELECT ItmsGrpCod, ItmsGrpNam FROM vw_sbo_product_groups ORDER BY ItmsGrpCod "
        Try

            rsData = xServ.GetADORecordset(sSQL)
            If Not (rsData.BOF And rsData.EOF) Then
                Do While Not rsData.EOF
                    Response.Write("<Option value='" & CStr(rsData("ItmsGrpCod").Value).ToUpper() & "'>" & CStr(rsData("ItmsGrpNam").Value) & "</Option>")
                    rsData.MoveNext()
                Loop
            End If

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

End Class
