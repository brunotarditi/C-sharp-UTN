using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RangoHijosMenores : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetValorHijos()
    {
        return txtHijos.Text;
    }

    public void SetValorHijos(string valor)
    {
        txtHijos.Text = valor;
    }
}