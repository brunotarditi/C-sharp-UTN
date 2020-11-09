<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datospersonales.aspx.cs" Inherits="Session_datospersonales" %>

<%@ Register Src="~/1.ControlesUsuarios/Fecha.ascx" TagPrefix="uc2" TagName="Fecha" %>
<%@ Register Src="~/1.ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/1.ControlesUsuarios/ComboPaises.ascx" TagPrefix="uc3" TagName="ComboPaises" %>
<%@ Register Src="~/1.ControlesUsuarios/RadioButtonSex.ascx" TagPrefix="uc4" TagName="RadioButtonSex" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Datos-personales</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-4 py-4" style="background-color: #F8E18A">
            <form id="form1" runat="server">
                <div>
                    <div class="form-group">
                        <asp:Label ID="lbnombre" runat="server" Text="Nombre"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="nom" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbapellido" runat="server" Text="Apellido"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="apellido" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbdni" runat="server" Text="DNI"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="txtdni" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbdomicilio" runat="server" Text="Domicilio"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="txtdomicilio" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbnacionalidad" runat="server" Text="Nacionalidad"></asp:Label>
                        <uc3:ComboPaises runat="server" ID="ComboPaises" />
                    </div>
                <div class="form-group">
                    <asp:Label ID="lbsex" runat="server" Text="Sexo: "></asp:Label>
                    <uc4:RadioButtonSex runat="server" ID="RadioButtonSex" />
                </div>
                <asp:Label ID="lbfec" runat="server" Text="Fecha de nacimiento"></asp:Label>
                <uc2:Fecha runat="server" ID="Fecha" />
                <div class="justify-content-end" style="text-align: right">
                    <asp:Button runat="server" ID="btn" Text="Siguiente Paso" CssClass="btn btn-danger" OnClick="Button1_Click" />
                </div>
            </div>
        </form>
    </div>
    </div>
</body>
</html>
