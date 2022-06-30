Public Class crProdAgeMetViewer
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents r As CrystalDecisions.Web.CrystalReportViewer

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
        Dim sSQL As String = ""
        Dim sGroup As String = ""
        Dim sReportName As Object
        'Dim sPDFFile As String
        'Dim myPdfMaker As New wsCrystalPDFMaker
        'Dim sTableName As String
        'Dim sActivity As String

        Try
            sReportName = Server.MapPath("crProdAgeMet.rpt")
            sGroup = Request.QueryString("Group")

            sSQL = " SELECT C.ItmsGrpNam as GroupName, Avg(DateDiff(dd, A.Datetime_Arrival, CURRENT_TIMESTAMP())) AS Age " & _
                    " FROM WMS_Stock_x_Location A, DEF_COMMODITIES B, vw_sbo_product_groups C " & _
                    " WHERE A.Cod_Product = B.Cod_Product AND B.ItmsGrpCod = C.ItmsGrpCod "

            If sGroup <> Nothing Then
                sSQL = sSQL & " AND B.ItmsGrpCod = '" & sGroup & "'"
            End If

            sSQL = sSQL & " GROUP BY C.ItmsGrpNam"


            'sPDFFile = myPdfMaker.CreatePDFfromCrystal(sSQL, sReportName)
            'Response.ClearContent()
            'Response.ClearHeaders()
            'Response.ContentType = "application/pdf"
            'Response.WriteFile(sPDFFile)
            'Response.Flush()
            'Response.Close()

            'Call myPdfMaker.KillPDFFile(sPDFFile)

            Response.Write("EN CONSTRUCCION")

        Catch ex As Exception
            Response.Write(ex.Message)

        End Try
    End Sub

End Class
