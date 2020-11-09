<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxNoEmpty.ascx.cs" Inherits="WebUserControl" %>
<asp:RequiredFieldValidator ID="txtRequerido" SetFocusOnError="True" ForeColor="Red" ControlToValidate="txtNoVacio" runat="server" Text="*" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>
<br />
<asp:TextBox ID="txtNoVacio" runat="server" CssClass="form-control"></asp:TextBox>