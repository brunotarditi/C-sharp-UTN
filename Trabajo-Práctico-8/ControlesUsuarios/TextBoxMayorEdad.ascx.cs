using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBoxMayorEdad : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }   

    public string GetValorEdad()
    {
        return txtMayorEdad.Text;
    }

    public void SetValorEdad(string valor)
    {
        txtMayorEdad.Text = valor;
    }

}