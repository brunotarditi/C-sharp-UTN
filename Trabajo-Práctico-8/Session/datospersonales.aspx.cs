using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session_datospersonales : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        
        if (Page.IsValid)
        {
            Session["nombre"] = nom.GetValorCaja();
            Session["apellido"] = apellido.GetValorCaja();
            Session["dni"] = txtdni.GetValorCaja();
            Session["domicilio"] = txtdomicilio.GetValorCaja();
            Session["nacionalidad"] = ComboPaises.GetValorCombo();
            Session["sexo"] = RadioButtonSex.GetValorRadio();
            Session["fecha"] = Fecha.GetFec();
        }
        Response.Redirect("estudios.aspx");
    }

    
}