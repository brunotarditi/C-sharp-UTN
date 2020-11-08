<%@ Page Language="C#" AutoEventWireup="true" CodeFile="trabajos.aspx.cs" Inherits="Session_t" %>

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
            <asp:Label ID="Periodo" runat="server" Text="Periodo de Ocupación"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txtperiodo" />
            <br />
            <asp:Label ID="Lugar" runat="server" Text="Lugar de Trabajo"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txtlugar" />
            <br />
            <asp:Label ID="Tarea" runat="server" Text="Tarea desempeñada"></asp:Label>
            <br />
            <uc1:TextBoxNoEmpty runat="server" ID="txttarea" />
             <br />
            <asp:Button runat="server" ID="btn" CssClass="btn btn-primary" Text="Siguiente Paso" OnClick="Button1_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
