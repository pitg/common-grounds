<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="LoginForm_Webform.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td><span>Username:</span></td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td><span>Password:</span></td>
                    <td>
                         <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
            <asp:Label ID="lblMessage" runat="server" />
        </div>
    </form>
</body>
</html>
