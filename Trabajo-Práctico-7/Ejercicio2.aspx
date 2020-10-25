<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ejercicio2.aspx.cs" Inherits="Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script></script>
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-4 px-4 py-2" style="background-color: #E7EAEC">
            <form id="form1" runat="server">
                <div class="form-group">
                    <br />
                    <asp:Label runat="server" Font-Bold="true">Nombre</asp:Label>
                    <asp:RequiredFieldValidator runat="server" ID="rfvName" ForeColor="Red" InitialValue=" " ControlToValidate="firstname" ErrorMessage="(*) Nombre" Text="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator runat="server" ID="rfvLast" ForeColor="Red" InitialValue=" " ControlToValidate="lastname" ErrorMessage="(*) Apellido" Text="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ForeColor="Red" ValidationExpression="^[a-zA-Z]*$" ControlToValidate="firstname" ID="revName" ErrorMessage="(*) Solo deben ser letras" Text="*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator runat="server" ForeColor="Red" ValidationExpression="^[a-zA-Z]*$" ControlToValidate="lastname" ID="revLast" ErrorMessage="(*) Solo deben ser letras" Text="*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                    <div class="input-group">
                        <asp:TextBox CssClass="form-control" MaxLength="20" placeholder="Nombre" runat="server" ID="firstname" TextMode="SingleLine"></asp:TextBox>
                        &nbsp&nbsp&nbsp&nbsp
                        <asp:TextBox CssClass="form-control" MaxLength="20" placeholder="Apellido" runat="server" ID="lastname" TextMode="SingleLine"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Usuario</asp:Label>
                    <asp:RequiredFieldValidator runat="server" ID="rfvUser" ForeColor="Red" InitialValue=" " ControlToValidate="email" ErrorMessage="(*) Usuario" Text="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ID="revUser" ForeColor="Red" ControlToValidate="email" ErrorMessage="(*) Email incorrecto" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                    <asp:TextBox placeholder="@gmail.com" runat="server" ID="email" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Contraseña</asp:Label>
                    <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ForeColor="Red" InitialValue=" " ControlToValidate="password" ErrorMessage="(*) Contraseña" Text="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ID="revPassword" ControlToValidate="password" ValidationExpression=".*[!@#$%^&*+;:]+.*" ForeColor="Red" ErrorMessage="Debe incluir algunos de los siguientes simbolos !@#$%^&*+;:" Text="*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="password" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Confirma tu contraseña</asp:Label>
                    <asp:CompareValidator ID="cvPassword" SetFocusOnError="True" runat="server" ForeColor="Red" ControlToValidate="password" Operator="Equal" ControlToCompare="passwordConfirm" ErrorMessage="(*) Debe repetir la contraseña" Text="*"></asp:CompareValidator>
                    <asp:TextBox runat="server" ID="passwordConfirm" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Fecha de nacimiento</asp:Label>
                    <asp:RequiredFieldValidator runat="server" ID="rfvDay" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="day" ErrorMessage="(*) Día" Text="*"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator runat="server" ID="rfvMonth" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="month" ErrorMessage="(*) Mes" Text="*"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator runat="server" ID="rfvYear" SetFocusOnError="True" ForeColor="Red" InitialValue=" " ControlToValidate="year" ErrorMessage="(*) Año" Text="*"></asp:RequiredFieldValidator>
                    <asp:RangeValidator runat="server" ID="rvYear" SetFocusOnError="True" ForeColor="Red" Type="Integer" ControlToValidate="year" MinimumValue="1930" MaximumValue="2020" ErrorMessage="(*) El año debe estar entre 1930 y el año actual" Text="*"></asp:RangeValidator>
                    <div class="input-group">
                        <asp:TextBox runat="server" ID="day" TextMode="SingleLine" CssClass="form-control" placeholder="Día"></asp:TextBox>
                        &nbsp&nbsp
                        <asp:DropDownList runat="server" ID="month" CssClass="form-control">
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
                        &nbsp&nbsp
                        <asp:TextBox runat="server" ID="year" TextMode="SingleLine" CssClass="form-control" placeholder="Año"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Sexo</asp:Label>
                    <asp:RequiredFieldValidator SetFocusOnError="True" ID="rfvSex" runat="server" ForeColor="Red" InitialValue=" " ControlToValidate="sex" ErrorMessage="(*) Sexo" Text="*"></asp:RequiredFieldValidator>
                    <asp:DropDownList runat="server" ID="sex" CssClass="form-control">
                        <asp:ListItem Text="Selecciona tu sexo" Value=""></asp:ListItem>
                        <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                        <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Teléfono móvil</asp:Label>
                    <asp:RequiredFieldValidator SetFocusOnError="True" ID="rfvPhone" runat="server" ForeColor="Red" InitialValue=" " ControlToValidate="phone" ErrorMessage="(*) Teléfono" Text="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="True" ID="revPhone" runat="server" ForeColor="Red" ControlToValidate="phone" ErrorMessage="(*) El formato debe ser (XXX) XXX-XXXX" Text="*" ValidationExpression="[(]\d{3}[)]\s\d{3}[-]\d{4}"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="phone" MaxLength="14" TextMode="SingleLine" CssClass="form-control" placeholder="+54"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Dirección de correo alternativa</asp:Label>
                    <asp:RequiredFieldValidator SetFocusOnError="True" ID="rfvEmailAlt" runat="server" ForeColor="Red" InitialValue=" " ControlToValidate="emailAlternative" ErrorMessage="(*) Correo alternativo" Text="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="True" ID="revEmailAlt" runat="server" ForeColor="Red" ControlToValidate="emailAlternative" ErrorMessage="(*) Email incorrecto" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="emailAlternative" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Demuéstrenos que no eres un robot</asp:Label>
                    <asp:CompareValidator SetFocusOnError="True" runat="server" ID="cvImg" ForeColor="Red" ControlToValidate="captcha" Operator="Equal" ValueToCompare="arch dsjcbka" ErrorMessage="(*) Debes demostrar que no eres un robot" Text="*"></asp:CompareValidator>
                    <asp:Image runat="server" ImageUrl="~/captcha.png" ID="img" Width="410" />
                    <asp:Label runat="server">Escribe las dos palabras: </asp:Label>
                    <asp:TextBox runat="server" ID="captcha" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Font-Bold="true">Ubicación</asp:Label>
                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfvCountry" ForeColor="Red" InitialValue=" " ControlToValidate="country" ErrorMessage="(*) Ubicación" Text="*"></asp:RequiredFieldValidator>
                    <asp:DropDownList runat="server" ID="country" CssClass="form-control">
                        <asp:ListItem Text="Argentina" Value="Argentina"></asp:ListItem>
                        <asp:ListItem Text="Brasil" Value="Brasil"></asp:ListItem>
                        <asp:ListItem Text="España" Value="España"></asp:ListItem>
                        <asp:ListItem Text="Chile" Value="Chile"></asp:ListItem>
                        <asp:ListItem Text="Uruguay" Value="Uruguay"></asp:ListItem>
                        <asp:ListItem Text="México" Value="México"></asp:ListItem>
                        <asp:ListItem Text="Estados Unidos" Value="Estados Unidos"></asp:ListItem>
                        <asp:ListItem Text="Canadá" Value="Canadá"></asp:ListItem>
                        <asp:ListItem Text="Italia" Value="Italia"></asp:ListItem>
                        <asp:ListItem Text="Francia" Value="Francia"></asp:ListItem>
                        <asp:ListItem Text="Alemania" Value="Alemania"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">

                    <asp:CheckBox runat="server" ID="cbx" />
                    &nbsp
                    <asp:Label runat="server">Acepto las <a href="https://policies.google.com/terms?hl=es">Condiciones del servicio</a>  y la <a href="https://policies.google.com/privacy?hl=es">Política de privacidad de Google.</a></asp:Label>
                    &nbsp
                    <asp:CustomValidator runat="server" SetFocusOnError="True" ForeColor="Red" ID="cvCbx" ErrorMessage="Debe aceptar los términos y condiciones" OnServerValidate="ValidaCbx" Text="*"></asp:CustomValidator>

                </div>

                <div class="justify-content-end" style="text-align: right">

                    <asp:Button runat="server" CssClass="btn btn-primary" Text="Siguiente Paso" OnClick="Validaciones"/>
                </div>

                <br />
                <asp:ValidationSummary ID="valSum" runat="server"
                    HeaderText="Debe ingresar un valor en los siguientes campos:"
                    FontNames="verdana" FontSize="12" ForeColor="Red" />
                
            </form>
        </div>
    </div>

</body>

</html>
