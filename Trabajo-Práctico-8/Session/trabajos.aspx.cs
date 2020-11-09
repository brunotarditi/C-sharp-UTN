using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session_t : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            Session["fecDesde"] = fecDesde.GetFec();
            Session["fecHasta"] = fecHasta.GetFec();
            Session["lugar"] = txtlugar.GetValorCaja();
            Session["tarea"] = txttarea.GetValorCaja();
        }
        Response.Redirect("idioma.aspx");
    }

}