<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ejercicio1A.aspx.cs" Inherits="Ejercicio1A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>HTML PURO</title>
    <style>
        table {
            width: 40%;
            height: 10%;
            margin: auto;
        }
    </style>

</head>
<body>
    <form runat="server">
        <!-- TABLA -->
        <table border="1">
            <!-- FILA CABECERA -->
            <tr>
                <th></th>
                <th>COMPONENTES HTML</th>
            </tr>
            <!-- FILA CAJA DE TEXTO HTML-->
            <tr>
                <td>Caja de Texto</td>
                <td>
                    <input type="text" name="txtCaja" value="" id="txtCaja" runat="server" /></td>
            </tr>
            <!-- FILA COMBOBOX HTML-->
            <tr>
                <td>Combo</td>
                <td>
                    <select id="combo" name="combo" runat="server">
                        <option value="java">Java</option>
                        <option value="python">Python</option>
                        <option value="c++">C++</option>
                    </select>

                </td>
            </tr>
            <!-- FILA IMAGEN HTML-->
            <tr>
                <td>Imagen</td>
                <td style="text-align: center">
                    <img width="200" height="150" id="img" src="https://i.pinimg.com/originals/54/4b/4f/544b4fc1c4cd77c4157521b90a5a37d7.jpg" alt="Zorro en la nieve" runat="server" /></td>
            </tr>
            <!-- FILA CHECKBOX HTML-->
            <tr>
                <td>CheckBox</td>
                <td>
                    <input type="checkbox" name="cbx1" value="si" id="cbx1" runat="server" />SI
                        <input type="checkbox" name="cbx2" value="no" id="cbx2" runat="server" />NO
                </td>
            </tr>
            <!-- FILA HIPERVINCULO HTML-->
            <tr>
                <td>Hipervinculo</td>
                <td><a href="https://www.google.com" id="link" runat="server">Google</a></td>
            </tr>
            <!-- FILA RADIO BUTTON HTML-->
            <tr>
                <td>Radio</td>
                <td>
                    <input type="radio" name="rb" value="alta" id="rb1" runat="server" onserverchange="DatosIngresadosHTML" />Alta
                        <input type="radio" name="rb" value="media" id="rb2" runat="server" onserverchange="DatosIngresadosHTML" />Media
                        <input type="radio" name="rb" value="baja" id="rb3" runat="server" onserverchange="DatosIngresadosHTML" />Baja
                </td>
            </tr>
            <!-- FILA CAMPO OCULTO HTML-->
            <tr>
                <td>Campo Oculto</td>
                <td>
                    <input type="hidden" name="hdn" value="oculto" id="hdn" runat="server" /></td>
            </tr>
            <!-- FILA INPUT BUTTON HTML-->
            <tr>
                <td>Boton</td>
                <td>
                    <input type="button" name="btn" value="Button" id="btn" runat="server" onserverclick="DatosIngresadosHTML" /></td>
            </tr>
            <!-- FILA DATOS INGRESADO HTML-->
            <tr>
                <td colspan="2"><b>Datos ingresados</b></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE CAJA DE TEXTO HTML-->
            <tr>
                <td><b>Caja de texto: </b></td>
                <td id="rqtxtCaja" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE COMBOBOX HTML-->
            <tr>
                <td><b>Combo: </b></td>
                <td id="rqCombo" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE IMAGEN HTML-->
            <tr>
                <td><b>Imagen: </b></td>
                <td id="rqImg" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE CHECKBOX HTML-->
            <tr>
                <td><b>CheckBox: </b></td>
                <td id="rqCbx" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE HIPERVINCULO HTML-->
            <tr>
                <td><b>Hipervinculo: </b></td>
                <td id="rqHyper" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE RADIO BUTTON HTML-->
            <tr>
                <td><b>Radio Button: </b></td>
                <td id="rqRadio" runat="server"></td>
            </tr>
            <!-- FILA DATOS INGRESADOS DE CAMPO OCULTO HTML-->
            <tr>
                <td><b>Campo Oculto: </b></td>
                <td id="rqHdn" runat="server"></td>
            </tr>
        </table>
    </form>
</body>
</html>
