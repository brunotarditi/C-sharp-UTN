﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RangoHijosMenores.ascx.cs" Inherits="RangoHijosMenores" %>
<asp:RangeValidator ID="RangoHijosMenoresEdad" ControlToValidate="txtHijos" SetFocusOnError="True" ForeColor="Red" Type="Integer" MinimumValue="1" MaximumValue="17" runat="server" ErrorMessage="Debe ser mayor a 0 y menor a 18" Text="*"></asp:RangeValidator>
<br />
<asp:TextBox ID="txtHijos" runat="server" CssClass="form-control"></asp:TextBox>


