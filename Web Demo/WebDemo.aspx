<%@ Page language="c#" Inherits="WebDemo.WebDemo" CodeFile="WebDemo.aspx.cs" %>
<%@ Register TagPrefix="cc1" Namespace="Stimulsoft.Report.Web" Assembly="Stimulsoft.Report.Web" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form method="post" runat="server">
			<div style="FONT-WEIGHT: bold; FONT-SIZE: 20pt; COLOR: blue">
				<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="FONT-SIZE: 20pt; COLOR: white; FONT-FAMILY: Arial" bgColor="#5f9eef" height="60">&nbsp;</TD>
						<TD style="FONT-WEIGHT: bold; FONT-SIZE: 20pt; COLOR: white; FONT-FAMILY: Arial" bgColor="#5f9eef"
							colSpan="2" height="60">Stimulsoft Reports.Net Web Demo</TD>
						<TD style="FONT-SIZE: 20pt; COLOR: white; FONT-FAMILY: Arial" bgColor="#5f9eef" height="60">&nbsp;</TD>
					</TR>
					<TR>
						<TD style="COLOR: white; HEIGHT: 35px" bgColor="#5f9eef"></TD>
						<TD bgColor="#5f9eef" style="HEIGHT: 35px"><a class="link" href="http://www.stimulsoft.com/">http://www.stimulsoft.com</a></TD>
						<TD align="right" bgColor="#5f9eef" style="HEIGHT: 35px"><asp:label id="Label1" runat="server" Font-Bold="True" ForeColor="White" Width="110px">Reports:</asp:label><asp:dropdownlist id="ReportsList" runat="server" Width="151px" AutoPostBack="True">
								<asp:ListItem Value="SimpleList" Selected="True">Simple list</asp:ListItem>
								<asp:ListItem Value="TwoSimpleLists">Two Simple Lists</asp:ListItem>
								<asp:ListItem Value="SideBySideListWithContainers">Side by Side List</asp:ListItem>
								<asp:ListItem Value="HighlightCondition">Highlight Condition</asp:ListItem>
								<asp:ListItem Value="SimpleGroup">Simple group</asp:ListItem>
								<asp:ListItem Value="SideBySideGroupWithContainers">Side by Side Group</asp:ListItem>
								<asp:ListItem Value="MultiColumnList">Multi-Column List</asp:ListItem>
								<asp:ListItem Value="MultiColumnBandsAcrossThenDown">Multi-Column Bands</asp:ListItem>
								<asp:ListItem Value="Labels">Labels</asp:ListItem>
								<asp:ListItem Value="MasterDetail">Master-Detail</asp:ListItem>
							</asp:dropdownlist></TD>
						<TD align="right" bgColor="#5f9eef" style="HEIGHT: 35px"></TD>
					</TR>
					<TR>
						<TD style="COLOR: white" bgColor="#5f9eef"></TD>
						<TD style="COLOR: white" bgColor="#5f9eef">&nbsp;</TD>
						<TD align="right" bgColor="#5f9eef">&nbsp;</TD>
						<TD align="right" bgColor="#5f9eef"></TD>
					</TR>
				</TABLE>
			</div>
			<br>
			<br>
			<cc1:StiWebViewer id="StiWebViewer1" runat="server" Width="100%" Height="509px"
				ToolBarBackColor="WhiteSmoke" ImagesPath="Images/"></cc1:StiWebViewer>
		</form>
	</body>
</HTML>
