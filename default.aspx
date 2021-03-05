<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Bugtracker._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hi
            <asp:Button ID="ButtonAdd" Text="Add" OnClick="ButtonAdd_Click" runat="server" />
            <asp:Button ID="ButtonEdit" Text="Edit" OnClick="ButtonEdit_Click" runat="server" />

            <asp:Table id="Table1" 
            GridLines="Both" 
            HorizontalAlign="Center" 
            Font-Names="Verdana" 
            Font-Size="12pt" 
            CellPadding="5" 
            CellSpacing="0" 
            Runat="server"/>
        </div>
    </form>
</body>
</html>
