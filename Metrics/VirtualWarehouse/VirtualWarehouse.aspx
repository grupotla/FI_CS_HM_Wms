<%@ Page Language="vb" AutoEventWireup="false" Codebehind="VirtualWarehouse.aspx.vb" Inherits="WMS_AIMAR.VirtualWarehouse" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>Virtual Warehouse</title>
		<script language="javascript" src="../../Include/js/coolbuttons.js"></script>
		<script language="javascript">
			function ShowInv(sLocation)
			{
				window.open("../../inquiries/stock/reports/StockViewer.aspx?pType=5&pParam=" + sLocation, "","resizable=1; width=700; height=500; top=50; left=50; scrollbars=1");
			}
		</script>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="VBScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../../Include/styles/form.css" type="text/css" rel="stylesheet">
  </HEAD>
	<body topmargin="0" leftmargin="0" bottommargin="0" rightmargin="0" scroll="yes" >
		<form id="frmMain" method="post" runat="server">
		<table>
			<tr>
				<td bgcolor="gainsboro" style="BORDER-RIGHT: black thin solid; BORDER-TOP: black thin solid; BORDER-LEFT: black thin solid; BORDER-BOTTOM: black thin solid">
					<%BuildVWH()%>	
				</td>
			</tr>
		</table>
			
		
		</form>
	</body>
</HTML>
