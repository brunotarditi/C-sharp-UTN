<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxCuit.ascx.cs" Inherits="TextBoxCuit" %>
<asp:TextBox ID="txtCuitValido" runat="server"></asp:TextBox>
<asp:CustomValidator ID="customCuit" ControlToValidate="txtCuitValido"  runat="server" ErrorMessage="Debe ser un cuit válido" OnServerValidate="Validar" Text="*"></asp:CustomValidator>

