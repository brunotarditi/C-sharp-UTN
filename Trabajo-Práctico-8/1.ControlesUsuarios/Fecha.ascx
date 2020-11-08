<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Fecha.ascx.cs" Inherits="WebUserControl" %>
<asp:TextBox ID="dia" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ID="rfvDay" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="dia" ErrorMessage="(*) Día" Text="*" BorderColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
&nbsp;<asp:DropDownList ID="ddlMes" runat="server">
    <asp:ListItem Text="Mes" Value=""></asp:ListItem>
    <asp:ListItem Text="Enero" Value="1"></asp:ListItem>
    <asp:ListItem Text="Febrero" Value="2"></asp:ListItem>
    <asp:ListItem Text="Marzo" Value="3"></asp:ListItem>
    <asp:ListItem Text="Abril" Value="4"></asp:ListItem>
    <asp:ListItem Text="Mayo" Value="5"></asp:ListItem>
    <asp:ListItem Text="Junio" Value="6"></asp:ListItem>
    <asp:ListItem Text="Julio" Value="7"></asp:ListItem>
    <asp:ListItem Text="Agosto" Value="8"></asp:ListItem>
    <asp:ListItem Text="Septiembre" Value="9"></asp:ListItem>
    <asp:ListItem Text="Octubre" Value="10"></asp:ListItem>
    <asp:ListItem Text="Noviembre" Value="11"></asp:ListItem>
    <asp:ListItem Text="Diciembre" Value="12"></asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator runat="server" ID="rfvMonth" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="ddlMes" ErrorMessage="(*) Mes" Text="*"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="anio" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ID="rfvYear" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="anio" ErrorMessage="(*) Año" Text="*"></asp:RequiredFieldValidator>
<asp:RangeValidator runat="server" ID="rvYear" SetFocusOnError="True" ForeColor="Red" Type="Integer" ControlToValidate="anio" MinimumValue="1930" MaximumValue="2020" ErrorMessage="(*) El año debe estar entre 1930 y el año actual" Text="*"></asp:RangeValidator>
