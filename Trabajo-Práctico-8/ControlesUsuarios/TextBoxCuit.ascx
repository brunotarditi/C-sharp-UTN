<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxCuit.ascx.cs" Inherits="TextBoxCuit" %>
<asp:CustomValidator ID="customCuit" SetFocusOnError="True" ForeColor="Red" ControlToValidate="txtCuitValido"  runat="server" ErrorMessage="Debe ser un cuit válido" OnServerValidate="Validar" Text="*"></asp:CustomValidator>
<br />
<asp:TextBox ID="txtCuitValido" runat="server" CssClass="form-control"></asp:TextBox>


