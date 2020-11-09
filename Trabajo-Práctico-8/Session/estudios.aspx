<%@ Page Language="C#" AutoEventWireup="true" CodeFile="estudios.aspx.cs" Inherits="Session_estudios" %>

<%@ Register Src="~/ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Antecedentes educacionales</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-4 py-4" style="background-color: #F8E18A">
            <form id="form1" runat="server">
                <div>
                    <div class="form-group">
                        <asp:Label ID="niveles" runat="server" Text="Nivel de Estudio"></asp:Label>
                        <asp:DropDownList ID="nivelesEstudio" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="titulo" runat="server" Text="Titulo"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="txtTitulo" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="establecimiento" runat="server" Text="Establecimiento"></asp:Label>
                        <uc1:TextBoxNoEmpty runat="server" ID="txtEstablecimiento" />
                    </div>
                    <div class="justify-content-end" style="text-align: right">
                        <asp:Button runat="server" ID="btn" CssClass="btn btn-danger" Text="Siguiente Paso" OnClick="Button1_Click" />
                    </div>

                </div>
            </form>
        </div>
    </div>
</body>
</html>
