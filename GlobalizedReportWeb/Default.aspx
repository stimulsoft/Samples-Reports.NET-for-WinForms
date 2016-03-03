<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="14px" Text="Select Country"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="150">
            <asp:ListItem Value="fr-FR">France</asp:ListItem>
            <asp:ListItem Value="de-DE">Germany</asp:ListItem>
            <asp:ListItem Value="it-IT">Italy</asp:ListItem>
            <asp:ListItem Value="ru-RU">Russia</asp:ListItem>
            <asp:ListItem Value="es-ES">Spain</asp:ListItem>
            <asp:ListItem Value="en-GB">United Kingdom</asp:ListItem>
            <asp:ListItem Value="en-US">United States</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="View Report" onclick="Button1_Click" />
        <br />
        <br />
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" />
    </div>
    </form>
</body>
</html>