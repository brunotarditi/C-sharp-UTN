<%@ Page Language="C#" AutoEventWireup="true" CodeFile="idioma.aspx.cs" Inherits="Session_Idiomas" %>

<%@ Register Src="~/1.ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Idiomas</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-4 py-4" style="background-color: #F8E18A">
            <form id="form1" runat="server">
                <div>
                    <asp:Label ID="idioma" runat="server" Text="Idioma"></asp:Label>
                    <uc1:TextBoxNoEmpty runat="server" ID="txtidioma" />
                    <div class="form-group">
                        <asp:Label ID="nivel" runat="server" Text="Nivel de Conocimiento"></asp:Label>
                        <div class="form-check">                    
                            <asp:RadioButtonList ID="radioIdioma" runat="server" RepeatColumns="3">
                                <asp:ListItem Value="Basico" Text="Básico"></asp:ListItem>
                                <asp:ListItem Value="Intermedio" Text="Intermedio"></asp:ListItem>
                                <asp:ListItem Value="Avanzado" Text="Avanzando"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>
                    <div class="justify-content-end" style="text-align: right">
                        <asp:Button runat="server" ID="btn" CssClass="btn btn-danger" Text="Enviar" OnClick="Button1_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
