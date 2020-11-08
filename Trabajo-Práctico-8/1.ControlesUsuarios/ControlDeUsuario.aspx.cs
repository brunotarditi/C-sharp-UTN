using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }

   protected void BtnClick(object sender, EventArgs e)
    {
        lbApellido.InnerHtml = "- " + txtApellido.GetValorCaja();
        lbNombre.InnerText = "- " + txtNombre.GetValorCaja();
        lbCuit.InnerText = "- " + txtCuit.GetValorCuit();
        lbEdad.InnerHtml = "- " + txtEdad.GetValorEdad();
        lbSexo.InnerHtml = "- " + RadioButtonSex.GetValorRadio();
        lbPais.InnerHtml = "- " + ComboPaises.GetValorCombo();
        lbHijos.InnerHtml = "- " + RangoHijosMenores.GetValorHijos();
    }
}