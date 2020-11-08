<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxNoEmpty.ascx.cs" Inherits="WebUserControl" %>
<asp:TextBox ID="txtNoVacio" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="txtRequerido" ControlToValidate="txtNoVacio" runat="server" Text="*" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>

