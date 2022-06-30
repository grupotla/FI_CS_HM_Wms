Public Class crDemandViewer
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
        Dim sBuilding As String = ""
        Dim sReportName As Object
        'Dim sPDFFile As String
        'Dim myPdfMaker As New wsCrystalPDFMaker

        Try
            sReportName = Server.MapPath("crDemand.rpt")
            sBuilding = Request.QueryString("Building")

            sSQL = " SELECT '1' AS HIDDENVALUE1, 'Pendiente Asignacion' AS FullName, Count(DISTINCT A.DocNum) AS Quantity  " & _
                    " FROM VW_SBO_Sales_Header A " & _
                    " WHERE NOT EXISTS (Select * FROM WMS_Picking_Tasks C " & _
                                            " WHERE C.Status <> '9' AND C.ERP_Document = Cast(A.DocNum as Varchar) AND C.Reason='1') "

            sSQL = sSQL & " UNION "

            sSQL = sSQL & " SELECT '2' AS HIDDENVALUE1, 'Asignados pendientes de Picking' AS FullName, Count(DISTINCT A.Erp_Document) AS Quantity  " & _
                    " FROM WMS_Picking_Tasks A " & _
                    " WHERE A.Reason = '1' AND A.Status = '2' " & _
                        "AND NOT EXISTS (Select * FROM WMS_Picking_Tasks C " & _
                                            " WHERE C.Status <> '9' AND C.Status <> '2' AND C.ERP_Document = A.Erp_Document AND C.Reason='1') "

            sSQL = sSQL & " UNION "

            sSQL = sSQL & " SELECT '3' AS HIDDENVALUE1, 'Picking en Proceso' AS FullName, Count(DISTINCT A.Erp_Document) AS Quantity  " & _
                    " FROM WMS_Picking_Tasks A, WMS_Dispatch_Cycle B " & _
                    " WHERE A.ERP_Document = B.ERP_Document AND A.Reason = '1' AND A.Status IN ('3', '4') " & _
                        "AND B.Picking_Start IS NOT NULL AND B.Picking_End IS NULL "

            sSQL = sSQL & " UNION "

            sSQL = sSQL & " SELECT '4' AS HIDDENVALUE1, 'Picking Finalizado - Pendiente de Despacho' AS FullName, Count(DISTINCT A.Erp_Document) AS Quantity  " & _
                    " FROM WMS_Picking_Tasks A " & _
                    " WHERE A.Reason = '1' AND A.Status = '4' " & _
                        "AND NOT EXISTS (Select * FROM WMS_Picking_Tasks C " & _
                                            " WHERE C.Status <> '9' AND C.Status <> '4' AND C.ERP_Document = A.Erp_Document AND C.Reason='1') "

            sSQL = sSQL & " ORDER BY HIDDENVALUE1"


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
