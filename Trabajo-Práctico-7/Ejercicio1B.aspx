<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ejercicio1B.aspx.cs" Inherits="Ejercicio1B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ASP.NET</title>
</head>
<body>
    <form runat="server">
        <%-- TABLA --%>
        <asp:Table CellPadding="10" GridLines="Both" HorizontalAlign="Center" runat="server" Width="40%" Height="7%">
            <%-- FILA CABECERA --%>
            <asp:TableRow>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableCell>COMPONENTES ASP</asp:TableCell>
            </asp:TableRow>
            <%-- FILA CAJA DE TEXTO ASP --%>
            <asp:TableRow>
                <asp:TableCell>Caja de texto</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtCaja" TextMode="SingleLine"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA COMBO BOX ASP --%>
            <asp:TableRow>
                <asp:TableCell>Combo</asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList runat="server" ID="combo">
                        <asp:ListItem Value="java" Text="Java"></asp:ListItem>
                        <asp:ListItem Value="python" Text="Python"></asp:ListItem>
                        <asp:ListItem Value="c++" Text="C++"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA IMAGEN ASP --%>
            <asp:TableRow>
                <asp:TableCell>Imagen</asp:TableCell>
                <asp:TableCell>
                    <asp:Image ImageUrl="https://i.pinimg.com/originals/54/4b/4f/544b4fc1c4cd77c4157521b90a5a37d7.jpg" Width="200" Height="150" ID="img" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA CHECKBOX ASP --%>
            <asp:TableRow>
                <asp:TableCell>Checkbox</asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBoxList RepeatColumns="2" ID="cbx" runat="server">
                        <asp:ListItem Value="si" Text="SI"></asp:ListItem>
                        <asp:ListItem Value="no" Text="NO"></asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA HIPERVINCULO ASP --%>
            <asp:TableRow>
                <asp:TableCell>Hipervinculo</asp:TableCell>
                <asp:TableCell>
                    <asp:HyperLink runat="server" ID="link" NavigateUrl="https://google.com">Google</asp:HyperLink>
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA RADIO BUTTON ASP --%>
            <asp:TableRow>
                <asp:TableCell>Radio Button</asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButtonList runat="server" ID="radio" RepeatColumns="3">
                        <asp:ListItem Value="alta" Text="Alta"></asp:ListItem>
                        <asp:ListItem Value="media" Text="Media"></asp:ListItem>
                        <asp:ListItem Value="baja" Text="Baja"></asp:ListItem>
                    </asp:RadioButtonList>
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA CAMPO OCULTO ASP --%>
            <asp:TableRow>
                <asp:TableCell>Campo Oculto</asp:TableCell>
                <asp:TableCell>
                    <asp:HiddenField runat="server" ID="hdn" Value="oculto" />
                </asp:TableCell>
            </asp:TableRow>
            <%-- FILA BUTTON ASP --%>
            <asp:TableRow>
                <asp:TableCell>Boton</asp:TableCell>
                <asp:TableCell><asp:Button runat="server" Text="Button" OnClick="DatosIngresadosASP"/></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell ColumnSpan="2" Font-Bold="true">Datos Ingresados:</asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Caja de Texto:</asp:TableCell>
                <asp:TableCell runat="server" ID="caja"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Combo:</asp:TableCell>
                <asp:TableCell runat="server" ID="cbo"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Imagen:</asp:TableCell>
                <asp:TableCell runat="server" ID="imagen"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">CheckBox:</asp:TableCell>
                <asp:TableCell runat="server" ID="cbox"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Hipervinculo:</asp:TableCell>
                <asp:TableCell runat="server" ID="hyp"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Radio Button:</asp:TableCell>
                <asp:TableCell runat="server" ID="rbtn"></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell Font-Bold="true">Campo Oculto:</asp:TableCell>
                <asp:TableCell runat="server" ID="campo"></asp:TableCell>
            </asp:TableRow>

        </asp:Table>
    </form>
</body>
</html>
