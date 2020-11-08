<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ControlDeUsuario.aspx.cs" Inherits="_Default" %>
<%@ Register src="TextBoxNoEmpty.ascx" tagname="TextBoxNoEmpty" tagprefix="uc1" %>
<%@ Register Src="TextBoxNoEmpty.ascx" TagPrefix="uc2" TagName="TextBoxNoEmpty" %>
<%@ Register Src="TextBoxCuit.ascx" TagPrefix="uc3" TagName="TextBoxCuit" %>
<%@ Register Src="TextBoxMayorEdad.ascx" TagPrefix="uc4" TagName="TextBoxMayorEdad" %>
<%@ Register Src="ComboPaises.ascx" TagPrefix="uc5" TagName="ComboPaises" %>
<%@ Register Src="RadioButtonSex.ascx" TagPrefix="uc6" TagName="RadioButtonSex" %>
<%@ Register Src="RangoHijosMenores.ascx" TagPrefix="uc7" TagName="RangoHijosMenores" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Datos
            <br />
            <uc1:TextBoxNoEmpty ID="txtApellido" runat="server" />
            <br />
            <uc2:TextBoxNoEmpty runat="server" ID="txtNombre" />
            <br />
            <uc3:TextBoxCuit runat="server" ID="txtCuit" />
            <br />
            <uc4:TextBoxMayorEdad runat="server" ID="txtEdad" />
            <br />
            <uc6:RadioButtonSex runat="server" ID="RadioButtonSex" />          
            <uc5:ComboPaises runat="server" ID="ComboPaises" />
            <br />
            <uc7:RangoHijosMenores runat="server" ID="RangoHijosMenores" />
            <br />
            <asp:Button ID="btn" runat="server" Text="Validar" OnClick="BtnClick"></asp:Button>
        </div>
        <div>
            <span id="lbApellido" runat="server"></span>
            <br />
            <span id="lbNombre" runat="server"></span>
            <br />
            <span id="lbCuit" runat="server"></span>
            <br />
            <span id="lbEdad" runat="server"></span>
            <br />
            <span id="lbSexo" runat="server"></span>
            <br />
            <span id="lbPais" runat="server"></span>
            <br />
            <span id="lbHijos" runat="server"></span>
        </div>
    </form>
</body>
</html>
