<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Site.Admin.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Bem vindo a sistema</h3>
            <hr />

            <asp:Button ID="btnLogout" runat="server" Text="Sair do sistema"
                OnClick="btnLogout_Click"/>

        </div>
    </form>
</body>
</html>