using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session_estudios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NivelEstudio();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Session["nivel"] = nivelesEstudio.SelectedValue;
            Session["titulo"] = txtTitulo.GetValorCaja();
            Session["establecimiento"] = txtEstablecimiento.GetValorCaja();
        }
            Response.Redirect("trabajos.aspx");
    }

    public void NivelEstudio()
    {
        for (int i = 0; i < 5; i++)
        {
            ListItem item = new ListItem();
            string[] items = { "Primario", "Secundario", "Terciario", "Universitario", "Doctorado" };
            item.Value = i.ToString();
            item.Text = items[i];
            nivelesEstudio.Items.Add(item);
        }
    }


}