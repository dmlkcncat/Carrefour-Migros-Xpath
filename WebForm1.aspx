<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="58px" OnClick="Button1_Click" Text="verileri al" Width="141px" />
        </p>
        <asp:ListBox ID="makyaj1" runat="server" Width="132px"></asp:ListBox>
        <asp:ListBox ID="makyaj2" runat="server" Width="111px"></asp:ListBox>
        <asp:ListBox ID="makyaj3" runat="server" Width="123px"></asp:ListBox>
    </form>
</body>
</html>
