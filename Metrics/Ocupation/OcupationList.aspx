<%@ Page Language="vb" AutoEventWireup="false" Codebehind="OcupationList.aspx.vb" Inherits="WMS_AIMAR.OcupationList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>domainsList</title>
		<script language="javascript">
			function RefreshData()
			{
				frmMain.submit();
				return false;
			}
			
			function SortTable(sField)
			{
				frmMain.txtSortField.value = sField;
				frmMain.submit();
				return false;
			}
			

			
			function ShowGraph()
			{
				window.parent.frames('graph').location.href='crOcupationViewer.aspx';
			}
			
			
			
		</script>
		<script language="JavaScript" src="../../../../Include/js/coolbuttons1.js"></script>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="VBScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../../Include/styles/console.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body topmargin="0" leftmargin="0" bottommargin="0" rightmargin="0" scroll="yes" onload="ShowGraph()">
		<form id="frmMain" method="post" runat="server">
			<input id="txtSortField" name="txtSortField" type="hidden" runat="server" style="FONT-SIZE: 10px; FONT-FAMILY: Verdana">
			<table id="tblList" runat="server" width="100%" cellspacing="0" cellpadding="1">
			</table>
		</form>
	</body>
</HTML>
