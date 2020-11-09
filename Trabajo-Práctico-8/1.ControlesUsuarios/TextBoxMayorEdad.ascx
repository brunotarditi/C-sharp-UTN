<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxMayorEdad.ascx.cs" Inherits="TextBoxMayorEdad" %>
<asp:CompareValidator ID="comparaEdad" ControlToValidate="txtMayorEdad" SetFocusOnError="True" ForeColor="Red" Operator="GreaterThanEqual" ValueToCompare="18" Type="Integer" runat="server" ErrorMessage="Debe ser mayor o igual a 18" Text="*"></asp:CompareValidator>
<br />
<asp:TextBox ID="txtMayorEdad" runat="server" CssClass="form-control"></asp:TextBox>




