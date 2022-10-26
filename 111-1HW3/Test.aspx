<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="_111_1HW3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Category" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList ID="ddl_Food" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>