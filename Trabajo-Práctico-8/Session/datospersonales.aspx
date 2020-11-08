<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datospersonales.aspx.cs" Inherits="Session_datospersonales" %>
<%@ Register Src="~/1.ControlesUsuarios/Fecha.ascx" TagPrefix="uc2" TagName="Fecha" %>
<%@ Register Src="~/1.ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/1.ControlesUsuarios/ComboPaises.ascx" TagPrefix="uc3" TagName="ComboPaises" %>
<%@ Register Src="~/1.ControlesUsuarios/RadioButtonSex.ascx" TagPrefix="uc4" TagName="RadioButtonSex" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbnombre" runat="server" Text="Nombre"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" id="nom" />
            <br />
            <asp:Label ID="lbapellido" runat="server" Text="Apellido"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" id="apellido" />
            <br />
            <asp:Label ID="lbdni" runat="server" Text="DNI"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" id="txtdni" />
            <br />
            <asp:Label ID="lbdomicilio" runat="server" Text="Domicilio"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" id="txtdomicilio" />          
            <br />
            <uc3:ComboPaises runat="server" ID="ComboPaises" />
            <br />
            <uc4:RadioButtonSex runat="server" ID="RadioButtonSex" />
            <br />
            <uc2:Fecha runat="server" ID="Fecha" />
            <br />
            <asp:Button runat="server" ID="btn" Text="Siguiente Paso" OnClick="Button1_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
