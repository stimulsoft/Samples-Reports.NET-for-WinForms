<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Stimulsoft.Report.Web" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%" height="500">
            <tr>
                <td style="width: 20%; height: 21px" valign="top">
                    <asp:ListBox ID="ListBox1" runat="server" Height="331px" Width="100%" AutoPostBack="True">
                        <asp:ListItem Value="Brazil"></asp:ListItem>
                        <asp:ListItem Value="France"></asp:ListItem>
                        <asp:ListItem Value="Germany"></asp:ListItem>
                        <asp:ListItem Value="Italy"></asp:ListItem>
                        <asp:ListItem Value="Spain"></asp:ListItem>
                        <asp:ListItem Value="UK"></asp:ListItem>
                        <asp:ListItem Value="USA"></asp:ListItem>
                    </asp:ListBox></td>
                <td style="width: 80%; height: 21px" valign="top">
                    <cc1:StiWebViewer ID="StiWebViewer1" runat="server" Height="500px" Width="100%" ScrollBarsMode="True" />
                </td>
            </tr>
        </table>
    
    </div>
        <cc1:StiReportWeb ID="StiReportWeb1" runat="server" ReportSource="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" />
    </form>
</body>
</html>
