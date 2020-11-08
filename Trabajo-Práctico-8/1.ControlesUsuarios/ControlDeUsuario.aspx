<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ControlDeUsuario.aspx.cs" Inherits="_Default" %>

<%@ Register Src="TextBoxNoEmpty.ascx" TagName="TextBoxNoEmpty" TagPrefix="uc1" %>
<%@ Register Src="TextBoxNoEmpty.ascx" TagPrefix="uc2" TagName="TextBoxNoEmpty" %>
<%@ Register Src="TextBoxCuit.ascx" TagPrefix="uc3" TagName="TextBoxCuit" %>
<%@ Register Src="TextBoxMayorEdad.ascx" TagPrefix="uc4" TagName="TextBoxMayorEdad" %>
<%@ Register Src="ComboPaises.ascx" TagPrefix="uc5" TagName="ComboPaises" %>
<%@ Register Src="RadioButtonSex.ascx" TagPrefix="uc6" TagName="RadioButtonSex" %>
<%@ Register Src="RangoHijosMenores.ascx" TagPrefix="uc7" TagName="RangoHijosMenores" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Controles-de-Usuario</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
   
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-3 py-3" style="background-color: #E7EAEC">
            <form id="form1" runat="server">
                <div>
                    <asp:Label ID="datos" runat="server" CssClass="font-weight-bolder"> Datos</asp:Label>
                    <div class="form-group">
                        <asp:Label ID="ape" runat="server">Apellido:</asp:Label>
                        <uc1:TextBoxNoEmpty ID="txtApellido" runat="server" />                    
                        <asp:Label ID="nom" runat="server">Nombre:</asp:Label>
                        <uc2:TextBoxNoEmpty runat="server" ID="txtNombre" />                    
                        <asp:Label ID="cuit" runat="server">Cuit:</asp:Label>
                        <uc3:TextBoxCuit runat="server" ID="txtCuit" />                   
                        <asp:Label ID="edad" runat="server">Edad:</asp:Label>
                        <uc4:TextBoxMayorEdad runat="server" ID="txtEdad" />                    
                        <asp:Label ID="sex" runat="server"> Sexo:</asp:Label>
                        <uc6:RadioButtonSex runat="server" ID="RadioButtonSex" />                   
                        <asp:Label ID="pais" runat="server">País:</asp:Label>
                        <uc5:ComboPaises runat="server" ID="ComboPaises" />                 
                        <asp:Label ID="niños" runat="server">Cantidad de hijos:</asp:Label>
                        <uc7:RangoHijosMenores runat="server" ID="RangoHijosMenores" />
                    </div>
                    <asp:Button ID="btn" CssClass="btn btn-primary" runat="server" Text="Validar" OnClick="BtnClick"></asp:Button>
                </div>

            </form>
        </div>
    </div>

    <div class="row mt-3 justify-content-center">
        <div class="col-3 px-3 py-3">

            <span id="lbApellido" runat="server"></span><br />
            <span id="lbNombre" runat="server"></span><br />
            <span id="lbCuit" runat="server"></span><br />
            <span id="lbEdad" runat="server"></span><br />
            <span id="lbSexo" runat="server"></span><br />
            <span id="lbPais" runat="server"></span><br />
            <span id="lbHijos" runat="server"></span><br />

        </div>
    </div>
</body>
</html>
