<%@ Page Language="C#" AutoEventWireup="true" CodeFile="trabajos.aspx.cs" Inherits="Session_t" %>

<%@ Register Src="~/ControlesUsuarios/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/ControlesUsuarios/Fecha.ascx" TagPrefix="uc2" TagName="Fecha" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Experiencia laboral</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-4 py-4" style="background-color: #F8E18A">
            <form id="form1" runat="server">
                <div>
                    <asp:Label ID="Periodo" runat="server" Text="Periodo de Ocupación"></asp:Label><br />
                    <asp:Label ID="desde" runat="server" Text="Desde"></asp:Label>                    
                    <uc2:Fecha runat="server" ID="fecDesde" />                    
                    <asp:Label ID="hasta" runat="server" Text="Hasta"></asp:Label>
                    <uc2:Fecha runat="server" ID="fecHasta" />
                    <asp:Label ID="Lugar" runat="server" Text="Lugar de Trabajo"></asp:Label>
                    <uc1:TextBoxNoEmpty runat="server" ID="txtlugar" />
                    <asp:Label ID="Tarea" runat="server" Text="Tarea desempeñada"></asp:Label>
                    <uc1:TextBoxNoEmpty runat="server" ID="txttarea" /><br />
                    <div class="justify-content-end" style="text-align: right">
                        <asp:Button runat="server" ID="btn" CssClass="btn btn-danger" Text="Siguiente Paso" OnClick="Button1_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
