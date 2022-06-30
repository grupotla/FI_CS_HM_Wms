Public Class OcupationList
    Inherits System.Web.UI.Page


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents tblList As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSortField As System.Web.UI.HtmlControls.HtmlInputHidden

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public sSortField As String
    Public sType As String


    Private Function BuildSQL() As String
        Dim sSQL As String
        Dim xListBuilder As New wsListBuilder
        Dim bFilter As Boolean = False
        Dim sTableName As String = ""
        Dim sActivity As String = ""

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

            Case "4"
                sActivity = "Tareas de Inventario Fisico"
                'sTableName = "WMS_Replenishment_Tasks"

        End Select

        sSQL = " SELECT '" & sActivity & "' AS HIDDENVALUE1, B.LastName + ', ' + B.FirstName AS FullName, COUNT(A.Task_Number) AS Quantity " & _
                " FROM " & sTableName & " A, DEF_USERS B " & _
                " WHERE A.Cod_User = B.Cod_User " & _
                    " AND (A.Status = 2 OR A.Status = 3) " & _
                    " GROUP BY  B.LastName + ', ' + B.FirstName "

        If sType = "4" Then
            sSQL = "SELECT '" & sActivity & "' AS HIDDENVALUE1, B.LastName + ', ' + B.FirstName AS FullName, Count(A.*) as Quantity " & _
                    " FROM WC_UBICACIONES_CONTEO A, DEF_USERS B " & _
                    " WHERE A.Usuario = b.Cod_User and (a.Estado = '1' OR a.Estado = '2') " & _
                    " GROUP BY  B.LastName + ', ' + B.FirstName "
        End If

        Return sSQL

    End Function


    Private Sub BuildTable()

        Dim sXML As String
        Dim sSQL As String
        Dim cListBuilder As New wsListBuilder

        sSQL = BuildSQL()
        sXML = cListBuilder.BuildXMLHeader("", sSQL, 0, 0, "", "")
        sXML = sXML & cListBuilder.AddXMLNode("User", "Usuario Asignado", "text", "", "text", "", "300")
        sXML = sXML & cListBuilder.AddXMLNode("Quantity", "Tareas", "integer", "", "text", "", "200")
        sXML = sXML & cListBuilder.CloseXML()

        Try
            Call cListBuilder.BuildTable(sXML, Me.tblList)
        Catch ex As Exception
            Response.Write(ex.Message & " " & sSQL)
        End Try

    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sType = Request.QueryString("Type")
        BuildTable()

    End Sub
End Class
