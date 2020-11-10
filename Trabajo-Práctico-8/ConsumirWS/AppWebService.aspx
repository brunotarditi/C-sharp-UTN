<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppWebService.aspx.cs" Inherits="AppWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Conversión</title>
    <!--BOOTSTRAP-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <div class="row mt-5 justify-content-center">
        <div class="col-3 px-3 py-3" style="background-color: #E7EAEC">
            <form id="form1" runat="server">
                <div>
                    <h3>Longitud</h3>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="font-weight-bold" ID="convertir">Quiero convertir:</asp:Label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="valor"></asp:TextBox>
                </div>
                <div class="form-group">
                <asp:DropDownList runat="server" ID="longitudA" CssClass="form-control">
                    <asp:ListItem Value="Kilometro" Text="Kilómetro"></asp:ListItem>
                    <asp:ListItem Value="Metro" Text="Metro"></asp:ListItem>
                    <asp:ListItem Value="Decimetro" Text="Decímetro"></asp:ListItem>
                    <asp:ListItem Value="Centimetro" Text="Centímetro"></asp:ListItem>
                    <asp:ListItem Value="Milimetro" Text="Milímetro"></asp:ListItem>
                    <asp:ListItem Value="Micrometro" Text="Micrómetro"></asp:ListItem>
                </asp:DropDownList>
                </div>
                <div class="form-group">
                <asp:Label runat="server" ID="conversion" CssClass="font-weight-bold">A:</asp:Label>
                <asp:DropDownList runat="server" ID="longitudB" CssClass="form-control">
                    <asp:ListItem Value="Kilometro" Text="Kilómetro"></asp:ListItem>
                    <asp:ListItem Value="Metro" Text="Metro"></asp:ListItem>
                    <asp:ListItem Value="Decimetro" Text="Decímetro"></asp:ListItem>
                    <asp:ListItem Value="Centimetro" Text="Centímetro"></asp:ListItem>
                    <asp:ListItem Value="Milimetro" Text="Milímetro"></asp:ListItem>
                    <asp:ListItem Value="Micrometro" Text="Micrómetro"></asp:ListItem>
                </asp:DropDownList>
                </div>
                <div class="form-inline" style="background-color: #C4E4E8">
                    <div class="col-md-1">
                    <asp:ImageButton ID="img" runat="server" ImageUrl="~/recarga.png" Width="80px" Height="80px" OnClick="Button_Click" />                                                        
                    </div>
                    <div class="col-md-10 text-right">
                        <asp:Label runat="server" ID="resultado" Font-Size="X-Large"></asp:Label>                      
                    </div>
                </div>
                <div class="text-right">
                <asp:Label runat="server" ForeColor="#00434B" ID="detalle" Font-Size="Large">Conversión detallada</asp:Label>                      
                </div>
            </form>
        </div>
    </div>
</body>
</html>
