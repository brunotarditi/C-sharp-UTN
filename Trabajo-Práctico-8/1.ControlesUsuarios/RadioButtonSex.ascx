<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RadioButtonSex.ascx.cs" Inherits="RadioButtonSex" %>
<asp:RequiredFieldValidator SetFocusOnError="True" ID="rfvSex" runat="server" ForeColor="Red" InitialValue=" " ControlToValidate="rbSex" ErrorMessage="(*) Sexo" Text="*"></asp:RequiredFieldValidator>
<br />
<asp:RadioButtonList ID="rbSex" runat="server" RepeatColumns="2" class="form-check">
    <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
    <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
</asp:RadioButtonList>

