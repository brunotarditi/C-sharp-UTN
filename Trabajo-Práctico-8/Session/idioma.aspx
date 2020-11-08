<%@ Page Language="C#" AutoEventWireup="true" CodeFile="idioma.aspx.cs" Inherits="Session_Idiomas" %>

<%@ Register Src="~/1.ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="idioma" runat="server" Text="Idioma"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txtidioma" />
            <br />
            <br />
            <asp:Label ID="nivel" runat="server" Text="Nivel de Conocimiento"></asp:Label>
            <asp:RadioButtonList ID="radioIdioma" runat="server" RepeatColumns="3">
                <asp:ListItem Value="Basico" Text="Básico"></asp:ListItem>
                <asp:ListItem Value="Intermedio" Text="Intermedio"></asp:ListItem>
                <asp:ListItem Value="Avanzado" Text="Avanzando"></asp:ListItem>
            </asp:RadioButtonList>

             <br />
            <asp:Button runat="server" ID="btn" CssClass="btn btn-primary" Text="Enviar" OnClick="Button1_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
