<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExemploWebForm.aspx.cs" Inherits="ExemploApp.ExemploWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Exemplo Web Form</h1>

        <%--<asp:Calendar runat="server"></asp:Calendar>--%>



        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clique Aqui" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>



    </form>
</body>
</html>
