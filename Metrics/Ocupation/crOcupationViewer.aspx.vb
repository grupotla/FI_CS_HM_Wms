Public Class crOcupationViewer
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
        Dim sType As String = ""
        Dim sReportName As Object
        'Dim sPDFFile As String
        'Dim myPdfMaker As New wsCrystalPDFMaker
        Dim sTableName As String
        Dim sActivity As String

        Try
            sReportName = Server.MapPath("crOcupation.rpt")
            sType = Request.QueryString("Type")
            If sType = "" Or sType = Nothing Then sType = "1"

            Select Case sType
                Case "1"
                    sActivity = "Tareas de Picking"
                    sTableName = "WMS_PICKING_TASKS"

                Case "2"
                    sActivity = "Tareas de Reubicacion"
                    sTableName = "WMS_RELOCATION_TASKS"

                Case "3"
                    sActivity = "Tareas de Reabastecimiento"
                    sTableName = "WMS_REPLENISHMENT_TASKS"

                Case Else

                    sActivity = "Tareas de Inventario Fisico"
                    sTableName = "WC_UBICACIONES_CONTEO"

            End Select

            If sType <> "4" Then
                sSQL = " SELECT '" & sActivity & "' AS HIDDENVALUE1, B.LastName + ', ' + B.FirstName AS FullName, COUNT(A.Task_Number) AS Quantity " & _
                                    " FROM " & sTableName & " A, DEF_USERS B " & _
                                    " WHERE A.Cod_User = B.Cod_User " & _
                                        " AND (A.Status = 2 OR A.Status = 3) " & _
                                        " GROUP BY  B.LastName + ', ' + B.FirstName "
            Else
                sSQL = "SELECT '" & sActivity & "' AS HIDDENVALUE1, B.LastName + ', ' + B.FirstName AS FullName, Count(Cod_Ubicacion) as Quantity " & _
                    " FROM WC_UBICACIONES_CONTEO A, DEF_USERS B " & _
                    " WHERE A.Usuario = B.Cod_User and (A.Estado = '1' OR A.Estado = '2') " & _
                    " GROUP BY  B.LastName + ', ' + B.FirstName "

                sSQL = sSQL & _
                        " UNION SELECT '" & sActivity & "' AS HIDDENVALUE1, B.LastName + ', ' + B.FirstName AS FullName, Count(Cod_Product) as Quantity " & _
                    " FROM WC_PRODUCTOS_CONTEO A, DEF_USERS B " & _
                    " WHERE A.User_Assigned = B.Cod_User and (A.Status = '1' OR A.Status = '2') " & _
                    " GROUP BY  B.LastName + ', ' + B.FirstName "
            End If

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
