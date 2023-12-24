<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
</head>
<body runat="server" id="BodyTag">
    <form id="form1" runat="server">
        <asp:DropDownList runat="server" id="ColorSelector" autopostback="true" onselectedindexchanged="ColorSelector_IndexChanged">
            <asp:ListItem value="White" selected="True">Select color...</asp:ListItem>
            <asp:ListItem value="Red">Red</asp:ListItem>
            <asp:ListItem value="Green">Green</asp:ListItem>
            <asp:ListItem value="Blue">Blue</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
