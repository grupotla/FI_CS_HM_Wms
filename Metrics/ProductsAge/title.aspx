<%@ Page Language="vb" AutoEventWireup="false" Codebehind="title.aspx.vb" Inherits="WMS_AIMAR.ProductsAgeMetTitle" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<script LANGUAGE="javascript">

			function ShowGraph()
			{
				window.parent.frames('graph').location.href='crProdAgeMetViewer.aspx?Group='+cboGroups.value;				
			}
			
			function getQueryString( sProp ) {
				var re = new RegExp( sProp + "=([^\\&]*)", "i" );
				var a = re.exec( document.location.search );
				if ( a == null )
					return "";
				return a[1];
			}

			function changeCssFile( sCssFile ) {
				var loc = String(document.location);
				var search = document.location.search;
				if ( search != "" )
					loc = loc.replace( search, "" );
				loc = loc + "?css=" + sCssFile;
				document.location.replace( loc );
			}

			var cssFile = getQueryString( "css" );
			if ( cssFile == "" ){
				cssFile = "../../Include/styles/qnx.css";
			}
			
			document.write("<link type=\"text/css\" rel=\"StyleSheet\" href=\"" + cssFile + "\" />" );

		</script>
		<script language="javascript" src="../../Include/js/coolbuttons.js"></script>
		<link rel="stylesheet" type="text/css" href="../../Include/styles/titles.css">
		<meta NAME="GENERATOR" Content="Microsoft FrontPage 5.0">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body topmargin="0" leftmargin="0" scroll="no" onload="ShowGraph();">
		<table WIDTH="100%" cellspacing="0" cellpadding="0" border="0">
			<tr>
				<th bgcolor="Cornflowerblue" valign="middle" align="center" height="35" width="3%">
					&nbsp;<img border="0" SRC="../../Include/Images/prod_age_small.gif">
				</th>
				<th bgcolor="Cornflowerblue" align="left">
					<P>Indicador de Antiguedad de Productos en Inventario</P>
				</th>
			</tr>
		</table>
		<table WIDTH="100%" cellspacing="0" cellpadding="0" border="0">
			<tr>
				<td bgcolor="silver" width="30" height="25">
					<img src="../../include/images/clearpixel.gif">
				</td>
				<td bgcolor="silver" width="250">
					<select id="cboGroups" name="cboGroups" style="FONT-SIZE: 8pt; WIDTH: 100%; FONT-FAMILY: verdana">
						<option value=''></option>
						<%FillGroupsCombo%>
					</select>
				</td>
				<td width="5" bgcolor="silver"><img src="../../include/images/clearpixel.gif"></td>
				<td width="18" bgcolor="silver" onclick="ShowGraph();" style="cursor:hand"><img src="../../include/images/go.gif"></td>
				<td width="*" bgcolor="silver"><img src="../../include/images/clearpixel.gif">
				</td>
			</tr>
		</table>
	</body>
</HTML>
