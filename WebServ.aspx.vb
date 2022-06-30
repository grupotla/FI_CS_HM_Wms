Public Class WebServ


    Inherits System.Web.UI.Page
    Dim Print As New wsLabelPrinter
    Dim Print2 As New wsPrintLabels
    Dim Print3 As New Printer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cmb_Etiquetas.SelectedValue = 1 Then
            Response.Write(Print.PrintLabelCommodity("PREFIX", "DA", "BL", "CONSIGNE", "CONTAINER", "AGENT", "DATA_ENTERED", "PAQUETES", "PAQUETE", "\\172.16.9.210\zebra_Z4M", "SHORT", Session("AIMAR_REPORTS"), "DA_LABEL", "RESA"))
        End If
        If Cmb_Etiquetas.SelectedValue = 2 Then
            Response.Write(Print.PrintLabelViajeDetail("VIAJE", "VIAJED", "DETALLE", "CUSTOMER", "FABRICA", "CONSIGNE", "FECHAENTRA", "NPAQUE", "TPAQUE", "\\172.16.9.210\zebra_Z4M", "COMPANY"))
        End If
        If Cmb_Etiquetas.SelectedValue = 3 Then
            Response.Write(Print.SMDPrint("LINEA 1", "LINEA 2", "LINEA 3", "LINEA 4", "LINEA 5", "BARCODEH", 2, 1, 2, "\\172.16.9.210\zebra_Z4M"))
        End If
        If Cmb_Etiquetas.SelectedValue = 4 Then
            Response.Write(Print.SlitterPrint("LINEA 1", "LINEA 2", "BARCODEH12", 10, 1, 3))
        End If
        If Cmb_Etiquetas.SelectedValue = 5 Then
            Response.Write(Print.KitchenPrint("HOLA", "MUNDO", "BARCODE"))
        End If
        If Cmb_Etiquetas.SelectedValue = 6 Then
            Response.Write(Print2.PrintLabelCommodity("LI 1", "LI 2", "LI 3", "LI 4", "LI 5", "Barcode", 1, "02"))
        End If
        If Cmb_Etiquetas.SelectedValue = 7 Then
            Response.Write(Print2.ImprimirMultiples("COD_PROD", "DESPROD", "NLOTE", "5", "24/04/2013", "21/04/2013", "SUXC", "REG", "BARCODE", "\\172.16.9.210\zebra_Z4M", "BARCODE1", "\\172.16.9.210\zebra_Z4M"))
        End If
        If Cmb_Etiquetas.SelectedValue = 8 Then
            Response.Write(Print2.ImprimirMultiples2("COD_PROD", "DESPRODUCTO", "NLOTE", "10", "20/04/2012", "21/04/2013", "UXC", "REG", "CXP", "BARC", "\\172.16.9.210\zebra_Z4M", "BARCI", "\\172.16.9.210\zebra_Z4M"))
        End If
        If Cmb_Etiquetas.SelectedValue = 9 Then
            Response.Write(Print3.Print("codigo_barras", "\\172.16.9.210\zebra_Z4M"))
        End If





    End Sub
End Class