<%@ Page Language="C#" AutoEventWireup="true" CodeFile="estudios.aspx.cs" Inherits="Session_estudios" %>

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
            <asp:Label ID="niveles" runat="server" Text="Nivel de Estudio"></asp:Label>
            <br />
            <asp:DropDownList ID="nivelesEstudio" runat="server">              
            </asp:DropDownList>
            <br />
            <asp:Label ID="titulo" runat="server" Text="Titulo"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txtTitulo" />
            <br />
            <asp:Label ID="establecimiento" runat="server" Text="Establecimiento"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txtEstablecimiento" />
            <br />
            <asp:Button runat="server" ID="btn" CssClass="btn btn-primary" Text="Siguiente Paso" OnClick="Button1_Click"/>
            <br />
            
        </div>
    </form>
</body>
</html>
